using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{

    public partial class Form1 : Form
    {
        private int changeCount = 0;
        private const string tableName = "NhanVien";
        private const string statusMessage = "Đã có {0} thay đổi.";
        private DataTable dt = new DataTable();
        //' The following objects are reused
        //' for the lifetime of the application.
        private SqlConnection connection = null;
        private SqlCommand command = null;
        Update form = new Update();
        //private DataSet dataToWatch = null;
        //private BindingSource SBind = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
        }
        private bool CanRequestNotifications()
        {
            // In order to use the callback feature of the
            // SqlDependency, the application must have
            // the SqlClientPermission permission.
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);
                perm.Demand();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrive it from a configuration file.
            // Return "Data Source=THU-PC\TINTIN;Initial Catalog=QLVT;Persist Security Info=True;User ID=sa;Password=kc;Pooling = false"
            return "Data Source=MSI;Initial Catalog=ChuyenDeCNPM;User ID=sa;Password=123;";
        }
        private string GetSQL()
        {
            return "select manv as [Mã NV],Ho as [       Họ],Ten as [Tên],phai as [Phái],diachi as [     Địa chỉ] from dbo.NhanVien";
        }
        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.nhanVienBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.chuyenDeCNPMDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chuyenDeCNPMDataSet.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.chuyenDeCNPMDataSet.NhanVien);
            if (CanRequestNotifications() == true)
            {
                //nhanVienTableAdapter.Fill(chuyenDeCNPMDataSet.NhanVien);
                BatDau();
            }    
               
            else
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", "Cảnh báo", MessageBoxButtons.OK);

        }
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {

            // This event will occur on a thread pool thread.
            // It is illegal to update the UI from a worker thread
            // The following code checks to see if it is safe update the UI.
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // If InvokeRequired returns True, the code is executing on a worker thread.
            if (i.InvokeRequired)
            {
                // Create a delegate to perform the thread switch
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);

                object[] args = new[] { sender, e };

                // Marshal the data from the worker thread
                // to the UI thread.
                i.BeginInvoke(tempDelegate, args);

                return;
            }

            // Remove the handler since it's only good
            // for a single notification
            SqlDependency dependency = (SqlDependency)sender;

            dependency.OnChange -= dependency_OnChange;

            // At this point, the code is executing on the
            // UI thread, so it is safe to update the UI.
            ++changeCount;
            this.label1.Text = string.Format(statusMessage, changeCount);

            // Add information from the event arguments to the list box
            // for debugging purposes only.
            {
                var withBlock = this.ListBox1.Items;
                withBlock.Clear();
                withBlock.Add("Info:   " + e.Info.ToString());
                withBlock.Add("Source: " + e.Source.ToString());
                withBlock.Add("Type:   " + e.Type.ToString());
            }

            // Reload the dataset that's bound to the grid.
            GetData();
        }

        private void GetData()
        {
           
                // Empty the dataset so that there is only
                // one batch worth of data displayed.
                dt.Clear();

                // Make sure the command object does not already have
                // a notification object associated with it.

                command.Notification = null;

                // Create and bind the SqlDependency object
                // to the command object.        

                SqlDependency dependency = new SqlDependency(command);
                
                dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
            /*using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dataToWatch, tableName);
                DataGridView1.DataSource = null;
                DataGridView1.DataSource = dataToWatch;
                DataGridView1.DataMember = tableName;
                //DataGridView1.Refresh();
            }*/


            //dt = new DataTable();
                if (connection.State == ConnectionState.Closed)
                {
                connection.Open();
                }
                dt.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
            //DataGridView1.AutoGenerateColumns = false;
            //SBind = new BindingSource();
            //SBind.DataSource = dt;
            DataGridView1.DataSource = dt;
            form.nhanVienTableAdapter.Fill(form.chuyenDeCNPMDataSet.NhanVien);
            //DataGridView1.DataSource = SBind;
            //DataGridView1.Refresh();
        }

        private void BatDau()
        {
            changeCount = 0;
            // Remove any existing dependency connection, then create a new one.
            SqlDependency.Stop(GetConnectionString());
            try
            {
                SqlDependency.Start(GetConnectionString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (connection == null)
            {
                connection = new SqlConnection(GetConnectionString());
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                
            }
            if (command == null)
                // GetSQL is a local procedure that returns
                // a paramaterized SQL string. You might want
                // to use a stored procedure in your application.
                command = new SqlCommand(GetSQL(), connection);

            /*if (dataToWatch == null)
                dataToWatch = new DataSet();*/
            GetData();
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            
            form.Show();
        }
        private void Form1_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            SqlDependency.Stop(GetConnectionString());
            if (connection != null)
                connection.Close();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

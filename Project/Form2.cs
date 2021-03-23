using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        private const string statusMessage = "Đã có {0} thay đổi.";
        private int changeCount = 0;
        public delegate void NewHome();
        public event NewHome OnNewHome;
        string connectionString = "Data Source=MSI;Initial Catalog=ChuyenDeCNPM;User ID=sa;Password=123;";
        SqlConnection con = null;
        public Form2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(connectionString);
            SqlDependency.Start(connectionString);
            con = new SqlConnection(connectionString);
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuyenDeCNPMDataSet);

        }
        void LoadData()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT  MANV, HO, TEN, PHAI, DIACHI FROM [dbo].[NHANVIEN]", con);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            nhanVienDataGridView.DataSource = dt;
        }

        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }

            if (e.Type == SqlNotificationType.Change)
            {
                changeCount++;
                this.label1.Text = string.Format(statusMessage, changeCount);
                rtBox.AppendText("#" + changeCount + "\n");
                rtBox.AppendText("Info: " + e.Info.ToString() + "\n");
                rtBox.AppendText("Source: " + e.Source.ToString() + "\n");
                rtBox.AppendText("Type: " + e.Type.ToString() + "\n\n");

                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chuyenDeCNPMDataSet.NhanVien' table. You can move, or remove it, as needed.
            OnNewHome += new NewHome(Form2_OnNewHome);
            LoadData();

        }
        public void Form2_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                NewHome dd = new NewHome(Form2_OnNewHome);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlDependency.Stop(connectionString);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Update form = new Update();
            form.Show();
        }
    }
}

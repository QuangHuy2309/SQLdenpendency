using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Update : Form
    {
        int position = 0;
        int type = 1;
        public Update()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuyenDeCNPMDataSet);

        }

        private void Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chuyenDeCNPMDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.chuyenDeCNPMDataSet.NhanVien);

        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            position = nhanVienBindingSource.Position;
            this.nhanVienBindingSource.AddNew();
            //txt_manv.Enabled = false;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            int maNV = 0;
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này không?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                
                    maNV = int.Parse(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["manv"].ToString());
                    type = 0;
                    SqlConnection connect = new SqlConnection(Form1.GetConnectionString());
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SP_UPDATE_TABLE", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@manv", maNV));
                    cmd.Parameters.Add(new SqlParameter("@ho", ""));
                    cmd.Parameters.Add(new SqlParameter("@ten", ""));
                    cmd.Parameters.Add(new SqlParameter("@phai", ""));
                    cmd.Parameters.Add(new SqlParameter("@diachi", ""));
                    cmd.Parameters.Add(new SqlParameter("@ngaysinh", ""));
                    cmd.Parameters.Add(new SqlParameter("@luong", ""));
                    cmd.Parameters.Add(new SqlParameter("@type", type));
                    SqlDataReader myReader = null;
                    panel2.Width = 110;
                    try
                    {
                        myReader = cmd.ExecuteReader();
                        timer1.Start();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                    MessageBox.Show("Lỗi xảy ra trong quá trình xóa. Vui lòng thử lại!\n" + ex.Message, "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.nhanVienTableAdapter.Fill(this.chuyenDeCNPMDataSet.NhanVien);
                    nhanVienBindingSource.Position = nhanVienBindingSource.Find("manv", maNV);
                    return;
                    }
                    this.nhanVienTableAdapter.Fill(this.chuyenDeCNPMDataSet.NhanVien);
                
            }
        }

        private void button_Ghi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        string manv = txt_manv.Text.Trim();
                        string ho = txt_ho.Text.Trim();
                        string ten = txt_ten.Text.Trim();
                        string phai = txt_phai.Text.Trim();
                        string diachi = txt_diachi.Text.Trim();
                        string ngaysinh = dte_ngaysinh.Value.ToString("yyyy-MM-dd");
                        float luong = float.Parse(txt_luong.Text.Trim());
                        type = 1;

                        SqlConnection connect = new SqlConnection(Form1.GetConnectionString());
                        if (connect.State == ConnectionState.Closed)
                        {
                            connect.Open();
                        }
                        SqlCommand cmd = new SqlCommand("SP_UPDATE_TABLE", connect);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@manv", manv));
                        cmd.Parameters.Add(new SqlParameter("@ho", ho));
                        cmd.Parameters.Add(new SqlParameter("@ten", ten));
                        cmd.Parameters.Add(new SqlParameter("@phai", phai));
                        cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                        cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
                        cmd.Parameters.Add(new SqlParameter("@luong", luong));
                        cmd.Parameters.Add(new SqlParameter("@type", type));
                        SqlDataReader myReader = null;
                        panel2.Width = 110;
                        try
                        {
                            myReader = cmd.ExecuteReader();
                            timer1.Start();
                            MessageBox.Show("Ghi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        /*this.nhanVienBindingSource.EndEdit();*/
                        this.nhanVienTableAdapter.Fill(this.chuyenDeCNPMDataSet.NhanVien);
                        //MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        // Khi Update database lỗi thì xóa record vừa thêm trong bds
                        nhanVienBindingSource.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_ho_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ho.Text))
            {
                e.Cancel = true;
                txt_ho.Focus();
                errorProvider1.SetError(txt_ho, "Họ không được để trống!");
            }
            else if (txt_ho.Text.Trim().All(c => !char.IsLetterOrDigit(c)))
            {
                e.Cancel = true;
                txt_ho.Focus();
                errorProvider1.SetError(txt_ho, "Họ chỉ được chứa chữ cái!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_ho, "");
            }
        }

        private void txt_ten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ten.Text))
            {
                e.Cancel = true;
                txt_ten.Focus();
                errorProvider1.SetError(txt_ten, "Tên không được để trống!");
            }
            else if (txt_ho.Text.Trim().All(c => !char.IsLetterOrDigit(c)))
            {
                e.Cancel = true;
                txt_ten.Focus();
                errorProvider1.SetError(txt_ten, "Tên chỉ được chứa chữ cái!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_ten, "");
            }
        }

        private void txt_phai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_phai.Text))
            {
                e.Cancel = true;
                txt_phai.Focus();
                errorProvider1.SetError(txt_phai, "Phái không được để trống!");
            }
            else if((!txt_phai.Text.Trim().Equals("NAM", StringComparison.OrdinalIgnoreCase)) 
                && (!txt_phai.Text.Trim().Equals("NỮ", StringComparison.OrdinalIgnoreCase)) )
            {
                e.Cancel = true;
                txt_phai.Focus();
                errorProvider1.SetError(txt_phai, "Chỉ được chọn NAM/NỮ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_phai, "");
            }
        }

        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            
        }

        private void txt_diachi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_diachi.Text))
            {
                e.Cancel = true;
                txt_diachi.Focus();
                errorProvider1.SetError(txt_diachi, "Địa chỉ không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_diachi, "");
            }
        }

        private void txt_luong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_luong.Text))
            {
                e.Cancel = true;
                txt_luong.Focus();
                errorProvider1.SetError(txt_luong, "Lương không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_luong, "");
            }
            
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 112;
            if(panel2.Width >= 1115)
            {
                timer1.Stop();
                panel2.Width = 1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_luong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_luong_Leave(object sender, EventArgs e)
        {

            //txt_luong.Text = string.Format("{0:#,##0.00}", double.Parse(txt_luong.Text));
            if (Double.Parse(txt_luong.Text.Trim()) <= 1000000)
            {
                txt_luong.Focus();
                errorProvider1.SetError(txt_luong, "Lương không được thấp hơn 1.000.000!");
            }
            else
            {
                txt_luong.Text = string.Format("{0:#,##0.00}", double.Parse(txt_luong.Text));
            }
        }
    }
}

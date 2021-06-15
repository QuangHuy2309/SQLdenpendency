
namespace Project
{
    partial class Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label manvLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label phaiLabel;
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label luongLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            this.chuyenDeCNPMDataSet = new Project.ChuyenDeCNPMDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new Project.ChuyenDeCNPMDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new Project.ChuyenDeCNPMDataSetTableAdapters.TableAdapterManager();
            this.nhanVienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Ghi = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_ho = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_phai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.dte_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            manvLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            phaiLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            luongLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenDeCNPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // manvLabel
            // 
            manvLabel.AutoSize = true;
            manvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            manvLabel.Location = new System.Drawing.Point(12, 356);
            manvLabel.Name = "manvLabel";
            manvLabel.Size = new System.Drawing.Size(70, 20);
            manvLabel.TabIndex = 5;
            manvLabel.Text = "Mã NV: ";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(373, 353);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(36, 20);
            hoLabel.TabIndex = 7;
            hoLabel.Text = "Họ:";
            // 
            // phaiLabel
            // 
            phaiLabel.AutoSize = true;
            phaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phaiLabel.Location = new System.Drawing.Point(12, 408);
            phaiLabel.Name = "phaiLabel";
            phaiLabel.Size = new System.Drawing.Size(47, 20);
            phaiLabel.TabIndex = 11;
            phaiLabel.Text = "Phái:";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diachiLabel.Location = new System.Drawing.Point(373, 448);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(66, 20);
            diachiLabel.TabIndex = 13;
            diachiLabel.Text = "Địa chỉ:";
            // 
            // luongLabel
            // 
            luongLabel.AutoSize = true;
            luongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            luongLabel.Location = new System.Drawing.Point(373, 408);
            luongLabel.Name = "luongLabel";
            luongLabel.Size = new System.Drawing.Size(60, 20);
            luongLabel.TabIndex = 17;
            luongLabel.Text = "Lương:";
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaysinhLabel.Location = new System.Drawing.Point(12, 448);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(88, 20);
            ngaysinhLabel.TabIndex = 18;
            ngaysinhLabel.Text = "Ngày sinh:";
            // 
            // chuyenDeCNPMDataSet
            // 
            this.chuyenDeCNPMDataSet.DataSetName = "ChuyenDeCNPMDataSet";
            this.chuyenDeCNPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.chuyenDeCNPMDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.ChuyenDeCNPMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienDataGridView
            // 
            this.nhanVienDataGridView.AutoGenerateColumns = false;
            this.nhanVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.nhanVienDataGridView.DataSource = this.nhanVienBindingSource;
            this.nhanVienDataGridView.Location = new System.Drawing.Point(-2, 0);
            this.nhanVienDataGridView.Name = "nhanVienDataGridView";
            this.nhanVienDataGridView.ReadOnly = true;
            this.nhanVienDataGridView.RowHeadersWidth = 51;
            this.nhanVienDataGridView.RowTemplate.Height = 24;
            this.nhanVienDataGridView.Size = new System.Drawing.Size(929, 307);
            this.nhanVienDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "manv";
            this.dataGridViewTextBoxColumn1.HeaderText = "manv";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ho";
            this.dataGridViewTextBoxColumn2.HeaderText = "ho";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ten";
            this.dataGridViewTextBoxColumn3.HeaderText = "ten";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "phai";
            this.dataGridViewTextBoxColumn4.HeaderText = "phai";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "diachi";
            this.dataGridViewTextBoxColumn5.HeaderText = "diachi";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ngaysinh";
            this.dataGridViewTextBoxColumn6.HeaderText = "ngaysinh";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "luong";
            this.dataGridViewTextBoxColumn7.HeaderText = "luong";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(975, 32);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(94, 44);
            this.button_Them.TabIndex = 2;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Ghi
            // 
            this.button_Ghi.Location = new System.Drawing.Point(975, 100);
            this.button_Ghi.Name = "button_Ghi";
            this.button_Ghi.Size = new System.Drawing.Size(94, 44);
            this.button_Ghi.TabIndex = 3;
            this.button_Ghi.Text = "Ghi";
            this.button_Ghi.UseVisualStyleBackColor = true;
            this.button_Ghi.Click += new System.EventHandler(this.button_Ghi_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(975, 176);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(94, 44);
            this.button_Xoa.TabIndex = 4;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(975, 247);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(94, 44);
            this.button_Thoat.TabIndex = 5;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // txt_manv
            // 
            this.txt_manv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "manv", true));
            this.txt_manv.Enabled = false;
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(110, 353);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(140, 27);
            this.txt_manv.TabIndex = 6;
            // 
            // txt_ho
            // 
            this.txt_ho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "ho", true));
            this.txt_ho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ho.Location = new System.Drawing.Point(453, 353);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(309, 27);
            this.txt_ho.TabIndex = 8;
            this.txt_ho.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ho_Validating);
            // 
            // txt_ten
            // 
            this.txt_ten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "ten", true));
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(768, 353);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(159, 27);
            this.txt_ten.TabIndex = 10;
            this.txt_ten.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ten_Validating);
            // 
            // txt_phai
            // 
            this.txt_phai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "phai", true));
            this.txt_phai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phai.Location = new System.Drawing.Point(110, 405);
            this.txt_phai.MaxLength = 3;
            this.txt_phai.Name = "txt_phai";
            this.txt_phai.Size = new System.Drawing.Size(140, 27);
            this.txt_phai.TabIndex = 12;
            this.txt_phai.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phai_Validating);
            // 
            // txt_diachi
            // 
            this.txt_diachi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "diachi", true));
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(453, 448);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(471, 27);
            this.txt_diachi.TabIndex = 14;
            this.txt_diachi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_diachi_Validating);
            // 
            // txt_luong
            // 
            this.txt_luong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "luong", true));
            this.txt_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luong.Location = new System.Drawing.Point(453, 401);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(309, 27);
            this.txt_luong.TabIndex = 18;
            this.txt_luong.TextChanged += new System.EventHandler(this.txt_luong_TextChanged);
            this.txt_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_luong_KeyPress);
            this.txt_luong.Leave += new System.EventHandler(this.txt_luong_Leave);
            this.txt_luong.Validating += new System.ComponentModel.CancelEventHandler(this.txt_luong_Validating);
            // 
            // dte_ngaysinh
            // 
            this.dte_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dte_ngaysinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "ngaysinh", true));
            this.dte_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dte_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dte_ngaysinh.Location = new System.Drawing.Point(110, 448);
            this.dte_ngaysinh.Name = "dte_ngaysinh";
            this.dte_ngaysinh.Size = new System.Drawing.Size(140, 27);
            this.dte_ngaysinh.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 8);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 5);
            this.panel2.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(ngaysinhLabel);
            this.Controls.Add(this.dte_ngaysinh);
            this.Controls.Add(luongLabel);
            this.Controls.Add(this.txt_luong);
            this.Controls.Add(diachiLabel);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(phaiLabel);
            this.Controls.Add(this.txt_phai);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(hoLabel);
            this.Controls.Add(this.txt_ho);
            this.Controls.Add(manvLabel);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Ghi);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.nhanVienDataGridView);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuyenDeCNPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ChuyenDeCNPMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Ghi;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_ho;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_phai;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.DateTimePicker dte_ngaysinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView nhanVienDataGridView;
        public ChuyenDeCNPMDataSet chuyenDeCNPMDataSet;
        public System.Windows.Forms.BindingSource nhanVienBindingSource;
        public ChuyenDeCNPMDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}
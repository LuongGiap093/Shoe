namespace main
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.textCommand1 = new DevExpress.CodeRush.Core.TextCommand(this.components);
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnxoanv = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemxongnv = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtmanv = new DevExpress.XtraEditors.TextEdit();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.combogioitinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txttennv = new DevExpress.XtraEditors.TextEdit();
            this.txtdt = new DevExpress.XtraEditors.TextEdit();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuaxong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btntimnhanvien = new DevExpress.XtraEditors.SimpleButton();
            this.txttimtennv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textCommand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combogioitinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttennv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textCommand1
            // 
            this.textCommand1.CommandName = null;
            this.textCommand1.Description = null;
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Location = new System.Drawing.Point(12, 289);
            this.DgvNhanVien.MultiSelect = false;
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.ReadOnly = true;
            this.DgvNhanVien.RowTemplate.Height = 24;
            this.DgvNhanVien.Size = new System.Drawing.Size(857, 206);
            this.DgvNhanVien.StandardTab = true;
            this.DgvNhanVien.TabIndex = 12;
            this.DgvNhanVien.TabStop = false;
            this.DgvNhanVien.SelectionChanged += new System.EventHandler(this.gidviewnhanvien_SelectionChanged);
            // 
            // btnxoanv
            // 
            this.btnxoanv.Location = new System.Drawing.Point(501, 173);
            this.btnxoanv.Name = "btnxoanv";
            this.btnxoanv.Size = new System.Drawing.Size(89, 34);
            this.btnxoanv.TabIndex = 10;
            this.btnxoanv.Text = "Xóa";
            this.btnxoanv.Click += new System.EventHandler(this.btnxoanv_Click);
            // 
            // btnthemxongnv
            // 
            this.btnthemxongnv.Location = new System.Drawing.Point(626, 40);
            this.btnthemxongnv.Name = "btnthemxongnv";
            this.btnthemxongnv.Size = new System.Drawing.Size(89, 34);
            this.btnthemxongnv.TabIndex = 7;
            this.btnthemxongnv.Text = "Thêm Xong";
            this.btnthemxongnv.Click += new System.EventHandler(this.btnthemxongnv_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(501, 103);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(89, 34);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(501, 40);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 34);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 21);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Mã Nhân Viên";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(184, 37);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(260, 22);
            this.txtmanv.TabIndex = 0;
            // 
            // datengaysinh
            // 
            this.datengaysinh.Location = new System.Drawing.Point(184, 155);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(260, 23);
            this.datengaysinh.TabIndex = 3;
            // 
            // combogioitinh
            // 
            this.combogioitinh.Location = new System.Drawing.Point(184, 117);
            this.combogioitinh.Name = "combogioitinh";
            this.combogioitinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combogioitinh.Size = new System.Drawing.Size(260, 22);
            this.combogioitinh.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 21);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Tên Nhân Viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 21);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Giới Tính";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 21);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Ngày Sinh";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(12, 197);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 21);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Địa Chỉ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(12, 238);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 21);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Số Điện Thoại";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(184, 77);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(260, 22);
            this.txttennv.TabIndex = 1;
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(184, 239);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(260, 22);
            this.txtdt.TabIndex = 5;
            this.txtdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdt_KeyPress);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(184, 198);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(260, 22);
            this.txtdiachi.TabIndex = 4;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(626, 173);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 34);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnsuaxong
            // 
            this.btnsuaxong.Location = new System.Drawing.Point(626, 103);
            this.btnsuaxong.Name = "btnsuaxong";
            this.btnsuaxong.Size = new System.Drawing.Size(89, 34);
            this.btnsuaxong.TabIndex = 9;
            this.btnsuaxong.Text = "Sửa Xong";
            this.btnsuaxong.Click += new System.EventHandler(this.btnsuaxong_Click_1);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl7.Location = new System.Drawing.Point(489, 243);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 21);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Tìm theo tên:";
            // 
            // btntimnhanvien
            // 
            this.btntimnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btntimnhanvien.Image")));
            this.btntimnhanvien.Location = new System.Drawing.Point(762, 234);
            this.btntimnhanvien.Name = "btntimnhanvien";
            this.btntimnhanvien.Size = new System.Drawing.Size(51, 37);
            this.btntimnhanvien.TabIndex = 14;
            this.btntimnhanvien.Click += new System.EventHandler(this.btntimnhanvien_Click);
            // 
            // txttimtennv
            // 
            this.txttimtennv.Location = new System.Drawing.Point(597, 243);
            this.txttimtennv.Name = "txttimtennv";
            this.txttimtennv.Size = new System.Drawing.Size(136, 23);
            this.txttimtennv.TabIndex = 13;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 499);
            this.Controls.Add(this.txttimtennv);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btntimnhanvien);
            this.Controls.Add(this.combogioitinh);
            this.Controls.Add(this.datengaysinh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsuaxong);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthemxongnv);
            this.Controls.Add(this.btnxoanv);
            this.Controls.Add(this.DgvNhanVien);
            this.Controls.Add(this.btnthoat);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NhanVien_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textCommand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combogioitinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttennv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.CodeRush.Core.TextCommand textCommand1;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnxoanv;
        private DevExpress.XtraEditors.SimpleButton btnthemxongnv;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtmanv;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private DevExpress.XtraEditors.ComboBoxEdit combogioitinh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txttennv;
        private DevExpress.XtraEditors.TextEdit txtdt;
        private DevExpress.XtraEditors.TextEdit txtdiachi;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnsuaxong;
        private DevExpress.XtraEditors.SimpleButton btntimnhanvien;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txttimtennv;
    }
}
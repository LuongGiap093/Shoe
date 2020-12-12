namespace main
{
    partial class ChatLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatLieu));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gidviewchatlieu = new System.Windows.Forms.DataGridView();
            this.btnThemCL = new DevExpress.XtraEditors.SimpleButton();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.btnThemXong = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuaxong = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btntimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimtencl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gidviewchatlieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(249, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(325, 46);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "BẢNG CHẤT LIỆU";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã Chất Liệu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên Chất Liệu";
            // 
            // gidviewchatlieu
            // 
            this.gidviewchatlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gidviewchatlieu.Location = new System.Drawing.Point(12, 267);
            this.gidviewchatlieu.MultiSelect = false;
            this.gidviewchatlieu.Name = "gidviewchatlieu";
            this.gidviewchatlieu.ReadOnly = true;
            this.gidviewchatlieu.RowTemplate.Height = 24;
            this.gidviewchatlieu.Size = new System.Drawing.Size(770, 208);
            this.gidviewchatlieu.StandardTab = true;
            this.gidviewchatlieu.TabIndex = 3;
            this.gidviewchatlieu.TabStop = false;
            this.gidviewchatlieu.SelectionChanged += new System.EventHandler(this.gidviewchatlieu_SelectionChanged);
            // 
            // btnThemCL
            // 
            this.btnThemCL.Location = new System.Drawing.Point(461, 79);
            this.btnThemCL.Name = "btnThemCL";
            this.btnThemCL.Size = new System.Drawing.Size(90, 33);
            this.btnThemCL.TabIndex = 2;
            this.btnThemCL.Text = "Thêm";
            this.btnThemCL.Click += new System.EventHandler(this.btnThemCL_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(149, 90);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(210, 22);
            this.txtma.TabIndex = 0;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(149, 132);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(210, 22);
            this.txtten.TabIndex = 1;
            // 
            // btnThemXong
            // 
            this.btnThemXong.Location = new System.Drawing.Point(591, 79);
            this.btnThemXong.Name = "btnThemXong";
            this.btnThemXong.Size = new System.Drawing.Size(90, 33);
            this.btnThemXong.TabIndex = 3;
            this.btnThemXong.Text = "Thêm Xong";
            this.btnThemXong.Click += new System.EventHandler(this.btnThemXong_Click);
            // 
            // btnsuaxong
            // 
            this.btnsuaxong.Location = new System.Drawing.Point(593, 137);
            this.btnsuaxong.Name = "btnsuaxong";
            this.btnsuaxong.Size = new System.Drawing.Size(89, 34);
            this.btnsuaxong.TabIndex = 5;
            this.btnsuaxong.Text = "Sửa Xong";
            this.btnsuaxong.Click += new System.EventHandler(this.btnsuaxong_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(462, 137);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(89, 34);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(462, 197);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 34);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(592, 197);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 34);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(249, 217);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(46, 37);
            this.btntimkiem.TabIndex = 9;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tìm Theo Tên:";
            // 
            // txttimtencl
            // 
            this.txttimtencl.Location = new System.Drawing.Point(116, 228);
            this.txttimtencl.Name = "txttimtencl";
            this.txttimtencl.Size = new System.Drawing.Size(113, 23);
            this.txttimtencl.TabIndex = 8;
            // 
            // ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 481);
            this.Controls.Add(this.txttimtencl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsuaxong);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.btnThemXong);
            this.Controls.Add(this.btnThemCL);
            this.Controls.Add(this.gidviewchatlieu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChatLieu";
            this.Text = "ChatLieu";
            this.Load += new System.EventHandler(this.ChatLieu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatLieu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gidviewchatlieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridView gidviewchatlieu;
        private DevExpress.XtraEditors.SimpleButton btnThemCL;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.SimpleButton btnThemXong;
        private DevExpress.XtraEditors.SimpleButton btnsuaxong;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btntimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimtencl;
    }
}

namespace PM_QuanLyBanHang
{
    partial class fCustomers
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
            this.btncapnhap = new System.Windows.Forms.Button();
            this.txttimkiemkh = new System.Windows.Forms.TextBox();
            this.dataviewkh = new System.Windows.Forms.DataGridView();
            this.btnthemkh = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.lbttkh = new System.Windows.Forms.Label();
            this.lbmakh = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewkh)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncapnhap
            // 
            this.btncapnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhap.Location = new System.Drawing.Point(356, 526);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(130, 39);
            this.btncapnhap.TabIndex = 17;
            this.btncapnhap.Text = "CẬP NHẬP";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // txttimkiemkh
            // 
            this.txttimkiemkh.Location = new System.Drawing.Point(230, 112);
            this.txttimkiemkh.Name = "txttimkiemkh";
            this.txttimkiemkh.Size = new System.Drawing.Size(424, 20);
            this.txttimkiemkh.TabIndex = 25;
            this.txttimkiemkh.Text = "sodienthoai..";
            this.txttimkiemkh.TextChanged += new System.EventHandler(this.txttimkiemkh_TextChanged);
            // 
            // dataviewkh
            // 
            this.dataviewkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewkh.Location = new System.Drawing.Point(121, 165);
            this.dataviewkh.Name = "dataviewkh";
            this.dataviewkh.Size = new System.Drawing.Size(533, 312);
            this.dataviewkh.TabIndex = 20;
            this.dataviewkh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataviewkh_CellContentClick);
            // 
            // btnthemkh
            // 
            this.btnthemkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemkh.Location = new System.Drawing.Point(207, 526);
            this.btnthemkh.Name = "btnthemkh";
            this.btnthemkh.Size = new System.Drawing.Size(143, 39);
            this.btnthemkh.TabIndex = 18;
            this.btnthemkh.Text = "THÊM KHÁCH HÀNG";
            this.btnthemkh.UseVisualStyleBackColor = true;
            this.btnthemkh.Click += new System.EventHandler(this.btnthemkh_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(492, 526);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(96, 39);
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntk
            // 
            this.btntk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntk.Location = new System.Drawing.Point(121, 107);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(90, 28);
            this.btntk.TabIndex = 26;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // lbttkh
            // 
            this.lbttkh.AutoSize = true;
            this.lbttkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbttkh.Location = new System.Drawing.Point(94, 23);
            this.lbttkh.Name = "lbttkh";
            this.lbttkh.Size = new System.Drawing.Size(193, 16);
            this.lbttkh.TabIndex = 14;
            this.lbttkh.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lbmakh
            // 
            this.lbmakh.AutoSize = true;
            this.lbmakh.Location = new System.Drawing.Point(19, 70);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(44, 13);
            this.lbmakh.TabIndex = 15;
            this.lbmakh.Text = "MÃ KH:";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Location = new System.Drawing.Point(19, 93);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(51, 13);
            this.lbhoten.TabIndex = 16;
            this.lbhoten.Text = "HỌ TÊN:";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(19, 184);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(90, 13);
            this.lbsdt.TabIndex = 17;
            this.lbsdt.Text = "SỐ ĐIỆN THOẠI:";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Location = new System.Drawing.Point(19, 138);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(61, 13);
            this.lbgioitinh.TabIndex = 18;
            this.lbgioitinh.Text = "GIỚI TÍNH:";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(21, 210);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(49, 13);
            this.lbdiachi.TabIndex = 19;
            this.lbdiachi.Text = "ĐỊA CHỈ:";
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(115, 67);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.ReadOnly = true;
            this.txtmakh.Size = new System.Drawing.Size(172, 20);
            this.txtmakh.TabIndex = 20;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(115, 181);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(172, 20);
            this.txtsdt.TabIndex = 21;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(115, 207);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(256, 20);
            this.txtdc.TabIndex = 22;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(115, 93);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(256, 20);
            this.txthoten.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbnu);
            this.panel3.Controls.Add(this.rbnam);
            this.panel3.Location = new System.Drawing.Point(115, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 57);
            this.panel3.TabIndex = 24;
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Location = new System.Drawing.Point(65, 21);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(39, 17);
            this.rbnu.TabIndex = 1;
            this.rbnu.Text = "Nữ";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Checked = true;
            this.rbnam.Location = new System.Drawing.Point(3, 21);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(47, 17);
            this.rbnam.TabIndex = 0;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "Nam";
            this.rbnam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txthoten);
            this.panel1.Controls.Add(this.txtdc);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.txtmakh);
            this.panel1.Controls.Add(this.lbdiachi);
            this.panel1.Controls.Add(this.lbgioitinh);
            this.panel1.Controls.Add(this.lbsdt);
            this.panel1.Controls.Add(this.lbhoten);
            this.panel1.Controls.Add(this.lbmakh);
            this.panel1.Controls.Add(this.lbttkh);
            this.panel1.Location = new System.Drawing.Point(709, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 312);
            this.panel1.TabIndex = 15;
            // 
            // fCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 652);
            this.Controls.Add(this.txttimkiemkh);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.dataviewkh);
            this.Controls.Add(this.btnthemkh);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.panel1);
            this.Name = "fCustomers";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.fCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewkh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncapnhap;
        private System.Windows.Forms.TextBox txttimkiemkh;
        private System.Windows.Forms.DataGridView dataviewkh;
        private System.Windows.Forms.Button btnthemkh;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Label lbttkh;
        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.Panel panel1;
    }
}
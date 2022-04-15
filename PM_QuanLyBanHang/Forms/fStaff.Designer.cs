
namespace PM_QuanLyBanHang.Forms
{
    partial class fStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ranhanvien = new System.Windows.Forms.RadioButton();
            this.raquanly = new System.Windows.Forms.RadioButton();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbchucvu = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbttnv = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.btnsua = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtmk);
            this.panel1.Controls.Add(this.lbmatkhau);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.txthoten);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.lbchucvu);
            this.panel1.Controls.Add(this.lbdiachi);
            this.panel1.Controls.Add(this.lbhoten);
            this.panel1.Controls.Add(this.lbemail);
            this.panel1.Controls.Add(this.lbttnv);
            this.panel1.Location = new System.Drawing.Point(730, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 348);
            this.panel1.TabIndex = 0;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(86, 185);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(226, 20);
            this.txtmk.TabIndex = 11;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(23, 188);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(66, 13);
            this.lbmatkhau.TabIndex = 10;
            this.lbmatkhau.Text = "MẬT KHẨU:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ranhanvien);
            this.panel3.Controls.Add(this.raquanly);
            this.panel3.Location = new System.Drawing.Point(96, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 73);
            this.panel3.TabIndex = 0;
            // 
            // ranhanvien
            // 
            this.ranhanvien.AutoSize = true;
            this.ranhanvien.Checked = true;
            this.ranhanvien.Location = new System.Drawing.Point(24, 18);
            this.ranhanvien.Name = "ranhanvien";
            this.ranhanvien.Size = new System.Drawing.Size(74, 17);
            this.ranhanvien.TabIndex = 10;
            this.ranhanvien.TabStop = true;
            this.ranhanvien.Text = "Nhân viên";
            this.ranhanvien.UseVisualStyleBackColor = true;
            // 
            // raquanly
            // 
            this.raquanly.AutoSize = true;
            this.raquanly.Location = new System.Drawing.Point(137, 18);
            this.raquanly.Name = "raquanly";
            this.raquanly.Size = new System.Drawing.Size(61, 17);
            this.raquanly.TabIndex = 11;
            this.raquanly.Text = "Quản lý";
            this.raquanly.UseVisualStyleBackColor = true;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(86, 147);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(226, 20);
            this.txtdiachi.TabIndex = 9;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(86, 109);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(224, 20);
            this.txthoten.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(86, 72);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(224, 20);
            this.txtemail.TabIndex = 6;
            // 
            // lbchucvu
            // 
            this.lbchucvu.AutoSize = true;
            this.lbchucvu.Location = new System.Drawing.Point(23, 235);
            this.lbchucvu.Name = "lbchucvu";
            this.lbchucvu.Size = new System.Drawing.Size(58, 13);
            this.lbchucvu.TabIndex = 5;
            this.lbchucvu.Text = "CHỨC VỤ:";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(22, 150);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(49, 13);
            this.lbdiachi.TabIndex = 4;
            this.lbdiachi.Text = "ĐỊA CHỈ:";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Location = new System.Drawing.Point(23, 112);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(51, 13);
            this.lbhoten.TabIndex = 2;
            this.lbhoten.Text = "HỌ TÊN:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(23, 75);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(42, 13);
            this.lbemail.TabIndex = 1;
            this.lbemail.Text = "EMAIL:";
            // 
            // lbttnv
            // 
            this.lbttnv.AutoSize = true;
            this.lbttnv.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbttnv.Location = new System.Drawing.Point(79, 15);
            this.lbttnv.Name = "lbttnv";
            this.lbttnv.Size = new System.Drawing.Size(184, 27);
            this.lbttnv.TabIndex = 0;
            this.lbttnv.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvNhanvien);
            this.panel2.Location = new System.Drawing.Point(103, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 351);
            this.panel2.TabIndex = 1;
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(3, 18);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.Size = new System.Drawing.Size(518, 330);
            this.dgvNhanvien.TabIndex = 0;
            this.dgvNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellContentClick);
            // 
            // btnsua
            // 
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(329, 501);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 43);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(249, 65);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(288, 20);
            this.txttimkiem.TabIndex = 11;
            this.txttimkiem.Text = "name..";
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btnxoa
            // 
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(436, 501);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 43);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(224, 501);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(99, 43);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntk
            // 
            this.btntk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntk.Location = new System.Drawing.Point(139, 60);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(90, 28);
            this.btntk.TabIndex = 14;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 652);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.panel2);
            this.Name = "fStaff";
            this.Text = "QUẢN LÝ";
            this.Load += new System.EventHandler(this.fStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton ranhanvien;
        private System.Windows.Forms.RadioButton raquanly;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbchucvu;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbttnv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Button btntk;
    }
}
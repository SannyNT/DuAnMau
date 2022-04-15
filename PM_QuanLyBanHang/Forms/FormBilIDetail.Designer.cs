
namespace PM_QuanLyBanHang.Forms
{
    partial class FormBilIDetail
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
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.lbthoigian = new System.Windows.Forms.Label();
            this.lbmakh = new System.Windows.Forms.Label();
            this.lbthongtinhd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.lbdongia = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttonkho = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.lbtonkho = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.lbmasp = new System.Windows.Forms.Label();
            this.lbchitiethd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.lbthanhtien = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnthembill = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewsp = new System.Windows.Forms.DataGridView();
            this.lbsanpham = new System.Windows.Forms.Label();
            this.lbhd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtmakh);
            this.panel1.Controls.Add(this.txttime);
            this.panel1.Controls.Add(this.lbthoigian);
            this.panel1.Controls.Add(this.lbmakh);
            this.panel1.Controls.Add(this.lbthongtinhd);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 148);
            this.panel1.TabIndex = 0;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(109, 43);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(240, 20);
            this.txtmakh.TabIndex = 18;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(109, 92);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(240, 20);
            this.txttime.TabIndex = 9;
            // 
            // lbthoigian
            // 
            this.lbthoigian.AutoSize = true;
            this.lbthoigian.Location = new System.Drawing.Point(33, 95);
            this.lbthoigian.Name = "lbthoigian";
            this.lbthoigian.Size = new System.Drawing.Size(62, 13);
            this.lbthoigian.TabIndex = 6;
            this.lbthoigian.Text = "THỜI GIAN";
            // 
            // lbmakh
            // 
            this.lbmakh.AutoSize = true;
            this.lbmakh.Location = new System.Drawing.Point(33, 46);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(41, 13);
            this.lbmakh.TabIndex = 5;
            this.lbmakh.Text = "MÃ KH";
            // 
            // lbthongtinhd
            // 
            this.lbthongtinhd.AutoSize = true;
            this.lbthongtinhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthongtinhd.Location = new System.Drawing.Point(106, 13);
            this.lbthongtinhd.Name = "lbthongtinhd";
            this.lbthongtinhd.Size = new System.Drawing.Size(164, 18);
            this.lbthongtinhd.TabIndex = 0;
            this.lbthongtinhd.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtgia);
            this.panel2.Controls.Add(this.lbdongia);
            this.panel2.Controls.Add(this.txtmasp);
            this.panel2.Controls.Add(this.txttonkho);
            this.panel2.Controls.Add(this.txtsoluong);
            this.panel2.Controls.Add(this.lbtonkho);
            this.panel2.Controls.Add(this.lbsoluong);
            this.panel2.Controls.Add(this.lbmasp);
            this.panel2.Controls.Add(this.lbchitiethd);
            this.panel2.Location = new System.Drawing.Point(406, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 148);
            this.panel2.TabIndex = 1;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(71, 73);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(164, 20);
            this.txtgia.TabIndex = 22;
            this.txtgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbdongia
            // 
            this.lbdongia.AutoSize = true;
            this.lbdongia.Location = new System.Drawing.Point(13, 76);
            this.lbdongia.Name = "lbdongia";
            this.lbdongia.Size = new System.Drawing.Size(52, 13);
            this.lbdongia.TabIndex = 21;
            this.lbdongia.Text = "ĐƠN GIÁ";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(71, 40);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(124, 20);
            this.txtmasp.TabIndex = 20;
            this.txtmasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttonkho
            // 
            this.txttonkho.Location = new System.Drawing.Point(263, 39);
            this.txttonkho.Name = "txttonkho";
            this.txttonkho.Size = new System.Drawing.Size(87, 20);
            this.txttonkho.TabIndex = 17;
            this.txttonkho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(80, 107);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(155, 20);
            this.txtsoluong.TabIndex = 16;
            // 
            // lbtonkho
            // 
            this.lbtonkho.AutoSize = true;
            this.lbtonkho.Location = new System.Drawing.Point(201, 43);
            this.lbtonkho.Name = "lbtonkho";
            this.lbtonkho.Size = new System.Drawing.Size(56, 13);
            this.lbtonkho.TabIndex = 13;
            this.lbtonkho.Text = "TỒN KHO";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(13, 110);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(63, 13);
            this.lbsoluong.TabIndex = 12;
            this.lbsoluong.Text = "SỐ LƯỢNG";
            // 
            // lbmasp
            // 
            this.lbmasp.AutoSize = true;
            this.lbmasp.Location = new System.Drawing.Point(13, 42);
            this.lbmasp.Name = "lbmasp";
            this.lbmasp.Size = new System.Drawing.Size(40, 13);
            this.lbmasp.TabIndex = 8;
            this.lbmasp.Text = "MÃ SP";
            // 
            // lbchitiethd
            // 
            this.lbchitiethd.AutoSize = true;
            this.lbchitiethd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchitiethd.Location = new System.Drawing.Point(100, 13);
            this.lbchitiethd.Name = "lbchitiethd";
            this.lbchitiethd.Size = new System.Drawing.Size(142, 18);
            this.lbchitiethd.TabIndex = 1;
            this.lbchitiethd.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(67, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 147);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 141);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(457, 167);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(81, 33);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(545, 167);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(96, 33);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.ForeColor = System.Drawing.Color.White;
            this.btnthanhtoan.Location = new System.Drawing.Point(648, 167);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(108, 33);
            this.btnthanhtoan.TabIndex = 5;
            this.btnthanhtoan.Text = "THANH TOÁN";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // lbthanhtien
            // 
            this.lbthanhtien.AutoSize = true;
            this.lbthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthanhtien.Location = new System.Drawing.Point(322, 559);
            this.lbthanhtien.Name = "lbthanhtien";
            this.lbthanhtien.Size = new System.Drawing.Size(76, 13);
            this.lbthanhtien.TabIndex = 8;
            this.lbthanhtien.Text = "THÀNH TIỀN:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(545, 560);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(207, 20);
            this.txttotal.TabIndex = 16;
            this.txttotal.Text = "0";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // btnthembill
            // 
            this.btnthembill.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnthembill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthembill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthembill.ForeColor = System.Drawing.Color.White;
            this.btnthembill.Location = new System.Drawing.Point(163, 167);
            this.btnthembill.Name = "btnthembill";
            this.btnthembill.Size = new System.Drawing.Size(80, 33);
            this.btnthembill.TabIndex = 17;
            this.btnthembill.Text = ">>";
            this.btnthembill.UseVisualStyleBackColor = false;
            this.btnthembill.Click += new System.EventHandler(this.btnthembill_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewsp);
            this.panel4.Location = new System.Drawing.Point(67, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(667, 151);
            this.panel4.TabIndex = 18;
            // 
            // dataGridViewsp
            // 
            this.dataGridViewsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsp.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewsp.Name = "dataGridViewsp";
            this.dataGridViewsp.Size = new System.Drawing.Size(660, 144);
            this.dataGridViewsp.TabIndex = 0;
            this.dataGridViewsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsp_CellContentClick);
            // 
            // lbsanpham
            // 
            this.lbsanpham.AutoSize = true;
            this.lbsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsanpham.Location = new System.Drawing.Point(72, 204);
            this.lbsanpham.Name = "lbsanpham";
            this.lbsanpham.Size = new System.Drawing.Size(147, 15);
            this.lbsanpham.TabIndex = 19;
            this.lbsanpham.Text = "Danh Sách Sản Phẩm";
            // 
            // lbhd
            // 
            this.lbhd.AutoSize = true;
            this.lbhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhd.Location = new System.Drawing.Point(72, 391);
            this.lbhd.Name = "lbhd";
            this.lbhd.Size = new System.Drawing.Size(116, 16);
            this.lbhd.TabIndex = 20;
            this.lbhd.Text = "Hóa đơn chi tiết";
            // 
            // FormBilIDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 592);
            this.Controls.Add(this.lbhd);
            this.Controls.Add(this.lbsanpham);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnthembill);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbthanhtien);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBilIDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            this.Load += new System.EventHandler(this.FormBilIDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.Label lbthongtinhd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Label lbmasp;
        private System.Windows.Forms.Label lbchitiethd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Label lbthanhtien;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthembill;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttonkho;
        private System.Windows.Forms.Label lbtonkho;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewsp;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label lbdongia;
        private System.Windows.Forms.Label lbthoigian;
        private System.Windows.Forms.Label lbsanpham;
        private System.Windows.Forms.Label lbhd;
    }
}
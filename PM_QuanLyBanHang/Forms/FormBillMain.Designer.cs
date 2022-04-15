
namespace PM_QuanLyBanHang.Forms
{
    partial class FormBillMain
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
            this.tbttimkiem = new System.Windows.Forms.TextBox();
            this.btntao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txkhuyenmai = new System.Windows.Forms.TextBox();
            this.lbkhuyenmai = new System.Windows.Forms.Label();
            this.tbsohd = new System.Windows.Forms.TextBox();
            this.tbtime = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.tbmakh = new System.Windows.Forms.TextBox();
            this.lbsohd = new System.Windows.Forms.Label();
            this.lbthoigian = new System.Windows.Forms.Label();
            this.lbtenkh = new System.Windows.Forms.Label();
            this.lbmakh = new System.Windows.Forms.Label();
            this.lbthongtinhd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lbthanhtien = new System.Windows.Forms.Label();
            this.lbgiadatrukhuyemai = new System.Windows.Forms.Label();
            this.lbgimagia = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbttimkiem
            // 
            this.tbttimkiem.Location = new System.Drawing.Point(202, 81);
            this.tbttimkiem.Name = "tbttimkiem";
            this.tbttimkiem.Size = new System.Drawing.Size(257, 20);
            this.tbttimkiem.TabIndex = 1;
            this.tbttimkiem.Text = "name...";
            this.tbttimkiem.TextChanged += new System.EventHandler(this.tbttimkiem_TextChanged);
            // 
            // btntao
            // 
            this.btntao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntao.Location = new System.Drawing.Point(303, 451);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(130, 31);
            this.btntao.TabIndex = 3;
            this.btntao.Text = "TẠO HÓA ĐƠN";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 286);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txkhuyenmai);
            this.panel1.Controls.Add(this.lbkhuyenmai);
            this.panel1.Controls.Add(this.tbsohd);
            this.panel1.Controls.Add(this.tbtime);
            this.panel1.Controls.Add(this.txttenkh);
            this.panel1.Controls.Add(this.tbmakh);
            this.panel1.Controls.Add(this.lbsohd);
            this.panel1.Controls.Add(this.lbthoigian);
            this.panel1.Controls.Add(this.lbtenkh);
            this.panel1.Controls.Add(this.lbmakh);
            this.panel1.Controls.Add(this.lbthongtinhd);
            this.panel1.Location = new System.Drawing.Point(752, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 256);
            this.panel1.TabIndex = 7;
            // 
            // txkhuyenmai
            // 
            this.txkhuyenmai.Location = new System.Drawing.Point(103, 213);
            this.txkhuyenmai.Name = "txkhuyenmai";
            this.txkhuyenmai.ReadOnly = true;
            this.txkhuyenmai.Size = new System.Drawing.Size(248, 20);
            this.txkhuyenmai.TabIndex = 15;
            // 
            // lbkhuyenmai
            // 
            this.lbkhuyenmai.AutoSize = true;
            this.lbkhuyenmai.Location = new System.Drawing.Point(14, 216);
            this.lbkhuyenmai.Name = "lbkhuyenmai";
            this.lbkhuyenmai.Size = new System.Drawing.Size(74, 13);
            this.lbkhuyenmai.TabIndex = 14;
            this.lbkhuyenmai.Text = "KHUYẾN MẠI";
            // 
            // tbsohd
            // 
            this.tbsohd.Location = new System.Drawing.Point(102, 178);
            this.tbsohd.Name = "tbsohd";
            this.tbsohd.ReadOnly = true;
            this.tbsohd.Size = new System.Drawing.Size(249, 20);
            this.tbsohd.TabIndex = 13;
            // 
            // tbtime
            // 
            this.tbtime.Location = new System.Drawing.Point(102, 139);
            this.tbtime.Name = "tbtime";
            this.tbtime.ReadOnly = true;
            this.tbtime.Size = new System.Drawing.Size(249, 20);
            this.tbtime.TabIndex = 12;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(102, 104);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.ReadOnly = true;
            this.txttenkh.Size = new System.Drawing.Size(249, 20);
            this.txttenkh.TabIndex = 11;
            // 
            // tbmakh
            // 
            this.tbmakh.Location = new System.Drawing.Point(102, 69);
            this.tbmakh.Name = "tbmakh";
            this.tbmakh.ReadOnly = true;
            this.tbmakh.Size = new System.Drawing.Size(249, 20);
            this.tbmakh.TabIndex = 10;
            // 
            // lbsohd
            // 
            this.lbsohd.AutoSize = true;
            this.lbsohd.Location = new System.Drawing.Point(14, 181);
            this.lbsohd.Name = "lbsohd";
            this.lbsohd.Size = new System.Drawing.Size(41, 13);
            this.lbsohd.TabIndex = 7;
            this.lbsohd.Text = "SỐ HD";
            // 
            // lbthoigian
            // 
            this.lbthoigian.AutoSize = true;
            this.lbthoigian.Location = new System.Drawing.Point(14, 145);
            this.lbthoigian.Name = "lbthoigian";
            this.lbthoigian.Size = new System.Drawing.Size(62, 13);
            this.lbthoigian.TabIndex = 6;
            this.lbthoigian.Text = "THỜI GIAN";
            // 
            // lbtenkh
            // 
            this.lbtenkh.AutoSize = true;
            this.lbtenkh.Location = new System.Drawing.Point(14, 107);
            this.lbtenkh.Name = "lbtenkh";
            this.lbtenkh.Size = new System.Drawing.Size(47, 13);
            this.lbtenkh.TabIndex = 5;
            this.lbtenkh.Text = "TÊN KH";
            // 
            // lbmakh
            // 
            this.lbmakh.AutoSize = true;
            this.lbmakh.Location = new System.Drawing.Point(14, 72);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(41, 13);
            this.lbmakh.TabIndex = 4;
            this.lbmakh.Text = "MÃ KH";
            // 
            // lbthongtinhd
            // 
            this.lbthongtinhd.AutoSize = true;
            this.lbthongtinhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthongtinhd.Location = new System.Drawing.Point(83, 37);
            this.lbthongtinhd.Name = "lbthongtinhd";
            this.lbthongtinhd.Size = new System.Drawing.Size(164, 18);
            this.lbthongtinhd.TabIndex = 0;
            this.lbthongtinhd.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txttongtien);
            this.panel3.Controls.Add(this.textBox11);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.lbthanhtien);
            this.panel3.Controls.Add(this.lbgiadatrukhuyemai);
            this.panel3.Controls.Add(this.lbgimagia);
            this.panel3.Location = new System.Drawing.Point(752, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 126);
            this.panel3.TabIndex = 8;
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(200, 84);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(151, 20);
            this.txttongtien.TabIndex = 22;
            this.txttongtien.Text = "0";
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(200, 52);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(151, 20);
            this.textBox11.TabIndex = 21;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(200, 22);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(151, 20);
            this.textBox10.TabIndex = 20;
            // 
            // lbthanhtien
            // 
            this.lbthanhtien.AutoSize = true;
            this.lbthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthanhtien.Location = new System.Drawing.Point(27, 87);
            this.lbthanhtien.Name = "lbthanhtien";
            this.lbthanhtien.Size = new System.Drawing.Size(76, 13);
            this.lbthanhtien.TabIndex = 19;
            this.lbthanhtien.Text = "THÀNH TIỀN:";
            // 
            // lbgiadatrukhuyemai
            // 
            this.lbgiadatrukhuyemai.AutoSize = true;
            this.lbgiadatrukhuyemai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgiadatrukhuyemai.Location = new System.Drawing.Point(28, 55);
            this.lbgiadatrukhuyemai.Name = "lbgiadatrukhuyemai";
            this.lbgiadatrukhuyemai.Size = new System.Drawing.Size(142, 13);
            this.lbgiadatrukhuyemai.TabIndex = 18;
            this.lbgiadatrukhuyemai.Text = "GIÁ ĐÃ TRỪ KHUYẾN MẠI:";
            // 
            // lbgimagia
            // 
            this.lbgimagia.AutoSize = true;
            this.lbgimagia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgimagia.Location = new System.Drawing.Point(28, 29);
            this.lbgimagia.Name = "lbgimagia";
            this.lbgimagia.Size = new System.Drawing.Size(58, 13);
            this.lbgimagia.TabIndex = 17;
            this.lbgimagia.Text = "GIẢM GIÁ:";
            // 
            // btntimkiem
            // 
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(92, 74);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(84, 31);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // FormBillMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 652);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.tbttimkiem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntao);
            this.Name = "FormBillMain";
            this.Text = "HÓA ĐƠN";
            this.Load += new System.EventHandler(this.FormBillMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbttimkiem;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbkhuyenmai;
        private System.Windows.Forms.TextBox tbsohd;
        private System.Windows.Forms.TextBox tbtime;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox tbmakh;
        private System.Windows.Forms.Label lbsohd;
        private System.Windows.Forms.Label lbthoigian;
        private System.Windows.Forms.Label lbtenkh;
        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.Label lbthongtinhd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lbthanhtien;
        private System.Windows.Forms.Label lbgiadatrukhuyemai;
        private System.Windows.Forms.Label lbgimagia;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txkhuyenmai;
    }
}
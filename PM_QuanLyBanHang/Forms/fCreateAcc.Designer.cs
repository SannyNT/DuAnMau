
namespace PM_QuanLyBanHang.Forms
{
    partial class fCreateAcc
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbquanly = new System.Windows.Forms.RadioButton();
            this.rbnhanvien = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txthot = new System.Windows.Forms.TextBox();
            this.txtmatk = new System.Windows.Forms.TextBox();
            this.txtemdn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndkitk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtdc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txthot);
            this.panel1.Controls.Add(this.txtmatk);
            this.panel1.Controls.Add(this.txtemdn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(23, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 369);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbquanly);
            this.panel2.Controls.Add(this.rbnhanvien);
            this.panel2.Location = new System.Drawing.Point(192, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 60);
            this.panel2.TabIndex = 18;
            // 
            // rbquanly
            // 
            this.rbquanly.AutoSize = true;
            this.rbquanly.Location = new System.Drawing.Point(112, 18);
            this.rbquanly.Name = "rbquanly";
            this.rbquanly.Size = new System.Drawing.Size(61, 17);
            this.rbquanly.TabIndex = 1;
            this.rbquanly.Text = "Quản lý";
            this.rbquanly.UseVisualStyleBackColor = true;
            // 
            // rbnhanvien
            // 
            this.rbnhanvien.AutoSize = true;
            this.rbnhanvien.Checked = true;
            this.rbnhanvien.Location = new System.Drawing.Point(4, 18);
            this.rbnhanvien.Name = "rbnhanvien";
            this.rbnhanvien.Size = new System.Drawing.Size(74, 17);
            this.rbnhanvien.TabIndex = 0;
            this.rbnhanvien.TabStop = true;
            this.rbnhanvien.Text = "Nhân viên";
            this.rbnhanvien.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "VAI TRÒ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(237, 40);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(143, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "ĐĂNG KÝ";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(192, 238);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(371, 20);
            this.txtdc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "MẬT KHẨU:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "EMAIL ĐĂNG NHẬP:";
            // 
            // txthot
            // 
            this.txthot.Location = new System.Drawing.Point(192, 197);
            this.txthot.Name = "txthot";
            this.txthot.Size = new System.Drawing.Size(261, 20);
            this.txthot.TabIndex = 9;
            // 
            // txtmatk
            // 
            this.txtmatk.Location = new System.Drawing.Point(192, 155);
            this.txtmatk.Name = "txtmatk";
            this.txtmatk.Size = new System.Drawing.Size(261, 20);
            this.txtmatk.TabIndex = 8;
            this.txtmatk.UseSystemPasswordChar = true;
            // 
            // txtemdn
            // 
            this.txtemdn.Location = new System.Drawing.Point(192, 115);
            this.txtemdn.Name = "txtemdn";
            this.txtemdn.Size = new System.Drawing.Size(261, 20);
            this.txtemdn.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ĐỊA CHỈ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HỌ VÀ TÊN:";
            // 
            // btndkitk
            // 
            this.btndkitk.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btndkitk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndkitk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndkitk.ForeColor = System.Drawing.Color.White;
            this.btndkitk.Location = new System.Drawing.Point(257, 432);
            this.btndkitk.Name = "btndkitk";
            this.btndkitk.Size = new System.Drawing.Size(158, 32);
            this.btndkitk.TabIndex = 4;
            this.btndkitk.Text = "ĐĂNG KÝ";
            this.btndkitk.UseVisualStyleBackColor = false;
            this.btndkitk.Click += new System.EventHandler(this.btndkitk_Click);
            // 
            // fCreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(661, 535);
            this.Controls.Add(this.btndkitk);
            this.Controls.Add(this.panel1);
            this.Name = "fCreateAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthot;
        private System.Windows.Forms.TextBox txtmatk;
        private System.Windows.Forms.TextBox txtemdn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndkitk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbquanly;
        private System.Windows.Forms.RadioButton rbnhanvien;
        private System.Windows.Forms.Label label4;
    }
}
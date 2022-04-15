
namespace PM_QuanLyBanHang
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbthoat = new System.Windows.Forms.Label();
            this.btndangki = new System.Windows.Forms.Button();
            this.btnquenmk = new System.Windows.Forms.Button();
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.lbthoat);
            this.panel1.Controls.Add(this.btndangki);
            this.panel1.Controls.Add(this.btnquenmk);
            this.panel1.Controls.Add(this.lbdangnhap);
            this.panel1.Controls.Add(this.btndangnhap);
            this.panel1.Controls.Add(this.txtmk);
            this.panel1.Controls.Add(this.lbmatkhau);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.lbemail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(450, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 400);
            this.panel1.TabIndex = 0;
            // 
            // lbthoat
            // 
            this.lbthoat.AutoSize = true;
            this.lbthoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthoat.ForeColor = System.Drawing.Color.White;
            this.lbthoat.Location = new System.Drawing.Point(232, 22);
            this.lbthoat.Name = "lbthoat";
            this.lbthoat.Size = new System.Drawing.Size(17, 20);
            this.lbthoat.TabIndex = 0;
            this.lbthoat.Text = "x";
            this.lbthoat.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndangki
            // 
            this.btndangki.BackColor = System.Drawing.Color.White;
            this.btndangki.FlatAppearance.BorderSize = 0;
            this.btndangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangki.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btndangki.Location = new System.Drawing.Point(3, 308);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(101, 23);
            this.btndangki.TabIndex = 10;
            this.btndangki.Text = "Đăng ký";
            this.btndangki.UseVisualStyleBackColor = false;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // btnquenmk
            // 
            this.btnquenmk.BackColor = System.Drawing.Color.White;
            this.btnquenmk.FlatAppearance.BorderSize = 0;
            this.btnquenmk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquenmk.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnquenmk.Location = new System.Drawing.Point(138, 308);
            this.btnquenmk.Name = "btnquenmk";
            this.btnquenmk.Size = new System.Drawing.Size(101, 23);
            this.btnquenmk.TabIndex = 9;
            this.btnquenmk.Text = "Quên mật khẩu?";
            this.btnquenmk.UseVisualStyleBackColor = false;
            this.btnquenmk.Click += new System.EventHandler(this.btnquenmk_Click);
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbdangnhap.Location = new System.Drawing.Point(57, 58);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(153, 29);
            this.lbdangnhap.TabIndex = 8;
            this.lbdangnhap.Text = "ĐĂNG NHẬP";
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.Location = new System.Drawing.Point(34, 267);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(193, 35);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "ĐĂNG NHẬP";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(34, 197);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(193, 20);
            this.txtmk.TabIndex = 4;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbmatkhau.Location = new System.Drawing.Point(31, 179);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(66, 15);
            this.lbmatkhau.TabIndex = 3;
            this.lbmatkhau.Text = "Mật khẩu";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(34, 134);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(193, 20);
            this.txtemail.TabIndex = 2;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbemail.Location = new System.Drawing.Point(31, 116);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(116, 15);
            this.lbemail.TabIndex = 1;
            this.lbemail.Text = "Email đăng nhập";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbthoat;
        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Button btnquenmk;
        private System.Windows.Forms.Button btndangki;
    }
}



namespace PM_QuanLyBanHang
{
    partial class fManagement
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.lbllogo = new System.Windows.Forms.Label();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnemailuser = new System.Windows.Forms.Button();
            this.btncaidat = new System.Windows.Forms.Button();
            this.btnql = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnkh = new System.Windows.Forms.Button();
            this.btnsp = new System.Windows.Forms.Button();
            this.btndonhang = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btncaidat);
            this.panelMenu.Controls.Add(this.btnql);
            this.panelMenu.Controls.Add(this.btnout);
            this.panelMenu.Controls.Add(this.btnthongke);
            this.panelMenu.Controls.Add(this.btnkh);
            this.panelMenu.Controls.Add(this.btnsp);
            this.panelMenu.Controls.Add(this.btndonhang);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 661);
            this.panelMenu.TabIndex = 0;
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panellogo.Controls.Add(this.lbllogo);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panellogo.Size = new System.Drawing.Size(220, 80);
            this.panellogo.TabIndex = 0;
            // 
            // lbllogo
            // 
            this.lbllogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Minion Pro Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.Color.LightGray;
            this.lbllogo.Location = new System.Drawing.Point(36, 25);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(135, 26);
            this.lbllogo.TabIndex = 0;
            this.lbllogo.Text = "FASHION SHOP";
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.paneltitle.Controls.Add(this.btnemailuser);
            this.paneltitle.Controls.Add(this.lbltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(220, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(764, 80);
            this.paneltitle.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(336, 29);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(78, 26);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(764, 581);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // btnemailuser
            // 
            this.btnemailuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnemailuser.FlatAppearance.BorderSize = 0;
            this.btnemailuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemailuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemailuser.ForeColor = System.Drawing.Color.White;
            this.btnemailuser.Image = global::PM_QuanLyBanHang.Properties.Resources.moderator_24;
            this.btnemailuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemailuser.Location = new System.Drawing.Point(523, 12);
            this.btnemailuser.Name = "btnemailuser";
            this.btnemailuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnemailuser.Size = new System.Drawing.Size(241, 52);
            this.btnemailuser.TabIndex = 1;
            this.btnemailuser.Text = "    mail";
            this.btnemailuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemailuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnemailuser.UseVisualStyleBackColor = true;
            // 
            // btncaidat
            // 
            this.btncaidat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncaidat.FlatAppearance.BorderSize = 0;
            this.btncaidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncaidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaidat.ForeColor = System.Drawing.Color.White;
            this.btncaidat.Image = global::PM_QuanLyBanHang.Properties.Resources.settings_8_32;
            this.btncaidat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncaidat.Location = new System.Drawing.Point(0, 380);
            this.btncaidat.Name = "btncaidat";
            this.btncaidat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btncaidat.Size = new System.Drawing.Size(220, 60);
            this.btncaidat.TabIndex = 8;
            this.btncaidat.Text = "  CÀI ĐẶT";
            this.btncaidat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncaidat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncaidat.UseVisualStyleBackColor = true;
            this.btncaidat.Click += new System.EventHandler(this.btncaidat_Click);
            // 
            // btnql
            // 
            this.btnql.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnql.FlatAppearance.BorderSize = 0;
            this.btnql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnql.ForeColor = System.Drawing.Color.White;
            this.btnql.Image = global::PM_QuanLyBanHang.Properties.Resources.add_user_3_32;
            this.btnql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnql.Location = new System.Drawing.Point(0, 320);
            this.btnql.Name = "btnql";
            this.btnql.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnql.Size = new System.Drawing.Size(220, 60);
            this.btnql.TabIndex = 7;
            this.btnql.Text = "  QUẢN LÝ";
            this.btnql.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnql.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnql.UseVisualStyleBackColor = true;
            this.btnql.Click += new System.EventHandler(this.btnql_Click);
            // 
            // btnout
            // 
            this.btnout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnout.FlatAppearance.BorderSize = 0;
            this.btnout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.ForeColor = System.Drawing.Color.White;
            this.btnout.Image = global::PM_QuanLyBanHang.Properties.Resources.power_32;
            this.btnout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnout.Location = new System.Drawing.Point(0, 601);
            this.btnout.Name = "btnout";
            this.btnout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnout.Size = new System.Drawing.Size(220, 60);
            this.btnout.TabIndex = 6;
            this.btnout.Text = "  ĐĂNG XUẤT";
            this.btnout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnthongke.FlatAppearance.BorderSize = 0;
            this.btnthongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.ForeColor = System.Drawing.Color.White;
            this.btnthongke.Image = global::PM_QuanLyBanHang.Properties.Resources.bar_chart_5_32;
            this.btnthongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongke.Location = new System.Drawing.Point(0, 260);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnthongke.Size = new System.Drawing.Size(220, 60);
            this.btnthongke.TabIndex = 5;
            this.btnthongke.Text = "  THỐNG KÊ";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnkh
            // 
            this.btnkh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnkh.FlatAppearance.BorderSize = 0;
            this.btnkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkh.ForeColor = System.Drawing.Color.White;
            this.btnkh.Image = global::PM_QuanLyBanHang.Properties.Resources.conference_call_32;
            this.btnkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkh.Location = new System.Drawing.Point(0, 200);
            this.btnkh.Name = "btnkh";
            this.btnkh.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnkh.Size = new System.Drawing.Size(220, 60);
            this.btnkh.TabIndex = 3;
            this.btnkh.Text = "  KHÁCH HÀNG";
            this.btnkh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkh.UseVisualStyleBackColor = true;
            this.btnkh.Click += new System.EventHandler(this.btnkh_Click);
            // 
            // btnsp
            // 
            this.btnsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsp.FlatAppearance.BorderSize = 0;
            this.btnsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsp.ForeColor = System.Drawing.Color.White;
            this.btnsp.Image = global::PM_QuanLyBanHang.Properties.Resources.t_shirt_32;
            this.btnsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsp.Location = new System.Drawing.Point(0, 140);
            this.btnsp.Name = "btnsp";
            this.btnsp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnsp.Size = new System.Drawing.Size(220, 60);
            this.btnsp.TabIndex = 2;
            this.btnsp.Text = "  SẢN PHẨM";
            this.btnsp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsp.UseVisualStyleBackColor = true;
            this.btnsp.Click += new System.EventHandler(this.btnsp_Click);
            // 
            // btndonhang
            // 
            this.btndonhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndonhang.FlatAppearance.BorderSize = 0;
            this.btndonhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndonhang.ForeColor = System.Drawing.Color.White;
            this.btndonhang.Image = global::PM_QuanLyBanHang.Properties.Resources.cart_70_32;
            this.btndonhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonhang.Location = new System.Drawing.Point(0, 80);
            this.btndonhang.Name = "btndonhang";
            this.btndonhang.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btndonhang.Size = new System.Drawing.Size(220, 60);
            this.btndonhang.TabIndex = 1;
            this.btndonhang.Text = "  ĐƠN HÀNG";
            this.btndonhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndonhang.UseVisualStyleBackColor = true;
            this.btndonhang.Click += new System.EventHandler(this.button1_Click);
            // 
            // fManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "fManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fashion shop";
            this.Load += new System.EventHandler(this.fManagement_Load);
            this.panelMenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btnkh;
        private System.Windows.Forms.Button btnsp;
        private System.Windows.Forms.Button btndonhang;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Button btnql;
        private System.Windows.Forms.Button btncaidat;
        private System.Windows.Forms.Button btnemailuser;
        private System.Windows.Forms.Panel panelDesktop;
    }
}
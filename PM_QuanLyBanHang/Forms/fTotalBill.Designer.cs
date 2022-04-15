
namespace PM_QuanLyBanHang.Forms
{
    partial class fTotalBill
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
            this.dataGridthongke = new System.Windows.Forms.DataGridView();
            this.btnnhapkho = new System.Windows.Forms.Button();
            this.btntonkho = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridthongke);
            this.panel1.Location = new System.Drawing.Point(57, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 246);
            this.panel1.TabIndex = 0;
            // 
            // dataGridthongke
            // 
            this.dataGridthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridthongke.Location = new System.Drawing.Point(3, 3);
            this.dataGridthongke.Name = "dataGridthongke";
            this.dataGridthongke.Size = new System.Drawing.Size(806, 240);
            this.dataGridthongke.TabIndex = 0;
            // 
            // btnnhapkho
            // 
            this.btnnhapkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhapkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhapkho.Location = new System.Drawing.Point(249, 75);
            this.btnnhapkho.Name = "btnnhapkho";
            this.btnnhapkho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnnhapkho.Size = new System.Drawing.Size(204, 45);
            this.btnnhapkho.TabIndex = 2;
            this.btnnhapkho.Text = "SẢN PHẨM NHẬP KHO";
            this.btnnhapkho.UseVisualStyleBackColor = true;
            this.btnnhapkho.Click += new System.EventHandler(this.btnnhapkho_Click);
            // 
            // btntonkho
            // 
            this.btntonkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntonkho.Location = new System.Drawing.Point(489, 75);
            this.btntonkho.Name = "btntonkho";
            this.btntonkho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btntonkho.Size = new System.Drawing.Size(190, 45);
            this.btntonkho.TabIndex = 3;
            this.btntonkho.Text = "TỒN KHO";
            this.btntonkho.UseVisualStyleBackColor = true;
            this.btntonkho.Click += new System.EventHandler(this.btntonkho_Click);
            // 
            // fTotalBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 503);
            this.Controls.Add(this.btntonkho);
            this.Controls.Add(this.btnnhapkho);
            this.Controls.Add(this.panel1);
            this.Name = "fTotalBill";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.fTotalBill_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridthongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridthongke;
        private System.Windows.Forms.Button btnnhapkho;
        private System.Windows.Forms.Button btntonkho;
    }
}
﻿
namespace gym
{
    partial class Gym
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonabout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonpay = new System.Windows.Forms.Button();
            this.buttonliste = new System.Windows.Forms.Button();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonhome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(41)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.buttonabout);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.buttonpay);
            this.panel1.Controls.Add(this.buttonliste);
            this.panel1.Controls.Add(this.buttonekle);
            this.panel1.Controls.Add(this.buttonhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 531);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonabout
            // 
            this.buttonabout.BackColor = System.Drawing.Color.Transparent;
            this.buttonabout.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonabout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonabout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.buttonabout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonabout.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonabout.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonabout.Location = new System.Drawing.Point(0, 449);
            this.buttonabout.Name = "buttonabout";
            this.buttonabout.Size = new System.Drawing.Size(162, 79);
            this.buttonabout.TabIndex = 16;
            this.buttonabout.Text = "HAKKINDA";
            this.buttonabout.UseVisualStyleBackColor = false;
            this.buttonabout.Click += new System.EventHandler(this.buttonabout_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button4.Location = new System.Drawing.Point(0, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 92);
            this.button4.TabIndex = 15;
            this.button4.Text = "ÜYE TAKİP";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonpay
            // 
            this.buttonpay.BackColor = System.Drawing.Color.Transparent;
            this.buttonpay.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonpay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.buttonpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpay.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonpay.Location = new System.Drawing.Point(0, 278);
            this.buttonpay.Name = "buttonpay";
            this.buttonpay.Size = new System.Drawing.Size(162, 79);
            this.buttonpay.TabIndex = 14;
            this.buttonpay.Text = "ÖDEMELER";
            this.buttonpay.UseVisualStyleBackColor = false;
            this.buttonpay.Click += new System.EventHandler(this.buttonpay_Click);
            // 
            // buttonliste
            // 
            this.buttonliste.BackColor = System.Drawing.Color.Transparent;
            this.buttonliste.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonliste.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.buttonliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonliste.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonliste.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonliste.Location = new System.Drawing.Point(0, 206);
            this.buttonliste.Name = "buttonliste";
            this.buttonliste.Size = new System.Drawing.Size(162, 72);
            this.buttonliste.TabIndex = 13;
            this.buttonliste.Text = "ÜYELER";
            this.buttonliste.UseVisualStyleBackColor = false;
            this.buttonliste.Click += new System.EventHandler(this.buttonliste_Click);
            // 
            // buttonekle
            // 
            this.buttonekle.BackColor = System.Drawing.Color.Transparent;
            this.buttonekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonekle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonekle.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonekle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonekle.Location = new System.Drawing.Point(0, 126);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(162, 80);
            this.buttonekle.TabIndex = 12;
            this.buttonekle.Text = "ÜYE EKLE";
            this.buttonekle.UseVisualStyleBackColor = false;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonhome
            // 
            this.buttonhome.BackColor = System.Drawing.Color.Transparent;
            this.buttonhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonhome.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhome.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonhome.Image = global::gym.Properties.Resources.weightlifting__1_;
            this.buttonhome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonhome.Location = new System.Drawing.Point(0, 0);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(162, 126);
            this.buttonhome.TabIndex = 7;
            this.buttonhome.Text = "LOGO VE İSİM";
            this.buttonhome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonhome.UseVisualStyleBackColor = false;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(12)))), ((int)(((byte)(33)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 531);
            this.panel2.TabIndex = 1;
            // 
            // Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Gym";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonabout;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonpay;
        private System.Windows.Forms.Button buttonliste;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Panel panel2;
    }
}


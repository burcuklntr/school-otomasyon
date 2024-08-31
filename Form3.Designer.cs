
namespace school_otomasyon
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tohm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.havalandirma = new System.Windows.Forms.Button();
            this.nemlendirme = new System.Windows.Forms.Button();
            this.slma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numara = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.islem = new System.Windows.Forms.TextBox();
            this.ücret = new System.Windows.Forms.TextBox();
            this.tür = new System.Windows.Forms.TextBox();
            this.kayıtol = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.tohm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.havalandirma);
            this.groupBox1.Controls.Add(this.nemlendirme);
            this.groupBox1.Controls.Add(this.slma);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(617, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 638);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapılacak İşlem";
            // 
            // tohm
            // 
            this.tohm.BackColor = System.Drawing.Color.Plum;
            this.tohm.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tohm.Location = new System.Drawing.Point(256, 370);
            this.tohm.Name = "tohm";
            this.tohm.Size = new System.Drawing.Size(213, 51);
            this.tohm.TabIndex = 3;
            this.tohm.Text = "Tohum atma ";
            this.tohm.UseVisualStyleBackColor = false;
            this.tohm.Click += new System.EventHandler(this.tohm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-58, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarih";
            // 
            // havalandirma
            // 
            this.havalandirma.BackColor = System.Drawing.Color.LightSalmon;
            this.havalandirma.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.havalandirma.Location = new System.Drawing.Point(21, 145);
            this.havalandirma.Name = "havalandirma";
            this.havalandirma.Size = new System.Drawing.Size(209, 51);
            this.havalandirma.TabIndex = 3;
            this.havalandirma.Text = "Havalandırma";
            this.havalandirma.UseVisualStyleBackColor = false;
            this.havalandirma.Click += new System.EventHandler(this.havalandirma_Click);
            // 
            // nemlendirme
            // 
            this.nemlendirme.BackColor = System.Drawing.Color.Gold;
            this.nemlendirme.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nemlendirme.Location = new System.Drawing.Point(21, 370);
            this.nemlendirme.Name = "nemlendirme";
            this.nemlendirme.Size = new System.Drawing.Size(209, 51);
            this.nemlendirme.TabIndex = 3;
            this.nemlendirme.Text = "Nemlendirme";
            this.nemlendirme.UseVisualStyleBackColor = false;
            this.nemlendirme.Click += new System.EventHandler(this.nemlendirme_Click);
            // 
            // slma
            // 
            this.slma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.slma.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.slma.Location = new System.Drawing.Point(256, 145);
            this.slma.Name = "slma";
            this.slma.Size = new System.Drawing.Size(213, 51);
            this.slma.TabIndex = 3;
            this.slma.Text = "Sulama";
            this.slma.UseVisualStyleBackColor = false;
            this.slma.Click += new System.EventHandler(this.slma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "İstedigim islem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ücret";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bahce türü";
            // 
            // numara
            // 
            this.numara.BackColor = System.Drawing.Color.Honeydew;
            this.numara.Location = new System.Drawing.Point(218, 328);
            this.numara.Mask = "(999) 000-0000";
            this.numara.Name = "numara";
            this.numara.Size = new System.Drawing.Size(286, 29);
            this.numara.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 273);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 29);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(286, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // islem
            // 
            this.islem.BackColor = System.Drawing.SystemColors.Info;
            this.islem.Enabled = false;
            this.islem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem.Location = new System.Drawing.Point(218, 382);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(286, 28);
            this.islem.TabIndex = 0;
            this.islem.TextChanged += new System.EventHandler(this.islem_TextChanged);
            // 
            // ücret
            // 
            this.ücret.BackColor = System.Drawing.SystemColors.Info;
            this.ücret.Enabled = false;
            this.ücret.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ücret.ForeColor = System.Drawing.SystemColors.Info;
            this.ücret.Location = new System.Drawing.Point(218, 426);
            this.ücret.Name = "ücret";
            this.ücret.Size = new System.Drawing.Size(286, 28);
            this.ücret.TabIndex = 0;
            // 
            // tür
            // 
            this.tür.BackColor = System.Drawing.Color.Honeydew;
            this.tür.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tür.Location = new System.Drawing.Point(218, 224);
            this.tür.Name = "tür";
            this.tür.Size = new System.Drawing.Size(286, 28);
            this.tür.TabIndex = 0;
            // 
            // kayıtol
            // 
            this.kayıtol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kayıtol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtol.ForeColor = System.Drawing.Color.ForestGreen;
            this.kayıtol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kayıtol.ImageIndex = 0;
            this.kayıtol.Location = new System.Drawing.Point(276, 489);
            this.kayıtol.Name = "kayıtol";
            this.kayıtol.Size = new System.Drawing.Size(76, 39);
            this.kayıtol.TabIndex = 4;
            this.kayıtol.Text = "Kayıt ol";
            this.kayıtol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kayıtol.UseVisualStyleBackColor = true;
            this.kayıtol.Click += new System.EventHandler(this.kayıtol_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Soyisim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "İsim";
            // 
            // soyisim
            // 
            this.soyisim.BackColor = System.Drawing.Color.Honeydew;
            this.soyisim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisim.Location = new System.Drawing.Point(218, 172);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(286, 28);
            this.soyisim.TabIndex = 3;
            // 
            // isim
            // 
            this.isim.BackColor = System.Drawing.Color.Honeydew;
            this.isim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.Location = new System.Drawing.Point(218, 118);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(286, 28);
            this.isim.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.numara);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.islem);
            this.groupBox2.Controls.Add(this.ücret);
            this.groupBox2.Controls.Add(this.tür);
            this.groupBox2.Controls.Add(this.kayıtol);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.soyisim);
            this.groupBox2.Controls.Add(this.isim);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(9, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 638);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt ol";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::school_otomasyon.Properties.Resources.up_39637_1280;
            this.pictureBox1.Location = new System.Drawing.Point(1134, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tohm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button havalandirma;
        private System.Windows.Forms.Button nemlendirme;
        private System.Windows.Forms.Button slma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox numara;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox islem;
        private System.Windows.Forms.TextBox ücret;
        private System.Windows.Forms.TextBox tür;
        private System.Windows.Forms.Button kayıtol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox soyisim;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
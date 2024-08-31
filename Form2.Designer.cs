
namespace school_otomasyon
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bahce_türü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ücret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.istedigi_islem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nemlendirme",
            "Havalandırma",
            "Sulama",
            "Tohum Atma"});
            this.comboBox1.Location = new System.Drawing.Point(62, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 30);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(274, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.isim,
            this.soyisim,
            this.bahce_türü,
            this.tarih,
            this.telefon,
            this.ücret,
            this.istedigi_islem});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(62, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1308, 273);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // no
            // 
            this.no.Text = "no";
            // 
            // isim
            // 
            this.isim.Text = "İsim";
            this.isim.Width = 177;
            // 
            // soyisim
            // 
            this.soyisim.Text = "Soyisim";
            this.soyisim.Width = 165;
            // 
            // bahce_türü
            // 
            this.bahce_türü.Text = "Bahçe türü";
            this.bahce_türü.Width = 138;
            // 
            // tarih
            // 
            this.tarih.Text = "Tarih";
            this.tarih.Width = 176;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            this.telefon.Width = 183;
            // 
            // ücret
            // 
            this.ücret.Text = "Ücret";
            this.ücret.Width = 101;
            // 
            // istedigi_islem
            // 
            this.istedigi_islem.Text = "Yapılacak işlem";
            this.istedigi_islem.Width = 222;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1436, 32);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemleriGösterToolStripMenuItem,
            this.işlemSilToolStripMenuItem,
            this.işlemAraToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(89, 28);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            this.işlemlerToolStripMenuItem.Click += new System.EventHandler(this.işlemlerToolStripMenuItem_Click);
            // 
            // işlemleriGösterToolStripMenuItem
            // 
            this.işlemleriGösterToolStripMenuItem.Name = "işlemleriGösterToolStripMenuItem";
            this.işlemleriGösterToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.işlemleriGösterToolStripMenuItem.Text = "İşlemleri göster";
            this.işlemleriGösterToolStripMenuItem.Click += new System.EventHandler(this.işlemleriGösterToolStripMenuItem_Click);
            // 
            // işlemSilToolStripMenuItem
            // 
            this.işlemSilToolStripMenuItem.Name = "işlemSilToolStripMenuItem";
            this.işlemSilToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.işlemSilToolStripMenuItem.Text = "İşlem sil";
            this.işlemSilToolStripMenuItem.Click += new System.EventHandler(this.işlemSilToolStripMenuItem_Click);
            // 
            // işlemAraToolStripMenuItem
            // 
            this.işlemAraToolStripMenuItem.Name = "işlemAraToolStripMenuItem";
            this.işlemAraToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.işlemAraToolStripMenuItem.Text = "İşlem ara";
            this.işlemAraToolStripMenuItem.Click += new System.EventHandler(this.işlemAraToolStripMenuItem_Click);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDeğiştirToolStripMenuItem1});
            this.şifreDeğiştirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(66, 28);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre ";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // şifreDeğiştirToolStripMenuItem1
            // 
            this.şifreDeğiştirToolStripMenuItem1.Name = "şifreDeğiştirToolStripMenuItem1";
            this.şifreDeğiştirToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.şifreDeğiştirToolStripMenuItem1.Text = "Şifre değiştir";
            this.şifreDeğiştirToolStripMenuItem1.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem1_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporGörüntüleToolStripMenuItem});
            this.raporToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(75, 28);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // raporGörüntüleToolStripMenuItem
            // 
            this.raporGörüntüleToolStripMenuItem.Name = "raporGörüntüleToolStripMenuItem";
            this.raporGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.raporGörüntüleToolStripMenuItem.Text = "Rapor görüntüle";
            this.raporGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.raporGörüntüleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "İşlem ara";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::school_otomasyon.Properties.Resources.up_39637_1280;
            this.pictureBox1.Location = new System.Drawing.Point(1367, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader isim;
        private System.Windows.Forms.ColumnHeader soyisim;
        private System.Windows.Forms.ColumnHeader bahce_türü;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader ücret;
        private System.Windows.Forms.ColumnHeader istedigi_islem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemleriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem raporGörüntüleToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
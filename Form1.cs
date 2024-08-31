using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_otomasyon
{
    public partial class Form1 : Form
    {

        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[i];
            i++;
            if (i > ımageList1.Images.Count - 1) i = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[i];
            i++;
            if (i > ımageList1.Images.Count - 1) i = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin c = new admin();
            c.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullanıcı t = new kullanıcı();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            galeri x = new galeri();
            x.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            hizmetlerimiz r = new hizmetlerimiz();
            r.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            hakkımızda z = new hakkımızda();
            z.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            iletişim b = new iletişim();
            b.Show();
        }
    }
}

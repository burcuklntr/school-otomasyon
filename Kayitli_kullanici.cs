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
    public partial class Kayitli_kullanici : Form
    {
        public Kayitli_kullanici()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullanıcı a = new kullanıcı();
            a.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullanıcı_güncelle h = new kullanıcı_güncelle();
            h.Show();
        }
    }
}

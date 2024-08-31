using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data.Sql;

namespace school_otomasyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-N4LRT9C; Initial Catalog = projebrc; Integrated Security = True");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullanıcı n = new kullanıcı();
            n.Show();
        }
        

        private void havalandirma_Click(object sender, EventArgs e)
        {
            islem.Text = "Havalandırma";
            ücret.Text = "100";

        }

        private void slma_Click(object sender, EventArgs e)
        {
            islem.Text = "Sulama";
            ücret.Text = "150";
        }

        private void nemlendirme_Click(object sender, EventArgs e)
        {

            islem.Text = "Nemlendirme";
            ücret.Text = "200";
        }

        private void tohm_Click(object sender, EventArgs e)
        {
            islem.Text = "Tohum Atma";
            ücret.Text = "250";
        }

        private void kayıtol_Click(object sender, EventArgs e)
        {

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into kayit_bilgisi(isim, soyisim,bahce_türü,tarih,telefon,ücret,istedigi_islem) values('" + isim.Text + "','" + soyisim.Text + "','" + tür.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + numara.Text + "','" + ücret.Text + "','" + islem.Text + "')", con);



            if (isim.Text == "" || soyisim.Text == "" || tür.Text == "" || numara.Text == "" || dateTimePicker1.Text.ToString() == "" || islem.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kayıt eklendi " +
                    "Giriş yapabilirsiniz..", "KAYIT", MessageBoxButtons.OK); //MessageBox.Show("Kayıt eklendi ", "KAYIT İŞLEMİ", MessageBoxButtons.OK);
                this.Hide();
                Form1 n = new Form1();
                n.Show();

                //metni database'e aktar
            }
            con.Close();

        }

        private void islem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

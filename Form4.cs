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
using System.Data.Sql;

namespace school_otomasyon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N4LRT9C;Initial Catalog=projebrc;Integrated Security=True");

        public void SifreDegistir()
        {
            try
            {
                baglanti.Open();

                SqlCommand guncelle = new SqlCommand("update admin set sifre='" + txtYeniSifre.Text + "'", baglanti);

                guncelle.ExecuteNonQuery();
                baglanti.Close();
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Green;
                lblHata.Text = "Şifre Başarıyla Değiştirildi";

            }

            catch (Exception)
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Şifre Değiştirme Hatası";
            }
        }

            private void Form4_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            try
            {
                SqlCommand mevcutsifre = new SqlCommand();
                baglanti.Open();
                mevcutsifre.Connection = baglanti;
                mevcutsifre.CommandText = "select * from admin where sifre='" + txtMevcutSifre.ToString() + "'";
                SqlDataReader dr = mevcutsifre.ExecuteReader();
                if (dr.Read())
                {
                    txtMevcutSifre.Text = dr["sifre"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Mevcut Şifre Getirilemiyor";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMevcutSifre.UseSystemPasswordChar = false;
                txtYeniSifre.UseSystemPasswordChar = false;
                txtYeniSifreTekrar.UseSystemPasswordChar = false;
            }
            else
            {
                txtMevcutSifre.UseSystemPasswordChar = true;
                txtYeniSifre.UseSystemPasswordChar = true;
                txtYeniSifreTekrar.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                if (txtYeniSifre.Text != "" && txtYeniSifreTekrar.Text != "" && txtMevcutSifre.Text != "")
                {
                    SifreDegistir();
                }
                else
                {
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Red;
                    lblHata.Text = "Alanları Boş Bırakmayınız";
                }
            }
            else
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Şifreler Eşleşmiyor";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 u = new Form2();
            u.Show();
        }
    }
}

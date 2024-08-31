using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security;
using System.Net.Mail;

namespace school_otomasyon
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }


        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("mkalantar01@gmail.com");
            ePosta.To.Add(textBox1.Text);

            ePosta.Subject = konu;
            ePosta.Body = icerik;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("mkalantar01@gmail.com", "195401burcu");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {

                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }

        string sifre;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N4LRT9C;Initial Catalog=projebrc;Integrated Security=True");
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select * from admin where mail='" + textBox1.Text.ToString() + "'", baglanti);
                komut.Connection = baglanti;
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    sifre = oku["sifre"].ToString();

                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Green;
                    lblHata.Text = "Girmiş Olduğunuz Bilgiler Uyuşuyor Şifreniz Mail Olarak Gönderildi!";

                    progressBar1.Visible = true;
                    progressBar1.Maximum = 900000;
                    progressBar1.Minimum = 90;


                    for (int j = 90; j < 900000; j++)
                    {
                        progressBar1.Value = j;
                    }

                    MailGonder("ŞİFRE HATIRLATMA", "Şifreniz: " + sifre);
                    baglanti.Close();
                    this.Hide();
                    admin a = new admin();
                    a.Show();
                }
                else
                {
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Red;
                    lblHata.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
                }
            }
            catch (Exception)
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Mail Gönderme Hatası";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin w = new admin();
            w.Show();
        }

        private void sifremiunuttum_Load(object sender, EventArgs e)
        {

        }
    }
}


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

namespace school_otomasyon
{
    public partial class kullanıcı_güncelle : Form
    {
        int id = 0;
        public kullanıcı_güncelle()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-N4LRT9C;Initial Catalog=projebrc;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void kullanıcı_güncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from kayit_bilgisi where isim=@name and soyisim=@soy";
            //isim parametresine bağlı olarak müşteri bilgilerini çeken sql kodu
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@name", textBox1.Text);
            komut.Parameters.AddWithValue("@soy", textBox2.Text);

            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                id = Convert.ToInt32(dr["ID"]);
                textBox3.Text = dr["bahce_türü"].ToString();
                textBox4.Text = dr["tarih"].ToString();
                textBox5.Text = dr["telefon"].ToString();
                comboBox1.Text = dr["istedigi_islem"].ToString();

                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update kayit_bilgisi set bahce_türü=@bahce,tarih=@trh,telefon=@tel,istedigi_islem=@islem,ücret=@money where ID=@id";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.



            komut.Parameters.AddWithValue("@id", id);
            komut.Parameters.AddWithValue("@bahce", textBox3.Text);
            komut.Parameters.AddWithValue("@trh", textBox4.Text);
            komut.Parameters.AddWithValue("@tel", textBox5.Text);

            komut.Parameters.AddWithValue("@islem", comboBox1.Text);
            komut.Parameters.AddWithValue("@money", textBox6.Text);




            //komut.Parameters.AddWithValue("@islem", comboBox1.Text);


            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

            this.Hide();
            Form1 u = new Form1();
            u.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox6.Text = "100";
            else if (comboBox1.SelectedIndex == 1)
                textBox6.Text = "150";
            else if (comboBox1.SelectedIndex == 2)
                textBox6.Text = "200";
            else
                textBox6.Text = "250";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayitli_kullanici p = new Kayitli_kullanici();
            p.Show();
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
    


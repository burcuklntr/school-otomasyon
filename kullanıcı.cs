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
    public partial class kullanıcı : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public static string KullanicimSession = "";

        public int denemeSayisi = 0;
        public kullanıcı()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = isim.Text;
            string surname = soy.Text;
            con = new SqlConnection("Data Source=DESKTOP-N4LRT9C;Initial Catalog=projebrc;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select *From kayit_bilgisi where isim='"+isim.Text+"'And soyisim='"+soy.Text+"'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giris Basarılı");
                this.Hide();
                KullanicimSession = isim.Text;

                Kayitli_kullanici m = new Kayitli_kullanici();
                m.textBox1.Text = isim.Text;
                m.textBox2.Text = soy.Text;
                m.textBox3.Text = dr["bahce_türü"].ToString();
                m.textBox4.Text = dr["tarih"].ToString();
                m.textBox5.Text = dr["telefon"].ToString();
                m.textBox7.Text = dr["ücret"].ToString();
                m.textBox6.Text = dr["istedigi_islem"].ToString();


                m.ShowDialog();
            }
            else if (denemeSayisi == 0)
            {
                MessageBox.Show("1.deneme başarısız");
                isim.Clear();
                soy.Clear();
                isim.Focus();

                denemeSayisi++;
            }
            else if (denemeSayisi == 1)
            {
                MessageBox.Show("2.deneme başarısız");
                isim.Clear();
                soy.Clear();
                isim.Focus();
                denemeSayisi++;
            }
            else
            {
                MessageBox.Show("3.deneme başarısız");
                Application.Exit();
            }
            con.Close();


        }




        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcı_Load(object sender, EventArgs e)
        {

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 v = new Form3();
            v.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void isim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


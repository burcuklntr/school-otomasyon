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
    public partial class sifrem : Form
    {
        public sifrem()
        {
            InitializeComponent();
        }
        static string conString = "Data Source =DESKTOP-N4LRT9C; Initial Catalog = projebrc; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);


        private void sifrem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string secmeSorgusu = "SELECT * from kayit_bilgisi where ID=@musterino";

            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@musterino", textBox1.Text);

            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();

            if (dr.Read())
            {
                string isim = dr["isim"].ToString() + "" + dr["soyisim"].ToString();
                dr.Close();

                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from kayit_bilgisi where ID=@musterino";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@musterino", textBox1.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");

                }
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglanti.Close();

            this.Hide();
            Form2 a = new Form2();
            a.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 u = new Form2();
            u.Show();
        }
    }
}

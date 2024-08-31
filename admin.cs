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
    public partial class admin : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-N4LRT9C;Initial Catalog=projebrc;Integrated Security=True";

        public int denemeSayisi = 0;

        public admin()
        {
            InitializeComponent();
            Init_Data();
            con = new SqlConnection(SqlCon);
        }
        public void Login_ekran()
        {
            string sorgu = "select *from admin where isim=@user and sifre=@pass";


            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);



            con.Open();

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giris basarılı");

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya sifre yanlıs");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();


            }
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verıtabanı.Login_ekranKontrol(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Giris basarılı");         //Admin  //1234 (kullanıcı adı ve şifre)
                //hide ederek formu gizleriz.
                this.Hide();
                //KullanicimSession = textBox1.Text;
                Save_Data();
                Form2 a = new Form2();
                a.Show();

            }
            else if (denemeSayisi == 0)
            {
                MessageBox.Show("1.deneme başarısız");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

                denemeSayisi++;
            }
            else if (denemeSayisi == 1)
            {
                MessageBox.Show("2.deneme başarısız");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                denemeSayisi++;
            }
            else
            {
                MessageBox.Show("3.deneme başarısız");

                Application.Exit();
            }




        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.admin != string.Empty)
            {
                if (Properties.Settings.Default.remember == true)
                {
                    textBox1.Text = Properties.Settings.Default.admin;
                    textBox2.Text = Properties.Settings.Default.pass;
                    checkBox1.Checked = true;
                }
                else
                {
                    textBox1.Text = Properties.Settings.Default.admin;
                }
            }
        }
        private void Save_Data()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.admin = textBox1.Text;
                Properties.Settings.Default.pass = textBox2.Text;
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.Save();


            }
            else
            {
                Properties.Settings.Default.admin = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sifremiunuttum frm = new sifremiunuttum();
            frm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
    }


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
using System.Security.Cryptography;

namespace school_otomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-N4LRT9C; Initial Catalog = projebrc; Integrated Security = True");

        private void verilerigoster()
        {
            listView1.Items.Clear();

            con.Open();
            SqlCommand cmd = new SqlCommand("select *From kayit_bilgisi", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["ID"].ToString();
                ekle.SubItems.Add(dr["isim"].ToString());
                ekle.SubItems.Add(dr["soyisim"].ToString());
                ekle.SubItems.Add(dr["bahce_türü"].ToString());
                ekle.SubItems.Add(dr["tarih"].ToString());
                ekle.SubItems.Add(dr["telefon"].ToString());
                ekle.SubItems.Add(dr["ücret"].ToString());
                ekle.SubItems.Add(dr["istedigi_islem"].ToString());

                listView1.Items.Add(ekle);
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            con.Open();
            SqlCommand cmd = new SqlCommand("select *From kayit_bilgisi where istedigi_islem = '" + comboBox1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["ID"].ToString();
                ekle.SubItems.Add(dr["isim"].ToString());
                ekle.SubItems.Add(dr["soyisim"].ToString());
                ekle.SubItems.Add(dr["bahce_türü"].ToString());
                ekle.SubItems.Add(dr["tarih"].ToString());
                ekle.SubItems.Add(dr["telefon"].ToString());
                ekle.SubItems.Add(dr["ücret"].ToString());
                ekle.SubItems.Add(dr["istedigi_islem"].ToString());

                listView1.Items.Add(ekle);
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            button3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 w = new Form4();
            w.Show();
        }

        private void işlemleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;

            verilerigoster();

            comboBox1.SelectedIndex = -1;
        }

        private void işlemSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verilerigoster();
            sifrem a = new sifrem();
            a.Show();
        }

        private void işlemAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            comboBox1.Visible = true;
            button3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şifreDeğiştirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 z = new Form4();
            z.Show();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raporGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            rapor w = new rapor();
            w.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin q = new admin();
            q.Show();
        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }


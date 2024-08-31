using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace school_otomasyon
{
    class verıtabanı
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static System.Data.DataSet ds;

        public static string SqlCon = "Data Source=DESKTOP-N4LRT9C;Initial Catalog=projebrc;Integrated Security=True";

        public static bool Login_ekranKontrol(string isim, string sifre)
        {
            string sorgu = "select *from admin where isim=@user and sifre=@pass";


            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@user", isim);

            cmd.Parameters.AddWithValue("@pass", sifre);
           



            con.Open();

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //MessageBox.Show("Giris basarılı");

                con.Close();
                return true;
            }
            else
            {
                // MessageBox.Show("Kullanıcı adı veya sifre yanlıs");

                con.Close();
                return false;

            }


        }



    }
}

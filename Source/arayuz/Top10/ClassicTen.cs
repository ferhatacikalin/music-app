using arayuz.Kullanıcı_Arayüzü;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace arayuz.Top10
{
    public partial class ClassicTen : Form
    {

        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlConnection sqlcon = new MySqlConnection();
        DataTable sqldt = new DataTable();
        MySqlDataReader sqlRd;

        public ClassicTen()
        {
            InitializeComponent();
        }

        public void uploadData()//tabloyu yükleme
        {
            String Klasik = "%Classic%";
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "select * from sarki where Tur like '" + Klasik + "' order by DinlenmeSayisi Desc limit 10 ;";

            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridView1.DataSource = sqldt;
        }

        private void ClassicTen_Load(object sender, EventArgs e)
        {
            uploadData();
        }//upload data

        int x;
        public void kontrol(int gelenx)// premium or regular user ?
        {
            this.x = gelenx;
        }

        private void buttonpop_Click(object sender, EventArgs e)// pop ten
        {
            this.Hide();
            PopTen pt = new PopTen(); pt.kontrol(x);
            pt.Show();
        }
        private void buttonjazz_Click(object sender, EventArgs e)// jazz ten
        {
            this.Hide();
            JazzTen jt = new JazzTen(); jt.kontrol(x);
            jt.Show();
        }
        private void buttontopten_Click(object sender, EventArgs e)// top ten
        {
            this.Hide();
            Topten tt = new Topten(); tt.kontrol(x); tt.Show();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (x == 1)
            {
                Premium pr = new Premium();
                pr.Show();
            }
            else
            {
                RegularUser ru = new RegularUser();
                ru.Show();
            }
        }// exit butonu
    }
}

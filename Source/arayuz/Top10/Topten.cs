using arayuz.Kullanıcı_Arayüzü;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace arayuz.Top10
{
    public partial class Topten : Form
    {

        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlConnection sqlcon = new MySqlConnection();
        DataTable sqldt = new DataTable();
        MySqlDataReader sqlRd;

        public void uploadData()//tabloyu yükleme
        {

            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "select sarkiad,albumad,tur,dinlenmesayisi from prolab.sarki  order by DinlenmeSayisi DESC Limit 10 ;";

            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridView1.DataSource = sqldt;
        }

        public Topten()
        {
            InitializeComponent();
        }

        private void Topon_Load(object sender, EventArgs e)
        {
            uploadData();//odendicekme();
        }

        int x;
        public void kontrol(int gelenx)//premium mu regular mı kontrol 
        {
            this.x = gelenx;
        }

        private void button3_Click(object sender, EventArgs e)//classic ten
        {
            this.Hide();

            ClassicTen ct = new ClassicTen();
            ct.kontrol(x);
            ct.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)//pop ten
        {
            this.Hide();
            PopTen pt = new PopTen(); pt.kontrol(x);
            pt.Show();
        }
        private void buttonjazz_Click(object sender, EventArgs e)//jazz 
        {
            this.Hide();
            JazzTen jt = new JazzTen(); jt.kontrol(x);
            jt.Show();
        }
       
        private void button1_Click(object sender, EventArgs e) // exit button
        {

            this.Hide();
            if (x == 1)
            {
                Premium pr = new Premium();                
                pr.Show();
            }
            else
            {
                RegularUser rut = new RegularUser();
                rut.Show();
            }

        }
    }
}

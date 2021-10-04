using arayuz.Kullanıcı_Arayüzü;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace arayuz.Top10
{
    public partial class JazzTen : Form
    {
        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlConnection sqlcon = new MySqlConnection();
        DataTable sqldt = new DataTable();
        MySqlDataReader sqlRd;
        String sqlQuery;
        MySqlDataAdapter Dta = new MySqlDataAdapter();

        public JazzTen()
        {
            InitializeComponent();
        }

        public void uploadData()//tabloyu yükleme
        {
            String jazz = "%jazz%";
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "select * from prolab.sarki where Tur like '" + jazz + "' order by DinlenmeSayisi Desc Limit 10;";

            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridView1.DataSource = sqldt;
        }

        int x;
        public void kontrol(int gelenx)//premium mu regular mı kontrol 
        {
            this.x = gelenx;
        }

        private void JazzTen_Load(object sender, EventArgs e)//upload Data
        {
            uploadData();
        }
        private void buttonpop_Click(object sender, EventArgs e)//pop ten
        {
            this.Hide();
            PopTen pt = new PopTen(); pt.kontrol(x);
            pt.Show();

        }
        private void buttonklasik_Click(object sender, EventArgs e)// classic ten
        {
            this.Hide();
            ClassicTen ct = new ClassicTen(); ct.kontrol(x);
            ct.Show();
        }
        private void buttontopten_Click(object sender, EventArgs e)//top ten
        {
            this.Hide();
            Topten tt = new Topten(); tt.kontrol(x);
            tt.Show();
        }

        private void buttonexit_Click(object sender, EventArgs e)//exit button
        {

            this.Hide();
            if (x == 1)
            {
                Premium pre = new Premium();
                pre.Show();
            }
            else
            {
                RegularUser rut = new RegularUser();
                rut.Show();
            }
        }
    }
}

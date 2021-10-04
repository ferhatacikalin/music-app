using arayuz.Top10;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace arayuz.Kullanıcı_Arayüzü
{
    public partial class Premium : Form
    {
        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlConnection sqlcon = new MySqlConnection();
        DataTable sqldt = new DataTable();
        MySqlDataReader sqlRd;

        public string id;
        public void idcekme(string ad, string sifre)
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd.Connection = sqlcon; sqldt = new DataTable();
            sqlCmd.CommandText = "select kullaniciId from prolab.kullanicilar where kullaniciAdi='" + ad + "' and  sifre = '" + sifre + "' ";
            sqlRd = sqlCmd.ExecuteReader();
            while (sqlRd.Read())
            {
                String idgelen = Convert.ToString(sqlRd["kullaniciId"]);
                this.id = idgelen;
            }
        }

        public void uploadPopData()//Pop tabloyu yükleme
        {
            String pop = "%pop%";
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd = new MySqlCommand();
            sqlCmd.Connection = sqlcon; sqldt = new DataTable();
            sqlCmd.CommandText = "select sarkiad , sure,dinlenmesayisi from prolab.sarki as s ,prolab.playlistdata as pd, prolab.kullanicilar as k  where (pd.kullaniciId=k.kullaniciId  ) and (s.tur like '" + pop + "')and pd.sarkiid=s.sarkiid and pd.tur like '" + pop + "' and pd.kullaniciId='" + id + "'; ";
            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridViewPop.DataSource = sqldt;

        }
        public void uploadClassicData()//Classic tabloyu yükle
        {
            String classic = "%Classic%";
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd = new MySqlCommand();
            sqlCmd.Connection = sqlcon; sqldt = new DataTable();
            sqlCmd.CommandText = "select sarkiad , sure,dinlenmesayisi from prolab.sarki as s ,prolab.playlistdata as pd, prolab.kullanicilar as k  where (pd.kullaniciId=k.kullaniciId  ) and (s.tur like '" + classic + "')and pd.sarkiid=s.sarkiid and pd.tur like '" + classic + "' and pd.kullaniciId='" + id + "'; ";
            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridViewClassic.DataSource = sqldt;

        }
        public void uploadJazzData()//Jazz tabloyu yükle
        {
            String Jazz = "%Jazz%";
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd = new MySqlCommand();
            sqlCmd.Connection = sqlcon; sqldt = new DataTable();
            sqlCmd.CommandText = "select sarkiad , sure,dinlenmesayisi from prolab.sarki as s ,prolab.playlistdata as pd, prolab.kullanicilar as k  where (pd.kullaniciId=k.kullaniciId  ) and (s.tur like '" + Jazz + "')and pd.sarkiid=s.sarkiid and pd.tur like '" + Jazz + "' and pd.kullaniciId='" + id + "'; ";
            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridViewJazz.DataSource = sqldt;

        }
        public void Premium_Load(object sender, EventArgs e)
        {
            uploadPopData(); uploadClassicData(); uploadJazzData();
        }
       
        public Premium()
        {
            InitializeComponent();
            

        }
        private void buttontopten_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Topten to = new Topten(); to.kontrol(1);
            to.Show();
        }

        private void buttonpop10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PopTen pto = new PopTen(); pto.kontrol(1);
            pto.Show();
        }

        private void buttonclassic10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ClassicTen ct = new ClassicTen(); ct.kontrol(1);
            ct.Show();
        }

        private void buttonjazz10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            JazzTen jt = new JazzTen(); jt.kontrol(1);
            jt.Show();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

       
    }
}

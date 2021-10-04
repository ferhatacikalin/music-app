using arayuz.Kullanıcı_Arayüzü;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace arayuz
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }


        private void login_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Program.databasecon);
            MySqlCommand comm = new MySqlCommand(); MySqlCommand com = new MySqlCommand();
            MySqlDataReader dt, dr;

            con.Open();
            comm.Connection = con;
            com.Connection = con;



            comm.CommandText = "select * from prolab.kullanicilar where kullaniciAdi='" + this.username.Text + "' and sifre='" + this.password.Text + "' ;";
            com.CommandText = "select * from prolab.kullanicilar  where kullaniciAdi='" + this.username.Text + "' and sifre='" + this.password.Text + "' and odendi = true ; ;";


            dt = comm.ExecuteReader();
            if (dt.Read())
            {
                string name = Convert.ToString(this.username.Text);
                string sifre = Convert.ToString(this.password.Text);

                dt.Close();
                dr = com.ExecuteReader();
                if (dr.Read())
                {

                    MessageBox.Show("Premium User Login Successful");
                    this.Hide();
                    Premium pre = new Premium(); pre.idcekme(name, sifre);
                    pre.Show();

                }
                else
                {

                    MessageBox.Show("Regular User Login Successful");
                    this.Hide();
                    RegularUser ru = new RegularUser(); ru.idcekme(name, sifre);
                    ru.Show();
                }
            }
            else
            {
                labelwrong.Show();
            }
        }
        /*public string namegonder()
        {
            string gonder = Convert.ToString(this.username.Text);
            return gonder;
        }
        public string sifregonder()
        {
            string sifregonde = Convert.ToString(this.password.Text);
            return sifregonde;
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.Show();



        }

        private void linklabelexit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}

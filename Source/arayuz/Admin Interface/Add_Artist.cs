using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace arayuz
{
    public partial class SanatciEkleme : Form
    {


        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlConnection sqlcon = new MySqlConnection();
        DataTable sqldt = new DataTable();
        MySqlDataReader sqlRd;
        String sqlQuery;
        MySqlDataAdapter Dta = new MySqlDataAdapter();


        public void uploadData()
        {

            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "SELECT * FROM prolab.sanatci; ";

            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridView1.DataSource = sqldt;
        }
        public SanatciEkleme()
        {
            InitializeComponent();
            uploadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sanatciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void albumEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlbumEkleme ae = new AlbumEkleme();
            ae.Show();
        }

        private void EkleToolBar_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button4_Click(object sender, EventArgs e) //reset butonu
        {
            try
            {
                foreach (Control c in panel2.Controls)

                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();

                    }
                    textSanatciad.Text = ""; textSanatciid.Text = ""; textsanatciulke.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();

            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "delete from prolab.sanatci where sanatciid=@sanatciid";
            sqlCmd = new MySqlCommand(sqlQuery, sqlcon);
            sqlcon.Close();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

            }

        }//silme işlemi

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)// tabloya tıkladığında verileri
                                                                                        // textbox ' a aktarma işlemi
        {
            try
            {

                textSanatciid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textSanatciad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textsanatciulke.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)//ekleme işlemi
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            try
            {
                sqlcon.Open();
                sqlQuery = "insert into prolab.sanatci ( sanatciid,sanatciad, ulke)" + "values('" + textSanatciid.Text + "','" + textSanatciad.Text + "','" + textsanatciulke.Text + "')";
                sqlCmd = new MySqlCommand(sqlQuery, sqlcon);
                sqlRd = sqlCmd.ExecuteReader();
                sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            uploadData();
        }

        private void button5_Click(object sender, EventArgs e)// Güncelleme işlemi
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            try
            {

                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "Update prolab.sanatci set sanatciid=@sanatciid , sanatciad = @sanatciad,ulke =@ulke where sanatciid = @sanatciid;";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@sanatciid", textSanatciid.Text);
                sqlCmd.Parameters.AddWithValue("@sanatciad", textSanatciad.Text);
                sqlCmd.Parameters.AddWithValue("@ulke", textsanatciulke.Text);


                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                uploadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void SanatciEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}

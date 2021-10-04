using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace arayuz
{
    public partial class AlbumEkleme : Form
    {


        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlConnection sqlcon = new MySqlConnection();
        DataTable sqldt = new DataTable();
        MySqlDataReader sqlRd;
        String sqlQuery;
        MySqlDataAdapter Dta = new MySqlDataAdapter();


        public void uploadData()//tabloyu yükleme
        {

            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "SELECT * FROM prolab.album; ";

            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridView1.DataSource = sqldt;
        }

        public AlbumEkleme()
        {

            InitializeComponent();
            uploadData();
        }

        private void AlbumEkleme_Load(object sender, EventArgs e)
        {

        }

        private void albumEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void sanatciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanatciEkleme se = new SanatciEkleme();
            se.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();

        }

        private void button5_Click(object sender, EventArgs e)//text box ları resetleme
        {
            try
            {
                foreach (Control c in panel2.Controls)

                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();

                    }
                    textAlbumad.Text = ""; textAlbumid.Text = ""; textalbumtarih.Text = ""; textalbumtur.Text = ""; textSAnatciad.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)// tabloya tıkladığında verileri
                                                                                        // textbox ' a aktarma işlemi
        {
            try
            {

                textAlbumid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textAlbumad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textSAnatciad.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textalbumtarih.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textalbumtur.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)//silme işlemi
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();

            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "delete from prolab.album where albumid=@albumid";
            sqlCmd = new MySqlCommand(sqlQuery, sqlcon);
            sqlcon.Close();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

            }

        }

        private void button1_Click(object sender, EventArgs e)// ekle işlemi
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            try
            {
                sqlcon.Open();
                sqlQuery = "insert into prolab.album ( albumidd,albumad,sanatciad,tarih,tur)" + "values('" + textAlbumid.Text + "','" + textAlbumad.Text + "','" + textSAnatciad.Text + "','" + textalbumtarih.Text + "','" + textalbumtur.Text + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {

            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            try
            {

                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "Update prolab.album set albumidd=@albumidd , albumad = @albumad,sanatciad =@sanatciad,tarih=@tarih,tur=@tur where albumidd = @albumidd ;";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@albumidd", textAlbumid.Text);
                sqlCmd.Parameters.AddWithValue("@albumad", textAlbumad.Text);
                sqlCmd.Parameters.AddWithValue("@sanatciad", textSAnatciad.Text);
                sqlCmd.Parameters.AddWithValue("@tarih", textalbumtarih.Text);
                sqlCmd.Parameters.AddWithValue("@tur", textalbumtur.Text);




                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                uploadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}


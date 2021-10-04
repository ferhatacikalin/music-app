using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace arayuz
{
    public partial class AdminForm : Form
    {
        Bitmap bitmap;

        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlConnection sqlcon = new MySqlConnection();
        DataTable sqldt = new DataTable();
        MySqlDataReader sqlRd;
        String sqlQuery;
        MySqlDataAdapter Dta = new MySqlDataAdapter();


        public AdminForm()
        {
            InitializeComponent();
        }
        public void uploadData()//tabloyu yükleme
        {

            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "SELECT * FROM prolab.sarki; ";

            sqlRd = sqlCmd.ExecuteReader();
            sqldt.Load(sqlRd);
            sqlRd.Close();
            sqlcon.Close();
            dataGridView1.DataSource = sqldt;
        }
        private void albumEkleToolStripMenuItem1_Click(object sender, EventArgs e)  //albüm ekleye geçiş için menü bar
        {
            this.Hide();
            AlbumEkleme ae = new AlbumEkleme();
            ae.Show();
        }
        private void sanatciEkleToolStripMenuItem_Click(object sender, EventArgs e)  //sanatci ekleye geçiş için menü bar
        {
            this.Hide();
            SanatciEkleme se = new SanatciEkleme();
            se.Show();
        }
        private void button5_Click(object sender, EventArgs e)  //çıkış butonu
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
        private void button6_Click(object sender, EventArgs e)  //reset butonu
        {
            try
            {
                foreach (Control c in panel2.Controls)

                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();

                    }
                    textSarkiid.Text = ""; textSarkiAd.Text = ""; textSure.Text = ""; textTur.Text = ""; textAlbumAd.Text = ""; textSanatciid.Text = ""; textTarih.Text = ""; textDinlenmeSayisi.Text = "";


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)  //yazdır butonu 
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                e.Graphics.DrawImage(bitmap, 0, 0);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void AdminForm_Load(object sender, EventArgs e) // açıldığında tabloyu yükler
        {
            uploadData();
        }
        private void button1_Click(object sender, EventArgs e)   //ekle butonu
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            try
            {
                sqlcon.Open();
                sqlQuery = "insert into prolab.sarki ( sarkiid,sarkiad, tarih, sanatciid, albumad, tur, sure,dinlenmesayisi)" + "values('" + textSarkiid.Text + "','" + textSarkiAd.Text +
               "','" + textTarih.Text + "','" + textSanatciid.Text + "','" + textAlbumAd.Text + "','" + textTur.Text + "','" + textSure.Text + "','" + textDinlenmeSayisi.Text + "')";
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

        private void button3_Click(object sender, EventArgs e)   // güncelle butonu
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();
            try
            {

                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "Update prolab.sarki set sarkiid=@sarkiid , sarkiad = @sarkiad," +
                     " tarih =@tarih, " +
                    " sanatciid=@sanatciid , albumad=@albumad,tur=@tur,sure=@sure,dinlenmesayisi=@dinlenmesayisi " +
                    "where (sarkiid = @sarkiid)  and (sanatciid=@sanatciid);";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@sarkiid", textSarkiid.Text);
                sqlCmd.Parameters.AddWithValue("@sarkiad", textSarkiAd.Text);
                sqlCmd.Parameters.AddWithValue("@tarih", textTarih.Text);
                sqlCmd.Parameters.AddWithValue("@sanatciid", textSanatciid.Text);
                sqlCmd.Parameters.AddWithValue("@albumad", textAlbumAd.Text);
                sqlCmd.Parameters.AddWithValue("@tur", textTur.Text);
                sqlCmd.Parameters.AddWithValue("@sure", textSure.Text);
                sqlCmd.Parameters.AddWithValue("@dinlenmesayisi", textDinlenmeSayisi.Text);

                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                uploadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // tablonun göründüğü yer
        {
            try
            {

                textSarkiid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textSarkiAd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textTarih.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textSanatciid.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textAlbumAd.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textTur.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textSure.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textDinlenmeSayisi.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)//sil butonu
        {
            sqlcon = new MySqlConnection(Program.databasecon);
            sqlcon.Open();

            sqlCmd.Connection = sqlcon;
            sqlCmd.CommandText = "delete from prolab.sarki where sarkiid=@sarkiid";
            sqlCmd = new MySqlCommand(sqlQuery, sqlcon);
            sqlcon.Close();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

            }



        }
        private void Eklebutonu_Click(object sender, EventArgs e)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

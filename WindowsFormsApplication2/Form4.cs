using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        MySqlConnection ABC = new MySqlConnection("server=localhost; database=koperasi; uid=root; password=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader mdr;
        string s;
        DataTable dt = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new HomeAdmin();
            f.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Lengkapi Data Terlebih Dahulu");

            }
            else
            {
                ABC.Open();
                MySqlCommand cmd;
                cmd = ABC.CreateCommand();
                cmd.CommandText = "insert into daftarpengurus (IdPengurus,NamaPengurus,Alamat,Username,Password,Telp,directory) values (@idpengurus,@namapengurus,@alamat,@username,@password,@telp,@directory)";
                cmd.Parameters.AddWithValue("@idpengurus", textBox7.Text);
                cmd.Parameters.AddWithValue("@namapengurus", textBox1.Text);
                cmd.Parameters.AddWithValue("@alamat", textBox2.Text);
                cmd.Parameters.AddWithValue("@username", textBox3.Text);
                cmd.Parameters.AddWithValue("@password", textBox4.Text);
                cmd.Parameters.AddWithValue("@telp", textBox5.Text);
                cmd.Parameters.AddWithValue("@directory", textBox6.Text);
                MessageBox.Show("Anda Berhasil Mendaftarkan Admin Baru");
                cmd.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Clear();
                textBox7.Text = "";
                textBox6.Text = "";
                textBox8.Text = "";
                LoadData();
                ABC.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ABC.Open();
            LoadData();
            ABC.Close();
        }
        private void LoadData()
        {
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftarpengurus";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string sql = "update daftarpengurus SET IdPengurus='" + textBox7.Text + "',NamaPengurus='" + textBox1.Text + "',Alamat='" + textBox2.Text + "' ,Username ='" +textBox3.Text+ "',Password ='" + textBox4.Text + "',Telp = '" +textBox5.Text + "',directory = '" + textBox6.Text + "' where IdPengurus  ='" + textBox8.Text + "'";

            cmd = new MySqlCommand(sql, ABC);
            try
            {
                ABC.Open();
                adapter = new MySqlDataAdapter(cmd);

                adapter.UpdateCommand = ABC.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = ""; 
                    textBox7.Text = "";
                    textBox6.Text = "";
                    MessageBox.Show("Berhasil Mengubah Data Pengurus ! ");

                }
                ABC.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ABC.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM daftarpengurus where IdPengurus='" + textBox7.Text + "'";
            cmd = new MySqlCommand(sql, ABC);

            //open koneksi

            {

                ABC.Open();

                adapter = new MySqlDataAdapter(cmd);

                adapter.DeleteCommand = ABC.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                //konfirmasi hapus

                if (MessageBox.Show("Anda Yakin ?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = ""  ;
                        textBox7.Text = "";
                        MessageBox.Show("Berhasil Menghapus Data Pengurus!");
                    }
                }

                ABC.Close();


            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if(textBox8.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari");
            }
            try
            {
                ABC.Open();
                
                s= "select * from koperasi .daftarpengurus where IdPengurus=" + int.Parse(textBox8.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    textBox1.Text = mdr.GetString("NamaPengurus");
                    textBox2.Text = mdr.GetString("Alamat");
                    textBox3.Text = mdr.GetString("Username");
                    textBox4.Text = mdr.GetString("Password");
                    textBox5.Text = mdr.GetString("Telp");
                    textBox7.Text = mdr.GetString("IdPengurus");
                    pictureBox6.ImageLocation = mdr.GetString("directory");

                }
                else
                {
                    MessageBox.Show("Admin Tidak terdaftar");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ABC.Open();
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftarpengurus;";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            ABC.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png | All Files (*.*)|*.*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = dlg.FileName.ToString();
                string a = dlg.FileName.ToString();
                pictureBox6.ImageLocation = a;
            }
            
        }
    }
    }

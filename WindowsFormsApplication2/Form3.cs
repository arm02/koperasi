using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Design;
using WinFormCharpWebCam;
using WebCam_Capture;

namespace WindowsFormsApplication2
{
    public partial class HomeAdmin : Form
    {
        WebCam webcam;
        MySqlConnection ABC = new MySqlConnection("server=localhost; database=koperasi; uid=root; password=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader mdr;
        string s, a;
        DataTable dt = new DataTable();
        DataTable ds = new DataTable();
        public HomeAdmin()
        {
            InitializeComponent();
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            webcam = new WebCam();
            webcam.InitializeWebCam(ref ImgVideo);
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select tema from tema";
            cmd.ExecuteNonQuery();
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select tema from koperasi.tema";
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    comboBox1.Text = mdr.GetString("tema");

                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select label from label";
            cmd.ExecuteNonQuery();
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select label from koperasi.label";
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label6.Text = mdr.GetString("label");
                    label210.Text = mdr.GetString("label");

                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select logo from logo";
            cmd.ExecuteNonQuery();
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select logo from koperasi.logo";
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    pictureBox54.ImageLocation = mdr.GetString("logo");
                    pictureBox63.ImageLocation = mdr.GetString("logo");

                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select title from title";
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select title from koperasi.title";
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label213.Text = mdr.GetString("title");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select bunga from bunga";
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select bunga from koperasi.bunga";
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    textBox39.Text = mdr.GetString("bunga");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Keluar", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void LoadDataAdmin()
        {
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftarpengurus;";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            ABC.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panellogin.Width = 807;
            panelpengaturan.Width = 0;
            panelshowreport.Width = 0;
            panelsettingkoperasi.Width = 0;
            panelregisteranggota1.Width = 0;
            panelregistrasianggota2.Width = 0;
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox36.Clear();
            textBox38.Clear();
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox36.Clear();
            textBox38.Clear();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            panelregisteradmin.Width = 810;
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftarpengurus;";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            ABC.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panelsimpanann.Width = 810;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadDataAngggota()
        {
            ABC.Open();
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftaranggota;";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            ABC.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panelpenarikansimpanan.Width = 810;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelregisteranggota1.Width = 760;
            panellabeldaftaranggota.Width = 529;

            ABC.Open();
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftaranggota;";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            ABC.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panelpeminjamanpembayaran.Width = 810;
            panel18.Width = 300;
            panel19.Width = 300;
            panelpeminjaman.Width = 0;
            panelpembayaran.Width = 0;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panelshu.Width = 810;
            try
            {
                ABC.Open();
                a = "select * from koperasi .biaya where IdBiaya='001'";
                cmd = new MySqlCommand(a, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label181.Text = mdr.GetString("SimpananLain");
                    label180.Text = mdr.GetString("SimpananWajib");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panelregisteranggota1.Width = 0;
            panellabeldaftaranggota.Width = 0;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panelregistrasianggota2.Width = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelregistrasianggota2.Width = 762;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panelpenarikansimpanan.Width = 0;
            textBox7.Clear();
            textBox5.Clear();
            label42.Text = "-";
            label41.Text = "-";
            label40.Text = "-";
            label39.Text = "-";
            label36.Text = "-";

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            panelsimpananwajib.Width = 361;
            panelsetoranlain.Width = 0;
            panelsetoranpokok.Width = 0;
            panel27.Visible = true;
            panel28.Visible = false;
            panel29.Visible = false;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            panelsetoranpokok.BringToFront();
            panelsetoranpokok.Width = 362;
            panelsetoranlain.Width = 0;
            panelsimpananwajib.Width = 0;
            panel27.Visible = false;
            panel28.Visible = true;
            panel29.Visible = false;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
  

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            panelsetoranlain.Width = 362;
            panelsetoranpokok.Width = 0;
            panelsimpananwajib.Width = 0;
            panel27.Visible = false;
            panel28.Visible = false;
            panel29.Visible = true;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            panelsimpanann.Width = 0;
            label119.Text = "-";
            label118.Text = "-";
            label117.Text = "-";
            label116.Text = "-";
            label29.Text = "-";

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            panelpeminjaman.Width = 0;
            label160.Text = "-";
            label159.Text = ";";
            label158.Text = "-";
            label157.Text = ";";
            label154.Text = ";";
            textBox24.Clear();
            textBox25.Clear();

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            panelpeminjaman.Width = 765;
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            panelpembayaran.Width = 0;
            label139.Text = "-";
            label138.Text = "-";
            label137.Text = "-";
            label136.Text = "-";
            label133.Text = "-";
            textBox22.Clear();
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            panelpembayaran.Width = 761;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            panelpeminjamanpembayaran.Width = 0;
            panelpeminjaman.Width = 0;
            panelpembayaran.Width = 0;
            label160.Text = "-";
            label159.Text = "-";
            label158.Text = "-";
            label157.Text = "-";
            label154.Text = "-";
            textBox23.Clear();
            textBox24.Clear();
            textBox44.Clear();
            label139.Text = "-";
            label138.Text = "-";
            label137.Text = "-";
            label136.Text = "-";
            label133.Text = "-";
            textBox25.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelpeminjaman.Width = 760;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelpeminjaman.Width = 760;
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            panelshu.Width = 0;
        }

        private void label189_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png |BMP Files (*.bmp)|*.bmp|GIFs Files (*.gif)|*.gif| All Files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox27.Text = dlg.FileName.ToString();
                string a = dlg.FileName.ToString();
                pictureBox47.ImageLocation = a;
            }
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            if (textBox28.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                ABC.Open();
                cmd = new MySqlCommand("select * from daftarpengurus where " + comboBox3.Text + " LIKE '%" + textBox28.Text + "%'", ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    textBox33.Text = mdr.GetString("NamaPengurus");
                    textBox32.Text = mdr.GetString("Alamat");
                    textBox31.Text = mdr.GetString("Username");
                    textBox30.Text = mdr.GetString("Password");
                    textBox29.Text = mdr.GetString("Telp");
                    textBox34.Text = mdr.GetString("IdPengurus");
                    pictureBox47.ImageLocation = mdr.GetString("directory");

                }
                else
                {
                    MessageBox.Show("Admin Tidak terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }
        }

        private void panelregisteradmin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ABC.Open();
            LoadData();
            LoadDataAnggota();
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
        private void LoadDataAnggota()
        {
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftaranggota";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

        }
        private void LoadDataPinjaman()
        {
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from pinjaman";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

        }
        private void pictureBox50_Click(object sender, EventArgs e)
        {
            if (textBox33.Text == "" && textBox34.Text == "" && textBox29.Text == "" && textBox30.Text == "" && textBox31.Text == "" || textBox32.Text == "")
            {
                MessageBox.Show("Lengkapi Data Terlebih Dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ABC.Open();
                MySqlCommand cmd;
                cmd = ABC.CreateCommand();
                cmd.CommandText = "insert into daftarpengurus (NamaPengurus,Alamat,Username,Password,Telp,directory) values (@namapengurus,@alamat,@username,@password,@telp,@directory)";
               // cmd.Parameters.AddWithValue("@idpengurus", textBox34.Text);
                cmd.Parameters.AddWithValue("@namapengurus", textBox33.Text);
                cmd.Parameters.AddWithValue("@alamat", textBox32.Text);
                cmd.Parameters.AddWithValue("@username", textBox31.Text);
                cmd.Parameters.AddWithValue("@password", textBox30.Text);
                cmd.Parameters.AddWithValue("@telp", textBox29.Text);
                cmd.Parameters.AddWithValue("@directory", textBox27.Text);
                MessageBox.Show("Anda Berhasil Mendaftarkan Admin Baru ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.ExecuteNonQuery();
                textBox32.Clear();
                textBox31.Clear();
                textBox30.Clear();
                textBox29.Clear();
                textBox28.Clear();
                LoadData();
                ABC.Close();
                LoadDataAdmin();
                ABC.Close();
            }
            DataSet ds = new DataSet();
            ABC.Open();
            cmd = new MySqlCommand("select *from daftarpengurus where NamaPengurus LIKE '%" + textBox33.Text + "%'", ABC);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds.Clear();
            adapter.Fill(ds);
            ABC.Close();
            ReportDocument rd = new ReportDocument();
            crystalReportViewer11.RefreshReport();
            rd.Load("../../idcard.rpt");
            rd.Database.Tables[1].SetDataSource(ds.Tables[0]);
            crystalReportViewer11.ReportSource = rd;
            pictureBox73.Width = 51;
            crystalReportViewer11.Width = 810;
            textBox34.Clear();
            comboBox3.SendToBack();
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            if (textBox34.Text == "")
            {
                MessageBox.Show("Cari Data Yang Ingin Diubah Terlebih Dahulu ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd = new MySqlCommand("update daftarpengurus set IdPengurus='" + textBox34.Text + "',NamaPengurus ='" + textBox33.Text + "',Alamat ='" + textBox32.Text + "',Username ='" + textBox31.Text + "', Password ='" + textBox30.Text + "',Telp ='" + textBox29.Text + "'  where IdPengurus = '" + textBox34.Text + "'", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Anda Berhasil Mengubah Data Admin ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ABC.Close();
                LoadDataAdmin();
            }
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            if (textBox34.Text == "")
            {
                MessageBox.Show("Cari Data Yang Ingin Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = "DELETE FROM daftarpengurus where IdPengurus='" + textBox34.Text + "'";
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
                            textBox27.Text = "";
                            textBox29.Text = "";
                            textBox30.Text = "";
                            textBox31.Text = "";
                            textBox32.Clear();
                            textBox33.Text = "";
                            textBox34.Text = "";
                            MessageBox.Show("Anda Berhasil Menghapus Data Pengurus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    ABC.Close();
                    LoadDataAdmin();

                }
            }
        }

        private void pictureBox45_Click(object sender, EventArgs e)
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

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            panelregisteradmin.Width = 0;
            textBox34.Clear();
            textBox33.Clear();
            textBox32.Clear();
            textBox31.Clear();
            textBox30.Clear();
            textBox29.Clear();
            textBox28.Clear();
        }

        private void panelregisteranggota1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lengkapi Data Anggota Terlebih Dahulu");

            }
            else
            {
                ABC.Open();
                MySqlCommand cmd;
                cmd = ABC.CreateCommand();
                cmd.CommandText = "insert into daftaranggota (NamaAnggota,Alamat,NoTelp,Hari,SimpananPokok) values (@namaanggota,@alamat,@notelp,@hari,@simpananpokok)";
               
                cmd.Parameters.AddWithValue("@namaanggota", textBox2.Text);
                cmd.Parameters.AddWithValue("@notelp", textBox3.Text);
                cmd.Parameters.AddWithValue("@alamat", textBox4.Text);
                cmd.Parameters.AddWithValue("@hari", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@simpananpokok", textBox36.Text);
                MessageBox.Show("Anda Berhasil Mendaftarkan Anggota  Baru", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.ExecuteNonQuery();
             
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                ABC.Close();
                LoadDataAngggota();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox36.Clear();
                textBox38.Clear();
                panelregistrasianggota2.Width = 0;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Masukan Jumlah Penarikan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                double saldoawal, saldoakhir, saldokurang;
                String strsaldoakhir;

                saldoawal = Convert.ToDouble(label36.Text);
                saldokurang = Convert.ToDouble(textBox5.Text);
                saldoakhir = saldoawal - saldokurang;

                strsaldoakhir = saldoakhir.ToString();

                if (saldoawal < saldokurang)
                {
                    MessageBox.Show("Saldo Anda Tidak Mencukupi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    cmd = new MySqlCommand("update daftaranggota set SimpananPokok='" + strsaldoakhir + "' where IdAnggota ='" + label42.Text + "'", ABC);
                    ABC.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anda Berhasil Mengurangi Saldo", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ABC.Close();
                    try
                    {
                        ABC.Open();
                        a = "select * from koperasi .daftaranggota where IdAnggota=" + int.Parse(label42.Text);
                        cmd = new MySqlCommand(a, ABC);
                        mdr = cmd.ExecuteReader();
                        if (mdr.Read())
                        {
                            label36.Text = mdr.GetString("SimpananPokok");
                        }
                        else
                        {
                        }

                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                        ABC.Close();
                    }
                    cmd = new MySqlCommand("TRUNCATE saldotarik", ABC);
                    ABC.Open();
                    cmd.ExecuteNonQuery();
                    ABC.Close();
                    cmd = new MySqlCommand("insert into saldotarik values ('" + textBox5.Text + "')", ABC);
                    ABC.Open();
                    cmd.ExecuteNonQuery();
                    ABC.Close();
                    cmd = new MySqlCommand("insert into petugas values ('" + label13.Text + "')", ABC);
                    ABC.Open();
                    cmd.ExecuteNonQuery();
                    ABC.Close();
                    DataSet ds = new DataSet();
                    ABC.Open();
                    cmd = new MySqlCommand("select *from daftaranggota where IdAnggota LIKE '%" + label42.Text + "%'", ABC);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    ds.Clear();
                    adapter.Fill(ds);
                    ABC.Close();
                    ReportDocument rd = new ReportDocument();
                    crystalReportViewer3.RefreshReport();
                    rd.Load("../../CrystalReport3.rpt");
                    rd.Database.Tables[1].SetDataSource(ds.Tables[0]);
                    crystalReportViewer3.ReportSource = rd;
                    pictureBox71.Width = 51;
                    crystalReportViewer3.Width = 810;





                }
            }

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                ABC.Open();
                a = "select * from koperasi .daftaranggota where IdAnggota=" + int.Parse(textBox7.Text);
                cmd = new MySqlCommand(a, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label42.Text = mdr.GetString("IdAnggota");
                    label41.Text = mdr.GetString("NamaAnggota");
                    label40.Text = mdr.GetString("NoTelp");
                    label39.Text = mdr.GetString("Alamat");
                    label36.Text = mdr.GetString("SimpananPokok");
                }
                else
                {
                    MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (textBox17.Text == "")
            {
                MessageBox.Show("Masukan Jumlah Simpanan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox12.Text == "")
            {

                MessageBox.Show("Masukan Data Anggota Dan Isi Saldo Simpanan Pokok", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                double saldoawal, saldoakhir, saldotambah;
                String strsaldoakhir;

                saldoawal = Convert.ToDouble(label29.Text);
                saldotambah = Convert.ToDouble(textBox12.Text);

                saldoakhir = saldoawal + saldotambah;

                strsaldoakhir = saldoakhir.ToString();

                cmd = new MySqlCommand("update daftaranggota set SimpananPokok='" + strsaldoakhir + "' where IdAnggota ='" + label119.Text + "'", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Anda Berhasil Melakukan Simpanan Pokok", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ABC.Close();
                try
                {
                    ABC.Open();
                    a = "select * from koperasi .daftaranggota where IdAnggota=" + int.Parse(label119.Text);
                    cmd = new MySqlCommand(a, ABC);
                    mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label29.Text = mdr.GetString("SimpananPokok");
                    }
                    else
                    {
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ABC.Close();
                }
                panelsetoranpokok.SendToBack();
                cmd = new MySqlCommand("TRUNCATE saldosimpanpokok", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                cmd = new MySqlCommand("insert into petugas values ('" + label13.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                cmd = new MySqlCommand("insert into saldosimpanpokok values ('" + textBox12.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                DataSet ds = new DataSet();
                ABC.Open();
                cmd = new MySqlCommand("select *from daftaranggota where IdAnggota LIKE '%" + label119.Text + "%'", ABC);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                ABC.Close();
                ReportDocument rd = new ReportDocument();
                rd.Load("../../CrystalReport5.rpt");
                rd.Database.Tables[0].SetDataSource(ds.Tables[0]);
                crystalReportViewer5.ReportSource = rd;
                pictureBox72.Width = 51;
                crystalReportViewer5.RefreshReport();
                crystalReportViewer5.Width = 810;
            }

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            try
            {
                ABC.Open();
                a = "select * from koperasi .biaya where IdBiaya='001'";
                cmd = new MySqlCommand(a, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label200.Text = mdr.GetString("SimpananWajib");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }

            if (textBox16.Text == "")
            {
                MessageBox.Show("Masukan Data Anggota Dan Isi Saldo Simpanan Wajib", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox17.Text == "")
            {

                MessageBox.Show("Masukan Data Anggota Dan Isi Saldo Simpanan Wajib", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                double saldoawal, saldoakhir, saldotambah;
                String strsaldoakhir;

                saldoawal = Convert.ToDouble(label200.Text);
                saldotambah = Convert.ToDouble(textBox16.Text);

                saldoakhir = saldoawal + saldotambah;

                strsaldoakhir = saldoakhir.ToString();



                cmd = new MySqlCommand("update biaya set SimpananWajib='" + strsaldoakhir + "' where IdBiaya ='001'", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Anda Berhasil Melakukan Simpanan Wajib", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ABC.Close();
                cmd = new MySqlCommand("insert into petugas values ('" + label13.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                cmd = new MySqlCommand("TRUNCATE saldotarik", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                cmd = new MySqlCommand("insert into saldotarik values ('" + textBox16.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();

                DataSet ds = new DataSet();
                ABC.Open();
                cmd = new MySqlCommand("select *from daftaranggota where IdAnggota LIKE '%" + label119.Text + "%'", ABC);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                ABC.Close();
                ReportDocument rd = new ReportDocument();
                rd.Load("../../CrystalReport10.rpt");
                rd.Database.Tables[0].SetDataSource(ds.Tables[0]);
                crystalReportViewer10.ReportSource = rd;
                crystalReportViewer10.RefreshReport();
                crystalReportViewer10.Width = 810;
                pictureBox28.Width = 45;
                label118.Text = "-";
                label117.Text = "-";
                label116.Text = "-";
                textBox17.Clear();
                textBox16.Clear();
                label29.Text = "-";
                ABC.Close();
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                ABC.Open();
                a = "select * from koperasi .daftaranggota where IdAnggota=" + int.Parse(textBox11.Text);
                cmd = new MySqlCommand(a, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label62.Text = mdr.GetString("IdAnggota");
                    label61.Text = mdr.GetString("NamaAnggota");
                    label60.Text = mdr.GetString("NoTelp");
                    label59.Text = mdr.GetString("Alamat");
                }
                else
                {
                    MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            panellainlainnya.Width = 0;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (textBox19.Text == "")
            {
                MessageBox.Show("Masukan Jumlah Terlebih Dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    ABC.Open();
                    a = "select * from koperasi .biaya where IdBiaya='001'";
                    cmd = new MySqlCommand(a, ABC);
                    mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label201.Text = mdr.GetString("SimpananLain");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    mdr.Close();
                    ABC.Close();
                }

                cmd = new MySqlCommand("TRUNCATE setoranbulanke", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                cmd = new MySqlCommand("insert into setoranbulanke values ('" + dateTimePicker4.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                cmd = new MySqlCommand("insert into petugas values ('" + label13.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                cmd = new MySqlCommand("TRUNCATE saldotarik", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                cmd = new MySqlCommand("insert into saldotarik values ('" + textBox19.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();

                if (label119.Text == "-")
                {
                    MessageBox.Show("Masukan Data Anggota Dan Isi Saldo Simpanan Lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox18.Clear();
                    textBox15.Clear();
                    textBox19.Clear();
                }
                else
                {
                    double saldoawal, saldoakhir, saldotambah;
                    String strsaldoakhir;

                    saldoawal = Convert.ToDouble(label201.Text);
                    saldotambah = Convert.ToDouble(textBox19.Text);

                    saldoakhir = saldoawal + saldotambah;

                    strsaldoakhir = saldoakhir.ToString();

                    cmd = new MySqlCommand("update biaya set SimpananLain='" + strsaldoakhir + "' where IdBiaya ='001'", ABC);
                    ABC.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anda Berhasil Melakukan Simpanan Lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox18.Clear();
                    textBox15.Clear();
                    textBox19.Clear();
                    ABC.Close();
                }

                ABC.Open();
                DataSet ds = new DataSet();
                cmd = new MySqlCommand("select * from daftaranggota where IdAnggota  = '" + label119.Text + "'", ABC);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                ABC.Close();
                ReportDocument rd = new ReportDocument();
                rd.Load("../../CrystalReport7.rpt");
                crystalReportViewer6.ReportSource = rd;
                rd.Database.Tables[1].SetDataSource(ds.Tables[0]);
                
                crystalReportViewer6.RefreshReport();
                crystalReportViewer6.Width = 810;
                pictureBox97.Width = 45;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {


        }

        private void panelsetoranlain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            
        }

        private void label208_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            if (panelpengaturan.Width == 165)
            {
                panelpengaturan.Width = 0;
                panelshowreport.Width = 0;
                panelsettingkoperasi.Width = 0;

            }
            else
            {
                panelpengaturan.Width = 165;
            }
        }
        private bool login(string sUsername, string sPassword)
        {
            string SQL = "select Username,Password from daftarpengurus";
            ABC.Open();
            MySqlCommand cmd = new MySqlCommand(SQL, ABC);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((sUsername == reader.GetString(0)) && (sPassword == reader.GetString(1)))
                {
                    ABC.Close();
                    return true;
                }
            }
            ABC.Close();
            return false;
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {






        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {


        }

        private void textBox37_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox58_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Cari Data Yang Ingin Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd = new MySqlCommand("update daftaranggota set NamaAnggota =" + textBox2.Text + " ,Alamat=" + textBox4.Text + ",NoTelp=" + textBox3.Text + ",SimpananPokok=" + textBox36.Text + " where NamaAnggota =" + textBox2.Text + "", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Anda berhasil Mengubah Data ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ABC.Close();
                LoadDataAngggota();
            }
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Cari Data Yang Ingin Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    
                    ABC.Open();
                    cmd = new MySqlCommand("delete from daftaranggota where NamaAnggota = " + textBox2.Text + "", ABC);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anda berhasil Menghapus Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Clear();
                    textBox36.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    
                }
                catch (Exception ahok)
                {
                    MessageBox.Show(ahok.Message,"Gagal Menghapus");
                }
                finally
                {
                    ABC.Close();
                    LoadDataAngggota();
                }
                

                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Clear();
                textBox36.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            ABC.Open();
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftaranggota;";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            ABC.Close();
            

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Clear();
            textBox36.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            if (textBox38.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                try
                {
                    ABC.Open();
                    cmd = new MySqlCommand("select * from daftaranggota where " + comboBox2.Text + " LIKE '%" + textBox38.Text + "%'", ABC);
                    mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        
                        
                        textBox2.Text = mdr.GetString("NamaAnggota");
                        textBox3.Text = mdr.GetString("NoTelp");
                        textBox4.Text = mdr.GetString("Alamat");
                        textBox36.Text = mdr.GetString("SimpananPokok");
                        dateTimePicker1.Text = mdr.GetString("Hari");

                    }
                    else
                    {
                        MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    mdr.Close();
                    ABC.Close();
                }
            }
            
            
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            if (textBox26.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                ABC.Open();

                s = "select * from koperasi .daftaranggota where IdAnggota=" + int.Parse(textBox26.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label160.Text = mdr.GetString("IdAnggota");
                    label159.Text = mdr.GetString("NamaAnggota");
                    label158.Text = mdr.GetString("NoTelp");
                    label157.Text = mdr.GetString("Alamat");

                }
                else
                {
                    MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }
            try
            {
                ABC.Open();

                s = "select * from koperasi .pinjaman where IdPinjaman=" + int.Parse(textBox26.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label154.Text = mdr.GetString("JumlahPinjaman");

                }
                else
                {
                    label154.Text = "0";
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox24.Text == "" && textBox25.Text == "")
            {
                MessageBox.Show("Cari Anggota Yang Ingin Meminjam", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MySqlCommand cmd;
                ABC.Open();
                cmd = ABC.CreateCommand();
                cmd.CommandText = "insert into pinjaman (IdPinjaman,JumlahPinjaman,Hari,BatasBayar) values (@idpinjaman,@jumlahpinjaman,@hari,@batasbayar)";
                cmd.Parameters.AddWithValue("@idpinjaman", textBox24.Text);
                cmd.Parameters.AddWithValue("@jumlahpinjaman", textBox25.Text);
                cmd.Parameters.AddWithValue("@hari", dateTimePicker3.Text);
                cmd.Parameters.AddWithValue("@batasbayar", dateTimePicker2.Text);
                MessageBox.Show("Anda Telah Meminjam Uang");
                cmd.ExecuteNonQuery();
                textBox24.Clear();
                textBox25.Clear();
                dateTimePicker3.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                ABC.Close();
                textBox26.Clear();
                textBox24.Clear();
                textBox25.Clear();
                label159.Text = "-";
                label158.Text = "-";
                label157.Text = "-";
                label154.Text = "-";
                cmd = new MySqlCommand("insert into petugas values ('" + label13.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                DataSet ds = new DataSet();
                ABC.Open();
                cmd = new MySqlCommand("select * from daftaranggota where IdAnggota = '" + label160.Text + "'", ABC);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                ABC.Close();
                ReportDocument rd = new ReportDocument();
                rd.Load("../../CrystalReport8.rpt");
                rd.Database.Tables[0].SetDataSource(ds.Tables[0]);
                crystalReportViewer8.ReportSource = rd;
                //pictureBox76.Width = 51;
                crystalReportViewer8.RefreshReport();
                crystalReportViewer8.Width = 810;
                pictureBox75.Width = 38;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox23.Text == "")
            {
                MessageBox.Show("Cari Anggota Yang Ingin Membayar Pinjaman", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = "DELETE FROM pinjaman where IdPinjaman='" + textBox23.Text + "'";
                cmd = new MySqlCommand(sql, ABC);
                {
                    ABC.Open();
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.DeleteCommand = ABC.CreateCommand();
                    adp.DeleteCommand.CommandText = sql;

                    if (MessageBox.Show("Anda Yakin ?", "Bayar Pinjaman", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Terima Kasih Telah Membayar Pinjaman", "Bayar Pinjaman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ABC.Close();
                        }
                    }
                    textBox23.Clear();
                    textBox24.Clear();
                    textBox44.Clear();
                    label138.Text = "-";
                    label137.Text = "-";
                    label136.Text = "-";
                    label133.Text = "-";
                }
                cmd = new MySqlCommand("insert into petugas values ('" + label13.Text + "')", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                DataSet ds = new DataSet();
                ABC.Open();
                cmd = new MySqlCommand("select *from daftaranggota where IdPinjaman LIKE '%" + label139.Text + "%'", ABC);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                ABC.Close();
                ReportDocument rd = new ReportDocument();
                rd.Load("../../CrystalReport9.rpt");
                rd.Database.Tables[0].SetDataSource(ds.Tables[0]);
                crystalReportViewer9.ReportSource = rd;
                //pictureBox76.Width = 51;
                crystalReportViewer9.RefreshReport();
                crystalReportViewer9.Width = 810;
                pictureBox96.Width = 38;
                label139.Text = "-";
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            if (textBox23.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                ABC.Open();

                s = "select * from koperasi .daftaranggota where IdAnggota=" + int.Parse(textBox23.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label139.Text = mdr.GetString("IdAnggota");
                    label138.Text = mdr.GetString("NamaAnggota");
                    label137.Text = mdr.GetString("NoTelp");
                    label136.Text = mdr.GetString("Alamat");

                }
                else
                {
                    MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }
            try
            {
                ABC.Open();

                s = "select * from koperasi .pinjaman where IdPinjaman=" + int.Parse(textBox23.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label133.Text = mdr.GetString("JumlahPinjaman");

                }
                else
                {
                    label133.Text = "0";
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ABC.Open();
                a = "select * from koperasi .biaya where IdBiaya='001'";
                cmd = new MySqlCommand(a, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label129.Text = mdr.GetString("SimpananWajib");
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }
            if (label133.Text == "-")
            {
                MessageBox.Show("Cari Anggota Yang Ingin Membayar Pinjaman", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double saldoawal, saldoakhir, saldobunga;
                String strsaldoakhir;

                saldoawal = Convert.ToDouble(label133.Text);
                saldobunga = Convert.ToDouble(textBox39.Text);

                saldoakhir = saldoawal * (saldobunga / 100);

                strsaldoakhir = saldoakhir.ToString();
                textBox22.Text = strsaldoakhir;

                cmd = new MySqlCommand("update biaya set SimpananWajib='" + textBox22.Text + "' where IdBiaya ='001'", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery(); ;
                ABC.Close();

                double saldo, saldo1, saldo3;
                string saldo4;

                saldo = Convert.ToDouble(label133.Text);
                saldo3 = Convert.ToDouble(textBox22.Text);

                saldo1 = saldo + saldo3;

                saldo4 = saldo1.ToString();
                textBox44.Text = saldo4;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label6.Text = textBox21.Text;
            label210.Text = textBox21.Text;
            cmd = new MySqlCommand("truncate label", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery(); ;
            ABC.Close();
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "insert into label (label) values (@label)";
            cmd.Parameters.AddWithValue("@label", textBox21.Text);
            MessageBox.Show("Succes");
            cmd.ExecuteNonQuery();
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select * from koperasi .label where label=" + int.Parse(textBox21.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label6.Text = mdr.GetString("label");
                    label210.Text = mdr.GetString("label");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label213.Text = textBox40.Text;
            cmd = new MySqlCommand("truncate title", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery(); ;
            ABC.Close();
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "insert into title (title) values (@title)";
            cmd.Parameters.AddWithValue("@title", textBox40.Text);
            MessageBox.Show("Succes");
            cmd.ExecuteNonQuery();
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select * from koperasi .title where title=" + int.Parse(textBox40.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label213.Text = mdr.GetString("label");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
        }

        private void label206_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            panelsettingkoperasi.Width = 0;
        }

        private void label207_Click(object sender, EventArgs e)
        {
            if (panelsettingkoperasi.Width == 301)
            {
                panelsettingkoperasi.Width = 0;
                panelshowreport.Width = 0;
            }
            else
            {
                panelsettingkoperasi.Width = 301;
                panelshowreport.Width = 0;
            }
        }

        private void label205_Click(object sender, EventArgs e)
        {
            if (panelsettingkoperasi.Width == 301)
            {
                panelsettingkoperasi.Width = 0;
                panelshowreport.Width = 0;
            }
            else
            {
                panelsettingkoperasi.Width = 301;
                panelshowreport.Width = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox39.Text = textBox41.Text;
            cmd = new MySqlCommand("truncate bunga", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery(); ;
            ABC.Close();
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "insert into bunga (bunga) values (@bunga)";
            cmd.Parameters.AddWithValue("@bunga", textBox41.Text);
            MessageBox.Show("Succes");
            cmd.ExecuteNonQuery();
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select * from koperasi .bunga where bunga=" + int.Parse(textBox41.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    textBox39.Text = mdr.GetString("bunga");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox43.Text == "")
            {
                MessageBox.Show("Masukan Jumlah Anggota Terlebih Dahulu");
            }
            else
            {
                double saldoawal, saldoakhir, saldokurang;
                String strsaldoakhir;

                saldoawal = Convert.ToDouble(label180.Text);
                saldokurang = Convert.ToDouble(textBox43.Text);
                saldoakhir = saldoawal / saldokurang;

                strsaldoakhir = saldoakhir.ToString();
                textBox42.Text = strsaldoakhir;
                cmd = new MySqlCommand("update biaya set SimpananWajib='" + label221.Text + "' where IdBiaya ='001'", ABC);
                ABC.Open();
                cmd.ExecuteNonQuery();
                ABC.Close();
                label180.Text = label221.Text;
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {


        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Width = 0;
            pictureBox62.Width = 0;
            panelpengaturan.Width = 165;
            panelshowreport.Width = 200;
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label203_Click(object sender, EventArgs e)
        {
            if (panelshowreport.Width == 193)
            {
                panelshowreport.Width = 0;
            }
            else
            {
                panelshowreport.Width = 193;
            }
            panelsettingkoperasi.Width = 0;
        }

        private void label29_Click(object sender, EventArgs e)
        {
            
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void panelpembayaran_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelsettingkoperasi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("truncate logo", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery(); ;
            ABC.Close();
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "insert into logo (logo) values (@logo)";
            cmd.Parameters.AddWithValue("@logo", textBox45.Text);
            MessageBox.Show("Succes And Please Restart This Application");
            cmd.ExecuteNonQuery();
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select * from koperasi .logo where logo=" + int.Parse(textBox45.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    pictureBox63.ImageLocation = mdr.GetString("logo");
                    pictureBox54.ImageLocation = mdr.GetString("logo");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png |BMP Files (*.bmp)|*.bmp|GIFs Files (*.gif)|*.gif| All Files (*.*)|*.*";

            if (dl.ShowDialog() == DialogResult.OK)
            {
                textBox45.Text = dl.FileName.ToString();
                string a = dl.FileName.ToString();
                pictureBox63.ImageLocation = a;
            }
        }

        private void label225_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            crystalReportViewer2.Width = 0;
            pictureBox64.Width = 0;
            panelpengaturan.Width = 165;
            panelshowreport.Width = 200;
        }

        private void label204_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void label113_Click(object sender, EventArgs e)
        {
            paneltakeapicture.Width = 810;
            webcam.Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ImgCapture.Image = ImgVideo.Image;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label226_Click(object sender, EventArgs e)
        {
            panelinfouser.Width = 810;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            paneltakeapicture.Width = 0;
            panelregisteradmin.Width = 810;
            webcam.Stop();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Helper.SaveImageCapture(ImgCapture.Image);
        }

        private void panelpeminjaman_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            String strsaldoakhir;

            a = Convert.ToDouble(textBox18.Text);
            b = Convert.ToDouble(textBox15.Text);
            c = Convert.ToDouble(textBox47.Text);
            d = a + b + c;

            strsaldoakhir = d.ToString();
            strsaldoakhir = textBox19.Text;
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            textBox36.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            /* if () */
            {
                textBox34.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox33.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox32.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox31.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox30.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox29.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                pictureBox47.ImageLocation = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                pictureBox47.Show();
            }
            /*    else
                 {
                     textBox34
                 } */
        }

        private void CrystalReport61_InitReport(object sender, EventArgs e)
        {

        }

        private void pictureBox66_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer4.Width = 0;
            pictureBox66.Width = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ABC.Open();
            cmd = new MySqlCommand("select *from biaya", ABC);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds.Clear();
            adapter.Fill(ds);
            ABC.Close();
            ReportDocument rd = new ReportDocument();
            rd.Load("../../CrystalReport6.rpt");
            rd.Database.Tables[1].SetDataSource(ds.Tables[0]);
            crystalReportViewer4.ReportSource = rd;
            crystalReportViewer4.RefreshReport();
            crystalReportViewer4.Width = 810;
            pictureBox94.Width = 66;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label181.Text = "0";
            cmd = new MySqlCommand("update biaya set SimpananLain='" + label181.Text + "' where IdBiaya ='001'", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery();
            ABC.Close();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("truncate tema", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery(); ;
            ABC.Close();
            ABC.Open();
            cmd = ABC.CreateCommand();
            cmd.CommandText = "insert into tema (tema) values (@tema)";
            cmd.Parameters.AddWithValue("@tema", comboBox1.Text);
            MessageBox.Show("Succes");
            cmd.ExecuteNonQuery();
            ABC.Close();
            try
            {
                ABC.Open();
                s = "select * from koperasi .tema where tema=" + int.Parse(comboBox1.Text);
                cmd = new MySqlCommand(s, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    comboBox1.Text = mdr.GetString("tema");
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                ABC.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            if (comboBox1.Text == "HotPink")
            {
                panel20.BackColor = Color.HotPink;
                label6.BackColor = Color.HotPink;
                label7.BackColor = Color.HotPink;
                label225.BackColor = Color.HotPink;
                panel2.BackColor = Color.HotPink;
                panel3.BackColor = Color.HotPink;
                panel4.BackColor = Color.HotPink;
                panel5.BackColor = Color.HotPink;
                panel6.BackColor = Color.HotPink;
                panel7.BackColor = Color.HotPink;
                panel21.BackColor = Color.HotPink;
                label2.BackColor = Color.HotPink;
                panel19.BackColor = Color.HotPink;
                panel18.BackColor = Color.HotPink;
                button3.BackColor = Color.HotPink;
                button4.BackColor = Color.HotPink;
                button9.BackColor = Color.HotPink;
                button5.BackColor = Color.HotPink;
                button8.BackColor = Color.HotPink;
                button6.BackColor = Color.HotPink;
                pictureBox40.BackColor = Color.HotPink;
                pictureBox41.BackColor = Color.HotPink;
                panel14.BackColor = Color.HotPink;
                panel15.BackColor = Color.HotPink;
                label189.BackColor = Color.HotPink;
                label113.BackColor = Color.HotPink;
                label171.BackColor = Color.HotPink;
                label172.BackColor = Color.HotPink;
                button10.BackColor = Color.HotPink;
                button11.BackColor = Color.HotPink;
                button12.BackColor = Color.HotPink;
                button14.BackColor = Color.HotPink;
                button13.BackColor = Color.HotPink;
                button15.BackColor = Color.HotPink;
                button1.BackColor = Color.HotPink;
                panel23.BackColor = Color.HotPink;
                label245.BackColor = Color.HotPink;
                label244.BackColor = Color.HotPink;
                label243.BackColor = Color.HotPink;
                label242.BackColor = Color.HotPink;
                label241.BackColor = Color.HotPink;
                label240.BackColor = Color.HotPink;
                label228.BackColor = Color.HotPink;
                label239.BackColor = Color.HotPink;
                label238.BackColor = Color.HotPink;
                label237.BackColor = Color.HotPink;
                label236.BackColor = Color.HotPink;
                label235.BackColor = Color.HotPink;
                label234.BackColor = Color.HotPink;
                label229.BackColor = Color.HotPink;
                label230.BackColor = Color.HotPink;
                label231.BackColor = Color.HotPink;
                label232.BackColor = Color.HotPink;
                label233.BackColor = Color.HotPink;
                plogin.BackColor = Color.HotPink;
                label212.BackColor = Color.HotPink;
                label211.BackColor = Color.HotPink;
                checkBox3.BackColor = Color.HotPink;
                pictureBox57.BackColor = Color.HotPink;
                pictureBox79.BackColor = Color.HotPink;
                pictureBox78.BackColor = Color.HotPink;
                label252.BackColor = Color.HotPink;
                button16.BackColor = Color.HotPink;
                button17.BackColor = Color.HotPink;
                button18.BackColor = Color.HotPink;
                button19.BackColor = Color.HotPink;

                panel1.BackColor = Color.HotPink;
                panel16.BackColor = Color.HotPink;
                panel25.BackColor = Color.HotPink;
                panel26.BackColor = Color.HotPink;
                panel27.BackColor = Color.HotPink;
                panel28.BackColor = Color.HotPink;
                panel29.BackColor = Color.HotPink;
            }
            else if (comboBox1.Text == "LightBlue")
            {
                panel20.BackColor = Color.LightBlue;
                label6.BackColor = Color.LightBlue;
                label7.BackColor = Color.LightBlue;
                label225.BackColor = Color.LightBlue;
                panel2.BackColor = Color.LightBlue;
                panel3.BackColor = Color.LightBlue;
                panel4.BackColor = Color.LightBlue;
                panel5.BackColor = Color.LightBlue;
                panel6.BackColor = Color.LightBlue;
                panel7.BackColor = Color.LightBlue;
                panel21.BackColor = Color.LightBlue;
                label2.BackColor = Color.LightBlue;
                panel19.BackColor = Color.LightBlue;
                panel18.BackColor = Color.LightBlue;
                button3.BackColor = Color.LightBlue;
                button4.BackColor = Color.LightBlue;
                button9.BackColor = Color.LightBlue;
                button5.BackColor = Color.LightBlue;
                button8.BackColor = Color.LightBlue;
                button6.BackColor = Color.LightBlue;
                pictureBox40.BackColor = Color.LightBlue;
                pictureBox41.BackColor = Color.LightBlue;
                panel14.BackColor = Color.LightBlue;
                panel15.BackColor = Color.LightBlue;
                label189.BackColor = Color.LightBlue;
                label113.BackColor = Color.LightBlue;
                label171.BackColor = Color.LightBlue;
                label172.BackColor = Color.LightBlue;
                button10.BackColor = Color.LightBlue;
                button11.BackColor = Color.LightBlue;
                button12.BackColor = Color.LightBlue;
                button14.BackColor = Color.LightBlue;
                button13.BackColor = Color.LightBlue;
                button15.BackColor = Color.LightBlue;
                button1.BackColor = Color.LightBlue;
                panel23.BackColor = Color.LightBlue;
                label245.BackColor = Color.LightBlue;
                label244.BackColor = Color.LightBlue;
                label243.BackColor = Color.LightBlue;
                label242.BackColor = Color.LightBlue;
                label241.BackColor = Color.LightBlue;
                label240.BackColor = Color.LightBlue;
                label228.BackColor = Color.LightBlue;
                label239.BackColor = Color.LightBlue;
                label238.BackColor = Color.LightBlue;
                label237.BackColor = Color.LightBlue;
                label236.BackColor = Color.LightBlue;
                label235.BackColor = Color.LightBlue;
                label234.BackColor = Color.LightBlue;
                label229.BackColor = Color.LightBlue;
                label230.BackColor = Color.LightBlue;
                label231.BackColor = Color.LightBlue;
                label232.BackColor = Color.LightBlue;
                label233.BackColor = Color.LightBlue;
                plogin.BackColor = Color.LightBlue;
                label212.BackColor = Color.LightBlue;
                label211.BackColor = Color.LightBlue;
                checkBox3.BackColor = Color.LightBlue;
                pictureBox57.BackColor = Color.LightBlue;
                pictureBox79.BackColor = Color.LightBlue;
                pictureBox78.BackColor = Color.LightBlue;
                label252.BackColor = Color.LightBlue;
                button16.BackColor = Color.LightBlue;
                button17.BackColor = Color.LightBlue;
                button18.BackColor = Color.LightBlue;
                button19.BackColor = Color.LightBlue;

                panel1.BackColor = Color.LightBlue;
                panel16.BackColor = Color.LightBlue;
                panel25.BackColor = Color.LightBlue;
                panel26.BackColor = Color.LightBlue;
                panel27.BackColor = Color.LightBlue;
                panel28.BackColor = Color.LightBlue;
                panel29.BackColor = Color.LightBlue;
            }
            else if (comboBox1.Text == "Blue")
            {
                panel20.BackColor = Color.Blue;
                label6.BackColor = Color.Blue;
                label7.BackColor = Color.Blue;
                label225.BackColor = Color.Blue;
                panel2.BackColor = Color.Blue;
                panel3.BackColor = Color.Blue;
                panel4.BackColor = Color.Blue;
                panel5.BackColor = Color.Blue;
                panel6.BackColor = Color.Blue;
                panel7.BackColor = Color.Blue;
                panel21.BackColor = Color.Blue;
                label2.BackColor = Color.Blue;
                panel19.BackColor = Color.Blue;
                panel18.BackColor = Color.Blue;
                button3.BackColor = Color.Blue;
                button4.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                pictureBox40.BackColor = Color.Blue;
                pictureBox41.BackColor = Color.Blue;
                panel14.BackColor = Color.Blue;
                panel15.BackColor = Color.Blue;
                label189.BackColor = Color.Blue;
                label113.BackColor = Color.Blue;
                label171.BackColor = Color.Blue;
                label172.BackColor = Color.Blue;
                button10.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;
                button14.BackColor = Color.Blue;
                button13.BackColor = Color.Blue;
                button15.BackColor = Color.Blue;
                button1.BackColor = Color.Blue;
                panel23.BackColor = Color.Blue;
                label245.BackColor = Color.Blue;
                label244.BackColor = Color.Blue;
                label243.BackColor = Color.Blue;
                label242.BackColor = Color.Blue;
                label241.BackColor = Color.Blue;
                label240.BackColor = Color.Blue;
                label228.BackColor = Color.Blue;
                label239.BackColor = Color.Blue;
                label238.BackColor = Color.Blue;
                label237.BackColor = Color.Blue;
                label236.BackColor = Color.Blue;
                label235.BackColor = Color.Blue;
                label234.BackColor = Color.Blue;
                label229.BackColor = Color.Blue;
                label230.BackColor = Color.Blue;
                label231.BackColor = Color.Blue;
                label232.BackColor = Color.Blue;
                label233.BackColor = Color.Blue;
                plogin.BackColor = Color.Blue;
                label212.BackColor = Color.Blue;
                label211.BackColor = Color.Blue;
                checkBox3.BackColor = Color.Blue;
                pictureBox57.BackColor = Color.Blue;
                pictureBox79.BackColor = Color.Blue;
                pictureBox78.BackColor = Color.Blue;
                label252.BackColor = Color.Blue;
                button16.BackColor = Color.Blue;
                button17.BackColor = Color.Blue;
                button18.BackColor = Color.Blue;
                button19.BackColor = Color.Blue;
                panel1.BackColor = Color.Blue;
                panel16.BackColor = Color.Blue;
                panel25.BackColor = Color.Blue;
                panel26.BackColor = Color.Blue;
                panel27.BackColor = Color.Blue;
                panel28.BackColor = Color.Blue;
                panel29.BackColor = Color.Blue;

            }
            else if (comboBox1.Text == "Red")
            {
                panel20.BackColor = Color.Red;
                label6.BackColor = Color.Red;
                label7.BackColor = Color.Red;
                label225.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
                panel3.BackColor = Color.Red;
                panel4.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
                panel6.BackColor = Color.Red;
                panel7.BackColor = Color.Red;
                panel21.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                panel19.BackColor = Color.Red;
                panel18.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                pictureBox40.BackColor = Color.Red;
                pictureBox41.BackColor = Color.Red;
                panel14.BackColor = Color.Red;
                panel15.BackColor = Color.Red;
                label189.BackColor = Color.Red;
                label113.BackColor = Color.Red;
                label171.BackColor = Color.Red;
                label172.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                button12.BackColor = Color.Red;
                button14.BackColor = Color.Red;
                button13.BackColor = Color.Red;
                button15.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                panel23.BackColor = Color.Red;
                label245.BackColor = Color.Red;
                label244.BackColor = Color.Red;
                label243.BackColor = Color.Red;
                label242.BackColor = Color.Red;
                label241.BackColor = Color.Red;
                label240.BackColor = Color.Red;
                label228.BackColor = Color.Red;
                label239.BackColor = Color.Red;
                label238.BackColor = Color.Red;
                label237.BackColor = Color.Red;
                label236.BackColor = Color.Red;
                label235.BackColor = Color.Red;
                label234.BackColor = Color.Red;
                label229.BackColor = Color.Red;
                label230.BackColor = Color.Red;
                label231.BackColor = Color.Red;
                label232.BackColor = Color.Red;
                label233.BackColor = Color.Red;
                plogin.BackColor = Color.Red;
                label212.BackColor = Color.Red;
                label211.BackColor = Color.Red;
                checkBox3.BackColor = Color.Red;
                pictureBox57.BackColor = Color.Red;
                pictureBox79.BackColor = Color.Red;
                pictureBox78.BackColor = Color.Red;
                label252.BackColor = Color.Red;
                button16.BackColor = Color.Red;
                button17.BackColor = Color.Red;
                button18.BackColor = Color.Red;
                button19.BackColor = Color.Red;
                panel1.BackColor = Color.Red;
                panel16.BackColor = Color.Red;
                panel25.BackColor = Color.Red;
                panel26.BackColor = Color.Red;
                panel27.BackColor = Color.Red;
                panel28.BackColor = Color.Red;
                panel29.BackColor = Color.Red;
            }

            else if (comboBox1.Text == "Lavender")
            {
                panel20.BackColor = Color.Lavender;
                label6.BackColor = Color.Lavender;
                label7.BackColor = Color.Lavender;
                label225.BackColor = Color.Lavender;
                panel2.BackColor = Color.Lavender;
                panel3.BackColor = Color.Lavender;
                panel4.BackColor = Color.Lavender;
                panel5.BackColor = Color.Lavender;
                panel6.BackColor = Color.Lavender;
                panel7.BackColor = Color.Lavender;
                panel21.BackColor = Color.Lavender;
                label2.BackColor = Color.Lavender;
                panel19.BackColor = Color.Lavender;
                panel18.BackColor = Color.Lavender;
                button3.BackColor = Color.Lavender;
                button4.BackColor = Color.Lavender;
                button9.BackColor = Color.Lavender;
                button5.BackColor = Color.Lavender;
                button8.BackColor = Color.Lavender;
                button6.BackColor = Color.Lavender;
                pictureBox40.BackColor = Color.Lavender;
                pictureBox41.BackColor = Color.Lavender;
                panel14.BackColor = Color.Lavender;
                panel15.BackColor = Color.Lavender;
                label189.BackColor = Color.Lavender;
                label113.BackColor = Color.Lavender;
                label171.BackColor = Color.Lavender;
                label172.BackColor = Color.Lavender;
                button10.BackColor = Color.Lavender;
                button11.BackColor = Color.Lavender;
                button12.BackColor = Color.Lavender;
                button14.BackColor = Color.Lavender;
                button13.BackColor = Color.Lavender;
                button15.BackColor = Color.Lavender;
                button1.BackColor = Color.Lavender;
                panel23.BackColor = Color.Lavender;
                label245.BackColor = Color.Lavender;
                label244.BackColor = Color.Lavender;
                label243.BackColor = Color.Lavender;
                label242.BackColor = Color.Lavender;
                label241.BackColor = Color.Lavender;
                label240.BackColor = Color.Lavender;
                label228.BackColor = Color.Lavender;
                label239.BackColor = Color.Lavender;
                label238.BackColor = Color.Lavender;
                label237.BackColor = Color.Lavender;
                label236.BackColor = Color.Lavender;
                label235.BackColor = Color.Lavender;
                label234.BackColor = Color.Lavender;
                label229.BackColor = Color.Lavender;
                label230.BackColor = Color.Lavender;
                label231.BackColor = Color.Lavender;
                label232.BackColor = Color.Lavender;
                label233.BackColor = Color.Lavender;
                plogin.BackColor = Color.Lavender;
                label212.BackColor = Color.Lavender;
                label211.BackColor = Color.Lavender;
                checkBox3.BackColor = Color.Lavender;
                pictureBox57.BackColor = Color.Lavender;
                pictureBox79.BackColor = Color.Lavender;
                pictureBox78.BackColor = Color.Lavender;
                label252.BackColor = Color.Lavender;
                button16.BackColor = Color.Lavender;
                button17.BackColor = Color.Lavender;
                button18.BackColor = Color.Lavender;
                button19.BackColor = Color.Lavender;
                panel1.BackColor = Color.Lavender;
                panel16.BackColor = Color.Lavender;
                panel25.BackColor = Color.Lavender;
                panel26.BackColor = Color.Lavender;
                panel27.BackColor = Color.Lavender;
                panel28.BackColor = Color.Lavender;
                panel29.BackColor = Color.Lavender;

            }
            else if (comboBox1.Text == "GreenYellow")
            {
                panel20.BackColor = Color.GreenYellow;
                label6.BackColor = Color.GreenYellow;
                label7.BackColor = Color.GreenYellow;
                label225.BackColor = Color.GreenYellow;
                panel2.BackColor = Color.GreenYellow;
                panel3.BackColor = Color.GreenYellow;
                panel4.BackColor = Color.GreenYellow;
                panel5.BackColor = Color.GreenYellow;
                panel6.BackColor = Color.GreenYellow;
                panel7.BackColor = Color.GreenYellow;
                panel21.BackColor = Color.GreenYellow;
                label2.BackColor = Color.GreenYellow;
                panel19.BackColor = Color.GreenYellow;
                panel18.BackColor = Color.GreenYellow;
                button3.BackColor = Color.GreenYellow;
                button4.BackColor = Color.GreenYellow;
                button9.BackColor = Color.GreenYellow;
                button5.BackColor = Color.GreenYellow;
                button8.BackColor = Color.GreenYellow;
                button6.BackColor = Color.GreenYellow;
                pictureBox40.BackColor = Color.GreenYellow;
                pictureBox41.BackColor = Color.GreenYellow;
                panel14.BackColor = Color.GreenYellow;
                panel15.BackColor = Color.GreenYellow;
                label189.BackColor = Color.GreenYellow;
                label113.BackColor = Color.GreenYellow;
                label171.BackColor = Color.GreenYellow;
                label172.BackColor = Color.GreenYellow;
                button10.BackColor = Color.GreenYellow;
                button11.BackColor = Color.GreenYellow;
                button12.BackColor = Color.GreenYellow;
                button14.BackColor = Color.GreenYellow;
                button13.BackColor = Color.GreenYellow;
                button15.BackColor = Color.GreenYellow;
                button1.BackColor = Color.GreenYellow;
                panel23.BackColor = Color.GreenYellow;
                label245.BackColor = Color.GreenYellow;
                label244.BackColor = Color.GreenYellow;
                label243.BackColor = Color.GreenYellow;
                label242.BackColor = Color.GreenYellow;
                label241.BackColor = Color.GreenYellow;
                label240.BackColor = Color.GreenYellow;
                label228.BackColor = Color.GreenYellow;
                label239.BackColor = Color.GreenYellow;
                label238.BackColor = Color.GreenYellow;
                label237.BackColor = Color.GreenYellow;
                label236.BackColor = Color.GreenYellow;
                label235.BackColor = Color.GreenYellow;
                label234.BackColor = Color.GreenYellow;
                label229.BackColor = Color.GreenYellow;
                label230.BackColor = Color.GreenYellow;
                label231.BackColor = Color.GreenYellow;
                label232.BackColor = Color.GreenYellow;
                label233.BackColor = Color.GreenYellow;
                plogin.BackColor = Color.GreenYellow;
                label212.BackColor = Color.GreenYellow;
                label211.BackColor = Color.GreenYellow;
                checkBox3.BackColor = Color.GreenYellow;
                pictureBox57.BackColor = Color.GreenYellow;
                pictureBox79.BackColor = Color.GreenYellow;
                pictureBox78.BackColor = Color.GreenYellow;
                label252.BackColor = Color.GreenYellow;
                button16.BackColor = Color.GreenYellow;
                button17.BackColor = Color.GreenYellow;
                button18.BackColor = Color.GreenYellow;
                button19.BackColor = Color.GreenYellow;
                panel1.BackColor = Color.GreenYellow;
                panel16.BackColor = Color.GreenYellow;
                panel25.BackColor = Color.GreenYellow;
                panel26.BackColor = Color.GreenYellow;
                panel27.BackColor = Color.GreenYellow;
                panel28.BackColor = Color.GreenYellow;
                panel29.BackColor = Color.GreenYellow;

            }
            else if (comboBox1.Text == "Gold")
            {
                panel20.BackColor = Color.Gold;
                label6.BackColor = Color.Gold;
                label7.BackColor = Color.Gold;
                label225.BackColor = Color.Gold;
                panel2.BackColor = Color.Gold;
                panel3.BackColor = Color.Gold;
                panel4.BackColor = Color.Gold;
                panel5.BackColor = Color.Gold;
                panel6.BackColor = Color.Gold;
                panel7.BackColor = Color.Gold;
                panel21.BackColor = Color.Gold;
                label2.BackColor = Color.Gold;
                panel19.BackColor = Color.Gold;
                panel18.BackColor = Color.Gold;
                button3.BackColor = Color.Gold;
                button4.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button8.BackColor = Color.Gold;
                button6.BackColor = Color.Gold;
                pictureBox40.BackColor = Color.Gold;
                pictureBox41.BackColor = Color.Gold;
                panel14.BackColor = Color.Gold;
                panel15.BackColor = Color.Gold;
                label189.BackColor = Color.Gold;
                label113.BackColor = Color.Gold;
                label171.BackColor = Color.Gold;
                label172.BackColor = Color.Gold;
                button10.BackColor = Color.Gold;
                button11.BackColor = Color.Gold;
                button12.BackColor = Color.Gold;
                button14.BackColor = Color.Gold;
                button13.BackColor = Color.Gold;
                button15.BackColor = Color.Gold;
                button1.BackColor = Color.Gold;
                panel23.BackColor = Color.Gold;
                label245.BackColor = Color.Gold;
                label244.BackColor = Color.Gold;
                label243.BackColor = Color.Gold;
                label242.BackColor = Color.Gold;
                label241.BackColor = Color.Gold;
                label240.BackColor = Color.Gold;
                label228.BackColor = Color.Gold;
                label239.BackColor = Color.Gold;
                label238.BackColor = Color.Gold;
                label237.BackColor = Color.Gold;
                label236.BackColor = Color.Gold;
                label235.BackColor = Color.Gold;
                label234.BackColor = Color.Gold;
                label229.BackColor = Color.Gold;
                label230.BackColor = Color.Gold;
                label231.BackColor = Color.Gold;
                label232.BackColor = Color.Gold;
                label233.BackColor = Color.Gold;
                plogin.BackColor = Color.Gold;
                label212.BackColor = Color.Gold;
                label211.BackColor = Color.Gold;
                checkBox3.BackColor = Color.Gold;
                pictureBox57.BackColor = Color.Gold;
                pictureBox79.BackColor = Color.Gold;
                pictureBox78.BackColor = Color.Gold;
                label252.BackColor = Color.Gold;
                button16.BackColor = Color.Gold;
                button17.BackColor = Color.Gold;
                button18.BackColor = Color.Gold;
                button19.BackColor = Color.Gold;
                panel1.BackColor = Color.Gold;
                panel16.BackColor = Color.Gold;
                panel25.BackColor = Color.Gold;
                panel26.BackColor = Color.Gold;
                panel27.BackColor = Color.Gold;
                panel28.BackColor = Color.Gold;
                panel29.BackColor = Color.Gold;

            }
            else if (comboBox1.Text == "Maroon")
            {
                panel20.BackColor = Color.Maroon;
                label6.BackColor = Color.Maroon;
                label7.BackColor = Color.Maroon;
                label225.BackColor = Color.Maroon;
                panel2.BackColor = Color.Maroon;
                panel3.BackColor = Color.Maroon;
                panel4.BackColor = Color.Maroon;
                panel5.BackColor = Color.Maroon;
                panel6.BackColor = Color.Maroon;
                panel7.BackColor = Color.Maroon;
                panel21.BackColor = Color.Maroon;
                label2.BackColor = Color.Maroon;
                panel19.BackColor = Color.Maroon;
                panel18.BackColor = Color.Maroon;
                button3.BackColor = Color.Maroon;
                button4.BackColor = Color.Maroon;
                button9.BackColor = Color.Maroon;
                button5.BackColor = Color.Maroon;
                button8.BackColor = Color.Maroon;
                button6.BackColor = Color.Maroon;
                pictureBox40.BackColor = Color.Maroon;
                pictureBox41.BackColor = Color.Maroon;
                panel14.BackColor = Color.Maroon;
                panel15.BackColor = Color.Maroon;
                label189.BackColor = Color.Maroon;
                label113.BackColor = Color.Maroon;
                label171.BackColor = Color.Maroon;
                label172.BackColor = Color.Maroon;
                button10.BackColor = Color.Maroon;
                button11.BackColor = Color.Maroon;
                button12.BackColor = Color.Maroon;
                button14.BackColor = Color.Maroon;
                button13.BackColor = Color.Maroon;
                button15.BackColor = Color.Maroon;
                button1.BackColor = Color.Maroon;
                panel23.BackColor = Color.Maroon;
                label245.BackColor = Color.Maroon;
                label244.BackColor = Color.Maroon;
                label243.BackColor = Color.Maroon;
                label242.BackColor = Color.Maroon;
                label241.BackColor = Color.Maroon;
                label240.BackColor = Color.Maroon;
                label228.BackColor = Color.Maroon;
                label239.BackColor = Color.Maroon;
                label238.BackColor = Color.Maroon;
                label237.BackColor = Color.Maroon;
                label236.BackColor = Color.Maroon;
                label235.BackColor = Color.Maroon;
                label234.BackColor = Color.Maroon;
                label229.BackColor = Color.Maroon;
                label230.BackColor = Color.Maroon;
                label231.BackColor = Color.Maroon;
                label232.BackColor = Color.Maroon;
                label233.BackColor = Color.Maroon;
                plogin.BackColor = Color.Maroon;
                label212.BackColor = Color.Maroon;
                label211.BackColor = Color.Maroon;
                checkBox3.BackColor = Color.Maroon;
                pictureBox57.BackColor = Color.Maroon;
                pictureBox79.BackColor = Color.Maroon;
                pictureBox78.BackColor = Color.Maroon;
                label252.BackColor = Color.Maroon;
                button16.BackColor = Color.Maroon;
                button17.BackColor = Color.Maroon;
                button18.BackColor = Color.Maroon;
                button19.BackColor = Color.Maroon;
                panel1.BackColor = Color.Maroon;
                panel16.BackColor = Color.Maroon;
                panel25.BackColor = Color.Maroon;
                panel26.BackColor = Color.Maroon;
                panel27.BackColor = Color.Maroon;
                panel28.BackColor = Color.Maroon;
                panel29.BackColor = Color.Maroon;
            }
            else if (comboBox1.Text == "Violet")
            {
                panel20.BackColor = Color.Violet;
                label6.BackColor = Color.Violet;
                label7.BackColor = Color.Violet;
                label225.BackColor = Color.Violet;
                panel2.BackColor = Color.Violet;
                panel3.BackColor = Color.Violet;
                panel4.BackColor = Color.Violet;
                panel5.BackColor = Color.Violet;
                panel6.BackColor = Color.Violet;
                panel7.BackColor = Color.Violet;
                panel21.BackColor = Color.Violet;
                label2.BackColor = Color.Violet;
                panel19.BackColor = Color.Violet;
                panel18.BackColor = Color.Violet;
                button3.BackColor = Color.Violet;
                button4.BackColor = Color.Violet;
                button9.BackColor = Color.Violet;
                button5.BackColor = Color.Violet;
                button8.BackColor = Color.Violet;
                button6.BackColor = Color.Violet;
                pictureBox40.BackColor = Color.Violet;
                pictureBox41.BackColor = Color.Violet;
                panel14.BackColor = Color.Violet;
                panel15.BackColor = Color.Violet;
                label189.BackColor = Color.Violet;
                label113.BackColor = Color.Violet;
                label171.BackColor = Color.Violet;
                label172.BackColor = Color.Violet;
                button10.BackColor = Color.Violet;
                button11.BackColor = Color.Violet;
                button12.BackColor = Color.Violet;
                button14.BackColor = Color.Violet;
                button13.BackColor = Color.Violet;
                button15.BackColor = Color.Violet;
                button1.BackColor = Color.Violet;
                panel23.BackColor = Color.Violet;
                label245.BackColor = Color.Violet;
                label244.BackColor = Color.Violet;
                label243.BackColor = Color.Violet;
                label242.BackColor = Color.Violet;
                label241.BackColor = Color.Violet;
                label240.BackColor = Color.Violet;
                label228.BackColor = Color.Violet;
                label239.BackColor = Color.Violet;
                label238.BackColor = Color.Violet;
                label237.BackColor = Color.Violet;
                label236.BackColor = Color.Violet;
                label235.BackColor = Color.Violet;
                label234.BackColor = Color.Violet;
                label229.BackColor = Color.Violet;
                label230.BackColor = Color.Violet;
                label231.BackColor = Color.Violet;
                label232.BackColor = Color.Violet;
                label233.BackColor = Color.Violet;
                plogin.BackColor = Color.Violet;
                label212.BackColor = Color.Violet;
                label211.BackColor = Color.Violet;
                checkBox3.BackColor = Color.Violet;
                pictureBox57.BackColor = Color.Violet;
                pictureBox79.BackColor = Color.Violet;
                pictureBox78.BackColor = Color.Violet;
                label252.BackColor = Color.Violet;
                button16.BackColor = Color.Violet;
                button17.BackColor = Color.Violet;
                button18.BackColor = Color.Violet;
                button19.BackColor = Color.Violet;
                panel1.BackColor = Color.Violet;
                panel16.BackColor = Color.Violet;
                panel25.BackColor = Color.Violet;
                panel26.BackColor = Color.Violet;
                panel27.BackColor = Color.Violet;
                panel28.BackColor = Color.Violet;
                panel29.BackColor = Color.Violet;

            }
            else if (comboBox1.Text == "ForestGreen")
            {
                panel20.BackColor = Color.ForestGreen;
                label6.BackColor = Color.ForestGreen;
                label7.BackColor = Color.ForestGreen;
                label225.BackColor = Color.ForestGreen;
                panel2.BackColor = Color.ForestGreen;
                panel3.BackColor = Color.ForestGreen;
                panel4.BackColor = Color.ForestGreen;
                panel5.BackColor = Color.ForestGreen;
                panel6.BackColor = Color.ForestGreen;
                panel7.BackColor = Color.ForestGreen;
                panel21.BackColor = Color.ForestGreen;
                label2.BackColor = Color.ForestGreen;
                panel19.BackColor = Color.ForestGreen;
                panel18.BackColor = Color.ForestGreen;
                button3.BackColor = Color.ForestGreen;
                button4.BackColor = Color.ForestGreen;
                button9.BackColor = Color.ForestGreen;
                button5.BackColor = Color.ForestGreen;
                button8.BackColor = Color.ForestGreen;
                button6.BackColor = Color.ForestGreen;
                pictureBox40.BackColor = Color.ForestGreen;
                pictureBox41.BackColor = Color.ForestGreen;
                panel14.BackColor = Color.ForestGreen;
                panel15.BackColor = Color.ForestGreen;
                label189.BackColor = Color.ForestGreen;
                label113.BackColor = Color.ForestGreen;
                label171.BackColor = Color.ForestGreen;
                label172.BackColor = Color.ForestGreen;
                button10.BackColor = Color.ForestGreen;
                button11.BackColor = Color.ForestGreen;
                button12.BackColor = Color.ForestGreen;
                button14.BackColor = Color.ForestGreen;
                button13.BackColor = Color.ForestGreen;
                button15.BackColor = Color.ForestGreen;
                button1.BackColor = Color.ForestGreen;
                panel23.BackColor = Color.ForestGreen;
                label245.BackColor = Color.ForestGreen;
                label244.BackColor = Color.ForestGreen;
                label243.BackColor = Color.ForestGreen;
                label242.BackColor = Color.ForestGreen;
                label241.BackColor = Color.ForestGreen;
                label240.BackColor = Color.ForestGreen;
                label228.BackColor = Color.ForestGreen;
                label239.BackColor = Color.ForestGreen;
                label238.BackColor = Color.ForestGreen;
                label237.BackColor = Color.ForestGreen;
                label236.BackColor = Color.ForestGreen;
                label235.BackColor = Color.ForestGreen;
                label234.BackColor = Color.ForestGreen;
                label229.BackColor = Color.ForestGreen;
                label230.BackColor = Color.ForestGreen;
                label231.BackColor = Color.ForestGreen;
                label232.BackColor = Color.ForestGreen;
                label233.BackColor = Color.ForestGreen;
                plogin.BackColor = Color.ForestGreen;
                label212.BackColor = Color.ForestGreen;
                label211.BackColor = Color.ForestGreen;
                checkBox3.BackColor = Color.ForestGreen;
                pictureBox57.BackColor = Color.ForestGreen;
                pictureBox79.BackColor = Color.ForestGreen;
                pictureBox78.BackColor = Color.ForestGreen;
                label252.BackColor = Color.ForestGreen;
                button16.BackColor = Color.ForestGreen;
                button17.BackColor = Color.ForestGreen;
                button18.BackColor = Color.ForestGreen;
                button19.BackColor = Color.ForestGreen;
                panel1.BackColor = Color.ForestGreen;
                panel16.BackColor = Color.ForestGreen;
                panel25.BackColor = Color.ForestGreen;
                panel26.BackColor = Color.ForestGreen;
                panel27.BackColor = Color.ForestGreen;
                panel28.BackColor = Color.ForestGreen;
                panel29.BackColor = Color.ForestGreen;

            }
            else if (comboBox1.Text == "Brown")
            {
                panel20.BackColor = Color.Brown;
                label6.BackColor = Color.Brown;
                label7.BackColor = Color.Brown;
                label225.BackColor = Color.Brown;
                panel2.BackColor = Color.Brown;
                panel3.BackColor = Color.Brown;
                panel4.BackColor = Color.Brown;
                panel5.BackColor = Color.Brown;
                panel6.BackColor = Color.Brown;
                panel7.BackColor = Color.Brown;
                panel21.BackColor = Color.Brown;
                label2.BackColor = Color.Brown;
                panel19.BackColor = Color.Brown;
                panel18.BackColor = Color.Brown;
                button3.BackColor = Color.Brown;
                button4.BackColor = Color.Brown;
                button9.BackColor = Color.Brown;
                button5.BackColor = Color.Brown;
                button8.BackColor = Color.Brown;
                button6.BackColor = Color.Brown;
                pictureBox40.BackColor = Color.Brown;
                pictureBox41.BackColor = Color.Brown;
                panel14.BackColor = Color.Brown;
                panel15.BackColor = Color.Brown;
                label189.BackColor = Color.Brown;
                label113.BackColor = Color.Brown;
                label171.BackColor = Color.Brown;
                label172.BackColor = Color.Brown;
                button10.BackColor = Color.Brown;
                button11.BackColor = Color.Brown;
                button12.BackColor = Color.Brown;
                button14.BackColor = Color.Brown;
                button13.BackColor = Color.Brown;
                button15.BackColor = Color.Brown;
                button1.BackColor = Color.Brown;
                panel23.BackColor = Color.Brown;
                label245.BackColor = Color.Brown;
                label244.BackColor = Color.Brown;
                label243.BackColor = Color.Brown;
                label242.BackColor = Color.Brown;
                label241.BackColor = Color.Brown;
                label240.BackColor = Color.Brown;
                label228.BackColor = Color.Brown;
                label239.BackColor = Color.Brown;
                label238.BackColor = Color.Brown;
                label237.BackColor = Color.Brown;
                label236.BackColor = Color.Brown;
                label235.BackColor = Color.Brown;
                label234.BackColor = Color.Brown;
                label229.BackColor = Color.Brown;
                label230.BackColor = Color.Brown;
                label231.BackColor = Color.Brown;
                label232.BackColor = Color.Brown;
                label233.BackColor = Color.Brown;
                plogin.BackColor = Color.Brown;
                label212.BackColor = Color.Brown;
                label211.BackColor = Color.Brown;
                checkBox3.BackColor = Color.Brown;
                pictureBox57.BackColor = Color.Brown;
                pictureBox79.BackColor = Color.Brown;
                pictureBox78.BackColor = Color.Brown;
                label252.BackColor = Color.Brown;
                button16.BackColor = Color.Brown;
                button17.BackColor = Color.Brown;
                button18.BackColor = Color.Brown;
                button19.BackColor = Color.Brown;
                panel1.BackColor = Color.Brown;
                panel16.BackColor = Color.Brown;
                panel25.BackColor = Color.Brown;
                panel26.BackColor = Color.Brown;
                panel27.BackColor = Color.Brown;
                panel28.BackColor = Color.Brown;
                panel29.BackColor = Color.Brown;
            }
            else if (comboBox1.Text == "Fuchsia")
            {
                panel20.BackColor = Color.Fuchsia;
                label6.BackColor = Color.Fuchsia;
                label7.BackColor = Color.Fuchsia;
                label225.BackColor = Color.Fuchsia;
                panel2.BackColor = Color.Fuchsia;
                panel3.BackColor = Color.Fuchsia;
                panel4.BackColor = Color.Fuchsia;
                panel5.BackColor = Color.Fuchsia;
                panel6.BackColor = Color.Fuchsia;
                panel7.BackColor = Color.Fuchsia;
                panel21.BackColor = Color.Fuchsia;
                label2.BackColor = Color.Fuchsia;
                panel19.BackColor = Color.Fuchsia;
                panel18.BackColor = Color.Fuchsia;
                button3.BackColor = Color.Fuchsia;
                button4.BackColor = Color.Fuchsia;
                button9.BackColor = Color.Fuchsia;
                button5.BackColor = Color.Fuchsia;
                button8.BackColor = Color.Fuchsia;
                button6.BackColor = Color.Fuchsia;
                pictureBox40.BackColor = Color.Fuchsia;
                pictureBox41.BackColor = Color.Fuchsia;
                panel14.BackColor = Color.Fuchsia;
                panel15.BackColor = Color.Fuchsia;
                label189.BackColor = Color.Fuchsia;
                label113.BackColor = Color.Fuchsia;
                label171.BackColor = Color.Fuchsia;
                label172.BackColor = Color.Fuchsia;
                button10.BackColor = Color.Fuchsia;
                button11.BackColor = Color.Fuchsia;
                button12.BackColor = Color.Fuchsia;
                button14.BackColor = Color.Fuchsia;
                button13.BackColor = Color.Fuchsia;
                button15.BackColor = Color.Fuchsia;
                button1.BackColor = Color.Fuchsia;
                panel23.BackColor = Color.Fuchsia;
                label245.BackColor = Color.Fuchsia;
                label244.BackColor = Color.Fuchsia;
                label243.BackColor = Color.Fuchsia;
                label242.BackColor = Color.Fuchsia;
                label241.BackColor = Color.Fuchsia;
                label240.BackColor = Color.Fuchsia;
                label228.BackColor = Color.Fuchsia;
                label239.BackColor = Color.Fuchsia;
                label238.BackColor = Color.Fuchsia;
                label237.BackColor = Color.Fuchsia;
                label236.BackColor = Color.Fuchsia;
                label235.BackColor = Color.Fuchsia;
                label234.BackColor = Color.Fuchsia;
                label229.BackColor = Color.Fuchsia;
                label230.BackColor = Color.Fuchsia;
                label231.BackColor = Color.Fuchsia;
                label232.BackColor = Color.Fuchsia;
                label233.BackColor = Color.Fuchsia;
                plogin.BackColor = Color.Fuchsia;
                label212.BackColor = Color.Fuchsia;
                label211.BackColor = Color.Fuchsia;
                checkBox3.BackColor = Color.Fuchsia;
                pictureBox57.BackColor = Color.Fuchsia;
                pictureBox79.BackColor = Color.Fuchsia;
                pictureBox78.BackColor = Color.Fuchsia;
                label252.BackColor = Color.Fuchsia;
                button16.BackColor = Color.Fuchsia;
                button17.BackColor = Color.Fuchsia;
                button18.BackColor = Color.Fuchsia;
                button19.BackColor = Color.Fuchsia;
                panel1.BackColor = Color.Fuchsia;
                panel16.BackColor = Color.Fuchsia;
                panel25.BackColor = Color.Fuchsia;
                panel26.BackColor = Color.Fuchsia;
                panel27.BackColor = Color.Fuchsia;
                panel28.BackColor = Color.Fuchsia;
                panel29.BackColor = Color.Fuchsia;
            }  
}
        private void pictureBox70_Click(object sender, EventArgs e)
        {
            if (textBox46.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                ABC.Open();
                cmd = new MySqlCommand("select * from daftaranggota where " + comboBox4.Text + " LIKE '%" + textBox46.Text + "%'", ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label233.Text = mdr.GetString("IdAnggota");
                    label232.Text = mdr.GetString("NamaAnggota");
                    label231.Text = mdr.GetString("NoTelp");
                    label230.Text = mdr.GetString("Alamat");
                    label229.Text = mdr.GetString("SimpananPokok");
                }
                else
                {
                    MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            panelinfouser.Width = 0;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                textBox37.UseSystemPasswordChar = true ;
            }
            else if(checkBox3.Checked == false)
            {
                textBox37.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            pictureBox71.Width = 0;
            cmd = new MySqlCommand(("truncate petugas"), ABC);
            ABC.Open();
            cmd.ExecuteNonQuery();
            ABC.Close();
            crystalReportViewer3.Width = 0;
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            pictureBox72.Width = 0;
            crystalReportViewer5.Width = 0;
            cmd = new MySqlCommand("TRUNCATE petugas", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery();
            ABC.Close();
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            String strsaldoakhir;

            a = Convert.ToDouble(textBox15.Text);
            b = Convert.ToDouble(textBox18.Text);
            c = Convert.ToDouble(textBox47.Text);
            d = a + b + c;

            textBox19.Text = d.ToString();
        }

        private void crystalReportViewer6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            crystalReportViewer6.Width = 0;
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            pictureBox74.Width = 0;
            crystalReportViewer7.Width = 0;
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            crystalReportViewer8.Width = 0;
            pictureBox75.Width = 0;
            cmd = new MySqlCommand("TRUNCATE petugas", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery();
            ABC.Close();
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            pictureBox76.Width = 0;
            crystalReportViewer9.Width = 0;
        }

        private void textboxusernameadminlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label226_Click_1(object sender, EventArgs e)
        {
            panelinfouser.Width = 810;
        }

        private void pictureBox57_Click_1(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("select * from daftarpengurus where Username ='" + textboxusernameadminlogin.Text + "'", ABC);
            ABC.Open();

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label12.Text = dr.GetString("IdPengurus");
                label13.Text = dr.GetString("NamaPengurus");
                label14.Text = dr.GetString("Telp");
                pictureBox1.ImageLocation = dr.GetString("directory");
            }
            else
            {

            }
            ABC.Close();

            if (textboxusernameadminlogin.Text == "" && textBox37.Text == "")
            {
                MessageBox.Show("Username Dan Password Tidak Boleh Kosong . . .", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (login(textboxusernameadminlogin.Text, textBox37.Text))
            {
                MessageBox.Show("Welcome Admin !", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panellogin.Width = 0;
                textboxusernameadminlogin.Clear();
                textBox37.Clear();
                LoadData();
            }
            else
            {
                MessageBox.Show("Login Gagal !");
                textBox37.Clear();
                textboxusernameadminlogin.Clear();
            }
        }

        private void textBox37_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cmd = new MySqlCommand("select * from daftarpengurus where Username ='" + textboxusernameadminlogin.Text + "'", ABC);
                ABC.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label12.Text = dr.GetString("IdPengurus");
                    label13.Text = dr.GetString("NamaPengurus");
                    label14.Text = dr.GetString("Telp");
                    pictureBox1.ImageLocation = dr.GetString("directory");
                }
                else
                {
                    MessageBox.Show("Maaf data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ABC.Close();

                if (textboxusernameadminlogin.Text == "" && textBox37.Text == "")
                {
                    MessageBox.Show("Username Dan Password Tidak Boleh Kosong . . .");
                }
                else if (login(textboxusernameadminlogin.Text, textBox37.Text))
                {
                    MessageBox.Show("Welcome Admin !", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panellogin.Width = 0;
                    textboxusernameadminlogin.Clear();
                    textBox37.Clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Login Gagal !");
                    textBox37.Clear();
                    textboxusernameadminlogin.Clear();
                }
            }
        }

        private void plogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            plogin.Width = 0;
        }

        private void label251_Click(object sender, EventArgs e)
        {
            plogin.Width = 515;
        }

        private void pictureBox55_Click_1(object sender, EventArgs e)
        {
            plogin.Width = 515;
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            panelinfouser.Width = 810;
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            panelpengaturan.Height = 0;
        }

        private void panel24_MouseClick(object sender, MouseEventArgs e)
        {
            panelpengaturan.Height = 0;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            panelpengaturan.Height = 160;
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            panelshowreport.Width = 0;
        }

        private void label26_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer2.RefreshReport();
            crystalReportViewer2.Width = 810;
            pictureBox64.Width = 65;
            panelsettingkoperasi.Width = 0;
            panelpengaturan.Width = 0;
            panelshowreport.Width = 0;
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            crystalReportViewer2.RefreshReport();
            crystalReportViewer2.Width = 810;
            pictureBox64.Width = 65;
            panelsettingkoperasi.Width = 0;
            panelpengaturan.Width = 0;
            panelshowreport.Width = 0;
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {

            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Width = 810;
            pictureBox62.Width = 80;
            panelsettingkoperasi.Width = 0;
            panelpengaturan.Width = 0;
            panelshowreport.Width = 0;
        }

        private void label27_Click_1(object sender, EventArgs e)
        {

            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Width = 810;
            pictureBox62.Width = 80;
            panelsettingkoperasi.Width = 0;
            panelpengaturan.Width = 0;
            panelshowreport.Width = 0;
        }

        private void label255_Click(object sender, EventArgs e)
        {
            if (panelsettingkoperasi.Width == 506)
            {
                panelsettingkoperasi.Width = 0;
                panelshowreport.Width = 0;
            }
            else
            {
                panelsettingkoperasi.Width = 506;
                panelshowreport.Width = 0;
            }
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            if (panelsettingkoperasi.Width == 506)
            {
                panelsettingkoperasi.Width = 0;
                panelshowreport.Width = 0;
            }
            else
            {
                panelsettingkoperasi.Width = 506;
                panelshowreport.Width = 0;
            }
        }

        private void label253_Click(object sender, EventArgs e)
        {
            panelshowreport.Width = 201;
            panelsettingkoperasi.Width = 0;
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            panelshowreport.Width = 201;
            panelsettingkoperasi.Width = 0;
        }

        private void label256_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Logout", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                panellogin.Width = 810;
                panelsettingkoperasi.Width = 0;
                panelshowreport.Width = 0;
                panelpengaturan.Width = 0;
                plogin.Width = 0;
            }
            }

        private void pictureBox83_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Logout", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                panellogin.Width = 810;
                panelsettingkoperasi.Width = 0;
                panelshowreport.Width = 0;
                panelpengaturan.Width = 0;
                plogin.Width = 0;
            }
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {

        }

        private void label224_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            panelpengaturan.Width = 0;
            panelshowreport.Width = 0;
            panelsettingkoperasi.Width = 0;
        }

        private void panelsimpanann_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox33_Click_1(object sender, EventArgs e)
        {
            if (textBox17.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {
                    ABC.Open();
                    a = "select * from koperasi .daftaranggota where IdAnggota=" + int.Parse(textBox17.Text);
                    cmd = new MySqlCommand(a, ABC);
                    mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label119.Text = mdr.GetString("IdAnggota");
                        label118.Text = mdr.GetString("NamaAnggota");
                        label117.Text = mdr.GetString("NoTelp");
                        label116.Text = mdr.GetString("Alamat");
                        label29.Text = mdr.GetString("SimpananPokok");

                    }
                    else
                    {
                        MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    mdr.Close();
                    ABC.Close();
                }
            }
        }

        private void label110_Click(object sender, EventArgs e)
        {
            panelsetoranpokok.BringToFront();
            panelsetoranpokok.Width = 362;
            panelsetoranlain.Width = 0;
            panelsimpananwajib.Width = 0;
            panel27.Visible = false;
            panel28.Visible = true;
            panel29.Visible = false;
        }

        private void label53_Click(object sender, EventArgs e)
        {
            panelsimpananwajib.Width = 362;
            panelsetoranlain.Width = 0;
            panelsetoranpokok.Width = 0;
            panel27.Visible = true;
            panel28.Visible = false;
            panel29.Visible = false;
        }

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void label109_Click(object sender, EventArgs e)
        {
            panel27.Visible = false;
            panel28.Visible = false;
            panel29.Visible = true;
            panelsetoranlain.Width = 362;
            panelsetoranpokok.Width = 0;
            panelsimpananwajib.Width = 0;
        }

        private void pictureBox24_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer10.Width = 0;
            pictureBox28.Width = 0;
            cmd = new MySqlCommand(("truncate petugas"), ABC);
            ABC.Open();
            cmd.ExecuteNonQuery();
            ABC.Close();
        }

        private void pictureBox73_Click_1(object sender, EventArgs e)
        {
            pictureBox73.Width = 0;
            crystalReportViewer11.Width = 0;
        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_MouseClick(object sender, MouseEventArgs e)
        {
            panelfaisal.Visible = true;
            panelahok.Visible = false;

            panel26.Visible = false;
            panel25.Visible = true;
        }

        private void label78_Click(object sender, EventArgs e)
        {
            panelfaisal.Visible = true;
            panelahok.Visible = false;

            panel26.Visible = false;
            panel25.Visible = true;
        }

        private void panel17_MouseClick(object sender, MouseEventArgs e)
        {
            panelfaisal.Visible = false;
            panelahok.Visible = true;

            panel26.Visible = true;
            panel25.Visible = false;
        }

        private void label77_Click(object sender, EventArgs e)
        {
            panelfaisal.Visible = false;
            panelahok.Visible = true;
            panel26.Visible = true;
            panel25.Visible = false;
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            panelabout.Width = 0;
        }

        private void label254_Click(object sender, EventArgs e)
        {
            panelabout.Width = 810;
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            panelabout.Width = 810;
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {

            crystalReportViewer4.Width = 0;
            pictureBox94.Width = 0;
        }

        private void label257_Click(object sender, EventArgs e)
        {
            crystalReportViewer12.RefreshReport();
            crystalReportViewer12.Width = 810;
            pictureBox98.Width = 43;
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ABC.Open();
            cmd = new MySqlCommand("select *from biaya", ABC);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ds.Clear();
            adapter.Fill(ds);
            ABC.Close();
            ReportDocument rd = new ReportDocument();
            rd.Load("../../CrystalReport6.rpt");
            rd.Database.Tables[1].SetDataSource(ds.Tables[0]);
            crystalReportViewer4.ReportSource = rd;
            crystalReportViewer4.RefreshReport();
            crystalReportViewer4.BringToFront();
            crystalReportViewer4.Width = 810;
            pictureBox94.Width = 66;
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            crystalReportViewer12.Width = 0;
            pictureBox95.Width = 0;
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            crystalReportViewer9.Width = 0;
            pictureBox96.Width = 0;
            cmd = new MySqlCommand("TRUNCATE petugas", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery();
            ABC.Close();
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            pictureBox97.Width = 0;
            crystalReportViewer6.Width = 0;
            cmd = new MySqlCommand("TRUNCATE petugas", ABC);
            ABC.Open();
            cmd.ExecuteNonQuery();
            ABC.Close();
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            pictureBox98.Width = 0;
            crystalReportViewer12.Width = 0;
        }

        private void panelhomeadmin_MouseClick(object sender, MouseEventArgs e)
        {
            panelshowreport.Width = 0;
            panelsettingkoperasi.Width = 0;
            panelpengaturan.Width = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox46_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (textBox46.Text == "")
                {
                    MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                try
                {
                    ABC.Open();
                    cmd = new MySqlCommand("select * from daftaranggota where " + comboBox4.Text + " LIKE '%" + textBox46.Text + "%'", ABC);
                    mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label233.Text = mdr.GetString("IdAnggota");
                        label232.Text = mdr.GetString("NamaAnggota");
                        label231.Text = mdr.GetString("NoTelp");
                        label230.Text = mdr.GetString("Alamat");
                        label229.Text = mdr.GetString("SimpananPokok");
                        textBox46.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    mdr.Close();
                    ABC.Close();
                }
            }
        }

        private void pictureBox55_MouseMove(object sender, MouseEventArgs e)
        {
           panel1.Visible = true;
        }

        private void pictureBox55_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox77_MouseMove(object sender, MouseEventArgs e)
        {
            panel16.Visible = true;
        }

        private void pictureBox77_MouseLeave(object sender, EventArgs e)
        {
            panel16.Visible = false;
        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            panel26.Visible = true;
            panel25.Visible = false;
        }

        private void panel17_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel22_MouseMove(object sender, MouseEventArgs e)
        {
            panel25.Visible = true;
            panel26.Visible = false;
        }

        private void panel22_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel27.Visible = true;
            panel28.Visible = false;
            panel29.Visible = false;
            panelsimpananwajib.Width = 362;
            panelsetoranlain.Width = 0;
            panelsetoranpokok.Width = 0;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel27.Visible = false;
            panel28.Visible = true;
            panel29.Visible = false;
            panelsetoranpokok.BringToFront();
            panelsetoranpokok.Width = 362;
            panelsetoranlain.Width = 0;
            panelsimpananwajib.Width = 0;
        }

        private void panel11_Click(object sender, EventArgs e)
        {

            panelsetoranlain.Width = 362;
            panelsetoranpokok.Width = 0;
            panelsimpananwajib.Width = 0;
            panel27.Visible = false;
            panel28.Visible = false;
            panel29.Visible = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Masukan ID Yang Ingin Dicari", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                ABC.Open();
                a = "select * from koperasi .daftaranggota where IdAnggota=" + int.Parse(textBox7.Text);
                cmd = new MySqlCommand(a, ABC);
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    label42.Text = mdr.GetString("IdAnggota");
                    label41.Text = mdr.GetString("NamaAnggota");
                    label40.Text = mdr.GetString("NoTelp");
                    label39.Text = mdr.GetString("Alamat");
                    label36.Text = mdr.GetString("SimpananPokok");
                }
                else
                {
                    MessageBox.Show("Anggota Tidak Terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mdr.Close();
                ABC.Close();
            }

        }
    }
}


    


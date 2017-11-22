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
    public partial class Form1 : Form
    {
        MySqlConnection ABC = new MySqlConnection("server=localhost; database=koperasi; uid=root; password=;");
        

        public Form1()
        {
            InitializeComponent();
        }


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loginadmin.Width = 377;
                
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loginadmin.Width = 0;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                if (textboxusernameadminlogin.Text == "" && textboxloginadminpassword.Text == "")
                {
                    MessageBox.Show("Lengkapi Data Terlebih Dahulu . . .");
                }
                else if (login(textboxusernameadminlogin.Text, textboxloginadminpassword.Text))
                {
                    MessageBox.Show("Welcome Admin !");
                    Form f = new HomeAdmin();
                    f.ShowDialog();
                    this.Close();
                    textboxusernameadminlogin.Clear();
                    textboxloginadminpassword.Clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Login Gagal!");
                }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true )
            {
                panelprofileadrian.Width = 441;
                panelprofilefaisal.Width = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panelprofilefaisal.Width = 441;
                panelprofileadrian.Width = 0;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panelmyprofile.Width = 0;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panelprofileadrian.Width = 0;
        }

        private void panelprofileadrian_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panelprofilefaisal.Width = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panelmyprofile.Width = 441;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ABC.Open();
            LoadData();
            ABC.Close();
        }
        public void LoadData()
        {
            MySqlCommand cmd;
            cmd = ABC.CreateCommand();
            cmd.CommandText = "select * from daftarpengurus";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel3.Width = 0;
                 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new HomeAdmin();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Width = 733;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new HomeAdmin();
            f.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelsetoranwajib.Width = 733;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Width = 0;
            panel3.Width = 0;
            panel4.Width = 0;
            panelsetoranpokok.Width = 733;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel2.Width = 273;
            panel3.Width = 273;
            panel4.Width = 273;
            panelsetoranpokok.Width = 0;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel2.Width = 273;
            panel3.Width = 273;
            panel4.Width = 273;
            panelsetoranwajib.Width = 0;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel2.Width = 273;
            panel3.Width = 273;
            panel4.Width = 273;
            panellainlainnya.Width = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel2.Width = 0;
            panel3.Width = 0;
            panel4.Width = 0;
            panelsetoranwajib.Width = 733;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            panel2.Width = 0;
            panel3.Width = 0;
            panel4.Width = 0;
            panellainlainnya.Width = 733;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new HomeAdmin();
            f.ShowDialog();
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelpembayaran.Width = 733;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelpeminjaman.Width = 733;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelpeminjaman.Width = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelpembayaran.Width = 0;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panelpembayaran.Width = 733;
        }

        private void label47_Click(object sender, EventArgs e)
        {
            panelpembayaran.Width = 733;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panelpeminjaman.Width = 733;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            panelpeminjaman.Width = 733;
        }
    }
}

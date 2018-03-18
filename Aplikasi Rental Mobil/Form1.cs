using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Rental_Mobil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelHome.Show();
            panelPemesanan.Hide();
            comboBox1.SelectedIndex = 0;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tanyaAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPemesanan.Hide();
        }

        private void pemesananToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panelPemesanan.Show();
        }

        private void panelPemesanan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

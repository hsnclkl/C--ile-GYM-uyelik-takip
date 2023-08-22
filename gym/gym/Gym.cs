using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using gym.Forms;

namespace gym
{
    public partial class Gym : Form
    {
        public Gym()
        {
            InitializeComponent();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            ekle ekleForm = new ekle(); 
            ekleForm.TopLevel = false;
            ekleForm.FormBorderStyle = FormBorderStyle.None;
            ekleForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(ekleForm);

            ekleForm.Show();
        }

        private void buttonliste_Click(object sender, EventArgs e)
        {
            liste listeForm = new liste();                                                        
            listeForm.TopLevel = false;
            listeForm.FormBorderStyle = FormBorderStyle.None;
            listeForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(listeForm);

            listeForm.Show();
        }

        private void buttonpay_Click(object sender, EventArgs e)
        {
        pay payForm = new pay();                                                       
            payForm.TopLevel = false;
            payForm.FormBorderStyle = FormBorderStyle.None;
            payForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(payForm);

            payForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hesapla hesaplaForm = new hesapla();                                                         
            hesaplaForm.TopLevel = false;
            hesaplaForm.FormBorderStyle = FormBorderStyle.None;
            hesaplaForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(hesaplaForm);

            hesaplaForm.Show();

        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            temiz temizForm = new temiz(); // 
            temizForm.TopLevel = false;
            temizForm.FormBorderStyle = FormBorderStyle.None;
            temizForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(temizForm);

            temizForm.Show();

        }

        private void buttonabout_Click(object sender, EventArgs e)
        {
            about aboutForm = new about(); 
            aboutForm.TopLevel = false;
            aboutForm.FormBorderStyle = FormBorderStyle.None;
            aboutForm.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(aboutForm);

            aboutForm.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

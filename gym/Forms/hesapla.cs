using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace gym
{
    public partial class hesapla : Form
    {
        public hesapla()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");
        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, bagla);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void hesapla_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verilerigöster("Select *from takip");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bagla.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM takip WHERE Id='" + textBox1.Text + "'", bagla);
            komut.ExecuteNonQuery();
            verilerigöster("Select *from takip");
            bagla.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi!");
            textBox1.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            verilerigöster("Select *from takip");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double kilo = Convert.ToDouble(textBox4.Text);
                double boyCm = Convert.ToDouble(textBox5.Text);

                
                double boyMetre = boyCm / 100.0;

                double vki = kilo / (boyMetre * boyMetre);

                textBox1.Text = vki.ToString("0.00"); 

                string mesaj = "";
                if (vki < 18.5)
                    mesaj = "Zayıf kabul edilen vücut kitle indeksi aralığı olarak bilinir. Kişinin diyetisyen eşliğinde sağlıklı bir şekilde kilo alması şarttır.";
                else if (vki < 24.9)
                    mesaj = "Kişinin ideal kilosunda olduğu gösteren vücut kitle indeksi aralığıdır.";
                else if (vki < 29.9)
                    mesaj = "Kişinin fazla kilolu olduğunu ifade eder. Diyetisyen eşliğinde sağlıklı bir şekilde kilo verilmesi tavsiye edilir.";
                else if (vki < 34.9)
                    mesaj = "Kişinin birinci derece obez kategorisinde yer aldığını gösterir.";
                else if (vki < 39.9)
                    mesaj = "İkinci derece obez kategorisinde yer alan bu kişi; kalp ve damar hastalıklarına karşı savunmasızdır.";
                else if (vki < 44.9)
                    mesaj = "Üçüncü derece obezdir. Üçüncü derece obez kategorisinde yer alan bu kişi; hızlı bir şekilde kilo vermediği takdirde kendisini birçok hastalığın pençesinde bulur.";
                else
                    mesaj = "Süper obez olarak kabul edilir.";

                MessageBox.Show(mesaj, "VKİ Değerine Göre Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bagla.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM takip WHERE Id='" + textBox1.Text + "'", bagla);
            komut.ExecuteNonQuery();
            verilerigöster("Select *from takip");
            bagla.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi!");
            textBox1.Clear();
        }
    }
}

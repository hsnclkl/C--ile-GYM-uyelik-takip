using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace gym
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");
        private void ekle_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bagla.Open();

            SqlCommand komut2 = new SqlCommand("Insert into memberlist (Ad,Soyad,Yas,Boy,Kilo,Cinsiyet,Uyelik,Baslangic,Bitis,Odeme) values (@Ad,@Soyad,@Yas,@Boy,@Kilo,@Cinsiyet,@Uyelik,@Baslangic,@Bitis,@Odeme)", bagla);
            komut2.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut2.Parameters.AddWithValue("@Yas", comboBox3.Text);
            komut2.Parameters.AddWithValue("@Boy", textBox5.Text);
            komut2.Parameters.AddWithValue("@Kilo", textBox4.Text);
            komut2.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
            komut2.Parameters.AddWithValue("@Uyelik", comboBox2.Text);
            komut2.Parameters.AddWithValue("@Baslangic", dateTimePicker1.Value);
            komut2.Parameters.AddWithValue("@Bitis", dateTimePicker2.Value);
            komut2.Parameters.AddWithValue("@Odeme", textBox3.Text);
            komut2.ExecuteNonQuery();

            SqlCommand komut1 = new SqlCommand("Insert into pay (Tarih, Odeme) values (@Tarih, @Odeme)", bagla);
            komut1.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value); 
            komut1.Parameters.AddWithValue("@Odeme", textBox3.Text);
            komut1.ExecuteNonQuery();

            SqlCommand komut3 = new SqlCommand("Insert into takip (Ad,Soyad,Yas,Boy,Kilo,Baslangic) values (@Ad,@Soyad,@Yas,@Boy,@Kilo,@Baslangic)", bagla);
            komut3.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut3.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut3.Parameters.AddWithValue("@Yas", comboBox3.Text);
            komut3.Parameters.AddWithValue("@Boy", textBox5.Text);
            komut3.Parameters.AddWithValue("@Kilo", textBox4.Text);
            komut3.Parameters.AddWithValue("@Baslangic", dateTimePicker1.Value);
            komut3.ExecuteNonQuery();

            bagla.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || 
                string.IsNullOrEmpty(textBox2.Text) || 
                string.IsNullOrEmpty(textBox3.Text) || 
                string.IsNullOrEmpty(textBox4.Text) || 
                string.IsNullOrEmpty(textBox5.Text) || 
                string.IsNullOrEmpty(comboBox1.Text) || 
                string.IsNullOrEmpty(comboBox2.Text) || 
                string.IsNullOrEmpty(comboBox3.Text) || 
                string.IsNullOrEmpty(dateTimePicker1.Text) || 
                string.IsNullOrEmpty(dateTimePicker2.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bagla.Open();

            SqlCommand komut2 = new SqlCommand("Insert into memberlist (Ad,Soyad,Yas,Boy,Kilo,Cinsiyet,Uyelik,Baslangic,Bitis,Odeme) values (@Ad,@Soyad,@Yas,@Boy,@Kilo,@Cinsiyet,@Uyelik,@Baslangic,@Bitis,@Odeme)", bagla);
            komut2.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut2.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut2.Parameters.AddWithValue("@Yas", comboBox3.Text);
            komut2.Parameters.AddWithValue("@Boy", textBox5.Text);
            komut2.Parameters.AddWithValue("@Kilo", textBox4.Text);
            komut2.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
            komut2.Parameters.AddWithValue("@Uyelik", comboBox2.Text);
            komut2.Parameters.AddWithValue("@Baslangic", dateTimePicker1.Value);
            komut2.Parameters.AddWithValue("@Bitis", dateTimePicker2.Value);
            komut2.Parameters.AddWithValue("@Odeme", textBox3.Text);
            komut2.ExecuteNonQuery();

            SqlCommand komut1 = new SqlCommand("Insert into pay (Tarih, Odeme) values (@Tarih, @Odeme)", bagla);
            komut1.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
            komut1.Parameters.AddWithValue("@Odeme", textBox3.Text);
            komut1.ExecuteNonQuery();

            SqlCommand komut3 = new SqlCommand("Insert into takip (Ad,Soyad,Yas,Boy,Kilo,Baslangic) values (@Ad,@Soyad,@Yas,@Boy,@Kilo,@Baslangic)", bagla);
            komut3.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut3.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut3.Parameters.AddWithValue("@Yas", comboBox3.Text);
            komut3.Parameters.AddWithValue("@Boy", textBox5.Text);
            komut3.Parameters.AddWithValue("@Kilo", textBox4.Text);
            komut3.Parameters.AddWithValue("@Baslangic", dateTimePicker1.Value);
            komut3.ExecuteNonQuery();

            bagla.Close();
            MessageBox.Show("Başarıyla üye eklendi");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }
    }
}

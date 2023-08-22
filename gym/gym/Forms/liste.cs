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
using ClosedXML;
using ClosedXML.Excel;

namespace gym
{
    public partial class liste : Form
    {
        public liste()
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

        private void liste_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster("Select *from memberlist");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bagla.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM memberlist WHERE Id='" + textBox1.Text + "'", bagla);
            komut.ExecuteNonQuery();
            verilerigöster("Select *from memberlist");
            bagla.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi!");
            textBox1.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            verilerigöster("Select *from memberlist");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bagla.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM memberlist WHERE Id='" + textBox1.Text + "'", bagla);
            komut.ExecuteNonQuery();
            verilerigöster("Select *from memberlist");
            bagla.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi!");
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dt = (DataTable)dataGridView1.DataSource; 
                            if (dt != null)
                            {
                                workbook.Worksheets.Add(dt, "Rapor");
                                workbook.SaveAs(sfd.FileName);
                            }
                        }
                        MessageBox.Show("Kayıt Başarılı!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

    }
}

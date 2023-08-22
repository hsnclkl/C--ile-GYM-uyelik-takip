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
using ClosedXML;
using ClosedXML.Excel;

namespace gym
{
    public partial class pay : Form
    {
        public pay()
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster("Select *from pay");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bagla.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM pay WHERE Id='" + textBox1.Text + "'", bagla);
            komut.ExecuteNonQuery();
            verilerigöster("Select *from pay");
            bagla.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi!");
            textBox1.Clear();
        }

        private void pay_Load(object sender, EventArgs e)
        {
                // DataGridView veri kaynağını ayarlayın (örneğin bir DataTable)
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Ay", typeof(string));
                dataTable.Columns.Add("Odeme", typeof(decimal));
                // DataTable'e veriler eklemeyi unutmayın

                dataGridView1.DataSource = dataTable; // DataGridView'in veri kaynağını ayarlayın




            // DataGridView'dan veri alın
            _ = (DataTable)dataGridView1.DataSource; // DataGridView'in veri kaynağını burada doğru şekilde ayarlayın

            // Chart'a veri yükleme
            chart1.Series.Clear(); // Önce mevcut veri serilerini temizle
            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.DataType == typeof(double) || column.DataType == typeof(int))
                {
                    Series series = new Series(column.ColumnName);
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        double yValue = Convert.ToDouble(row[column]);
                        string xValue = row[dataGridView1.Columns[0].DataPropertyName].ToString(); // X ekseninde kullanmak istediğiniz değer

                        series.Points.AddXY(xValue, yValue);
                    }

                    chart1.Series.Add(series);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadChartDataFromDataGridView();
        }
        private void LoadChartDataFromDataGridView()
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                chart1.Series.Clear(); // Önce mevcut veri serilerini temizle

                Series series = new Series("Ödemeler");
                series.ChartType = SeriesChartType.Column;

                foreach (DataRow row in dataTable.Rows)
                {
                    string ay = row["Tarih"].ToString();
                    decimal odeme = Convert.ToDecimal(row["Odeme"]);

                    series.Points.AddXY(ay, odeme);
                }

                chart1.Series.Add(series);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                DataTable dt = (DataTable)dataGridView1.DataSource; // Bu satırı ekledik
                                if (dt != null)
                                {
                                    var worksheet = workbook.Worksheets.Add(dt, "Rapor");

                                    // İkinci sütunu tarih biçiminde ayarlama
                                    int tarihSutunuIndex = 2; // İkinci sütun (0 tabanlı index)
                                    string tarihFormati = "dd.MM.yyyy"; // Tarih formatı

                                    for (int row = 2; row <= worksheet.Rows().Count(); row++) // İlk satır başlık olduğu varsayılır
                                    {
                                        worksheet.Cell(row, tarihSutunuIndex + 2).Style.DateFormat.Format = tarihFormati;
                                    }

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
}

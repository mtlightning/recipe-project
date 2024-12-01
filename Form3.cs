using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLabTarifProjesi
{
    public partial class Form3 : Form
    {
        List<string> tarifListesi = new List<string>();
        public Form3()
        {
            InitializeComponent();
            TarifleriYukle();
            VerileriGoruntule();
        }

        private void VerileriGoruntule(string arama = "")
        {
            string connectionString = @"Data Source=.;Initial Catalog=YazLabTarifDb;Integrated Security=True;TrustServerCertificate=True";

            string sorgu = "SELECT TarifID, TarifAdi, Kategori, HazirlamaSuresi, Talimatlar, TarifMaliyet FROM Tarifler";
            if (!string.IsNullOrEmpty(arama))
            {
                sorgu += " WHERE TarifAdi LIKE @Arama OR Kategori LIKE @Arama";
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                    if (!string.IsNullOrEmpty(arama))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Arama", "%" + arama + "%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından veri çekerken sorun oldu! " + ex.Message);
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            VerileriGoruntule(textBox1.Text);




        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TarifleriYukle()
        {

        }


        private void LoadMalzemeler()
        {



        }


        private void TarifiGetir(string tarifAdi)
        {



        }

        private void controller1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) 
            {
                int tarifID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TarifID"].Value);
                MalzemeleriGoruntule(tarifID); 
            }


        }


        private void MalzemeleriGoruntule(int tarifID)
        {
            string connectionString = @"Data Source=.;Initial Catalog=YazLabTarifDb;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    string sorgu = "SELECT m.MalzemeAdi, tmi.MalzemeMiktar, m.ToplamMiktar, m.MalzemeBirim " +
                                   "FROM TarifMalzemeIliskisi tmi " +
                                   "JOIN Malzemeler m ON tmi.MalzemeID = m.MalzemeID " +
                                   "WHERE tmi.TarifID = @TarifID";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@TarifID", tarifID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = dt;

                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            decimal malzemeMiktar = Convert.ToDecimal(row.Cells["MalzemeMiktar"].Value ?? 0);
                            decimal toplamMiktar = Convert.ToDecimal(row.Cells["ToplamMiktar"].Value ?? 0);

                            if (malzemeMiktar > toplamMiktar)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red; 
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.Green; 
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu tarife ait malzeme bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzemeleri görüntülerken bir hata oluştu! " + ex.Message);
                }
            }
        }


    }
}

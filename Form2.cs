using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazLabTarifProjesi
{
    public partial class Form2 : Form
    {
        List<string> tarifListesi = new List<string>();

        public Form2()
        {
            InitializeComponent();
           
            LoadMalzemeler();
            ConfigureDataGridView2();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var selectedItem in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(selectedItem))
                {
                    listBox2.Items.Add(selectedItem);
                }

            }
            listBox1.ClearSelected();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.ClearSelected();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {
            string aramaMetni = textBox1.Text;

            listBox1.Items.Clear();

            foreach (string malzeme in tumMalzemeler)
            {
                if (malzeme.Contains(aramaMetni)) 
                {
                    listBox1.Items.Add(malzeme);
                }
            }




        }

        List<string> tumMalzemeler = new List<string>();

        private void LoadMalzemeler()
        {
            string connectionString = @"Data Source=.;Initial Catalog=YazLabTarifDb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT MalzemeAdi FROM Malzemeler"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string malzemeAdi = reader["MalzemeAdi"].ToString();
                        tumMalzemeler.Add(malzemeAdi); 
                    }

                    reader.Close();

                    listBox1.Items.AddRange(tumMalzemeler.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void TarifiGetir(string tarifAdi)
        {

            string connectionString = @"Data Source=.;Initial Catalog=YazLabTarifDb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Tarifler WHERE TarifAdi = @TarifAdi"; 

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@TarifAdi", tarifAdi);

                try
                {

                    baglanti.Open();
                    SqlDataReader reader = komut.ExecuteReader();

                    if (reader.Read())
                    {
                        string tarifDetayi = "Tarif Adı: " + reader["TarifAdi"].ToString() + "\n" +
                                             "Malzemeler: " + reader["Malzemeler"].ToString() + "\n" +
                                             "Talimatlar: " + reader["Talimatlar"].ToString();

                        MessageBox.Show(tarifDetayi);
                    }
                    else
                    {
                        MessageBox.Show("Tarif bulunamadı.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarif yüklenirken hata oluştu: " + ex.Message);
                }
            }

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            string connectionString = @"Data Source=.;Initial Catalog=YazLabTarifDb;Integrated Security=True;TrustServerCertificate=True";

            List<string> secilenMalzemeler = new List<string>();
            foreach (var item in listBox2.Items)
            {
                secilenMalzemeler.Add(item.ToString());
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();

                List<int> malzemeIdListesi = new List<int>();

                if (secilenMalzemeler.Count > 0)
                {
                    string malzemeIdSorgu = "SELECT MalzemeID FROM Malzemeler WHERE ";
                    List<string> paramNames = new List<string>();
                    for (int i = 0; i < secilenMalzemeler.Count; i++)
                    {
                        string paramName = $"@malzemeAdi{i}";
                        paramNames.Add(paramName);
                        malzemeIdSorgu += (i == 0 ? "MalzemeAdi = " + paramName : " OR MalzemeAdi = " + paramName);
                    }

                    SqlCommand malzemeCommand = new SqlCommand(malzemeIdSorgu, baglanti);

                    for (int i = 0; i < secilenMalzemeler.Count; i++)
                    {
                        malzemeCommand.Parameters.AddWithValue($"@malzemeAdi{i}", secilenMalzemeler[i]);
                    }

                    using (SqlDataReader reader = malzemeCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            malzemeIdListesi.Add(reader.GetInt32(0));
                        }
                    }
                }

                if (malzemeIdListesi.Count == 0)
                {
                    MessageBox.Show("Seçili malzemelere uygun tarif bulunamadı.");
                    return;
                }



                string tarifSorgu = @"
            SELECT t.TarifID, t.TarifAdi, t.Kategori, t.HazirlamaSuresi, t.TarifMaliyet,
                   COUNT(tm.MalzemeID) AS TarifToplamMalzeme,
                   SUM(CASE WHEN tm.MalzemeID IN (" + string.Join(",", malzemeIdListesi.Select((id, i) => $"@malzemeId{i}")) + @") THEN 1 ELSE 0 END) AS EslesenMalzeme
            FROM Tarifler t
            JOIN TarifMalzemeIliskisi tm ON t.TarifID = tm.TarifID
            GROUP BY t.TarifID, t.TarifAdi, t.Kategori, t.HazirlamaSuresi, t.TarifMaliyet
            HAVING SUM(CASE WHEN tm.MalzemeID IN (" + string.Join(",", malzemeIdListesi.Select((id, i) => $"@malzemeId{i}")) + @") THEN 1 ELSE 0 END) > 0";

                SqlCommand tarifCommand = new SqlCommand(tarifSorgu, baglanti);

                for (int i = 0; i < malzemeIdListesi.Count; i++)
                {
                    tarifCommand.Parameters.AddWithValue($"@malzemeId{i}", malzemeIdListesi[i]);
                }

                SqlDataAdapter tarifAdapter = new SqlDataAdapter(tarifCommand);
                DataTable tarifTable = new DataTable();
                tarifAdapter.Fill(tarifTable);

                tarifTable.Columns.Add("EslesmeYuzdesi", typeof(string));

                foreach (DataRow row in tarifTable.Rows)
                {
                    int tarifToplamMalzeme = Convert.ToInt32(row["TarifToplamMalzeme"]); 
                    int eslesenMalzeme = Convert.ToInt32(row["EslesenMalzeme"]); 

                    decimal eslesmeYuzdesi = tarifToplamMalzeme > 0 ? ((decimal)eslesenMalzeme / tarifToplamMalzeme) * 100 : 0;
                    row["EslesmeYuzdesi"] = $"{eslesmeYuzdesi:0.##}%";
                }

                dataGridView1.DataSource = tarifTable;
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) 
            {
                int tarifID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TarifID"].Value);
                TarifMalzemeleriGoster(tarifID); 
            }

        }

        private void TarifMalzemeleriGoster(int tarifID)
        {
            string connectionString = @"Data Source=.;Initial Catalog=YazLabTarifDb;Integrated Security=True;TrustServerCertificate=True";

            List<string> listBoxMalzemeler = new List<string>();
            foreach (var item in listBox2.Items)
            {
                listBoxMalzemeler.Add(item.ToString().ToLower()); 
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                string sorgu = @"
            SELECT m.MalzemeAdi, tmi.MalzemeMiktar, m.ToplamMiktar, m.MalzemeBirim 
            FROM TarifMalzemeIliskisi tmi
            JOIN Malzemeler m ON tmi.MalzemeID = m.MalzemeID
            WHERE tmi.TarifID = @TarifID";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@TarifID", tarifID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        object cellValue = row.Cells["MalzemeAdi"].Value;
                        if (cellValue != null && cellValue != DBNull.Value)
                        {
                            string malzemeAdi = cellValue.ToString().ToLower(); 
                            if (listBoxMalzemeler.Contains(malzemeAdi))
                            {
                                row.DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu tarife ait malzeme bulunamadı.");
                }
            }

            ConfigureDataGridView2();
        }
        private void ConfigureDataGridView2()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;    
            dataGridView2.AllowUserToResizeRows = false;                              
            dataGridView2.RowHeadersVisible = false;                                  
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;      
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;     
        }


    }

}

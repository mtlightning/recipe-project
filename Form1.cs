using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace YazLabTarifProjesi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=YazLabTarifDb;Integrated Security=True;TrustServerCertificate=True");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verileriGoruntule();
            MalzemeleriYukle();
            MalzemeBirimleriniYukle();

            comboBoxMalzemeler.SelectedIndexChanged += comboBoxMalzemeler_SelectedIndexChanged;
        }


        private void verileriGoruntule()
        {
            try
            {
                string sorgu = "SELECT TarifID,TarifAdi,Kategori,HazirlamaSuresi,Talimatlar,TarifMaliyet FROM Tarifler";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından veri çekerken sorun oldu !" + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }
        private void MalzemeleriYukle()
        {
            try
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("SELECT MalzemeID, MalzemeAdi FROM Malzemeler", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxMalzemeler.DataSource = dt; 
                comboBoxMalzemeler.DisplayMember = "MalzemeAdi"; 
                comboBoxMalzemeler.ValueMember = "MalzemeID"; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzemeleri yüklerken bir hata oluştu! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void MalzemeBirimleriniYukle()
        {
            try
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("SELECT DISTINCT MalzemeBirim FROM Malzemeler", baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxMalzemeBirim.Items.Add(reader["MalzemeBirim"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme birimlerini yüklerken hata oluştu! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxTarifID.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxTarifAdi.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxKategori.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxHazirlamaSuresi.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            richTextBoxTalimat.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxTarifMaliyet.Text = dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();

            int tarifID = Convert.ToInt32(dataGridView1.Rows[secilenSatir].Cells[0].Value);
            MalzemeleriGoruntule(tarifID);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir2 = dataGridView2.SelectedCells[0].RowIndex;
            comboBoxMalzemeler.Text = dataGridView2.Rows[secilenSatir2].Cells[0].Value.ToString();
            textBoxMalzemeMiktar.Text = dataGridView2.Rows[secilenSatir2].Cells[1].Value.ToString();
            comboBoxMalzemeBirim.Text = dataGridView2.Rows[secilenSatir2].Cells[2].Value.ToString();

        }



        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            butonlariTemizle();

        }

        private void butonlariTemizle()
        {
            textBoxTarifID.Text = "";
            textBoxTarifAdi.Text = "";
            textBoxKategori.Text = "";
            textBoxHazirlamaSuresi.Text = "";
            textBoxTarifMaliyet.Text = "";
            richTextBoxTalimat.Text = "";
            textBoxMalzemeID.Text = "";
            comboBoxMalzemeler.Text = "";
            comboBoxMalzemeBirim.Text = "";
            textBoxMalzemeMiktar.Text = "";

        }

        private void MalzemeleriGoruntule(int tarifID)
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
                        decimal malzemeMiktar = Convert.ToDecimal(row.Cells["MalzemeMiktar"].Value);
                        decimal toplamMiktar = Convert.ToDecimal(row.Cells["ToplamMiktar"].Value);

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








        private void buttonTarifEkle_Click(object sender, EventArgs e)
        {


            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Tarifler (TarifAdi, Kategori, HazirlamaSuresi, Talimatlar, TarifMaliyet) VALUES (@P2,@P3,@P4,@P5,@P6); SELECT SCOPE_IDENTITY();", baglanti);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxTarifAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxKategori.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxHazirlamaSuresi.Text);
                sqlCommand.Parameters.AddWithValue("@P5", richTextBoxTalimat.Text);
                sqlCommand.Parameters.AddWithValue("@P6", textBoxTarifMaliyet.Text);

                int tarifID = Convert.ToInt32(sqlCommand.ExecuteScalar());

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        string malzemeAdi = row.Cells[0].Value.ToString();
                        decimal miktar = Convert.ToDecimal(row.Cells[1].Value);

                        SqlCommand malzemeCommand = new SqlCommand("SELECT MalzemeID FROM Malzemeler WHERE MalzemeAdi = @P1", baglanti);
                        malzemeCommand.Parameters.AddWithValue("@P1", malzemeAdi);
                        int malzemeID = Convert.ToInt32(malzemeCommand.ExecuteScalar());

                        SqlCommand iliskiCommand = new SqlCommand("INSERT INTO TarifMalzemeIliskisi (TarifID, MalzemeID, MalzemeMiktar) VALUES (@P1, @P2, @P3)", baglanti);
                        iliskiCommand.Parameters.AddWithValue("@P1", tarifID);
                        iliskiCommand.Parameters.AddWithValue("@P2", malzemeID);
                        iliskiCommand.Parameters.AddWithValue("@P3", miktar);
                        iliskiCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tarif başarıyla eklendi!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanına tarif eklerken hata oluştu !\n " + ex.Message);

            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
            verileriGoruntule();
            butonlariTemizle();
        }

        private void buttonTarifSil_Click(object sender, EventArgs e)
        {
            if (textBoxTarifID.Text.Equals(""))
            {
                MessageBox.Show("Lütfen bir tarif seçiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand1 = new SqlCommand("DELETE FROM Tarifler WHERE TarifID=@P1", baglanti);
                    sqlCommand1.Parameters.AddWithValue("P1", textBoxTarifID.Text);
                    sqlCommand1.ExecuteNonQuery();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından tarif silerken hata oluştu !\n " + ex.Message);
                }

                finally
                {
                    if (baglanti != null)
                        baglanti.Close();
                }
                verileriGoruntule();
                butonlariTemizle();


            }
        }

        private void buttonTairfGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxTarifID.Text.Equals(""))
            {
                MessageBox.Show("Lütfen bir tarif seçiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Tarifler SET TarifAdi = @P1, Kategori =@P2, HazirlamaSuresi = @P3,Talimatlar =@P4,TarifMaliyet = @P5 WHERE TarifID = @P6 ", baglanti);
                    sqlCommand.Parameters.AddWithValue("P1", textBoxTarifAdi.Text);
                    sqlCommand.Parameters.AddWithValue("P2", textBoxKategori.Text);
                    decimal hazirlamaSuresi;
                    if (decimal.TryParse(textBoxHazirlamaSuresi.Text, out hazirlamaSuresi))
                    {
                        sqlCommand.Parameters.AddWithValue("@P3", hazirlamaSuresi);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir hazırlama süresi değeri giriniz!");
                        return;  
                    }



                    sqlCommand.Parameters.AddWithValue("P4", richTextBoxTalimat.Text);
                   
                    decimal tarifMaliyet;
                    if (decimal.TryParse(textBoxTarifMaliyet.Text, out tarifMaliyet))
                    {
                        sqlCommand.Parameters.AddWithValue("P5", textBoxTarifMaliyet.Text);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir maliyet değeri giriniz!");
                        return;
                    }
                    sqlCommand.Parameters.AddWithValue("P6", textBoxTarifID.Text);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanındaki tarif güncellenirken hata oluştu !\n " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                verileriGoruntule();
                butonlariTemizle();
            }




        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonYeniMalzemeEkle_Click(object sender, EventArgs e)
        {
            string MalzemeID = textBoxMalzemeID.Text;
            string MalzemeAdi = textBoxYeniMalzemeAdi.Text;
            string MalzemeBirim = textBoxYeniMalzemeBirim.Text;
            string ToplamMiktar = textBoxToplamMiktar.Text;
            string BirimFiyat = textBoxMalzemeBirimFiyati.Text;


            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Malzemeler (MalzemeID,MalzemeAdi,MalzemeBirim,ToplamMiktar,Birimfiyat) VALUES (@MalzemeID,@MalzemeAdi,@MalzemeBirim,@ToplamMiktar,@BirimFiyat)", baglanti);
                sqlCommand.Parameters.AddWithValue("@MalzemeID", MalzemeID);
                sqlCommand.Parameters.AddWithValue("@MalzemeAdi", MalzemeAdi);
                sqlCommand.Parameters.AddWithValue("@MalzemeBirim", MalzemeBirim);
                sqlCommand.Parameters.AddWithValue("@ToplamMiktar", ToplamMiktar);
                sqlCommand.Parameters.AddWithValue("@BirimFiyat", BirimFiyat);
                sqlCommand.ExecuteNonQuery();

                comboBoxMalzemeler.Items.Add(MalzemeAdi);

                MessageBox.Show("Yeni malzeme veritabanına başarıyla eklendi! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yeni malzeme veritabanına eklenirken hata oluştu! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void buttonMalzemeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxTarifID.Text, out int tarifId))
                {
                    MessageBox.Show("Lütfen geçerli bir Tarif ID'si girin.");
                    return;
                }

                if (comboBoxMalzemeler.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir malzeme seçin.");
                    return; 
                }

                int malzemeId = (int)comboBoxMalzemeler.SelectedValue;

                if (!decimal.TryParse(textBoxMalzemeMiktar.Text, out decimal malzemeMiktar))
                {
                    MessageBox.Show("Lütfen geçerli bir malzeme miktarı girin.");
                    return;
                }

                string query = "INSERT INTO TarifMalzemeIliskisi (TarifID, MalzemeID, MalzemeMiktar) " +
                               "VALUES (@TarifID, @MalzemeID, @MalzemeMiktar)";

                baglanti.Open();

                SqlCommand command = new SqlCommand(query, baglanti);
                command.Parameters.AddWithValue("@TarifID", tarifId);
                command.Parameters.AddWithValue("@MalzemeID", malzemeId);
                command.Parameters.AddWithValue("@MalzemeMiktar", malzemeMiktar);

                command.ExecuteNonQuery();

                MalzemeleriGoruntule(tarifId); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına malzeme eklerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void labelMalzemeMiktar_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }








        private void comboBoxMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMalzemeler.SelectedValue != null)
            {
                int malzemeId = (int)comboBoxMalzemeler.SelectedValue;
                MalzemeBiriminiGetir(malzemeId);
            }
        }

        private void MalzemeBiriminiGetir(int malzemeId)
        {
            try
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("SELECT MalzemeBirim FROM Malzemeler WHERE MalzemeID = @MalzemeID", baglanti);
                command.Parameters.AddWithValue("@MalzemeID", malzemeId);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    comboBoxMalzemeBirim.Text = result.ToString();
                }
                else
                {
                    comboBoxMalzemeBirim.Text = ""; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme birimini getirirken hata oluştu! " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }





        private void buttonMiktarArttir_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];


                string malzemeAdi = selectedRow.Cells["MalzemeAdi"].Value.ToString();
                decimal mevcutMiktar = Convert.ToDecimal(selectedRow.Cells["MalzemeMiktar"].Value);


                decimal artirmaMiktari;


                if (decimal.TryParse(textBoxMalzemeMiktar.Text, out artirmaMiktari) && artirmaMiktari > 0)
                {

                    decimal yeniMiktar = mevcutMiktar + artirmaMiktari;

                    try
                    {

                        baglanti.Open();
                        SqlCommand command = new SqlCommand("UPDATE TarifMalzemeIliskisi SET MalzemeMiktar = @YeniMiktar WHERE MalzemeID = (SELECT MalzemeID FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi)", baglanti);
                        command.Parameters.AddWithValue("@YeniMiktar", yeniMiktar);
                        command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Miktar başarıyla artırıldı!");

                            MalzemeleriGoruntule(Convert.ToInt32(textBoxTarifID.Text));
                        }
                        else
                        {
                            MessageBox.Show("Miktar artırılırken bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanında güncelleme yapılırken bir hata oluştu: " + ex.Message);
                    }
                    finally
                    {
                        if (baglanti.State == ConnectionState.Open)
                            baglanti.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir artırma miktarı girin.");
                }
            }
            else
            {

                MessageBox.Show("Lütfen bir malzeme seçin.");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show(); 


        }

        private async void button2_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show(); 
            
        }
    }
}

namespace YazLabTarifProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            buttonMiktarArttir = new Button();
            comboBoxMalzemeBirim = new ComboBox();
            buttonMalzemeEkle = new Button();
            comboBoxMalzemeler = new ComboBox();
            textBoxMalzemeMiktar = new TextBox();
            labelMalzemeBirim = new Label();
            labelMalzemeAdi = new Label();
            labelMalzemeMiktar = new Label();
            label4 = new Label();
            textBoxToplamMiktar = new TextBox();
            textBoxYeniMalzemeBirim = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxYeniMalzemeAdi = new TextBox();
            buttonYeniMalzemeEkle = new Button();
            panel5 = new Panel();
            textBoxMalzemeID = new TextBox();
            label6 = new Label();
            textBoxMalzemeBirimFiyati = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            richTextBoxMalzeme = new RichTextBox();
            richTextBoxTalimat = new RichTextBox();
            labelTalimat = new Label();
            buttonTemizle = new Button();
            label1 = new Label();
            buttonTairfGuncelle = new Button();
            buttonTarifSil = new Button();
            buttonTarifEkle = new Button();
            textBoxTarifMaliyet = new TextBox();
            labelTalimatlar = new Label();
            textBoxHazirlamaSuresi = new TextBox();
            textBoxKategori = new TextBox();
            textBoxTarifAdi = new TextBox();
            textBoxTarifID = new TextBox();
            labelHaizrlamaSuresi = new Label();
            labelTarifKategori = new Label();
            labelTarifAdi = new Label();
            labeltarifID = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(5, 445);
            panel1.Name = "panel1";
            panel1.Size = new Size(1404, 304);
            panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(857, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(544, 298);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(851, 298);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.DarkSalmon;
            panel4.Controls.Add(buttonMiktarArttir);
            panel4.Controls.Add(comboBoxMalzemeBirim);
            panel4.Controls.Add(buttonMalzemeEkle);
            panel4.Controls.Add(comboBoxMalzemeler);
            panel4.Controls.Add(textBoxMalzemeMiktar);
            panel4.Controls.Add(labelMalzemeBirim);
            panel4.Controls.Add(labelMalzemeAdi);
            panel4.Controls.Add(labelMalzemeMiktar);
            panel4.Location = new Point(5, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(393, 213);
            panel4.TabIndex = 2;
            // 
            // buttonMiktarArttir
            // 
            buttonMiktarArttir.BackColor = Color.Gold;
            buttonMiktarArttir.Location = new Point(186, 138);
            buttonMiktarArttir.Name = "buttonMiktarArttir";
            buttonMiktarArttir.Size = new Size(204, 45);
            buttonMiktarArttir.TabIndex = 31;
            buttonMiktarArttir.Text = "Veritabanına Malzeme Ekle";
            buttonMiktarArttir.UseVisualStyleBackColor = false;
            buttonMiktarArttir.Click += buttonMiktarArttir_Click;
            // 
            // comboBoxMalzemeBirim
            // 
            comboBoxMalzemeBirim.FormattingEnabled = true;
            comboBoxMalzemeBirim.Location = new Point(250, 50);
            comboBoxMalzemeBirim.Name = "comboBoxMalzemeBirim";
            comboBoxMalzemeBirim.Size = new Size(136, 28);
            comboBoxMalzemeBirim.TabIndex = 30;
            // 
            // buttonMalzemeEkle
            // 
            buttonMalzemeEkle.BackColor = Color.Gold;
            buttonMalzemeEkle.Location = new Point(3, 138);
            buttonMalzemeEkle.Name = "buttonMalzemeEkle";
            buttonMalzemeEkle.Size = new Size(180, 45);
            buttonMalzemeEkle.TabIndex = 28;
            buttonMalzemeEkle.Text = "Malzeme Ekle";
            buttonMalzemeEkle.UseVisualStyleBackColor = false;
            buttonMalzemeEkle.Click += buttonMalzemeEkle_Click;
            // 
            // comboBoxMalzemeler
            // 
            comboBoxMalzemeler.FormattingEnabled = true;
            comboBoxMalzemeler.Location = new Point(250, 14);
            comboBoxMalzemeler.Name = "comboBoxMalzemeler";
            comboBoxMalzemeler.Size = new Size(136, 28);
            comboBoxMalzemeler.TabIndex = 24;
            // 
            // textBoxMalzemeMiktar
            // 
            textBoxMalzemeMiktar.Location = new Point(250, 92);
            textBoxMalzemeMiktar.Name = "textBoxMalzemeMiktar";
            textBoxMalzemeMiktar.Size = new Size(136, 27);
            textBoxMalzemeMiktar.TabIndex = 20;
            // 
            // labelMalzemeBirim
            // 
            labelMalzemeBirim.AutoSize = true;
            labelMalzemeBirim.Font = new Font("Century", 12F);
            labelMalzemeBirim.Location = new Point(6, 50);
            labelMalzemeBirim.Name = "labelMalzemeBirim";
            labelMalzemeBirim.Size = new Size(165, 23);
            labelMalzemeBirim.TabIndex = 23;
            labelMalzemeBirim.Text = "Malzeme Birim :";
            // 
            // labelMalzemeAdi
            // 
            labelMalzemeAdi.AutoSize = true;
            labelMalzemeAdi.Font = new Font("Century", 12F);
            labelMalzemeAdi.Location = new Point(3, 13);
            labelMalzemeAdi.Name = "labelMalzemeAdi";
            labelMalzemeAdi.Size = new Size(143, 23);
            labelMalzemeAdi.TabIndex = 22;
            labelMalzemeAdi.Text = "Malzeme Adı :";
            // 
            // labelMalzemeMiktar
            // 
            labelMalzemeMiktar.AutoSize = true;
            labelMalzemeMiktar.Font = new Font("Century", 12F);
            labelMalzemeMiktar.Location = new Point(6, 92);
            labelMalzemeMiktar.Name = "labelMalzemeMiktar";
            labelMalzemeMiktar.Size = new Size(177, 23);
            labelMalzemeMiktar.TabIndex = 19;
            labelMalzemeMiktar.Text = "Malzeme Miktar :";
            labelMalzemeMiktar.Click += labelMalzemeMiktar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F);
            label4.Location = new Point(-3, 108);
            label4.Name = "label4";
            label4.Size = new Size(252, 23);
            label4.TabIndex = 27;
            label4.Text = "Malzeme Toplam Miktar :";
            // 
            // textBoxToplamMiktar
            // 
            textBoxToplamMiktar.Location = new Point(258, 104);
            textBoxToplamMiktar.Name = "textBoxToplamMiktar";
            textBoxToplamMiktar.Size = new Size(125, 27);
            textBoxToplamMiktar.TabIndex = 26;
            // 
            // textBoxYeniMalzemeBirim
            // 
            textBoxYeniMalzemeBirim.Location = new Point(258, 71);
            textBoxYeniMalzemeBirim.Name = "textBoxYeniMalzemeBirim";
            textBoxYeniMalzemeBirim.Size = new Size(125, 27);
            textBoxYeniMalzemeBirim.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F);
            label3.Location = new Point(3, 71);
            label3.Name = "label3";
            label3.Size = new Size(165, 23);
            label3.TabIndex = 24;
            label3.Text = "Malzeme Birim :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F);
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 24;
            label2.Text = "Malzeme Adi :";
            // 
            // textBoxYeniMalzemeAdi
            // 
            textBoxYeniMalzemeAdi.Location = new Point(258, 38);
            textBoxYeniMalzemeAdi.Name = "textBoxYeniMalzemeAdi";
            textBoxYeniMalzemeAdi.Size = new Size(125, 27);
            textBoxYeniMalzemeAdi.TabIndex = 24;
            // 
            // buttonYeniMalzemeEkle
            // 
            buttonYeniMalzemeEkle.BackColor = Color.Pink;
            buttonYeniMalzemeEkle.Location = new Point(118, 175);
            buttonYeniMalzemeEkle.Name = "buttonYeniMalzemeEkle";
            buttonYeniMalzemeEkle.Size = new Size(150, 37);
            buttonYeniMalzemeEkle.TabIndex = 0;
            buttonYeniMalzemeEkle.Text = "Yeni Malzeme Ekle";
            buttonYeniMalzemeEkle.UseVisualStyleBackColor = false;
            buttonYeniMalzemeEkle.Click += buttonYeniMalzemeEkle_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.MediumSpringGreen;
            panel5.Controls.Add(textBoxMalzemeID);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(textBoxMalzemeBirimFiyati);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(buttonYeniMalzemeEkle);
            panel5.Controls.Add(textBoxToplamMiktar);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textBoxYeniMalzemeAdi);
            panel5.Controls.Add(textBoxYeniMalzemeBirim);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(8, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 215);
            panel5.TabIndex = 20;
            // 
            // textBoxMalzemeID
            // 
            textBoxMalzemeID.Location = new Point(258, 5);
            textBoxMalzemeID.Name = "textBoxMalzemeID";
            textBoxMalzemeID.Size = new Size(125, 27);
            textBoxMalzemeID.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F);
            label6.Location = new Point(3, 5);
            label6.Name = "label6";
            label6.Size = new Size(136, 23);
            label6.TabIndex = 30;
            label6.Text = "Malzeme ID :";
            // 
            // textBoxMalzemeBirimFiyati
            // 
            textBoxMalzemeBirimFiyati.Location = new Point(258, 140);
            textBoxMalzemeBirimFiyati.Name = "textBoxMalzemeBirimFiyati";
            textBoxMalzemeBirimFiyati.Size = new Size(125, 27);
            textBoxMalzemeBirimFiyati.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F);
            label5.Location = new Point(3, 144);
            label5.Name = "label5";
            label5.Size = new Size(226, 23);
            label5.TabIndex = 28;
            label5.Text = "Malzeme Birim Fiyatı :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(richTextBoxMalzeme);
            panel3.Controls.Add(richTextBoxTalimat);
            panel3.Controls.Add(labelTalimat);
            panel3.Controls.Add(buttonTemizle);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(buttonTairfGuncelle);
            panel3.Controls.Add(buttonTarifSil);
            panel3.Controls.Add(buttonTarifEkle);
            panel3.Controls.Add(textBoxTarifMaliyet);
            panel3.Controls.Add(labelTalimatlar);
            panel3.Controls.Add(textBoxHazirlamaSuresi);
            panel3.Controls.Add(textBoxKategori);
            panel3.Controls.Add(textBoxTarifAdi);
            panel3.Controls.Add(textBoxTarifID);
            panel3.Controls.Add(labelHaizrlamaSuresi);
            panel3.Controls.Add(labelTarifKategori);
            panel3.Controls.Add(labelTarifAdi);
            panel3.Controls.Add(labeltarifID);
            panel3.Font = new Font("Century", 9F);
            panel3.Location = new Point(404, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(541, 434);
            panel3.TabIndex = 1;
            // 
            // richTextBoxMalzeme
            // 
            richTextBoxMalzeme.Location = new Point(310, 233);
            richTextBoxMalzeme.Name = "richTextBoxMalzeme";
            richTextBoxMalzeme.Size = new Size(213, 43);
            richTextBoxMalzeme.TabIndex = 18;
            richTextBoxMalzeme.Text = "";
            // 
            // richTextBoxTalimat
            // 
            richTextBoxTalimat.Location = new Point(137, 282);
            richTextBoxTalimat.Name = "richTextBoxTalimat";
            richTextBoxTalimat.Size = new Size(386, 65);
            richTextBoxTalimat.TabIndex = 0;
            richTextBoxTalimat.Text = "";
            // 
            // labelTalimat
            // 
            labelTalimat.AutoSize = true;
            labelTalimat.Font = new Font("Century", 12F);
            labelTalimat.Location = new Point(3, 292);
            labelTalimat.Name = "labelTalimat";
            labelTalimat.Size = new Size(121, 23);
            labelTalimat.TabIndex = 17;
            labelTalimat.Text = "Talimatlar :";
            // 
            // buttonTemizle
            // 
            buttonTemizle.BackColor = SystemColors.Info;
            buttonTemizle.Font = new Font("Century", 9F);
            buttonTemizle.Location = new Point(383, 355);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(114, 64);
            buttonTemizle.TabIndex = 15;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = false;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F);
            label1.Location = new Point(3, 233);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 13;
            label1.Text = "Malzemeler :";
            // 
            // buttonTairfGuncelle
            // 
            buttonTairfGuncelle.BackColor = SystemColors.Info;
            buttonTairfGuncelle.Font = new Font("Century", 9F);
            buttonTairfGuncelle.Location = new Point(263, 353);
            buttonTairfGuncelle.Name = "buttonTairfGuncelle";
            buttonTairfGuncelle.Size = new Size(114, 64);
            buttonTairfGuncelle.TabIndex = 12;
            buttonTairfGuncelle.Text = "Tarif Güncelle";
            buttonTairfGuncelle.UseVisualStyleBackColor = false;
            buttonTairfGuncelle.Click += buttonTairfGuncelle_Click;
            // 
            // buttonTarifSil
            // 
            buttonTarifSil.BackColor = SystemColors.Info;
            buttonTarifSil.Font = new Font("Century", 9F);
            buttonTarifSil.Location = new Point(157, 353);
            buttonTarifSil.Name = "buttonTarifSil";
            buttonTarifSil.Size = new Size(100, 64);
            buttonTarifSil.TabIndex = 11;
            buttonTarifSil.Text = "Tarif Sil";
            buttonTarifSil.UseVisualStyleBackColor = false;
            buttonTarifSil.Click += buttonTarifSil_Click;
            // 
            // buttonTarifEkle
            // 
            buttonTarifEkle.BackColor = SystemColors.Info;
            buttonTarifEkle.Font = new Font("Century", 9F);
            buttonTarifEkle.Location = new Point(46, 353);
            buttonTarifEkle.Name = "buttonTarifEkle";
            buttonTarifEkle.Size = new Size(105, 64);
            buttonTarifEkle.TabIndex = 10;
            buttonTarifEkle.Text = "Tarifi ve Malzemeleri Ekle";
            buttonTarifEkle.UseVisualStyleBackColor = false;
            buttonTarifEkle.Click += buttonTarifEkle_Click;
            // 
            // textBoxTarifMaliyet
            // 
            textBoxTarifMaliyet.Location = new Point(372, 188);
            textBoxTarifMaliyet.Name = "textBoxTarifMaliyet";
            textBoxTarifMaliyet.Size = new Size(151, 26);
            textBoxTarifMaliyet.TabIndex = 9;
            // 
            // labelTalimatlar
            // 
            labelTalimatlar.AutoSize = true;
            labelTalimatlar.Font = new Font("Century", 12F);
            labelTalimatlar.Location = new Point(3, 187);
            labelTalimatlar.Name = "labelTalimatlar";
            labelTalimatlar.Size = new Size(93, 23);
            labelTalimatlar.TabIndex = 8;
            labelTalimatlar.Text = "Maliyet :";
            // 
            // textBoxHazirlamaSuresi
            // 
            textBoxHazirlamaSuresi.Location = new Point(372, 145);
            textBoxHazirlamaSuresi.Name = "textBoxHazirlamaSuresi";
            textBoxHazirlamaSuresi.Size = new Size(151, 26);
            textBoxHazirlamaSuresi.TabIndex = 7;
            // 
            // textBoxKategori
            // 
            textBoxKategori.Location = new Point(372, 103);
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.Size = new Size(151, 26);
            textBoxKategori.TabIndex = 6;
            // 
            // textBoxTarifAdi
            // 
            textBoxTarifAdi.Location = new Point(372, 59);
            textBoxTarifAdi.Name = "textBoxTarifAdi";
            textBoxTarifAdi.Size = new Size(151, 26);
            textBoxTarifAdi.TabIndex = 5;
            // 
            // textBoxTarifID
            // 
            textBoxTarifID.Location = new Point(372, 18);
            textBoxTarifID.Name = "textBoxTarifID";
            textBoxTarifID.Size = new Size(151, 26);
            textBoxTarifID.TabIndex = 4;
            // 
            // labelHaizrlamaSuresi
            // 
            labelHaizrlamaSuresi.AutoSize = true;
            labelHaizrlamaSuresi.Font = new Font("Century", 12F);
            labelHaizrlamaSuresi.Location = new Point(3, 144);
            labelHaizrlamaSuresi.Name = "labelHaizrlamaSuresi";
            labelHaizrlamaSuresi.Size = new Size(186, 23);
            labelHaizrlamaSuresi.TabIndex = 3;
            labelHaizrlamaSuresi.Text = "Hazırlama Süresi :";
            // 
            // labelTarifKategori
            // 
            labelTarifKategori.AutoSize = true;
            labelTarifKategori.Font = new Font("Century", 12F);
            labelTarifKategori.Location = new Point(3, 102);
            labelTarifKategori.Name = "labelTarifKategori";
            labelTarifKategori.Size = new Size(103, 23);
            labelTarifKategori.TabIndex = 2;
            labelTarifKategori.Text = "Kategori :";
            // 
            // labelTarifAdi
            // 
            labelTarifAdi.AutoSize = true;
            labelTarifAdi.Font = new Font("Century", 12F);
            labelTarifAdi.Location = new Point(3, 58);
            labelTarifAdi.Name = "labelTarifAdi";
            labelTarifAdi.Size = new Size(105, 23);
            labelTarifAdi.TabIndex = 1;
            labelTarifAdi.Text = "Tarif Adi :";
            // 
            // labeltarifID
            // 
            labeltarifID.AutoSize = true;
            labeltarifID.Font = new Font("Century", 12F);
            labeltarifID.Location = new Point(3, 17);
            labeltarifID.Name = "labeltarifID";
            labeltarifID.Size = new Size(98, 23);
            labeltarifID.TabIndex = 0;
            labeltarifID.Text = "Tarif ID :";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(982, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 437);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(951, 8);
            button1.Name = "button1";
            button1.Size = new Size(446, 214);
            button1.TabIndex = 21;
            button1.Text = "MALZEMELERE GÖRE YEMEK TARİFİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(951, 225);
            button2.Name = "button2";
            button2.Size = new Size(446, 217);
            button2.TabIndex = 22;
            button2.Text = "TARİF ARAMA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 747);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMRE-METE";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel4;
        private DataGridView dataGridView2;
        private Label labelMalzemeBirim;
        private Label labelMalzemeAdi;
        private Label labelMalzemeMiktar;
        private TextBox textBoxMalzemeMiktar;
        private TextBox textBoxYeniMalzemeBirim;
        private Label label3;
        private Label label2;
        private TextBox textBoxYeniMalzemeAdi;
        private Button buttonYeniMalzemeEkle;
        private ComboBox comboBoxMalzemeler;
        private Label label4;
        private TextBox textBoxToplamMiktar;
        private Panel panel5;
        private Button buttonMalzemeEkle;
        private Panel panel3;
        private RichTextBox richTextBoxMalzeme;
        private RichTextBox richTextBoxTalimat;
        private Label labelTalimat;
        private Button buttonTemizle;
        private Label label1;
        private Button buttonTairfGuncelle;
        private Button buttonTarifSil;
        private Button buttonTarifEkle;
        private TextBox textBoxTarifMaliyet;
        private Label labelTalimatlar;
        private TextBox textBoxHazirlamaSuresi;
        private TextBox textBoxKategori;
        private TextBox textBoxTarifAdi;
        private TextBox textBoxTarifID;
        private Label labelHaizrlamaSuresi;
        private Label labelTarifKategori;
        private Label labelTarifAdi;
        private Label labeltarifID;
        private Panel panel2;
        private Label label5;
        private TextBox textBoxMalzemeBirimFiyati;
        private TextBox textBoxMalzemeID;
        private Label label6;
        private ComboBox comboBoxMalzemeBirim;
        private Button buttonMiktarArttir;
        private Button button1;
        private Button button2;
    }
}

namespace YazLabTarifProjesi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            listBox1 = new ListBox();
            controller1BindingSource = new BindingSource(components);
            button1 = new Button();
            listBox2 = new ListBox();
            button2 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controller1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1385, 346);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 374);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 2;
            label1.Text = "MALZEME SEÇİM BÖLÜMÜ";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(15, 437);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(254, 284);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // controller1BindingSource
            // 
            controller1BindingSource.DataSource = typeof(Controllers.Controller1);
            // 
            // button1
            // 
            button1.BackColor = Color.Cornsilk;
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(275, 404);
            button1.Name = "button1";
            button1.Size = new Size(208, 26);
            button1.TabIndex = 4;
            button1.Text = "MALZEMELERİ SEÇ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(275, 436);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(208, 244);
            listBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Cornsilk;
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(275, 686);
            button2.Name = "button2";
            button2.Size = new Size(208, 33);
            button2.TabIndex = 6;
            button2.Text = "MALZEMELERİ SİL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Cornsilk;
            button4.ForeColor = Color.DarkMagenta;
            button4.Location = new Point(489, 405);
            button4.Name = "button4";
            button4.Size = new Size(208, 314);
            button4.TabIndex = 10;
            button4.Text = "TARİFLERİ GÖSTER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(703, 404);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(694, 315);
            dataGridView2.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1409, 747);
            Controls.Add(dataGridView2);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            ForeColor = Color.DarkBlue;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MALZEMEYE GÖRE TARİF AYARLAMA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)controller1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ListBox listBox1;
        private BindingSource controller1BindingSource;
        private Button button1;
        private ListBox listBox2;
        private Button button2;
        private TextBox textBox1;
        private Button button4;
        private DataGridView dataGridView2;
    }
}
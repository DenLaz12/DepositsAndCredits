namespace LokatyOrazKredyty_LazarenkoDenys51064
{
    partial class Systematyczne_oszczedzanie
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnWyjścieZprogramu = new System.Windows.Forms.Button();
            this.btnPrzejdżDoMenuZlokat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnGraficznaWizualizacja = new System.Windows.Forms.Button();
            this.btnTabelarycznaWizualizacja = new System.Windows.Forms.Button();
            this.btnObliczeniePrzyszłejWartości = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrzyszłaWartość = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbWysokośćRaty = new System.Windows.Forms.GroupBox();
            this.txtStałaR = new System.Windows.Forms.TextBox();
            this.rdbKoniec = new System.Windows.Forms.RadioButton();
            this.rdbPoczątek = new System.Windows.Forms.RadioButton();
            this.gbCzęstośćKapitalizacjiOdsetek = new System.Windows.Forms.GroupBox();
            this.rdbCoMiesiąc = new System.Windows.Forms.RadioButton();
            this.rdbCoKwartal = new System.Windows.Forms.RadioButton();
            this.rdbCoPółRoku = new System.Windows.Forms.RadioButton();
            this.rdbRazWroku = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRocznaStopaProcentowa = new System.Windows.Forms.ComboBox();
            this.dgvTabelarycznaWizualizacja = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbWysokośćRaty.SuspendLayout();
            this.gbCzęstośćKapitalizacjiOdsetek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelarycznaWizualizacja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWyjścieZprogramu
            // 
            this.btnWyjścieZprogramu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWyjścieZprogramu.Location = new System.Drawing.Point(14, 38);
            this.btnWyjścieZprogramu.Name = "btnWyjścieZprogramu";
            this.btnWyjścieZprogramu.Size = new System.Drawing.Size(150, 37);
            this.btnWyjścieZprogramu.TabIndex = 5;
            this.btnWyjścieZprogramu.Text = "Wyjście z programu";
            this.btnWyjścieZprogramu.UseVisualStyleBackColor = true;
            this.btnWyjścieZprogramu.Click += new System.EventHandler(this.btnWyjścieZprogramu_Click);
            // 
            // btnPrzejdżDoMenuZlokat
            // 
            this.btnPrzejdżDoMenuZlokat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrzejdżDoMenuZlokat.Location = new System.Drawing.Point(14, 89);
            this.btnPrzejdżDoMenuZlokat.Name = "btnPrzejdżDoMenuZlokat";
            this.btnPrzejdżDoMenuZlokat.Size = new System.Drawing.Size(150, 53);
            this.btnPrzejdżDoMenuZlokat.TabIndex = 16;
            this.btnPrzejdżDoMenuZlokat.Text = "Przejdż do formularza kalkulacje finansowe";
            this.btnPrzejdżDoMenuZlokat.UseVisualStyleBackColor = true;
            this.btnPrzejdżDoMenuZlokat.Click += new System.EventHandler(this.btnPrzejdżDoMenuZlokat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetuj);
            this.panel1.Controls.Add(this.btnGraficznaWizualizacja);
            this.panel1.Controls.Add(this.btnTabelarycznaWizualizacja);
            this.panel1.Controls.Add(this.btnObliczeniePrzyszłejWartości);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPrzyszłaWartość);
            this.panel1.Controls.Add(this.btnWyjścieZprogramu);
            this.panel1.Controls.Add(this.btnPrzejdżDoMenuZlokat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(671, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 615);
            this.panel1.TabIndex = 17;
            // 
            // btnResetuj
            // 
            this.btnResetuj.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetuj.Location = new System.Drawing.Point(14, 418);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(150, 44);
            this.btnResetuj.TabIndex = 23;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // btnGraficznaWizualizacja
            // 
            this.btnGraficznaWizualizacja.AutoSize = true;
            this.btnGraficznaWizualizacja.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGraficznaWizualizacja.Location = new System.Drawing.Point(14, 359);
            this.btnGraficznaWizualizacja.Name = "btnGraficznaWizualizacja";
            this.btnGraficznaWizualizacja.Size = new System.Drawing.Size(153, 44);
            this.btnGraficznaWizualizacja.TabIndex = 22;
            this.btnGraficznaWizualizacja.Text = "Graficzna wizualizacja ";
            this.btnGraficznaWizualizacja.UseVisualStyleBackColor = true;
            this.btnGraficznaWizualizacja.Click += new System.EventHandler(this.btnGraficznaWizualizacja_Click);
            // 
            // btnTabelarycznaWizualizacja
            // 
            this.btnTabelarycznaWizualizacja.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTabelarycznaWizualizacja.Location = new System.Drawing.Point(14, 296);
            this.btnTabelarycznaWizualizacja.Name = "btnTabelarycznaWizualizacja";
            this.btnTabelarycznaWizualizacja.Size = new System.Drawing.Size(150, 42);
            this.btnTabelarycznaWizualizacja.TabIndex = 21;
            this.btnTabelarycznaWizualizacja.Text = "Tabelaryczna wizualizacja ";
            this.btnTabelarycznaWizualizacja.UseVisualStyleBackColor = true;
            this.btnTabelarycznaWizualizacja.Click += new System.EventHandler(this.btnTabelarycznaWizualizacja_Click);
            // 
            // btnObliczeniePrzyszłejWartości
            // 
            this.btnObliczeniePrzyszłejWartości.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnObliczeniePrzyszłejWartości.Location = new System.Drawing.Point(14, 232);
            this.btnObliczeniePrzyszłejWartości.Name = "btnObliczeniePrzyszłejWartości";
            this.btnObliczeniePrzyszłejWartości.Size = new System.Drawing.Size(150, 46);
            this.btnObliczeniePrzyszłejWartości.TabIndex = 20;
            this.btnObliczeniePrzyszłejWartości.Text = "Obliczenie przyszłej wartości Knmr";
            this.btnObliczeniePrzyszłejWartości.UseVisualStyleBackColor = true;
            this.btnObliczeniePrzyszłejWartości.Click += new System.EventHandler(this.btnObliczeniePrzyszłejWartości_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Przyszła wartość Knmr";
            // 
            // txtPrzyszłaWartość
            // 
            this.txtPrzyszłaWartość.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrzyszłaWartość.Location = new System.Drawing.Point(14, 200);
            this.txtPrzyszłaWartość.Name = "txtPrzyszłaWartość";
            this.txtPrzyszłaWartość.Size = new System.Drawing.Size(150, 26);
            this.txtPrzyszłaWartość.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbWysokośćRaty);
            this.panel2.Controls.Add(this.gbCzęstośćKapitalizacjiOdsetek);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtN);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtK);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbRocznaStopaProcentowa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 615);
            this.panel2.TabIndex = 18;
            // 
            // gbWysokośćRaty
            // 
            this.gbWysokośćRaty.Controls.Add(this.txtStałaR);
            this.gbWysokośćRaty.Controls.Add(this.rdbKoniec);
            this.gbWysokośćRaty.Controls.Add(this.rdbPoczątek);
            this.gbWysokośćRaty.Location = new System.Drawing.Point(7, 399);
            this.gbWysokośćRaty.Name = "gbWysokośćRaty";
            this.gbWysokośćRaty.Size = new System.Drawing.Size(179, 146);
            this.gbWysokośćRaty.TabIndex = 12;
            this.gbWysokośćRaty.TabStop = false;
            this.gbWysokośćRaty.Text = "Wysokość raty systematycznego oszczędzania";
            // 
            // txtStałaR
            // 
            this.txtStałaR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStałaR.Location = new System.Drawing.Point(12, 106);
            this.txtStałaR.Name = "txtStałaR";
            this.txtStałaR.Size = new System.Drawing.Size(138, 26);
            this.txtStałaR.TabIndex = 5;
            // 
            // rdbKoniec
            // 
            this.rdbKoniec.AutoSize = true;
            this.rdbKoniec.Location = new System.Drawing.Point(19, 81);
            this.rdbKoniec.Name = "rdbKoniec";
            this.rdbKoniec.Size = new System.Drawing.Size(63, 19);
            this.rdbKoniec.TabIndex = 1;
            this.rdbKoniec.TabStop = true;
            this.rdbKoniec.Text = "Koniec";
            this.rdbKoniec.UseVisualStyleBackColor = true;
            // 
            // rdbPoczątek
            // 
            this.rdbPoczątek.AutoSize = true;
            this.rdbPoczątek.Location = new System.Drawing.Point(19, 55);
            this.rdbPoczątek.Name = "rdbPoczątek";
            this.rdbPoczątek.Size = new System.Drawing.Size(72, 19);
            this.rdbPoczątek.TabIndex = 0;
            this.rdbPoczątek.TabStop = true;
            this.rdbPoczątek.Text = "Początek";
            this.rdbPoczątek.UseVisualStyleBackColor = true;
            // 
            // gbCzęstośćKapitalizacjiOdsetek
            // 
            this.gbCzęstośćKapitalizacjiOdsetek.Controls.Add(this.rdbCoMiesiąc);
            this.gbCzęstośćKapitalizacjiOdsetek.Controls.Add(this.rdbCoKwartal);
            this.gbCzęstośćKapitalizacjiOdsetek.Controls.Add(this.rdbCoPółRoku);
            this.gbCzęstośćKapitalizacjiOdsetek.Controls.Add(this.rdbRazWroku);
            this.gbCzęstośćKapitalizacjiOdsetek.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCzęstośćKapitalizacjiOdsetek.Location = new System.Drawing.Point(7, 242);
            this.gbCzęstośćKapitalizacjiOdsetek.Name = "gbCzęstośćKapitalizacjiOdsetek";
            this.gbCzęstośćKapitalizacjiOdsetek.Size = new System.Drawing.Size(179, 142);
            this.gbCzęstośćKapitalizacjiOdsetek.TabIndex = 11;
            this.gbCzęstośćKapitalizacjiOdsetek.TabStop = false;
            this.gbCzęstośćKapitalizacjiOdsetek.Text = "Częstość kapitalizacji odsetek m";
            // 
            // rdbCoMiesiąc
            // 
            this.rdbCoMiesiąc.AutoSize = true;
            this.rdbCoMiesiąc.Location = new System.Drawing.Point(19, 108);
            this.rdbCoMiesiąc.Name = "rdbCoMiesiąc";
            this.rdbCoMiesiąc.Size = new System.Drawing.Size(82, 19);
            this.rdbCoMiesiąc.TabIndex = 3;
            this.rdbCoMiesiąc.TabStop = true;
            this.rdbCoMiesiąc.Text = "Co miesiąc";
            this.rdbCoMiesiąc.UseVisualStyleBackColor = true;
            // 
            // rdbCoKwartal
            // 
            this.rdbCoKwartal.AutoSize = true;
            this.rdbCoKwartal.Location = new System.Drawing.Point(19, 81);
            this.rdbCoKwartal.Name = "rdbCoKwartal";
            this.rdbCoKwartal.Size = new System.Drawing.Size(81, 19);
            this.rdbCoKwartal.TabIndex = 2;
            this.rdbCoKwartal.TabStop = true;
            this.rdbCoKwartal.Text = "Co kwartal";
            this.rdbCoKwartal.UseVisualStyleBackColor = true;
            // 
            // rdbCoPółRoku
            // 
            this.rdbCoPółRoku.AutoSize = true;
            this.rdbCoPółRoku.Location = new System.Drawing.Point(19, 54);
            this.rdbCoPółRoku.Name = "rdbCoPółRoku";
            this.rdbCoPółRoku.Size = new System.Drawing.Size(87, 19);
            this.rdbCoPółRoku.TabIndex = 1;
            this.rdbCoPółRoku.TabStop = true;
            this.rdbCoPółRoku.Text = "Co pół roku";
            this.rdbCoPółRoku.UseVisualStyleBackColor = true;
            // 
            // rdbRazWroku
            // 
            this.rdbRazWroku.AutoSize = true;
            this.rdbRazWroku.Location = new System.Drawing.Point(19, 31);
            this.rdbRazWroku.Name = "rdbRazWroku";
            this.rdbRazWroku.Size = new System.Drawing.Size(83, 19);
            this.rdbRazWroku.TabIndex = 0;
            this.rdbRazWroku.TabStop = true;
            this.rdbRazWroku.Text = "Raz w roku";
            this.rdbRazWroku.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wysokość rocznej \r\nstopy procentowej p";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtN.Location = new System.Drawing.Point(7, 111);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(179, 26);
            this.txtN.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liczba lat lokaty n";
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtK.Location = new System.Drawing.Point(7, 43);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(179, 26);
            this.txtK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wysokość lokaty kapitalowej K";
            // 
            // cmbRocznaStopaProcentowa
            // 
            this.cmbRocznaStopaProcentowa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbRocznaStopaProcentowa.FormattingEnabled = true;
            this.cmbRocznaStopaProcentowa.Items.AddRange(new object[] {
            "2,0%",
            "2,1%",
            "2,2%",
            "2,3%",
            "2,4%",
            "2,5%",
            "2,8%",
            "3,3%",
            "3,7%",
            "4,2%",
            "4,9%",
            "5,4%",
            "6,0%",
            "6,5%",
            "6,9%",
            "7,3%",
            "7,7%",
            "8,1%",
            "8,5%"});
            this.cmbRocznaStopaProcentowa.Location = new System.Drawing.Point(7, 193);
            this.cmbRocznaStopaProcentowa.Name = "cmbRocznaStopaProcentowa";
            this.cmbRocznaStopaProcentowa.Size = new System.Drawing.Size(179, 27);
            this.cmbRocznaStopaProcentowa.TabIndex = 0;
            this.cmbRocznaStopaProcentowa.Text = "Wybierz stopę procentową";
            // 
            // dgvTabelarycznaWizualizacja
            // 
            this.dgvTabelarycznaWizualizacja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelarycznaWizualizacja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTabelarycznaWizualizacja.Location = new System.Drawing.Point(211, 127);
            this.dgvTabelarycznaWizualizacja.Name = "dgvTabelarycznaWizualizacja";
            this.dgvTabelarycznaWizualizacja.RowHeadersWidth = 82;
            this.dgvTabelarycznaWizualizacja.Size = new System.Drawing.Size(449, 346);
            this.dgvTabelarycznaWizualizacja.TabIndex = 19;
            this.dgvTabelarycznaWizualizacja.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(315, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Systematyczne oszczędzanie";
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(211, 127);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Stan konta Knmr";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(449, 346);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numer okresu lokaty";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Stan konta na początku okresu lokaty";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Odsetki za dany okres lokaty";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stan konta na koniec okresu lokaty";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Systematyczne_oszczedzanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 615);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTabelarycznaWizualizacja);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Systematyczne_oszczedzanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systematyczne_oszczedzanie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbWysokośćRaty.ResumeLayout(false);
            this.gbWysokośćRaty.PerformLayout();
            this.gbCzęstośćKapitalizacjiOdsetek.ResumeLayout(false);
            this.gbCzęstośćKapitalizacjiOdsetek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelarycznaWizualizacja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWyjścieZprogramu;
        private System.Windows.Forms.Button btnPrzejdżDoMenuZlokat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRocznaStopaProcentowa;
        private System.Windows.Forms.Button btnObliczeniePrzyszłejWartości;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrzyszłaWartość;
        private System.Windows.Forms.GroupBox gbWysokośćRaty;
        private System.Windows.Forms.TextBox txtStałaR;
        private System.Windows.Forms.RadioButton rdbKoniec;
        private System.Windows.Forms.RadioButton rdbPoczątek;
        private System.Windows.Forms.GroupBox gbCzęstośćKapitalizacjiOdsetek;
        private System.Windows.Forms.RadioButton rdbCoMiesiąc;
        private System.Windows.Forms.RadioButton rdbCoKwartal;
        private System.Windows.Forms.RadioButton rdbCoPółRoku;
        private System.Windows.Forms.RadioButton rdbRazWroku;
        private System.Windows.Forms.DataGridView dgvTabelarycznaWizualizacja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnTabelarycznaWizualizacja;
        private System.Windows.Forms.Button btnGraficznaWizualizacja;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
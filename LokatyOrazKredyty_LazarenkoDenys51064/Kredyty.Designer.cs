namespace LokatyOrazKredyty_LazarenkoDenys51064
{
    partial class Kredyty
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGraficznaPrezentacjaSpłatyKredytu = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnTabelaryczneRozliczenieSpłaty = new System.Windows.Forms.Button();
            this.gbSpłataKredytuWratach = new System.Windows.Forms.GroupBox();
            this.rdbRosnąca = new System.Windows.Forms.RadioButton();
            this.rdbMalejąca = new System.Windows.Forms.RadioButton();
            this.rdbStała = new System.Windows.Forms.RadioButton();
            this.gbLiczbaRatWrokuM = new System.Windows.Forms.GroupBox();
            this.rdbCoKwartal = new System.Windows.Forms.RadioButton();
            this.rdbCoMiesiąc = new System.Windows.Forms.RadioButton();
            this.rdbCoPółRoku = new System.Windows.Forms.RadioButton();
            this.rdbRazWroku = new System.Windows.Forms.RadioButton();
            this.cmbRocznaStopaProcentowa = new System.Windows.Forms.ComboBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSpłataR = new System.Windows.Forms.TextBox();
            this.dgvTabelaryczneRozliczenieKredytu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrzejdżDoMenu = new System.Windows.Forms.Button();
            this.btnWyjścieZprogramu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbSpłataKredytuWratach.SuspendLayout();
            this.gbLiczbaRatWrokuM.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaryczneRozliczenieKredytu)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Yellow;
            this.tabPage1.Controls.Add(this.btnGraficznaPrezentacjaSpłatyKredytu);
            this.tabPage1.Controls.Add(this.btnResetuj);
            this.tabPage1.Controls.Add(this.btnTabelaryczneRozliczenieSpłaty);
            this.tabPage1.Controls.Add(this.gbSpłataKredytuWratach);
            this.tabPage1.Controls.Add(this.gbLiczbaRatWrokuM);
            this.tabPage1.Controls.Add(this.cmbRocznaStopaProcentowa);
            this.tabPage1.Controls.Add(this.txtK);
            this.tabPage1.Controls.Add(this.txtN);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pulpit rozliczenia kredytu";
            // 
            // btnGraficznaPrezentacjaSpłatyKredytu
            // 
            this.btnGraficznaPrezentacjaSpłatyKredytu.Location = new System.Drawing.Point(431, 349);
            this.btnGraficznaPrezentacjaSpłatyKredytu.Name = "btnGraficznaPrezentacjaSpłatyKredytu";
            this.btnGraficznaPrezentacjaSpłatyKredytu.Size = new System.Drawing.Size(164, 52);
            this.btnGraficznaPrezentacjaSpłatyKredytu.TabIndex = 10;
            this.btnGraficznaPrezentacjaSpłatyKredytu.Text = "Graficzna prezentacja spłaty kredytu";
            this.btnGraficznaPrezentacjaSpłatyKredytu.UseVisualStyleBackColor = true;
            this.btnGraficznaPrezentacjaSpłatyKredytu.Click += new System.EventHandler(this.btnGraficznaPrezentacjaSpłatyKredytu_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(272, 349);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(93, 52);
            this.btnResetuj.TabIndex = 9;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // btnTabelaryczneRozliczenieSpłaty
            // 
            this.btnTabelaryczneRozliczenieSpłaty.Location = new System.Drawing.Point(39, 349);
            this.btnTabelaryczneRozliczenieSpłaty.Name = "btnTabelaryczneRozliczenieSpłaty";
            this.btnTabelaryczneRozliczenieSpłaty.Size = new System.Drawing.Size(163, 52);
            this.btnTabelaryczneRozliczenieSpłaty.TabIndex = 8;
            this.btnTabelaryczneRozliczenieSpłaty.Text = "Tabelaryczne rozliczenie spłaty kredytu";
            this.btnTabelaryczneRozliczenieSpłaty.UseVisualStyleBackColor = true;
            this.btnTabelaryczneRozliczenieSpłaty.Click += new System.EventHandler(this.btnTabelaryczneRozliczenieSpłaty_Click);
            // 
            // gbSpłataKredytuWratach
            // 
            this.gbSpłataKredytuWratach.Controls.Add(this.rdbRosnąca);
            this.gbSpłataKredytuWratach.Controls.Add(this.rdbMalejąca);
            this.gbSpłataKredytuWratach.Controls.Add(this.rdbStała);
            this.gbSpłataKredytuWratach.Location = new System.Drawing.Point(39, 248);
            this.gbSpłataKredytuWratach.Name = "gbSpłataKredytuWratach";
            this.gbSpłataKredytuWratach.Size = new System.Drawing.Size(556, 76);
            this.gbSpłataKredytuWratach.TabIndex = 7;
            this.gbSpłataKredytuWratach.TabStop = false;
            this.gbSpłataKredytuWratach.Text = "Spłata kredytu w ratach";
            // 
            // rdbRosnąca
            // 
            this.rdbRosnąca.AutoSize = true;
            this.rdbRosnąca.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbRosnąca.Location = new System.Drawing.Point(298, 35);
            this.rdbRosnąca.Name = "rdbRosnąca";
            this.rdbRosnąca.Size = new System.Drawing.Size(85, 19);
            this.rdbRosnąca.TabIndex = 8;
            this.rdbRosnąca.TabStop = true;
            this.rdbRosnąca.Text = "Rosnących";
            this.rdbRosnąca.UseVisualStyleBackColor = true;
            // 
            // rdbMalejąca
            // 
            this.rdbMalejąca.AutoSize = true;
            this.rdbMalejąca.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbMalejąca.Location = new System.Drawing.Point(160, 35);
            this.rdbMalejąca.Name = "rdbMalejąca";
            this.rdbMalejąca.Size = new System.Drawing.Size(87, 19);
            this.rdbMalejąca.TabIndex = 2;
            this.rdbMalejąca.TabStop = true;
            this.rdbMalejąca.Text = "Malejących";
            this.rdbMalejąca.UseVisualStyleBackColor = true;
            // 
            // rdbStała
            // 
            this.rdbStała.AutoSize = true;
            this.rdbStała.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbStała.Location = new System.Drawing.Point(29, 35);
            this.rdbStała.Name = "rdbStała";
            this.rdbStała.Size = new System.Drawing.Size(65, 19);
            this.rdbStała.TabIndex = 1;
            this.rdbStała.TabStop = true;
            this.rdbStała.Text = "Stałych";
            this.rdbStała.UseVisualStyleBackColor = true;
            // 
            // gbLiczbaRatWrokuM
            // 
            this.gbLiczbaRatWrokuM.Controls.Add(this.rdbCoKwartal);
            this.gbLiczbaRatWrokuM.Controls.Add(this.rdbCoMiesiąc);
            this.gbLiczbaRatWrokuM.Controls.Add(this.rdbCoPółRoku);
            this.gbLiczbaRatWrokuM.Controls.Add(this.rdbRazWroku);
            this.gbLiczbaRatWrokuM.Location = new System.Drawing.Point(39, 158);
            this.gbLiczbaRatWrokuM.Name = "gbLiczbaRatWrokuM";
            this.gbLiczbaRatWrokuM.Size = new System.Drawing.Size(556, 75);
            this.gbLiczbaRatWrokuM.TabIndex = 6;
            this.gbLiczbaRatWrokuM.TabStop = false;
            this.gbLiczbaRatWrokuM.Text = "Liczba rat w roku m";
            // 
            // rdbCoKwartal
            // 
            this.rdbCoKwartal.AutoSize = true;
            this.rdbCoKwartal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbCoKwartal.Location = new System.Drawing.Point(298, 39);
            this.rdbCoKwartal.Name = "rdbCoKwartal";
            this.rdbCoKwartal.Size = new System.Drawing.Size(84, 19);
            this.rdbCoKwartal.TabIndex = 2;
            this.rdbCoKwartal.TabStop = true;
            this.rdbCoKwartal.Text = "Co kwartal ";
            this.rdbCoKwartal.UseVisualStyleBackColor = true;
            // 
            // rdbCoMiesiąc
            // 
            this.rdbCoMiesiąc.AutoSize = true;
            this.rdbCoMiesiąc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbCoMiesiąc.Location = new System.Drawing.Point(432, 39);
            this.rdbCoMiesiąc.Name = "rdbCoMiesiąc";
            this.rdbCoMiesiąc.Size = new System.Drawing.Size(82, 19);
            this.rdbCoMiesiąc.TabIndex = 3;
            this.rdbCoMiesiąc.TabStop = true;
            this.rdbCoMiesiąc.Text = "Co miesiąc";
            this.rdbCoMiesiąc.UseVisualStyleBackColor = true;
            // 
            // rdbCoPółRoku
            // 
            this.rdbCoPółRoku.AutoSize = true;
            this.rdbCoPółRoku.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbCoPółRoku.Location = new System.Drawing.Point(160, 39);
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
            this.rdbRazWroku.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbRazWroku.Location = new System.Drawing.Point(29, 39);
            this.rdbRazWroku.Name = "rdbRazWroku";
            this.rdbRazWroku.Size = new System.Drawing.Size(83, 19);
            this.rdbRazWroku.TabIndex = 0;
            this.rdbRazWroku.TabStop = true;
            this.rdbRazWroku.Text = "Raz w roku";
            this.rdbRazWroku.UseVisualStyleBackColor = true;
            // 
            // cmbRocznaStopaProcentowa
            // 
            this.cmbRocznaStopaProcentowa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbRocznaStopaProcentowa.FormattingEnabled = true;
            this.cmbRocznaStopaProcentowa.Items.AddRange(new object[] {
            "11,00%",
            "12,00%",
            "12,50%",
            "13,50%",
            "14,00%",
            "14,50%",
            "15,50%",
            "16,00%",
            "16,50%",
            "17,00%",
            "17,50%",
            "18,00%",
            "18,50%"});
            this.cmbRocznaStopaProcentowa.Location = new System.Drawing.Point(541, 68);
            this.cmbRocznaStopaProcentowa.Name = "cmbRocznaStopaProcentowa";
            this.cmbRocznaStopaProcentowa.Size = new System.Drawing.Size(163, 23);
            this.cmbRocznaStopaProcentowa.TabIndex = 5;
            this.cmbRocznaStopaProcentowa.Text = "Wybież stopę procentową";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(228, 46);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(113, 26);
            this.txtK.TabIndex = 4;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(228, 90);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(113, 26);
            this.txtN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Roczna stopa procentowa p\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba lat spłaty kredytu n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wysokość kredytu K";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Aqua;
            this.tabPage2.Controls.Add(this.txtSpłataR);
            this.tabPage2.Controls.Add(this.dgvTabelaryczneRozliczenieKredytu);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabelaryczne rozliczrnie kredytu";
            // 
            // txtSpłataR
            // 
            this.txtSpłataR.Location = new System.Drawing.Point(546, 9);
            this.txtSpłataR.Name = "txtSpłataR";
            this.txtSpłataR.Size = new System.Drawing.Size(133, 26);
            this.txtSpłataR.TabIndex = 2;
            // 
            // dgvTabelaryczneRozliczenieKredytu
            // 
            this.dgvTabelaryczneRozliczenieKredytu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaryczneRozliczenieKredytu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTabelaryczneRozliczenieKredytu.Location = new System.Drawing.Point(8, 46);
            this.dgvTabelaryczneRozliczenieKredytu.Name = "dgvTabelaryczneRozliczenieKredytu";
            this.dgvTabelaryczneRozliczenieKredytu.RowHeadersWidth = 82;
            this.dgvTabelaryczneRozliczenieKredytu.Size = new System.Drawing.Size(706, 372);
            this.dgvTabelaryczneRozliczenieKredytu.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numer raty";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Wusokość raty lącznej R";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Wysokość raty odsetkowej Ro";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Splata R + procent";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Zadlużenie po wpLaceniu i-tej raty";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wysokość raty kapitalowej Rk (która jest stała, czyli const)";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Lime;
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(720, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graficzne rozliczenie kredytu";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(82, 14);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = " R";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Ro";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Rk";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(560, 402);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnPrzejdżDoMenu
            // 
            this.btnPrzejdżDoMenu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrzejdżDoMenu.Location = new System.Drawing.Point(734, 68);
            this.btnPrzejdżDoMenu.Name = "btnPrzejdżDoMenu";
            this.btnPrzejdżDoMenu.Size = new System.Drawing.Size(133, 63);
            this.btnPrzejdżDoMenu.TabIndex = 1;
            this.btnPrzejdżDoMenu.Text = "Przejdż do formularza kalkulacje finansowe";
            this.btnPrzejdżDoMenu.UseVisualStyleBackColor = true;
            this.btnPrzejdżDoMenu.Click += new System.EventHandler(this.btnPrzejdżDoMenu_Click);
            // 
            // btnWyjścieZprogramu
            // 
            this.btnWyjścieZprogramu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWyjścieZprogramu.Location = new System.Drawing.Point(734, 22);
            this.btnWyjścieZprogramu.Name = "btnWyjścieZprogramu";
            this.btnWyjścieZprogramu.Size = new System.Drawing.Size(133, 31);
            this.btnWyjścieZprogramu.TabIndex = 17;
            this.btnWyjścieZprogramu.Text = "Wyjście z programu";
            this.btnWyjścieZprogramu.UseVisualStyleBackColor = true;
            this.btnWyjścieZprogramu.Click += new System.EventHandler(this.btnWyjścieZprogramu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Kredyty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.btnWyjścieZprogramu);
            this.Controls.Add(this.btnPrzejdżDoMenu);
            this.Controls.Add(this.tabControl1);
            this.Name = "Kredyty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredyty";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbSpłataKredytuWratach.ResumeLayout(false);
            this.gbSpłataKredytuWratach.PerformLayout();
            this.gbLiczbaRatWrokuM.ResumeLayout(false);
            this.gbLiczbaRatWrokuM.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaryczneRozliczenieKredytu)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGraficznaPrezentacjaSpłatyKredytu;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Button btnTabelaryczneRozliczenieSpłaty;
        private System.Windows.Forms.GroupBox gbSpłataKredytuWratach;
        private System.Windows.Forms.RadioButton rdbRosnąca;
        private System.Windows.Forms.RadioButton rdbMalejąca;
        private System.Windows.Forms.RadioButton rdbStała;
        private System.Windows.Forms.GroupBox gbLiczbaRatWrokuM;
        private System.Windows.Forms.RadioButton rdbCoKwartal;
        private System.Windows.Forms.RadioButton rdbCoMiesiąc;
        private System.Windows.Forms.RadioButton rdbCoPółRoku;
        private System.Windows.Forms.RadioButton rdbRazWroku;
        private System.Windows.Forms.ComboBox cmbRocznaStopaProcentowa;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPrzejdżDoMenu;
        private System.Windows.Forms.Button btnWyjścieZprogramu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpłataR;
        private System.Windows.Forms.DataGridView dgvTabelaryczneRozliczenieKredytu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
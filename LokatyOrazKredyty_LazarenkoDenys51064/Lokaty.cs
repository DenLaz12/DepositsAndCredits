using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LokatyOrazKredyty_LazarenkoDenys51064
{
    public partial class Lokaty : Form
    {
        public Lokaty()
        {
            InitializeComponent();
        }
        private void TabelaryczneRozliczenieLokaty(float dlK, ushort dln, float dlp, ushort dlm, out float[,] dlTRL)
        {
            dlTRL = new float[dln * dlm + 1, 3];
            dlTRL[0, 0] = 0.0F;
            dlTRL[0, 1] = 0.0F;
            dlTRL[0, 2] = dlK;
            for (int dli = 1; dli < dlTRL.GetLength(0); dli++)
            {
                dlTRL[dli, 0] = dlTRL[dli - 1, 2];
                dlTRL[dli, 1] = dlTRL[dli, 0] * dlp / dlm;
                dlTRL[dli, 2] = dlTRL[dli, 0] + dlTRL[dli, 1];
            }
        }
        bool PobranieDanychWejściowych(out float dlK, out ushort dln, out float dlp, out ushort dlm)
        {
            dlK = 0.0F; dln = 0; dlp = 0.0F; dlm = 0;
            if (string.IsNullOrEmpty(txtK.Text))
            {
                errorProvider1.SetError(txtK, "ERROR: musisz podacz wysokość lokaty K");
                return false;
            }
            else
                errorProvider1.Dispose();
            if (!float.TryParse(txtK.Text, out dlK))
            {
                errorProvider1.SetError(txtK, "ERROR: wystąpił niedozwolony znak w zapisie K");
                return false;
            }
            else
                errorProvider1.Dispose();
            if (dlK < 100)
            {
                errorProvider1.SetError(txtK, "ERROR: minimalna kwota k >= 100");
                return false;
            }
            else
                errorProvider1.Dispose();
            if (string.IsNullOrEmpty(txtN.Text))
            {
                errorProvider1.SetError(txtN, "ERROR: musisz podacz wysokość lokaty n");
                return false;
            }
            else
                errorProvider1.Dispose();
            if (!ushort.TryParse(txtN.Text, out dln))
            {
                errorProvider1.SetError(txtK, "ERROR: musisz podacz wysokość lokaty K");
                return false;
            }
            else
                errorProvider1.Dispose();
            if (dln <= 0)
            {
                errorProvider1.SetError(txtN, "ERROR: liczba lat lokaty musi spelniacz warunek n > 0");
                return false;
            }
            else
                if (cmbRocznaStopaProcentowa.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbRocznaStopaProcentowa, "ERROR: musisz wybracz roczną stopę procentową");
                return false;
            }
            else
                errorProvider1.Dispose();
            string RocznaStopaProcentowa = cmbRocznaStopaProcentowa.SelectedItem.ToString();

            RocznaStopaProcentowa = RocznaStopaProcentowa.Substring(0, RocznaStopaProcentowa.Length - 1);
            if (!float.TryParse(RocznaStopaProcentowa, out dlp))
            {
                errorProvider1.SetError(cmbRocznaStopaProcentowa, "ERROR: wystąpił niedozwolony znak");
                return false;
            }
            else
                errorProvider1.Dispose();
            dlp = dlp / 100;
            if (rdbRazWroku.Checked)
                dlm = 1;
            else
                if (rdbCoPółRoku.Checked)
                dlm = 2;
            else
                if (rdbCoKwartal.Checked)
                dlm = 4;
            else
                if (rdbCoMiesiąc.Checked)
                dlm = 12;
            else
            {
                errorProvider1.SetError(gbCzęstośćKapitalizacjiOdsetek, "ERROR");
                return false;
            }
            errorProvider1.Dispose();
            return true;
        }
        private void btnTabelarycznaWizualizacja_Click(object sender, EventArgs e)
        {
            float dlK, dlp;
            ushort dln, dlm;
            if (!PobranieDanychWejściowych(out dlK, out dln, out dlp, out dlm))
                return;
            float[,] dlTRL;
            TabelaryczneRozliczenieLokaty(dlK, dln, dlp, dlm, out dlTRL);
            for (int dli = 0; dli < dlTRL.GetLength(0); dli++)
            {
                dgvTabelarycznaWizualizacja.Rows.Add();
                dgvTabelarycznaWizualizacja.Rows[dli].Cells[0].Value = dli;
                dgvTabelarycznaWizualizacja.Rows[dli].Cells[1].Value = string.Format("{0:0.000}", dlTRL[dli, 0]);
                dgvTabelarycznaWizualizacja.Rows[dli].Cells[2].Value = string.Format("{0:0.000}", dlTRL[dli, 1]);
                dgvTabelarycznaWizualizacja.Rows[dli].Cells[3].Value = string.Format("{0:0.000}", dlTRL[dli, 2]);
                if (dli % 2 == 0)
                    dgvTabelarycznaWizualizacja.Rows[dli].DefaultCellStyle.BackColor = Color.LightGray;
                else
                    dgvTabelarycznaWizualizacja.Rows[dli].DefaultCellStyle.BackColor = Color.White;
            }
            dgvTabelarycznaWizualizacja.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTabelarycznaWizualizacja.Visible = true;
            chtGraficznaWizualizacja.Visible = false;
            btnTabelarycznaWizualizacja.Enabled = false;
        }

        private void btnGraficznaWizualizacja_Click(object sender, EventArgs e)
        {
            float dlK, dlp;
            ushort dln, dlm;
            if (!PobranieDanychWejściowych(out dlK, out dln, out dlp, out dlm))
                return;
            float[,] TRL;
            TabelaryczneRozliczenieLokaty(dlK, dln, dlp, dlm, out TRL);
            chtGraficznaWizualizacja.Titles.Add("Wykres zmiany stanu konta w okresie lokaty");
            chtGraficznaWizualizacja.Series.Clear();
            chtGraficznaWizualizacja.Series.Add("Stan konta Kmn");
            chtGraficznaWizualizacja.ChartAreas[0].AxisX.Title = "Okres lokaty";
            chtGraficznaWizualizacja.ChartAreas[0].AxisX.Minimum = 0;
            chtGraficznaWizualizacja.ChartAreas[0].AxisX.Interval = 2;
            chtGraficznaWizualizacja.ChartAreas[0].AxisY.Title = "Wysokość stanu konta";
            chtGraficznaWizualizacja.ChartAreas[0].AxisY.Minimum = 0;
            chtGraficznaWizualizacja.Series[0].IsVisibleInLegend = true;
            chtGraficznaWizualizacja.Legends.FindByName("Legend1").Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chtGraficznaWizualizacja.Series[0].Name = "Wykres zmiany stanu konta";
            chtGraficznaWizualizacja.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chtGraficznaWizualizacja.Series[0].Color = Color.Red;
            chtGraficznaWizualizacja.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chtGraficznaWizualizacja.Series[0].BorderWidth = 2;
            for (int dli = 0; dli < TRL.GetLength(0); dli++)
                chtGraficznaWizualizacja.Series[0].Points.AddXY(dli, TRL[dli, 2]);
            chtGraficznaWizualizacja.Visible = true;
            dgvTabelarycznaWizualizacja.Visible = false;
            btnGraficznaWizualizacja.Enabled = false;
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            txtK.Text = null;
            txtN.Text = null;
            cmbRocznaStopaProcentowa.SelectedItem = null;
            rdbRazWroku.Checked = false;
            rdbCoPółRoku.Checked = false;
            rdbCoKwartal.Checked = false;
            rdbCoMiesiąc.Checked = false;
            txtPrzyszłyStanKonta.Text = null;
            {
                dgvTabelarycznaWizualizacja.Visible = false;
                {
                    dgvTabelarycznaWizualizacja.Rows.Clear();
                }
            }
            {
                chtGraficznaWizualizacja.Visible = false;
                {
                    chtGraficznaWizualizacja.Titles.Clear();
                    chtGraficznaWizualizacja.Series.Clear();
                }
                btnTabelarycznaWizualizacja.Enabled = true;
                btnObliczStanKonta.Enabled = true;
                btnGraficznaWizualizacja.Enabled = true;
            }
        }
        private void btnObliczStanKonta_Click(object sender, EventArgs e)
        {
            float dlK, dlp;
            ushort dln, dlm;
            if (!PobranieDanychWejściowych(out dlK, out dln, out dlp, out dlm))
                return;

            float Knm = dlK * (float)Math.Pow(1 + dlp / dlm, dln * dlm);
            txtPrzyszłyStanKonta.Text = string.Format("{0:0.00} ", Knm);
            btnObliczStanKonta.Enabled = false;
            btnTabelarycznaWizualizacja.Enabled = true;
        }

        private void btnPrzejdżDoMenuZlokat_Click(object sender, EventArgs e)
        {
            this.Hide();
            KalkulacjeFinansowe dlKalkulacjeFinansowe = new KalkulacjeFinansowe();
            dlKalkulacjeFinansowe.Show();
        }

        private void btnWyjścieZprogramu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

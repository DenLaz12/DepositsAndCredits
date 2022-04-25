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
    public partial class Systematyczne_oszczedzanie : Form
    {
        public Systematyczne_oszczedzanie()
        {
            InitializeComponent();
        }
        private bool PobranieDanychWejsciowych(out double dlK, out ushort dln, out double dlp, out ushort dlm, out ushort dlraty, out double dlR)
        {

            dlK = 0; dln = 0; dlp = 0; dlm = 0; dlraty = 0; dlR = 0;

            if (string.IsNullOrEmpty(txtK.Text))
            {
                errorProvider1.SetError(txtK, "Error");
                return false;
            }
            else errorProvider1.Dispose();

            if (!double.TryParse(txtK.Text, out dlK))
            {
                errorProvider1.SetError(txtK, "Error");
                return false;
            }
            else errorProvider1.Dispose();

            if (dlK < 100.0F)
            {
                errorProvider1.SetError(txtK, "Error");
                return false;
            }
            else errorProvider1.Dispose();

            if (string.IsNullOrEmpty(txtN.Text))
            {
                errorProvider1.SetError(txtN, "Error");
                return false;
            }
            else errorProvider1.Dispose();

            if (!ushort.TryParse(txtN.Text, out dln))
            {
                errorProvider1.SetError(txtN, "Error");
                return false;
            }
            else errorProvider1.Dispose();

            if (cmbRocznaStopaProcentowa.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbRocznaStopaProcentowa, "Error 3");
                return false;
            }
            else errorProvider1.Dispose();

            string RocznaStopa;
            RocznaStopa = cmbRocznaStopaProcentowa.SelectedItem.ToString();
            RocznaStopa = RocznaStopa.Trim();
            RocznaStopa = RocznaStopa.Substring(0, RocznaStopa.Length - 1);

            if (!double.TryParse(RocznaStopa, out dlp))
            {
                errorProvider1.SetError(cmbRocznaStopaProcentowa, "Error 1");
                return false;
            }
            else errorProvider1.Dispose();

            dlp = dlp / 100.0F;

            if ((dlp <= 0.0F) || (dlp >= 10.0F))
            {
                errorProvider1.SetError(cmbRocznaStopaProcentowa, "Error 2");
                return false;
            }
            else errorProvider1.Dispose();

            if (rdbRazWroku.Checked)
            {
                dlm = 1;
            }
            else if (rdbCoPółRoku.Checked)
            {
                dlm = 2;
            }
            else if (rdbCoKwartal.Checked)
            {
                dlm = 4;
            }
            else if (rdbCoMiesiąc.Checked)
            {
                dlm = 12;
            }
            else
            {
                errorProvider1.SetError(gbWysokośćRaty, "ERROR: Musisz wybrac opcje");
                return false;
            }

            if (rdbPoczątek.Checked)
            {
                dlraty = 1;
            }
            else if (rdbKoniec.Checked)
            {
                dlraty = 2;
            }

            else
            {
                errorProvider1.SetError(gbWysokośćRaty, "ERROR: Musisz wybrac opcje");
                return false;
            }
            if (string.IsNullOrEmpty(txtStałaR.Text))
            {
                errorProvider1.SetError(txtStałaR, "Error");
                return false;
            }
            else errorProvider1.Dispose();

            if (!double.TryParse(txtStałaR.Text, out dlR))
            {
                errorProvider1.SetError(txtStałaR, "Error");
                return false;
            }
            else errorProvider1.Dispose();

            if (dlK < 100.0F)
            {
                errorProvider1.SetError(txtStałaR, "Error");
                return false;
            }
            else errorProvider1.Dispose();


            return true;
        }

        private void btnWyjścieZprogramu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrzejdżDoMenuZlokat_Click(object sender, EventArgs e)
        {
            this.Hide();
            KalkulacjeFinansowe dlKalkulacjeFinansowe = new KalkulacjeFinansowe();
            dlKalkulacjeFinansowe.Show();
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
            txtPrzyszłaWartość.Text = null;
            rdbPoczątek.Checked = false;
            rdbKoniec.Checked = false;
            txtStałaR.Text = null;
            {
                dgvTabelarycznaWizualizacja.Visible = false;

            }
            {
                chart1.Visible = false;

                btnTabelarycznaWizualizacja.Enabled = true;
                btnObliczeniePrzyszłejWartości.Enabled = true;
                btnGraficznaWizualizacja.Enabled = true;
            }
        }

        private void btnObliczeniePrzyszłejWartości_Click(object sender, EventArgs e)
        {
            double Knmr;
            if (!PobranieDanychWejsciowych(out double dlK, out ushort dln, out double dlp, out ushort dlm, out ushort dlraty, out double dlR))
            {
                return;
            }
            if (dlraty == 1)
            {
                Knmr = dlK * Math.Pow(1 + dlp / dlm, dln * dlm) + dlR * (Math.Pow(1 + dlp / dlm, dln * dlm) - 1) / (dlp / dlm);
                Knmr = Math.Round(Knmr, 3);
                txtPrzyszłaWartość.Text = Convert.ToString(Knmr);
            }
            if (dlraty == 2)
            {
                Knmr = dlK * Math.Pow(1 + dlp / dlm, dln * dlm) + dlR + (Math.Pow(1 + dlp / dlm, dln * dlm) - 1) / (dlp / dlm) * (1 + (dlp / dlm));
                Knmr = Math.Round(Knmr, 3);
                txtPrzyszłaWartość.Text = Convert.ToString(Knmr);
            }
        }

        private void btnTabelarycznaWizualizacja_Click(object sender, EventArgs e)
        {
            if (!PobranieDanychWejsciowych(out double dlK, out ushort dln, out double dlp, out ushort dlm, out ushort dlraty, out double dlR))
            {
                return;
            }

            {
                dgvTabelarycznaWizualizacja.Rows.Clear();
            }
            double[,] dlTRL;
            RozliczenieLokaty(dlK, dln, dlp, dlm, dlraty, dlR, out dlTRL);

            for (int i = 0; i < dlTRL.GetLength(0); i++)
            {

                dgvTabelarycznaWizualizacja.Rows.Add();
                dgvTabelarycznaWizualizacja.Rows[i].Cells[0].Value = i;
                dgvTabelarycznaWizualizacja.Rows[i].Cells[1].Value = string.Format("{00:0.00}", dlTRL[i, 0]);
                dgvTabelarycznaWizualizacja.Rows[i].Cells[2].Value = string.Format("{00:0.00}", dlTRL[i, 1]);
                dgvTabelarycznaWizualizacja.Rows[i].Cells[3].Value = string.Format("{00:0.00}", dlTRL[i, 2]);

                if (i % 2 == 0)
                {
                    dgvTabelarycznaWizualizacja.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dgvTabelarycznaWizualizacja.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

                dgvTabelarycznaWizualizacja.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvTabelarycznaWizualizacja.Visible = true;
                btnGraficznaWizualizacja.Visible = true;
            }
        }
        private void RozliczenieLokaty(double dlK, ushort dln, double dlp, ushort dlm, ushort dlraty, double dlR, out double[,] dlRL)
        {

            double Knmr;
            dlRL = new double[dln * dlm + 1, 3];



            if (dlraty == 1)
            {

                dlRL[0, 0] = 0.0F;
                dlRL[0, 1] = 0.0F;
                dlRL[0, 2] = dlK;


                Knmr = dlK * Math.Pow(1 + dlp / dlm, dln * dlm) + dlR * (Math.Pow(1 + dlp / dlm, dln * dlm) - 1) / (dlp / dlm);
                Knmr = Math.Round(Knmr, 3);

                for (int i = 1; i < dlRL.GetLength(0); i++)
                {
                    dlRL[i, 0] = dlRL[i - 1, 2];
                    dlRL[i, 1] = dlRL[i, 0] * dlp;
                    dlRL[i, 2] = dlRL[i, 0] + dlRL[i, 1] + dlR;
                }
                chart1.Series[0].Points.Clear();



                for (int i = 0; i <= dlm * dln; i++)
                {
                    chart1.Series[0].Points.AddXY(i, dlRL[i, 2]);
                }
            }
            if (dlraty == 2)
            {

                dlRL[0, 0] = 0.0F;
                dlRL[0, 1] = 0.0F;
                dlRL[0, 2] = dlK;


                Knmr = dlK * Math.Pow(1 + dlp / dlm, dln * dlm) + dlR + (Math.Pow(1 + dlp / dlm, dln * dlm) - 1) / (dlp / dlm) * (1 + (dlp / dlm));
                Knmr = Math.Round(Knmr, 3);

                for (int i = 1; i < dlRL.GetLength(0); i++)
                {
                    dlRL[i, 0] = dlRL[i - 1, 2];
                    dlRL[i, 1] = dlRL[i, 0] * dlp;
                    dlRL[i, 2] = dlRL[i, 0] + dlRL[i, 1] + dlR;
                }

                chart1.Series[0].Points.Clear();

                for (int i = 0; i <= dlm * dln; i++)
                {
                    chart1.Series[0].Points.AddXY(i, dlRL[i, 2]);
                }
            }
        }

        private void btnGraficznaWizualizacja_Click(object sender, EventArgs e)
        {
            dgvTabelarycznaWizualizacja.Visible = false;
            chart1.Visible = true;

        }
    }
    
}

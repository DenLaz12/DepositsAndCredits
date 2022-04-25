using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LokatyOrazKredyty_LazarenkoDenys51064
{
    public partial class Kredyty : Form
    {
        public Kredyty()
        {
            InitializeComponent();
        }

        private void btnWyjścieZprogramu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool PobranieDanychWejsciowych(out double dlK, out ushort dln, out double dlp, out ushort dlm, out ushort dlraty)
        {

            dlK = 0; dln = 0; dlp = 0; dlm = 0; dlraty = 0;

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
                errorProvider1.SetError(gbSpłataKredytuWratach, "ERROR: Musisz wybrac opcje");
                return false;
            }

            if (rdbStała.Checked)
            {
                dlraty = 1;
            }
            else if (rdbMalejąca.Checked)
            {
                dlraty = 2;
            }
            else if (rdbRosnąca.Checked)
            {
                dlraty = 3;
            }
            else
            {
                errorProvider1.SetError(gbSpłataKredytuWratach, "ERROR: Musisz wybrac opcje");
                return false;
            }

            return true;
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            txtK.Text = "";
            txtN.Text = "";
            rdbCoKwartal.Checked = false;
            rdbCoMiesiąc.Checked = false;
            rdbCoPółRoku.Checked = false;
            rdbRazWroku.Checked = false;
            rdbMalejąca.Checked = false;
            rdbRosnąca.Checked = false;
            rdbStała.Checked = false;
            cmbRocznaStopaProcentowa.SelectedItem = null;
        }

        private void btnTabelaryczneRozliczenieSpłaty_Click(object sender, EventArgs e)
        {
            {

                tabControl1.SelectedTab = tabPage2;

                {
                    dgvTabelaryczneRozliczenieKredytu.Rows.Clear();
                }

                if (!PobranieDanychWejsciowych(out double dlK, out ushort dln, out double dlp, out ushort dlm, out ushort dlraty))
                {
                    return;
                }

                double[,] TRL;
                RozliczenieLokaty(dlK, dln, dlp, dlm, dlraty, out TRL);

                for (int dli = 0; dli < TRL.GetLength(0); dli++)
                {

                    dgvTabelaryczneRozliczenieKredytu.Rows.Add();
                    dgvTabelaryczneRozliczenieKredytu.Rows[dli].Cells[0].Value = dli;
                    dgvTabelaryczneRozliczenieKredytu.Rows[dli].Cells[1].Value = string.Format("{00:0.00}", TRL[dli, 0]);
                    dgvTabelaryczneRozliczenieKredytu.Rows[dli].Cells[2].Value = string.Format("{00:0.00}", TRL[dli, 1]);
                    dgvTabelaryczneRozliczenieKredytu.Rows[dli].Cells[3].Value = string.Format("{00:0.00}", TRL[dli, 2]);
                    dgvTabelaryczneRozliczenieKredytu.Rows[dli].Cells[4].Value = string.Format("{00:0.00}", TRL[dli, 3]);

                    if (dli % 2 == 0)
                    {
                        dgvTabelaryczneRozliczenieKredytu.Rows[dli].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else
                    {
                        dgvTabelaryczneRozliczenieKredytu.Rows[dli].DefaultCellStyle.BackColor = Color.White;
                    }

                    dgvTabelaryczneRozliczenieKredytu.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvTabelaryczneRozliczenieKredytu.Visible = true;
                }


            }
        }
        private void RozliczenieLokaty(double dlK, ushort dln, double dlp, ushort dlm, ushort dlraty, out double[,] RL)
        {

            double R;
            double Rk;
            RL = new double[dln * dlm + 1, 4];

            chart1.Series[0].BorderWidth = 10;

            chart1.Series[1].BorderDashStyle = ChartDashStyle.Dot;
            chart1.Series[1].BorderWidth = 10;

            chart1.Series[2].BorderDashStyle = ChartDashStyle.Dot;
            chart1.Series[2].BorderWidth = 10;

            if (dlraty == 1)
            {

                RL[0, 0] = 0.0F;
                RL[0, 1] = 0.0F;
                RL[0, 2] = 0.0F;
                RL[0, 3] = dlK;


                R = dlK * (((dlp / dlm) * Math.Pow(1 + dlp / dlm, dln * dlm)) / (Math.Pow(1 + dlp / dlm, dln * dlm) - 1));
                R = Math.Round(R, 3);



                txtSpłataR.Text = Convert.ToString(R);



                for (int dli = 1; dli < RL.GetLength(0); dli++)
                {
                    RL[dli, 0] = RL[dli - 1, 3];
                    RL[dli, 1] = RL[dli, 0] * dlp / dlm;
                    RL[dli, 2] = R - RL[dli, 1];
                    RL[dli, 3] = RL[dli, 0] - RL[dli, 2];
                    if (RL[dli, 3] == 0.1 || RL[dli, 3] < 0)
                    {
                        RL[dli, 3] = 0.00;
                    }
                }



                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                for (int dli = 0; dli <= dlm * dln; dli++)
                {
                    chart1.Series[0].Points.AddXY(dli, R);
                    chart1.Series[1].Points.AddXY(dli, RL[dli, 1]);
                    chart1.Series[2].Points.AddXY(dli, RL[dli, 2]);
                }
            }

            if (dlraty == 2)
            {
                RL[0, 0] = 0.0F;
                RL[0, 1] = 0.0F;
                RL[0, 2] = 0.0F;
                RL[0, 3] = dlK;

                Rk = dlK / (dln * dlm);

                Rk = Math.Round(Rk, 3);

                txtSpłataR.Text = Convert.ToString(Rk);

                for (int dli = 1; dli < RL.GetLength(0); dli++)
                {
                    RL[dli, 0] = RL[dli - 1, 3];
                    RL[dli, 1] = RL[dli, 0] * dlp / dlm;
                    RL[dli, 2] = Rk + RL[dli, 1];
                    RL[dli, 3] = RL[dli, 0] - RL[dli, 2];
                    if (RL[dli, 3] < Rk)
                    {

                        RL[dli + 1, 0] = RL[dli, 3];
                        RL[dli + 1, 1] = RL[dli + 1, 0] * dlp / dlm;
                        RL[dli + 1, 2] = RL[dli, 3] + RL[dli + 1, 1];
                        RL[dli + 1, 3] = 0.000f;
                        break;

                    }
                }

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                for (int dli = 0; dli <= dlm * dln; dli++)
                {
                    chart1.Series[0].Points.AddXY(dli, Rk);
                    chart1.Series[1].Points.AddXY(dli, RL[dli, 1]);
                    chart1.Series[2].Points.AddXY(dli, RL[dli, 2]);
                }
            }

            if (dlraty == 3)
            {
                RL[0, 0] = 0.0F;
                RL[0, 1] = 0.0F;
                RL[0, 2] = 0.0F;
                RL[0, 3] = 0.0F;

                Rk = dlK / (dln * dlm);

                Rk = Math.Round(Rk, 3);

                txtSpłataR.Text = Convert.ToString(Rk);

                for (int dli = 1; dli < RL.GetLength(0); dli++)
                {
                    RL[dli, 0] = RL[dli - 1, 3];
                    RL[dli, 1] = RL[dli, 0] * dlp / dlm;
                    RL[dli, 2] = Rk + RL[dli, 1];
                    RL[dli, 3] = RL[dli, 0] + RL[dli, 2];

                }

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                for (int dli = 0; dli <= dlm * dln; dli++)
                {
                    chart1.Series[0].Points.AddXY(dli, Rk);
                    chart1.Series[1].Points.AddXY(dli, RL[dli, 1]);
                    chart1.Series[2].Points.AddXY(dli, RL[dli, 2]);
                }
            }
        }

        private void btnGraficznaPrezentacjaSpłatyKredytu_Click(object sender, EventArgs e)
        {
            {


                tabControl1.SelectedTab = tabPage3;

                {
                    dgvTabelaryczneRozliczenieKredytu.Rows.Clear();
                }

                if (!PobranieDanychWejsciowych(out double dlK, out ushort dln, out double dlp, out ushort dlm, out ushort dlraty))
                {
                    return;
                }

                double[,] TRL;
                RozliczenieLokaty(dlK, dln, dlp, dlm, dlraty, out TRL);

            }
        }

        private void btnPrzejdżDoMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            KalkulacjeFinansowe dlKalkulacjeFinansowe = new KalkulacjeFinansowe();
            dlKalkulacjeFinansowe.Show();
        }
    }
}

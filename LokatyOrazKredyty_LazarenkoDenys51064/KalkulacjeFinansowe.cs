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
    public partial class KalkulacjeFinansowe : Form
    {
        public KalkulacjeFinansowe()
        {
            InitializeComponent();
        }

        private void btnPrzejścieNaKredyty_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Kredyty = new Kredyty();
            Kredyty.Show();
        }

        private void btnPrzejścieNaLokaty_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Lokaty = new Lokaty();
            Lokaty.Show();
        }

        private void btnAuyorProjektu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Autor = new Autor();
            Autor.Show();
        }

        private void btnWyjścieZprogramu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSystematyczneOszczenzanie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Systematyczne_oszczedzanie dlSystematyczneOszczędzanie = new Systematyczne_oszczedzanie();
            dlSystematyczneOszczędzanie.Show();
        }
    }
}

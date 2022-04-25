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
    public partial class Autor : Form
    {
        public Autor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

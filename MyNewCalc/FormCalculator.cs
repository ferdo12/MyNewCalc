using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNewCalc
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void butonAdunare_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 + termen2;
            textBoxRezultat.Text = rezultat.ToString();

        }

        private void butonScadere_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 - termen2;
            textBoxRezultat.Text = rezultat.ToString();

        }

        private void butonInmultire_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 * termen2;
            textBoxRezultat.Text = rezultat.ToString();

        }

        private void butonImpartire_Click(object sender, EventArgs e)
        {
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            decimal rezultat = termen1 / termen2;
            textBoxRezultat.Text = rezultat.ToString();

           

        }
    }
}

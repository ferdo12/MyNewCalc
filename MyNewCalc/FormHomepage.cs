using System;
using System.Windows.Forms;

namespace MyNewCalc
{
    public partial class FormHomepage : Form
    {
        FormAbout FormAbout;
        FormCalculator FormCalculator;
        public FormHomepage()
        {
            InitializeComponent();
            FormAbout = new FormAbout();
            FormAbout.Visible = false;
            FormCalculator = new FormCalculator();
            FormCalculator.Visible = false;
        }

        private void buttonAboutForm_Click(object sender, EventArgs e)
        {
            if (FormAbout.Visible == true)
               FormAbout.Visible = false;
            else
               FormAbout.Visible = true;
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            if (FormCalculator.Visible == true)
                FormCalculator.Visible = false;
            else
                FormCalculator.Visible = true;
        }
    }
    }

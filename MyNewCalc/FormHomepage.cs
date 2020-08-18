using System;
using System.Windows.Forms;

namespace MyNewCalc
{
    public partial class FormHomepage : Form
    {
        FormAbout FormAbout;
        public FormHomepage()
        {
            InitializeComponent();
            FormAbout = new FormAbout();
            FormAbout.Visible = false;
        }

        private void buttonAboutForm_Click(object sender, EventArgs e)
        {
            if (FormAbout.Visible == true)
               FormAbout.Visible = false;
            else
               FormAbout.Visible = true;
        }
    }
    }

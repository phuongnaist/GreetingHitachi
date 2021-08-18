using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GreetingSoft
{
    public partial class fQuestion1 : Form
    {
        public fQuestion1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            fIntro fintro = new fIntro();
            fintro.StartPosition = this.StartPosition;
            this.Hide();
            fintro.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fQuestion2 fquestion2 = new fQuestion2();
            fquestion2.StartPosition = this.StartPosition;
            this.Hide();
            fquestion2.Show();
        }
    }
}

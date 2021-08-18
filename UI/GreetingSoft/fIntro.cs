using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GreetingSoft
{
    public partial class fIntro : Form
    {
        public fIntro()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        { 
            fLogin flogin = new fLogin();
            flogin.StartPosition = this.StartPosition;
            this.Hide();
            flogin.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fQuestion1 fquestion1 = new fQuestion1();
            this.Hide();
            fquestion1.StartPosition = this.StartPosition;
            fquestion1.Show();
        }
    }
}

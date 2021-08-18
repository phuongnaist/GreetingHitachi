using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GreetingSoft
{
    public partial class fQuestion2 : Form
    {
        public fQuestion2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            fQuestion1 fquestion1 = new fQuestion1();
            fquestion1.StartPosition = this.StartPosition;
            this.Hide();
            fquestion1.Show();
        }
    }
}

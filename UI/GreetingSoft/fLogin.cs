using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingSoft
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }



        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void logInBtn_Click_1(object sender, EventArgs e)
        { 
            fIntro fintro = new fIntro();
            fintro.StartPosition = this.StartPosition;
            fintro.Location = this.Location;
            fintro.Size = this.Size;
            this.Hide();
            fintro.ShowDialog();
            
        }

 

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace GreetingSoft
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
            string CnnStr= "Data Source = DESKTOP - CQEKB9O\TRUNGDUONGPC; Initial Catalog = GreetingHitachi; Integrated Security = True";
            SqlConnection connection = new SqlConnection(CnnStr);
        }
    }
}

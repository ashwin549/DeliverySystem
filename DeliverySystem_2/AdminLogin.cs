using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem_2
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Sub_but_Click(object sender, EventArgs e)
        {
            Admin2 ob = new Admin2();
            this.Hide();
            ob.Show();
        }

        private void B_but_Click(object sender, EventArgs e)
        {
            Home ob = new Home();
            this.Hide();    
            ob.Show();
        }
    }
}

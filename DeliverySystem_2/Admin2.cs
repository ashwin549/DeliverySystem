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
    public partial class Admin2 : Form
    {
        public Admin2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriverDetails ob = new DriverDetails();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeliveryHistory ob = new DeliveryHistory();
            this.Hide();
            ob.Show();
        }

        private void B_but_Click(object sender, EventArgs e)
        {
            AdminLogin ob = new AdminLogin();
            this.Hide();
            ob.Show();
        }
    }
}

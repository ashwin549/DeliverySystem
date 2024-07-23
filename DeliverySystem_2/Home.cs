using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace DeliverySystem_2
{
    public partial class Home : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Home()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            String oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            conn = new OracleConnection(oradb); // C# conn.Open();
            conn.Close();
        }
        int choice;
        private void L_but_Click(object sender, EventArgs e)
        {
            if (choice == 1)
            {

                EmpLogin ob1 = new EmpLogin();

                this.Hide();
                ob1.Show();

            }
            else if (choice == 2)
            {
                DriverLogin ob2 = new DriverLogin();

                this.Hide();
                ob2.Show();

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choice = 2;
        }

        private void A_but_Click(object sender, EventArgs e)
        {
            AdminLogin ob = new AdminLogin();
            this.Hide();
            ob.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}

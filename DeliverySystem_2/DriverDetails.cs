using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DeliverySystem_2
{
    public partial class DriverDetails : Form
    {
        OracleConnection conn;
        public DriverDetails()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            String oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin2 ob = new Admin2();
            this.Hide();
            ob.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "INSERT INTO DRIVER(DRIVERID, NAME, OFFICEID,PASSWORD, AVAILABLE) VALUES (:driverId, :dname, :officeid,:dpass, 'Yes' )";
            cm.Parameters.Add(":driverId", OracleDbType.Varchar2).Value = textBox1.Text.ToString();
            cm.Parameters.Add(":dname", OracleDbType.Varchar2).Value = textBox2.Text.ToString();
            cm.Parameters.Add(":officeid", OracleDbType.Varchar2).Value = textBox3.Text.ToString();
            cm.Parameters.Add(":dpass", OracleDbType.Varchar2).Value = textBox4.Text.ToString();
            cm.CommandType = CommandType.Text;
            conn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Inserted!");
            conn.Close();
        }
    }
}

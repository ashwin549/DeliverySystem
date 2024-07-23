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
    public partial class DriverLogin : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public DriverLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void connect1()
        {
            String oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Home ob = new Home();
            this.Hide();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from driver where DRIVERID='" + textBox1.Text + "'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "driver");
            dt = ds.Tables["driver"];
            int t = dt.Rows.Count;
            if (t > 0)
            {
                dr = dt.Rows[0];
                string did=textBox1.Text;
                string name = dr["name"].ToString();
                string office = dr["officeID"].ToString();
                MessageBox.Show("Name:" + name + "   OfficeID:" + office);
                conn.Close();
                Driver2 ob = new Driver2(did,office);
                this.Hide();
                ob.Show();
            }
            else { MessageBox.Show("Invalid username/password"); }
        }

        private void DriverLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

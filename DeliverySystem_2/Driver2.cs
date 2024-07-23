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
    public partial class Driver2 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string OfficeID;
        string DriverID;
        public Driver2()
        {
            InitializeComponent();
        }
        public Driver2(string driverID, string Officeid)
        {
            InitializeComponent();
            DriverID = driverID;
            OfficeID = Officeid;
            comboBox1.SelectedItem = Officeid;
            populatedatagridview();
        }
        public void connect1()
        {
            String oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }
        public void populatedatagridview()
        {
            connect1();
            conn.Open();
            string query = "SELECT parcelid,from_officeid,to_officeid,delivery_status,driverid FROM delivery natural join parcel where from_officeid='" + OfficeID + "' or to_officeid='" + OfficeID + "'";
            OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParcelDetails ob = new ParcelDetails(DriverID,OfficeID);
            this.Hide();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriverLogin ob = new DriverLogin();
            this.Hide();
            ob.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OfficeID = comboBox1.SelectedItem.ToString();
            connect1();
            conn.Open();
            string updateQuery = "UPDATE driver SET officeid = :officeid WHERE driverid = :driverid";
            OracleCommand command = new OracleCommand(updateQuery, conn);
            command.Parameters.Add(":officeid", OracleDbType.Varchar2).Value = OfficeID;
            command.Parameters.Add(":driverid", OracleDbType.Varchar2).Value = DriverID;
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Office ID updated successfully!");
            }
            populatedatagridview();
        }
    }
}

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

    public partial class AcceptDelivery : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string officeid;
        string empid;
        public AcceptDelivery()
        {
            InitializeComponent();
        }
        public AcceptDelivery(string ofid, string empid)
        {
            InitializeComponent();
            officeid = ofid;
            this.empid = empid;
        }
        public void connect1()
        {
            String oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string parcelid = textBox1.Text.ToString();
            populatedatagridview(parcelid);
        }
        public void populatedatagridview(string parcelid)
        {
            connect1();
            conn.Open();
            string query = "SELECT parcelid,from_officeid,to_officeid,delivery_status,driverid FROM delivery natural join parcel where to_officeid='" + officeid + "' and parcelid='" + parcelid + "' and delivery_status='delivering'";
            OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Emp2 ob = new Emp2(empid,officeid);
            this.Hide();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string parcelId = textBox1.Text.ToString();
                int rating = int.Parse(textBox2.Text);
                // Insert a row into the delivery log table
                InsertDeliveryLog(parcelId, "success", rating); // Assuming you have a method named InsertDeliveryLog

                //Delete the corresponding row from the parcel table
                DeleteParcel(parcelId); // Assuming you have a method named DeleteParcel
            }
            else
            {
                MessageBox.Show("No deliveries to complete.");
            }
        }
        private void InsertDeliveryLog(string parcelId, string result, int rating)
        {
                connect1();
                conn.Open();
                string query = "INSERT INTO del_log (logid, result, rating) VALUES (:logId,:result, :rating)";
                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(":logId", OracleDbType.Varchar2).Value = parcelId;
                command.Parameters.Add(":result", OracleDbType.Varchar2).Value = result;
                command.Parameters.Add(":rating", OracleDbType.Decimal).Value = rating;
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Delivery log inserted successfully.");
            }
            else
            {
                MessageBox.Show("No rows inserted into delivery log.");
            }
                conn.Close();
        }
        private void DeleteParcel(string parcelId)
        {
                connect1();
                conn.Open();
                string query = "DELETE FROM parcel WHERE parcelid = :parcelId";
                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(":parcelId", OracleDbType.Varchar2).Value = parcelId;
                command.ExecuteNonQuery();
            conn.Close();
        }
    }
}

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
    public partial class ParcelDetails : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string driverid;
        string officeid;
        public ParcelDetails()
        {
            InitializeComponent();
        }
        public ParcelDetails(string driverid, string officeid)
        {
            InitializeComponent();
            this.driverid = driverid;
            this.officeid = officeid;
        }
        public void connect1()
        {
            String oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void populatedatagridview()
        {
            connect1();
            conn.Open();
            string query = @"
            SELECT p.weight,
                   p.psize,
                   p.delivery_status,
                   p.safety_labels,
                   d.from_officeid,
                   d.to_officeid
            FROM parcel p
            JOIN delivery d ON p.parcelid = d.parcelid
            WHERE d.driverid IS NULL
              AND p.parcelid = :enteredParcelId
              AND d.from_officeid= :officeid";

            OracleCommand command = new OracleCommand(query, conn);
            command.Parameters.Add(":enteredParcelId", OracleDbType.Varchar2).Value = textBox1.Text;
            command.Parameters.Add(":officeid", OracleDbType.Varchar2).Value = officeid;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No parcels found/available for delivery.");
            }
            else
            {
                dataGridView1.DataSource = dataTable;
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Driver2 ob = new Driver2(driverid,officeid);
            this.Hide();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populatedatagridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the parcel ID from the selected row in the DataGridView
                string parcelId = textBox1.Text;

                // Update delivery_status of the parcel in parcel table to 'delivering'
                UpdateParcelStatus(parcelId, "delivering");

                // Update driverid for that parcel in delivery table to the driverid of driver given // Get the driver ID (you need to implement this)
                UpdateDeliveryDriverId(parcelId, driverid);
            }
            else
            {
                MessageBox.Show("Please select a parcel from the list.");
            }
        }

        private void UpdateParcelStatus(string parcelId, string status)
        {
            connect1();
            conn.Open();

            string query = "UPDATE parcel SET delivery_status = :status WHERE parcelid = :parcelId";
            OracleCommand command = new OracleCommand(query, conn);
            command.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;
            command.Parameters.Add(":parcelId", OracleDbType.Varchar2).Value = parcelId;
            command.ExecuteNonQuery();

            conn.Close();
        }
        private void UpdateDeliveryDriverId(string parcelId, string driverId)
        {
            connect1();
            conn.Open();

            string query = "UPDATE delivery SET driverid = :driverId WHERE parcelid = :parcelId";
            OracleCommand command = new OracleCommand(query, conn);
            command.Parameters.Add(":driverId", OracleDbType.Varchar2).Value = driverId;
            command.Parameters.Add(":parcelId", OracleDbType.Varchar2).Value = parcelId;
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}

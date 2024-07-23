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
    public partial class Emp2 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string officeid;
        string empid;
        public Emp2()
        {
            InitializeComponent();
        }
        public Emp2(string eid, string OID)
        {
            InitializeComponent();
            officeid = OID;
            empid = eid;
            label3.Text = officeid;
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
            string query = "SELECT parcelid,from_officeid,to_officeid,delivery_status,driverid FROM delivery natural join parcel where from_officeid='" + officeid + "' or to_officeid='" + officeid + "'";
            OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }
        private void Req_but_Click(object sender, EventArgs e)
        {
            Emp3 ob = new Emp3(empid, officeid);
            this.Hide();
            ob.Show();
        }

        private void Quit_but_Click(object sender, EventArgs e)
        {
            EmpLogin ob = new EmpLogin();
            this.Hide();
            ob.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Emp2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcceptDelivery ob = new AcceptDelivery(officeid,empid);
            this.Hide();
            ob.Show();
        }
    }
}

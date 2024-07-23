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
    public partial class DeliveryHistory : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public DeliveryHistory()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "OFFICE";
        }
        public void connect1()
        {
            String oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }
        public void populatedatagridview(string tablename)
        {
            connect1();
            conn.Open();
            string query = $"SELECT * FROM {tablename}";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void b_but_Click(object sender, EventArgs e)
        {
            Admin2 ob = new Admin2();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table = comboBox1.SelectedItem.ToString();
            populatedatagridview(table);
        }
    }
}

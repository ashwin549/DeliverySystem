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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeliverySystem_2
{
    public partial class EmpLogin : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public EmpLogin()
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

            Home ob = new Home();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from employee where EMPID='"+textBox1.Text+"'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "employee");
            dt = ds.Tables["employee"];
            int t = dt.Rows.Count;
            if (t > 0) {
                dr = dt.Rows[0];
                string empid = textBox1.Text;
                string name = dr["name"].ToString();
                string office = dr["officeID"].ToString();
                string position = dr["position"].ToString();
                string password = dr["password"].ToString();
                if (password == textBox2.Text) {
                    MessageBox.Show("Name:" + name + "   OfficeID:" + office + "   position:" + position);
                    conn.Close();
                    Emp2 ob = new Emp2(empid,office);
                    this.Hide();
                    ob.Show();
                }
                else { MessageBox.Show("Incorrect username/password"); }
                
            }
            else { MessageBox.Show("Incorrect username/password"); }

        }

        private void EmpLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

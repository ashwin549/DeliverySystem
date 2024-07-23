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
    public partial class Emp3 : Form
    {
        string Fromofficeid;
        string empid;
        OracleConnection conn;
        public Emp3()
        {
            InitializeComponent();
        }
        public Emp3(string eid,string office)
        {
            InitializeComponent();
            Fromofficeid = office;
            empid = eid;
            PopulateComboBox();
        }
        public void connect1()
        {
            String oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }
        public OracleConnection EstablishConnection()
        {
            string oradb = "Data Source=laptop-keifr5q6;User ID=ashwin;Password=MITpassword;";
            OracleConnection conn = new OracleConnection(oradb);
            return conn;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Emp2 obj = new Emp2();
            this.Hide();
            obj.Show();
        }
        private void PopulateComboBox()
        {
            comboBox1.Items.Clear();

            try
            {
                connect1();
                conn.Open();
                string query = "SELECT NAME,OFFICEID FROM OFFICE WHERE OFFICEID != :excludedOfficeName";

                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("excludedOfficeName", Fromofficeid));

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string officeName = reader.GetString(0);
                    string officeid_current= reader.GetString(1);
                    comboBox1.Items.Add(officeid_current + ","+officeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public int InsertParcel(int weight, string safety, int size)
        {
            int nextParcelId;
            using (OracleConnection connection = EstablishConnection())
            {
                string queryMaxParcelId = "SELECT MAX(ParcelID) FROM parcel";
                

                using (OracleCommand commandMaxParcelId = new OracleCommand(queryMaxParcelId, connection))
                {
                    try
                    {
                        connection.Open();
                        object maxParcelIdObj = commandMaxParcelId.ExecuteScalar();
                        if (maxParcelIdObj != null && maxParcelIdObj != DBNull.Value)
                        {
                            int maxParcelId = Convert.ToInt32(maxParcelIdObj);
                            nextParcelId = maxParcelId + 1;
                        }
                        else
                        {
                            nextParcelId = 1; // If no previous parcel ID exists
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error getting max parcel ID: " + ex.Message);
                        connection.Close() ;
                        return -1;
                    }
                }
            }
            connect1();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "INSERT INTO parcel(PARCELID, PSIZE, WEIGHT, DELIVERY_STATUS, SAFETY_LABELS) VALUES (:parcelId, :Psize, :Pweight, 'waiting', :Psafety )";
            cm.Parameters.Add(":parcelId", OracleDbType.Varchar2, 10).Value = nextParcelId.ToString();
            cm.Parameters.Add(":Psize", OracleDbType.Decimal).Value = size;
            cm.Parameters.Add(":Pweight", OracleDbType.Decimal).Value = weight;
            cm.Parameters.Add(":Psafety", OracleDbType.Varchar2, 10).Value = safety;
            cm.CommandType = CommandType.Text;
            conn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Inserted!");
            conn.Close();
            return nextParcelId;
        }
        public void InsertDelivery(int Parcelid, string fromoff,string tooffice)
        {
            int deliveryid=Parcelid;
            connect1();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "INSERT INTO DELIVERY(DELIVERYID,PARCELID, FROM_OFFICEID, TO_OFFICEID, EMPID) VALUES (:deliveryid,:parcelId, :fromoff, :tooff, :empid )";
            cm.Parameters.Add(":deliveryid", OracleDbType.Varchar2, 10).Value = deliveryid.ToString();
            cm.Parameters.Add(":parcelId", OracleDbType.Varchar2, 10).Value = Parcelid.ToString();
            cm.Parameters.Add(":fromoff", OracleDbType.Varchar2).Value = fromoff;
            cm.Parameters.Add(":tooff", OracleDbType.Varchar2).Value = tooffice;
            cm.Parameters.Add(":empid", OracleDbType.Varchar2, 10).Value = empid;
            cm.CommandType = CommandType.Text;
            conn.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Inserted!");
            conn.Close();
            return;
        }
        private void Emp3_Load(object sender, EventArgs e)
        {

        }

    private void button2_Click(object sender, EventArgs e)
        {
            string ToOffice = comboBox1.SelectedItem.ToString();
            string[] parts = ToOffice.Split(',');
            string ToofficeId = parts[0];
            string safety = comboBox2.SelectedItem.ToString();
            //try
            //{
                int weight = int.Parse(textBox1.Text);
                int size = int.Parse(textBox2.Text);
                int pid=InsertParcel(weight,safety,size);
                InsertDelivery(pid, Fromofficeid, ToofficeId);
           // }
            //catch (FormatException)
            //{
             //   MessageBox.Show("Invalid input!"); 
            //}
        }
    }
}

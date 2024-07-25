using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class Form3 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }
        private void LoadDatabase()
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
                // Change the query as needed, uncomment the desired one.
                da = new OleDbDataAdapter("SELECT * FROM Schedule", myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Schedule");
                dataGridView1.DataSource = ds.Tables["Schedule"];
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                if (myConn != null)
                {
                    myConn.Close();
                }
            }
        }
    }
}

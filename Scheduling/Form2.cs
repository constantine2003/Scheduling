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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Schedule (Team1, Team2, GameDate, GameTime, Venue) VALUES (@team1, @team2, @gamedate, @gametime, @venue)";
            OleDbCommand cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@team1", team1txt.Text);
            cmd.Parameters.AddWithValue("@team2", team2txt.Text);
            cmd.Parameters.AddWithValue("@gamedate", DateTime.Parse(gamedate.Text)); // Ensure this is a valid DateTime format
            cmd.Parameters.AddWithValue("@gametime", timetxt.Text); // Ensure this is a valid time format if needed
            cmd.Parameters.AddWithValue("@venue", venuetxt.Text);

            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }
        private void LoadDatabase()
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
                // Use the Schedule table instead of Volleyball
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


        private void button3_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
            da = new OleDbDataAdapter("SELECT *FROM Schedule", myConn);

            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Schedule");
            dataGridView1.DataSource = ds.Tables["Schedule"];
            myConn.Close();
        }

        private void venuetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

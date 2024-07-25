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
    public partial class Teams : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Teams()
        {
            InitializeComponent();
            categorytxt = this.categorytxt;
            teamidtxt = this.teamidtxt;
            winstxt = this.winstxt;
            losestxt = this.losestxt;
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
        }


        private void Teams_Load(object sender, EventArgs e)
        {
            LoadMaleQueryData();
            LoadFemaleQueryData();
            LoadMixedQueryData();
        }
        private void LoadMaleQueryData()
        {
            // Initialize the database connection
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
            OleDbDataAdapter da;
            DataSet ds;

            try
            {
                // Open the connection
                myConn.Open();

                // Create a data adapter to execute the query and fill the dataset
                string query = "SELECT * FROM [Male Query] ORDER BY Wins DESC"; // Sorting by Wins in descending order
                da = new OleDbDataAdapter(query, myConn);
                ds = new DataSet();
                da.Fill(ds, "MaleResult"); // Naming the result as "MaleResult" in the DataSet

                // Bind the dataset to the DataGridView
                dataGridView1.DataSource = ds.Tables["MaleResult"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void LoadFemaleQueryData()
        {
            // Initialize the database connection
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
            OleDbDataAdapter da;
            DataSet ds;

            try
            {
                // Open the connection
                myConn.Open();

                // Create a data adapter to execute the query and fill the dataset
                string query = "SELECT * FROM [Female Query] ORDER BY Wins DESC"; // Sorting by Wins in descending order
                da = new OleDbDataAdapter(query, myConn);
                ds = new DataSet();
                da.Fill(ds, "FemaleResult"); // Naming the result as "FemaleResult" in the DataSet

                // Bind the dataset to the DataGridView
                dataGridView2.DataSource = ds.Tables["FemaleResult"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void LoadMixedQueryData()
        {
            // Initialize the database connection
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
            OleDbDataAdapter da;
            DataSet ds;

            try
            {
                // Open the connection
                myConn.Open();

                // Create a data adapter to execute the query and fill the dataset
                string query = "SELECT * FROM [Mixed Query]"; // Replace this with your actual query if different
                da = new OleDbDataAdapter(query, myConn);
                ds = new DataSet();
                da.Fill(ds, "MixedQueryResult"); // Naming the result as "FemaleQueryResult" in the DataSet

                // Bind the dataset to the DataGridView
                dataGridView3.DataSource = ds.Tables["MixedQueryResult"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Check if the ComboBox is null
            if (categorytxt == null)
            {
                MessageBox.Show("ComboBox 'categorytxt' is not initialized.");
                return;
            }

            // Ensure a category is selected
            if (categorytxt.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid category.");
                return;
            }

            // Check if the textboxes are null
            if (teamidtxt == null || winstxt == null || losestxt == null)
            {
                MessageBox.Show("One or more textboxes are not initialized.");
                return;
            }

            // Determine the table name based on the selected category
            string selectedCategory = categorytxt.SelectedItem.ToString();
            string tableName;

            switch (selectedCategory)
            {
                case "Male":
                    tableName = "VolleyballMale";
                    break;
                case "Female":
                    tableName = "VolleyballFemale";
                    break;
                case "Mixed":
                    tableName = "VolleyballMixed";
                    break;
                default:
                    MessageBox.Show("Selected category is not valid.");
                    return;
            }

            // Construct the query dynamically
            string query = $"UPDATE [{tableName}] SET Wins = @Wins, Loses = @Loses WHERE TeamID = @id";

            // Create a new command
            using (OleDbCommand cmd = new OleDbCommand(query, myConn))
            {
                // Add parameters
                cmd.Parameters.AddWithValue("@Wins", Convert.ToInt32(winstxt.Text));
                cmd.Parameters.AddWithValue("@Loses", Convert.ToInt32(losestxt.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(teamidtxt.Text));

                // Open the connection, execute the query, and close the connection
                try
                {
                    myConn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show($"{rowsAffected} row(s) updated successfully!");
                }
                catch (FormatException fe)
                {
                    MessageBox.Show($"Formatting error: {fe.Message}");
                }
                catch (OleDbException oe)
                {
                    MessageBox.Show($"Database error: {oe.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    if (myConn.State == ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }
            LoadMaleQueryData();
            LoadFemaleQueryData();
            LoadMixedQueryData();
        }
    }
}

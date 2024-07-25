using System.Data.OleDb;
using System.Data;
using System.Xml.Linq;

namespace Scheduling
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }
        private void LoadDatabase()
        {
            using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;"))
            {
                try
                {
                    myConn.Open();

                    // Load VolleyballMale
                    using (OleDbDataAdapter daMale = new OleDbDataAdapter("SELECT * FROM VolleyballMale", myConn))
                    {
                        DataSet dsMale = new DataSet();
                        daMale.Fill(dsMale, "VolleyballMale");
                        dataGridView1.DataSource = dsMale.Tables["VolleyballMale"];
                    }

                    // Load VolleyballFemale
                    using (OleDbDataAdapter daFemale = new OleDbDataAdapter("SELECT * FROM VolleyballFemale", myConn))
                    {
                        DataSet dsFemale = new DataSet();
                        daFemale.Fill(dsFemale, "VolleyballFemale");
                        dataGridView2.DataSource = dsFemale.Tables["VolleyballFemale"];
                    }

                    // Load VolleyballMixed
                    using (OleDbDataAdapter daMixed = new OleDbDataAdapter("SELECT * FROM VolleyballMixed", myConn))
                    {
                        DataSet dsMixed = new DataSet();
                        daMixed.Fill(dsMixed, "VolleyballMixed");
                        dataGridView3.DataSource = dsMixed.Tables["VolleyballMixed"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        /*  private void Addbtn_Click(object sender, EventArgs e)
          {
              string query = "Insert into Volleyball (TeamName, CaptainBall, Coach, Category) values (@TName, @CBall, @Coach, @Cat)";
              cmd = new OleDbCommand(query, myConn);
              cmd.Parameters.AddWithValue("@TName", TeamNametxt.Text);
              cmd.Parameters.AddWithValue("@CBall", CaptainBalltxt.Text);
              cmd.Parameters.AddWithValue("@Coach", CoachNametxt.Text);
              cmd.Parameters.AddWithValue("@Cat", Categorytxt.Text);
              myConn.Open();
              cmd.ExecuteNonQuery();
              myConn.Close();

              LoadDatabase();
          } */
        private void Addbtn_Click(object sender, EventArgs e)
        {
            // Initialize the database connection
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\Database7.accdb;");

            try
            {
                // Test the connection
                myConn.Open();
              //  MessageBox.Show("Connected successfully!");

                // Check if a valid category is selected
                if (Category.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid category.");
                    return;
                }

                string selectedCategory = Category.SelectedItem.ToString();
                string tableName;

                // Debugging: Check the selected category
                MessageBox.Show($"Selected Category: {selectedCategory}");

                // Determine the table based on the selected category
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
                string query = $"INSERT INTO {tableName} (TeamName, CaptainBall, Coach, Category) VALUES (@TName, @CBall, @Coach, @Cat)";

                // Create a new command
                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    // Ensure TextBox controls are not null
                    if (TeamNametxt == null || CaptainBalltxt == null || CoachNametxt == null)
                    {
                        MessageBox.Show("TextBox controls are not initialized.");
                        return;
                    }

                    // Add parameters
                    cmd.Parameters.AddWithValue("@TName", TeamNametxt.Text);
                    cmd.Parameters.AddWithValue("@CBall", CaptainBalltxt.Text);
                    cmd.Parameters.AddWithValue("@Coach", CoachNametxt.Text);
                    cmd.Parameters.AddWithValue("@Cat", selectedCategory);

                    // Open the connection, execute the query, and close the connection
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data added successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
            finally
            {
                if (myConn.State == System.Data.ConnectionState.Open)
                {
                    myConn.Close();
                }
            }

            // Reload the database
            LoadDatabase();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Delete From Volleyball Where TeamID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id",
            dataGridView1.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

            LoadDatabase();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "UPDATE Volleyball SET TeamName = @Tname WHERE TeamID = @id";
                OleDbCommand cmd = new OleDbCommand(query, myConn);

                // Ensure the parameters names match those in the query
                cmd.Parameters.AddWithValue("@Tname", TeamNametxt.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(teamIDtxt.Text));

                myConn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                myConn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update successful!");
                }
                else
                {
                    MessageBox.Show("No rows affected. Please check if the TeamID exists.");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database update error: " + ex.Message);
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
            LoadDatabase();
        }
    }
}

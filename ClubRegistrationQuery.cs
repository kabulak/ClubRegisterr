using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class ClubRegistrationQuery
{
    // Private fields for database connection and operation
    private SqlConnection sqlConnect;
    private SqlCommand sqlCommand;
    private SqlDataAdapter sqlAdapter;
    private DataTable dataTable;
    private BindingSource bindingSource;

    
    private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Justine\ClubRegisterr\Database1.mdf;Integrated Security=True;Connect Timeout=30;";


   
    public ClubRegistrationQuery()
    {
        
        sqlConnect = new SqlConnection(connectionString);
        dataTable = new DataTable();
        bindingSource = new BindingSource();
    }

    
    public bool DisplayList(DataGridView dataGridView)
    {
        try
        {
            
            string query = "SELECT * FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(query, sqlConnect);

            
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);

            
            bindingSource.DataSource = dataTable;
            dataGridView.DataSource = bindingSource;

            return true;
        }
        catch (Exception ex)
        {
            
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // Method to register a new student in the database
    public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
    {
        try
        {
            // SQL command with parameters to insert a new record
            sqlCommand = new SqlCommand(
                "INSERT INTO ClubMembers (ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program) " +
                "VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)",
                sqlConnect);

            // Add parameters to the SQL command
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlCommand.Parameters.AddWithValue("@StudentID", StudentID);
            sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
            sqlCommand.Parameters.AddWithValue("@MiddleName", MiddleName);
            sqlCommand.Parameters.AddWithValue("@LastName", LastName);
            sqlCommand.Parameters.AddWithValue("@Age", Age);
            sqlCommand.Parameters.AddWithValue("@Gender", Gender);
            sqlCommand.Parameters.AddWithValue("@Program", Program);

            // Open the database connection, execute the query, and close the connection
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            return true;
        }
        catch (Exception ex)
        {
            // Display error message if the operation fails
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            // Ensure the connection is closed even if an exception occurs
            if (sqlConnect.State == ConnectionState.Open)
                sqlConnect.Close();
        }
    }
}

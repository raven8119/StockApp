using System.Data.OleDb;

namespace StockAppV2
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Uni Work\\SDAM2\\~SDAM2 Assignment\\StockAppV2\\StockAppDatabaseV2.accdb\";Persist Security Info=True;User ID=admin";
            String username = usernameText.Text;
            String password = passwordText.Text;

            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            try
            {
                // get userID from login 
                String getUserID = $"SELECT userID FROM login WHERE username = '{username}'";
                OleDbCommand getUserIDCommand = new OleDbCommand(getUserID, connection);
                int userID = Convert.ToInt32(getUserIDCommand.ExecuteScalar());

                // get password with the same userID from login
                String getPassword = $"SELECT password FROM login WHERE userID = {userID}";
                OleDbCommand getPasswordCommand = new OleDbCommand(getPassword, connection);
                String passwordFromDB = getPasswordCommand.ExecuteScalar().ToString();

                // compare password from login form with password from database
                if (password != passwordFromDB)
                {
                    // login failed message
                    MessageBox.Show("Login failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // update lastLogin date and time
                    String lastLogin = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    String updateLastLogin = $"UPDATE login SET lastLogin = '{lastLogin}' WHERE userID = {userID}";
                    OleDbCommand updateLastLoginCommand = new OleDbCommand(updateLastLogin, connection);
                    updateLastLoginCommand.ExecuteNonQuery();


                    // login successful and show options form
                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    optionsForm optionsForm = new optionsForm();
                    optionsForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
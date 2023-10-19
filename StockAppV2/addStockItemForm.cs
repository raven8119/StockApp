using System.Data.OleDb;

namespace StockAppV2
{
    public partial class addStockItemForm : Form
    {
        public addStockItemForm()
        {
            InitializeComponent();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\Uni Work\\SDAM2\\~SDAM2 Assignment\\StockAppV2\\StockAppDatabaseV2.accdb\";Persist Security Info=True;User ID=admin";
                String stockCode = stockItemCodeText.Text;
                String stockName = stockItemNameText.Text;
                int stockQuantity = Convert.ToInt32(stockQuantityText.Text);

                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();

                Item item = new Item(stockCode, stockName, stockQuantity);
                item.AddItem(connection);
                item.UpdateLog(connection, "Item added.");

                connection.Close();

                stockItemCodeText.Text = "";
                stockItemNameText.Text = "";
                stockQuantityText.Text = "";
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Database error. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid format. {ex.Message}", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unknown error has occured. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            optionsForm optionsForm = new optionsForm();
            optionsForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }
    }
}

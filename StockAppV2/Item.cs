using System.Data.OleDb;

namespace StockAppV2
{
    internal class Item
    {
        private String stockCode;
        private String stockName;
        private int stockQuantity;

        // Constructor for adding quantity to existing stock item
        public Item(String stockCode, int stockQuantity)
        {
            this.stockCode = stockCode;
            stockName = "";
            this.stockQuantity = stockQuantity;
        }

        // Constructor for adding new stock item
        public Item(String stockCode, String stockName, int stockQuantity)
        {


            this.stockCode = stockCode;
            // stock name should not be empty
            if (stockName == "")
            {
                throw new System.ArgumentException("Stock name cannot be empty.");
            }
            this.stockName = stockName;
            this.stockQuantity = stockQuantity;
        }

        public void AddItem(OleDbConnection connection)
        {
            // Insert stock item
            String insertQuery = $"INSERT INTO stockTable (stockCode, stockName, stockQuantity) VALUES ('{stockCode}', '{stockName}', '{stockQuantity}');";

            OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);

            int rowsAffected = insertCommand.ExecuteNonQuery();
            // Confirmation
            if (rowsAffected > 0)
            {
                MessageBox.Show("Stock item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Stock item not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add quantity to existing stock item
        public bool AddQuantity(OleDbConnection connection)
        {
            // Update stock quantity
            string updateQuery = $"UPDATE stockTable SET stockQuantity = stockQuantity + {stockQuantity} WHERE stockCode = '{stockCode}';";
            OleDbCommand oleDbCommand = new OleDbCommand(updateQuery, connection);

            int rowsAffected = oleDbCommand.ExecuteNonQuery();

            // Confirmation
            if (rowsAffected > 0)
            {
                MessageBox.Show("Quantity added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // update stockName 
                String getStockNameQuery = $"SELECT stockName FROM stockTable WHERE stockCode = '{stockCode}';";
                OleDbCommand getStockNameCommand = new OleDbCommand(getStockNameQuery, connection);
                stockName = getStockNameCommand.ExecuteScalar().ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Quantity not added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void UpdateLog(OleDbConnection connection, String action)
        {
            int logID;
            String timeStamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm").Replace('-', '/');

            // Check if log table is empty. If it is, logID is set to 1. If not, logID is set to the next available logID.
            String checkQuery = $"SELECT COUNT(*) FROM transactionLog;";
            OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection);

            int count = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (count > 0)
            {
                String getLogIDQuery = $"SELECT MAX(logID) FROM transactionLog";
                OleDbCommand getLogIDCommand = new OleDbCommand(getLogIDQuery, connection);
                logID = Convert.ToInt32(getLogIDCommand.ExecuteScalar());
                ++logID;
            }
            else
            {
                logID = 1;
            }

            // Get total stock quantity
            String getTotalQuery = $"SELECT stockQuantity FROM stockTable WHERE stockCode = '{stockCode}';";
            OleDbCommand getTotalCommand = new OleDbCommand(getTotalQuery, connection);
            int total = Convert.ToInt32(getTotalCommand.ExecuteScalar());

            // Insert log
            String insertQuery = $"INSERT INTO transactionLog (logID, logTime, process, stockCode, stockName,  quantityAdded, total) VALUES ({logID}, '{timeStamp}', '{action}', '{stockCode}', '{stockName}', {stockQuantity}, {total});";
            OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);

            insertCommand.ExecuteNonQuery();
        }
    }
}
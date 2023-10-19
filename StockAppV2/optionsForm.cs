namespace StockAppV2
{
    public partial class optionsForm : Form
    {
        public optionsForm()
        {
            InitializeComponent();
        }

        // Open addStockItemForm
        private void addStockItemBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStockItemForm addStockItemForm = new addStockItemForm();
            addStockItemForm.Show();
        }

        // Open addQuantityForm
        private void addQtyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addQuantityForm addQuantityForm = new addQuantityForm();
            addQuantityForm.Show();
        }

        // Exit application by pressing exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Confirm exit
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }
    }
}

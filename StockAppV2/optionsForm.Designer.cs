namespace StockAppV2
{
    partial class optionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addStockItemBtn = new Button();
            addQtyBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // addStockItemBtn
            // 
            addStockItemBtn.Cursor = Cursors.Hand;
            addStockItemBtn.Location = new Point(167, 134);
            addStockItemBtn.Name = "addStockItemBtn";
            addStockItemBtn.Size = new Size(146, 53);
            addStockItemBtn.TabIndex = 0;
            addStockItemBtn.Text = "Add Stock Item";
            addStockItemBtn.UseVisualStyleBackColor = true;
            addStockItemBtn.Click += addStockItemBtn_Click;
            // 
            // addQtyBtn
            // 
            addQtyBtn.Cursor = Cursors.Hand;
            addQtyBtn.Location = new Point(167, 193);
            addQtyBtn.Name = "addQtyBtn";
            addQtyBtn.Size = new Size(146, 53);
            addQtyBtn.TabIndex = 1;
            addQtyBtn.Text = "Add Quantity";
            addQtyBtn.UseVisualStyleBackColor = true;
            addQtyBtn.Click += addQtyBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(167, 252);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(146, 53);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // optionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            ControlBox = false;
            Controls.Add(exitBtn);
            Controls.Add(addQtyBtn);
            Controls.Add(addStockItemBtn);
            Name = "optionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose Option";
            ResumeLayout(false);
        }

        #endregion

        private Button addStockItemBtn;
        private Button addQtyBtn;
        private Button exitBtn;
    }
}
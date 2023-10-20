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
            remStockItemBtn = new Button();
            remQtyBtn = new Button();
            logOutBtn = new Button();
            viewlogBtn = new Button();
            viewStockBtn = new Button();
            SuspendLayout();
            // 
            // addStockItemBtn
            // 
            addStockItemBtn.Cursor = Cursors.Hand;
            addStockItemBtn.Location = new Point(89, 89);
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
            addQtyBtn.Location = new Point(89, 148);
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
            exitBtn.Location = new Point(241, 266);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(146, 53);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // remStockItemBtn
            // 
            remStockItemBtn.Cursor = Cursors.Hand;
            remStockItemBtn.Location = new Point(241, 89);
            remStockItemBtn.Name = "remStockItemBtn";
            remStockItemBtn.Size = new Size(146, 53);
            remStockItemBtn.TabIndex = 3;
            remStockItemBtn.Text = "Remove Stock Item";
            remStockItemBtn.UseVisualStyleBackColor = true;
            // 
            // remQtyBtn
            // 
            remQtyBtn.Cursor = Cursors.Hand;
            remQtyBtn.Location = new Point(241, 148);
            remQtyBtn.Name = "remQtyBtn";
            remQtyBtn.Size = new Size(146, 53);
            remQtyBtn.TabIndex = 4;
            remQtyBtn.Text = "Remove Quantity";
            remQtyBtn.UseVisualStyleBackColor = true;
            // 
            // logOutBtn
            // 
            logOutBtn.Cursor = Cursors.Hand;
            logOutBtn.Location = new Point(89, 266);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(146, 53);
            logOutBtn.TabIndex = 5;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = true;
            // 
            // viewlogBtn
            // 
            viewlogBtn.Cursor = Cursors.Hand;
            viewlogBtn.Location = new Point(89, 207);
            viewlogBtn.Name = "viewlogBtn";
            viewlogBtn.Size = new Size(146, 53);
            viewlogBtn.TabIndex = 6;
            viewlogBtn.Text = "View Logs";
            viewlogBtn.UseVisualStyleBackColor = true;
            // 
            // viewStockBtn
            // 
            viewStockBtn.Cursor = Cursors.Hand;
            viewStockBtn.Location = new Point(241, 207);
            viewStockBtn.Name = "viewStockBtn";
            viewStockBtn.Size = new Size(146, 53);
            viewStockBtn.TabIndex = 7;
            viewStockBtn.Text = "View Stock Levels";
            viewStockBtn.UseVisualStyleBackColor = true;
            // 
            // optionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            ControlBox = false;
            Controls.Add(viewStockBtn);
            Controls.Add(viewlogBtn);
            Controls.Add(logOutBtn);
            Controls.Add(remQtyBtn);
            Controls.Add(remStockItemBtn);
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
        private Button remStockItemBtn;
        private Button remQtyBtn;
        private Button logOutBtn;
        private Button viewlogBtn;
        private Button viewStockBtn;
    }
}
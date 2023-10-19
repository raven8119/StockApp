namespace StockAppV2
{
    partial class addStockItemForm
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
            backBtn = new Button();
            stockItemNameText = new TextBox();
            label1 = new Label();
            addItemBtn = new Button();
            qtyLabel = new Label();
            codeLbl = new Label();
            stockQuantityText = new TextBox();
            stockItemCodeText = new TextBox();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(159, 337);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(79, 53);
            backBtn.TabIndex = 14;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // stockItemNameText
            // 
            stockItemNameText.Location = new Point(252, 162);
            stockItemNameText.Name = "stockItemNameText";
            stockItemNameText.Size = new Size(125, 27);
            stockItemNameText.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 165);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 12;
            label1.Text = "Stock Item Name:";
            // 
            // addItemBtn
            // 
            addItemBtn.Cursor = Cursors.Hand;
            addItemBtn.Location = new Point(159, 278);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(164, 53);
            addItemBtn.TabIndex = 11;
            addItemBtn.Text = "Add Item";
            addItemBtn.UseVisualStyleBackColor = true;
            addItemBtn.Click += addItemBtn_Click;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new Point(144, 215);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(68, 20);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "Quantity:";
            // 
            // codeLbl
            // 
            codeLbl.AutoSize = true;
            codeLbl.Location = new Point(91, 116);
            codeLbl.Name = "codeLbl";
            codeLbl.Size = new Size(121, 20);
            codeLbl.TabIndex = 7;
            codeLbl.Text = "Stock Item Code:";
            // 
            // stockQuantityText
            // 
            stockQuantityText.Location = new Point(252, 212);
            stockQuantityText.Name = "stockQuantityText";
            stockQuantityText.Size = new Size(125, 27);
            stockQuantityText.TabIndex = 10;
            // 
            // stockItemCodeText
            // 
            stockItemCodeText.Location = new Point(252, 109);
            stockItemCodeText.Name = "stockItemCodeText";
            stockItemCodeText.Size = new Size(125, 27);
            stockItemCodeText.TabIndex = 8;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(244, 337);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(79, 53);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // addStockItemForm
            // 
            AcceptButton = addItemBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            ControlBox = false;
            Controls.Add(exitBtn);
            Controls.Add(backBtn);
            Controls.Add(stockItemNameText);
            Controls.Add(label1);
            Controls.Add(addItemBtn);
            Controls.Add(qtyLabel);
            Controls.Add(codeLbl);
            Controls.Add(stockQuantityText);
            Controls.Add(stockItemCodeText);
            Name = "addStockItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Stock Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private TextBox stockItemNameText;
        private Label label1;
        private Button addItemBtn;
        private Label qtyLabel;
        private Label codeLbl;
        private TextBox stockQuantityText;
        private TextBox stockItemCodeText;
        private Button exitBtn;
    }
}
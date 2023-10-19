namespace StockAppV2
{
    partial class addQuantityForm
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
            addQtyBtn = new Button();
            qtyLabel = new Label();
            codeLbl = new Label();
            stockQuantityText = new TextBox();
            stockItemCodeText = new TextBox();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(162, 327);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(79, 53);
            backBtn.TabIndex = 20;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // addQtyBtn
            // 
            addQtyBtn.Cursor = Cursors.Hand;
            addQtyBtn.Location = new Point(162, 268);
            addQtyBtn.Name = "addQtyBtn";
            addQtyBtn.Size = new Size(164, 53);
            addQtyBtn.TabIndex = 19;
            addQtyBtn.Text = "Add Quantity";
            addQtyBtn.UseVisualStyleBackColor = true;
            addQtyBtn.Click += addQtyBtn_Click;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new Point(149, 193);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(68, 20);
            qtyLabel.TabIndex = 15;
            qtyLabel.Text = "Quantity:";
            // 
            // codeLbl
            // 
            codeLbl.AutoSize = true;
            codeLbl.Location = new Point(96, 148);
            codeLbl.Name = "codeLbl";
            codeLbl.Size = new Size(121, 20);
            codeLbl.TabIndex = 16;
            codeLbl.Text = "Stock Item Code:";
            // 
            // stockQuantityText
            // 
            stockQuantityText.Location = new Point(257, 190);
            stockQuantityText.Name = "stockQuantityText";
            stockQuantityText.Size = new Size(125, 27);
            stockQuantityText.TabIndex = 18;
            // 
            // stockItemCodeText
            // 
            stockItemCodeText.Location = new Point(257, 141);
            stockItemCodeText.Name = "stockItemCodeText";
            stockItemCodeText.Size = new Size(125, 27);
            stockItemCodeText.TabIndex = 17;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(247, 327);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(79, 53);
            exitBtn.TabIndex = 21;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // addQuantityForm
            // 
            AcceptButton = addQtyBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            ControlBox = false;
            Controls.Add(exitBtn);
            Controls.Add(backBtn);
            Controls.Add(addQtyBtn);
            Controls.Add(qtyLabel);
            Controls.Add(codeLbl);
            Controls.Add(stockQuantityText);
            Controls.Add(stockItemCodeText);
            Name = "addQuantityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Quantity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Button addQtyBtn;
        private Label qtyLabel;
        private Label codeLbl;
        private TextBox stockQuantityText;
        private TextBox stockItemCodeText;
        private Button exitBtn;
    }
}
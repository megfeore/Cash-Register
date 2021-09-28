
namespace Cash_Register
{
    partial class Form1
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
            this.conesLabel = new System.Windows.Forms.Label();
            this.milkshakeLabel = new System.Windows.Forms.Label();
            this.sundaeLabel = new System.Windows.Forms.Label();
            this.coneTextBox = new System.Windows.Forms.TextBox();
            this.milkshakeTextBox = new System.Windows.Forms.TextBox();
            this.sundaeTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.blackLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedTextBox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeLabel2 = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.printingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conesLabel
            // 
            this.conesLabel.AutoSize = true;
            this.conesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conesLabel.Location = new System.Drawing.Point(12, 21);
            this.conesLabel.Name = "conesLabel";
            this.conesLabel.Size = new System.Drawing.Size(185, 25);
            this.conesLabel.TabIndex = 0;
            this.conesLabel.Text = "Number of Cones:";
            // 
            // milkshakeLabel
            // 
            this.milkshakeLabel.AutoSize = true;
            this.milkshakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkshakeLabel.Location = new System.Drawing.Point(12, 56);
            this.milkshakeLabel.Name = "milkshakeLabel";
            this.milkshakeLabel.Size = new System.Drawing.Size(231, 25);
            this.milkshakeLabel.TabIndex = 1;
            this.milkshakeLabel.Text = "Number of Milkshakes:";
            // 
            // sundaeLabel
            // 
            this.sundaeLabel.AutoSize = true;
            this.sundaeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundaeLabel.Location = new System.Drawing.Point(12, 91);
            this.sundaeLabel.Name = "sundaeLabel";
            this.sundaeLabel.Size = new System.Drawing.Size(208, 25);
            this.sundaeLabel.TabIndex = 2;
            this.sundaeLabel.Text = "Number of Sundaes:";
            // 
            // coneTextBox
            // 
            this.coneTextBox.Location = new System.Drawing.Point(260, 26);
            this.coneTextBox.Name = "coneTextBox";
            this.coneTextBox.Size = new System.Drawing.Size(100, 20);
            this.coneTextBox.TabIndex = 3;
            // 
            // milkshakeTextBox
            // 
            this.milkshakeTextBox.Location = new System.Drawing.Point(260, 61);
            this.milkshakeTextBox.Name = "milkshakeTextBox";
            this.milkshakeTextBox.Size = new System.Drawing.Size(100, 20);
            this.milkshakeTextBox.TabIndex = 4;
            // 
            // sundaeTextBox
            // 
            this.sundaeTextBox.Location = new System.Drawing.Point(260, 97);
            this.sundaeTextBox.Name = "sundaeTextBox";
            this.sundaeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sundaeTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(80, 145);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(216, 39);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(12, 201);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(97, 25);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal:";
            this.subtotalLabel.Click += new System.EventHandler(this.subtotalLabel_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 252);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(54, 25);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 298);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(66, 25);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            // 
            // totalsLabel
            // 
            this.totalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.Location = new System.Drawing.Point(199, 201);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(97, 122);
            this.totalsLabel.TabIndex = 10;
            this.totalsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.Location = new System.Drawing.Point(54, 419);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(216, 39);
            this.calculateChangeButton.TabIndex = 11;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackLabel.Location = new System.Drawing.Point(14, 337);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(346, 15);
            this.blackLabel.TabIndex = 12;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 375);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(110, 25);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Location = new System.Drawing.Point(196, 380);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedTextBox.TabIndex = 14;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 484);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(93, 25);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change:";
            // 
            // changeLabel2
            // 
            this.changeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel2.Location = new System.Drawing.Point(199, 484);
            this.changeLabel2.Name = "changeLabel2";
            this.changeLabel2.Size = new System.Drawing.Size(93, 25);
            this.changeLabel2.TabIndex = 16;
            // 
            // receiptButton
            // 
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(54, 525);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(216, 39);
            this.receiptButton.TabIndex = 17;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // printingLabel
            // 
            this.printingLabel.BackColor = System.Drawing.Color.White;
            this.printingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel.Location = new System.Drawing.Point(398, 21);
            this.printingLabel.Name = "printingLabel";
            this.printingLabel.Size = new System.Drawing.Size(284, 476);
            this.printingLabel.TabIndex = 18;
            this.printingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 578);
            this.Controls.Add(this.printingLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel2);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedTextBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.totalsLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.sundaeTextBox);
            this.Controls.Add(this.milkshakeTextBox);
            this.Controls.Add(this.coneTextBox);
            this.Controls.Add(this.sundaeLabel);
            this.Controls.Add(this.milkshakeLabel);
            this.Controls.Add(this.conesLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conesLabel;
        private System.Windows.Forms.Label milkshakeLabel;
        private System.Windows.Forms.Label sundaeLabel;
        private System.Windows.Forms.TextBox coneTextBox;
        private System.Windows.Forms.TextBox milkshakeTextBox;
        private System.Windows.Forms.TextBox sundaeTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedTextBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeLabel2;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label printingLabel;
    }
}


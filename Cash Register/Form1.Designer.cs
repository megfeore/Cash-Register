
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.printingLabel2 = new System.Windows.Forms.Label();
            this.printingLabel3 = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.printingLabel4 = new System.Windows.Forms.Label();
            this.blackLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conesLabel
            // 
            this.conesLabel.AutoSize = true;
            this.conesLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conesLabel.Location = new System.Drawing.Point(12, 21);
            this.conesLabel.Name = "conesLabel";
            this.conesLabel.Size = new System.Drawing.Size(203, 29);
            this.conesLabel.TabIndex = 0;
            this.conesLabel.Text = "Number of Cones:";
            // 
            // milkshakeLabel
            // 
            this.milkshakeLabel.AutoSize = true;
            this.milkshakeLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkshakeLabel.Location = new System.Drawing.Point(12, 57);
            this.milkshakeLabel.Name = "milkshakeLabel";
            this.milkshakeLabel.Size = new System.Drawing.Size(252, 29);
            this.milkshakeLabel.TabIndex = 1;
            this.milkshakeLabel.Text = "Number of Milkshakes:";
            // 
            // sundaeLabel
            // 
            this.sundaeLabel.AutoSize = true;
            this.sundaeLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundaeLabel.Location = new System.Drawing.Point(12, 91);
            this.sundaeLabel.Name = "sundaeLabel";
            this.sundaeLabel.Size = new System.Drawing.Size(225, 29);
            this.sundaeLabel.TabIndex = 2;
            this.sundaeLabel.Text = "Number of Sundaes:";
            // 
            // coneTextBox
            // 
            this.coneTextBox.Location = new System.Drawing.Point(272, 26);
            this.coneTextBox.Name = "coneTextBox";
            this.coneTextBox.Size = new System.Drawing.Size(100, 20);
            this.coneTextBox.TabIndex = 3;
            // 
            // milkshakeTextBox
            // 
            this.milkshakeTextBox.Location = new System.Drawing.Point(272, 65);
            this.milkshakeTextBox.Name = "milkshakeTextBox";
            this.milkshakeTextBox.Size = new System.Drawing.Size(100, 20);
            this.milkshakeTextBox.TabIndex = 4;
            // 
            // sundaeTextBox
            // 
            this.sundaeTextBox.Location = new System.Drawing.Point(272, 97);
            this.sundaeTextBox.Name = "sundaeTextBox";
            this.sundaeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sundaeTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.subtotalLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(12, 201);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(110, 29);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 252);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(58, 29);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 298);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(75, 29);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            // 
            // totalsLabel
            // 
            this.totalsLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.Location = new System.Drawing.Point(140, 201);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(97, 122);
            this.totalsLabel.TabIndex = 10;
            this.totalsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.Magenta;
            this.calculateChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.calculateChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.Location = new System.Drawing.Point(80, 420);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(216, 39);
            this.calculateChangeButton.TabIndex = 11;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
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
            this.tenderedLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 375);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(120, 29);
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
            this.changeLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 541);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(97, 25);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change:";
            // 
            // changeLabel2
            // 
            this.changeLabel2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel2.Location = new System.Drawing.Point(199, 541);
            this.changeLabel2.Name = "changeLabel2";
            this.changeLabel2.Size = new System.Drawing.Size(109, 25);
            this.changeLabel2.TabIndex = 16;
            // 
            // receiptButton
            // 
            this.receiptButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(54, 589);
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
            this.printingLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel.Location = new System.Drawing.Point(398, 21);
            this.printingLabel.Name = "printingLabel";
            this.printingLabel.Size = new System.Drawing.Size(284, 398);
            this.printingLabel.TabIndex = 18;
            this.printingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // printingLabel2
            // 
            this.printingLabel2.BackColor = System.Drawing.Color.White;
            this.printingLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel2.Location = new System.Drawing.Point(408, 91);
            this.printingLabel2.Name = "printingLabel2";
            this.printingLabel2.Size = new System.Drawing.Size(134, 318);
            this.printingLabel2.TabIndex = 19;
            // 
            // printingLabel3
            // 
            this.printingLabel3.BackColor = System.Drawing.Color.White;
            this.printingLabel3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel3.Location = new System.Drawing.Point(596, 91);
            this.printingLabel3.Name = "printingLabel3";
            this.printingLabel3.Size = new System.Drawing.Size(75, 318);
            this.printingLabel3.TabIndex = 20;
            this.printingLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(439, 441);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(216, 39);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // printingLabel4
            // 
            this.printingLabel4.BackColor = System.Drawing.Color.White;
            this.printingLabel4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel4.Location = new System.Drawing.Point(412, 317);
            this.printingLabel4.Name = "printingLabel4";
            this.printingLabel4.Size = new System.Drawing.Size(259, 92);
            this.printingLabel4.TabIndex = 22;
            this.printingLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blackLabel2
            // 
            this.blackLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackLabel2.ForeColor = System.Drawing.Color.White;
            this.blackLabel2.Location = new System.Drawing.Point(14, 483);
            this.blackLabel2.Name = "blackLabel2";
            this.blackLabel2.Size = new System.Drawing.Size(346, 43);
            this.blackLabel2.TabIndex = 23;
            this.blackLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(715, 640);
            this.Controls.Add(this.blackLabel2);
            this.Controls.Add(this.printingLabel4);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printingLabel3);
            this.Controls.Add(this.printingLabel2);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Meg\'s Icecream Parlour";
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
        private System.Windows.Forms.Label printingLabel2;
        private System.Windows.Forms.Label printingLabel3;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label printingLabel4;
        private System.Windows.Forms.Label blackLabel2;
    }
}


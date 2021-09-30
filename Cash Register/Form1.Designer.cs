
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.backgroundTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // conesLabel
            // 
            this.conesLabel.AutoSize = true;
            this.conesLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conesLabel.Location = new System.Drawing.Point(23, 106);
            this.conesLabel.Name = "conesLabel";
            this.conesLabel.Size = new System.Drawing.Size(203, 29);
            this.conesLabel.TabIndex = 0;
            this.conesLabel.Text = "Number of Cones:";
            // 
            // milkshakeLabel
            // 
            this.milkshakeLabel.AutoSize = true;
            this.milkshakeLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkshakeLabel.Location = new System.Drawing.Point(23, 142);
            this.milkshakeLabel.Name = "milkshakeLabel";
            this.milkshakeLabel.Size = new System.Drawing.Size(252, 29);
            this.milkshakeLabel.TabIndex = 1;
            this.milkshakeLabel.Text = "Number of Milkshakes:";
            // 
            // sundaeLabel
            // 
            this.sundaeLabel.AutoSize = true;
            this.sundaeLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundaeLabel.Location = new System.Drawing.Point(23, 176);
            this.sundaeLabel.Name = "sundaeLabel";
            this.sundaeLabel.Size = new System.Drawing.Size(225, 29);
            this.sundaeLabel.TabIndex = 2;
            this.sundaeLabel.Text = "Number of Sundaes:";
            // 
            // coneTextBox
            // 
            this.coneTextBox.Location = new System.Drawing.Point(283, 111);
            this.coneTextBox.Name = "coneTextBox";
            this.coneTextBox.Size = new System.Drawing.Size(100, 20);
            this.coneTextBox.TabIndex = 3;
            // 
            // milkshakeTextBox
            // 
            this.milkshakeTextBox.Location = new System.Drawing.Point(283, 147);
            this.milkshakeTextBox.Name = "milkshakeTextBox";
            this.milkshakeTextBox.Size = new System.Drawing.Size(100, 20);
            this.milkshakeTextBox.TabIndex = 4;
            // 
            // sundaeTextBox
            // 
            this.sundaeTextBox.Location = new System.Drawing.Point(283, 182);
            this.sundaeTextBox.Name = "sundaeTextBox";
            this.sundaeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sundaeTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(91, 230);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(216, 39);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(23, 286);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(110, 29);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(23, 337);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(58, 29);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(23, 383);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(75, 29);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            // 
            // totalsLabel
            // 
            this.totalsLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.Location = new System.Drawing.Point(151, 286);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(97, 122);
            this.totalsLabel.TabIndex = 10;
            this.totalsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.calculateChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.calculateChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.ForeColor = System.Drawing.Color.Black;
            this.calculateChangeButton.Location = new System.Drawing.Point(91, 505);
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
            this.blackLabel.Location = new System.Drawing.Point(25, 422);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(346, 15);
            this.blackLabel.TabIndex = 12;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(23, 460);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(120, 29);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Location = new System.Drawing.Point(207, 465);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedTextBox.TabIndex = 14;
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(23, 626);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(120, 25);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change:";
            // 
            // changeLabel2
            // 
            this.changeLabel2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel2.Location = new System.Drawing.Point(210, 626);
            this.changeLabel2.Name = "changeLabel2";
            this.changeLabel2.Size = new System.Drawing.Size(109, 25);
            this.changeLabel2.TabIndex = 16;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(91, 674);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(216, 39);
            this.receiptButton.TabIndex = 17;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // printingLabel
            // 
            this.printingLabel.BackColor = System.Drawing.Color.White;
            this.printingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printingLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel.Location = new System.Drawing.Point(409, 106);
            this.printingLabel.Name = "printingLabel";
            this.printingLabel.Size = new System.Drawing.Size(284, 398);
            this.printingLabel.TabIndex = 18;
            this.printingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // printingLabel2
            // 
            this.printingLabel2.BackColor = System.Drawing.Color.White;
            this.printingLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel2.Location = new System.Drawing.Point(419, 176);
            this.printingLabel2.Name = "printingLabel2";
            this.printingLabel2.Size = new System.Drawing.Size(134, 318);
            this.printingLabel2.TabIndex = 19;
            // 
            // printingLabel3
            // 
            this.printingLabel3.BackColor = System.Drawing.Color.White;
            this.printingLabel3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel3.Location = new System.Drawing.Point(607, 176);
            this.printingLabel3.Name = "printingLabel3";
            this.printingLabel3.Size = new System.Drawing.Size(75, 318);
            this.printingLabel3.TabIndex = 20;
            this.printingLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(450, 526);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(216, 39);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // printingLabel4
            // 
            this.printingLabel4.BackColor = System.Drawing.Color.White;
            this.printingLabel4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingLabel4.Location = new System.Drawing.Point(423, 402);
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
            this.blackLabel2.Location = new System.Drawing.Point(25, 568);
            this.blackLabel2.Name = "blackLabel2";
            this.blackLabel2.Size = new System.Drawing.Size(346, 43);
            this.blackLabel2.TabIndex = 23;
            this.blackLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(25, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(668, 45);
            this.titleLabel.TabIndex = 24;
            this.titleLabel.Text = "Welcome to Meg\'s Icecream Parlour ";
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.BackColor = System.Drawing.Color.White;
            this.titleLabel2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.Location = new System.Drawing.Point(172, 54);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(371, 31);
            this.titleLabel2.TabIndex = 25;
            this.titleLabel2.Text = "Please enter your order below";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cash_Register.Properties.Resources.milkshake_clip_art_6;
            this.pictureBox3.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cash_Register.Properties.Resources.sundae;
            this.pictureBox2.Location = new System.Drawing.Point(289, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cash_Register.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(377, 588);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Cash_Register.Properties.Resources._2;
            this.pictureBox4.Location = new System.Drawing.Point(498, 588);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Cash_Register.Properties.Resources._2;
            this.pictureBox5.Location = new System.Drawing.Point(611, 588);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(125, 134);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // backgroundTitleLabel
            // 
            this.backgroundTitleLabel.BackColor = System.Drawing.Color.White;
            this.backgroundTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundTitleLabel.Location = new System.Drawing.Point(10, 5);
            this.backgroundTitleLabel.Name = "backgroundTitleLabel";
            this.backgroundTitleLabel.Size = new System.Drawing.Size(693, 89);
            this.backgroundTitleLabel.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(715, 734);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.titleLabel);
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
            this.Controls.Add(this.backgroundTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Meg\'s Icecream Parlour";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label backgroundTitleLabel;
    }
}


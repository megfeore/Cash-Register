using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of Thread.Sleep() 

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        //3 global variables to hold the 3 different item prices
        double conePrice = 3.15;
        double milkshakePrice = 4.00;
        double sundaePrice = 3.75;
        //3 global variables to hold the number of each item purchase
        double coneNumber = 0;
        double milkshakeNumber = 0;
        double sundaeNumber = 0;
        //Global variable to hold total cost of order
        double subtotal = 0;
        //Global variable to hold tax rate of 13%, (0.13) 
        double taxRate = 0.13;
        //Global variable to hold value of tax amount
        double taxAmount = 0;
        //Global variable to hold total cost including tax
        double totalCost = 0;
        //Global variable for tendered amount
        double tendered = 0;
        //global variable for change
        double change = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void subtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //input of the cone number
            coneNumber = Convert.ToInt32(coneTextBox.Text);
            milkshakeNumber = Convert.ToInt32(milkshakeTextBox.Text);
            sundaeNumber = Convert.ToInt32(sundaeTextBox.Text);

            //calculate price 
            subtotal = conePrice * coneNumber + milkshakePrice * milkshakeNumber
                + sundaePrice * sundaeNumber;
            taxAmount = taxRate * subtotal;
            totalCost = taxAmount + subtotal;

            //show subtotal
            totalsLabel.Text = subtotal.ToString("$0.00");
            Refresh();
            Thread.Sleep(1000);
            //show tax
            totalsLabel.Text += $"\n\n {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            //show total cost
            totalsLabel.Text += $"\n\n {totalCost.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //making the buttons enabled
            calculateChangeButton.Enabled = true;
            receiptButton.Enabled = false;

        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            //input into tendered text box
            tendered = Convert.ToInt32(tenderedTextBox.Text);
            //calculate change 
            change = tendered - totalCost;
            //show change
            changeLabel2.Text = change.ToString("C");

            //making the receipt button enabled
            receiptButton.Enabled = true;

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //printing the receipt 
            printingLabel.Text = $"Meg's Icecream Shop";
            printingLabel.Refresh();
            Thread.Sleep(1000);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //making the buttons enabled
            calculateChangeButton.Enabled = false;
            receiptButton.Enabled = false;  
        }
    }
}

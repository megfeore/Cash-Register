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
using System.Media; //allows the use of SoundPlayer();

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
            //making the buttons enabled
            calculateChangeButton.Enabled = false;
            receiptButton.Enabled = false;
            newOrderButton.Enabled = false;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //input of the cone number
                coneNumber = Convert.ToInt32(coneTextBox.Text);
                coneTextBox.BackColor = Color.White;
            }
            catch
            {
                coneTextBox.BackColor = Color.Silver;
                coneTextBox.Text = "Insert #";
                return;
            }

            try
            {
                //input of the milkshake number
                milkshakeNumber = Convert.ToInt32(milkshakeTextBox.Text);
                milkshakeTextBox.BackColor = Color.White;
            }
            catch
            {
                milkshakeTextBox.BackColor = Color.Silver;
                milkshakeTextBox.Text = "Insert #";
                return;
            }

            try
            {
                //input of the sundae number
                sundaeNumber = Convert.ToInt32(sundaeTextBox.Text);
                sundaeTextBox.BackColor = Color.White;
            }
            catch
            {
                sundaeTextBox.BackColor = Color.Silver;
                sundaeTextBox.Text = "Insert #";
                return;
            }


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
            newOrderButton.Enabled = false;

        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //input into tendered text box
                tendered = Convert.ToInt32(tenderedTextBox.Text);
                //calculate change 
                change = tendered - totalCost;
                //show change
                changeLabel2.Text = change.ToString("C");
                receiptButton.Enabled = true;
                blackLabel2.Text = "";
            }
            catch
            {
                blackLabel2.Text = "Please enter a 2 digit number for your change!";
                receiptButton.Enabled = false;
            }
            //making the button enabled
            newOrderButton.Enabled = false;

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //create a sound player and load the alert.wav sound, then play it 
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.PrintingSound);

            soundPlayer.Play();

            //printing the receipt title
            printingLabel.Text = $"Meg's Icecream Parlour";
            printingLabel.Refresh();
            Thread.Sleep(1000);

            //cone price total printing
            printingLabel2.Text += $"Cones x{coneNumber}";
            double coneTotal = conePrice * coneNumber;
            printingLabel3.Text += $"{coneTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //milkshake total printing
            printingLabel2.Text += $"\nMilkshakes x{milkshakeNumber}";
            double milkshakeTotal = milkshakePrice * milkshakeNumber;
            printingLabel3.Text += $"\n{milkshakeTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //sundae total printing
            printingLabel2.Text += $"\nSundaes x{sundaeNumber}";
            double sundaeTotal = sundaePrice * sundaeNumber;
            printingLabel3.Text += $"\n{sundaeTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //subtotalPrinting
            printingLabel2.Text += $"\n\nSubtotal";
            printingLabel3.Text += $"\n\n{subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //taxPrinting
            printingLabel2.Text += $"\nTax";
            printingLabel3.Text += $"\n{taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //totalPrinting
            printingLabel2.Text += $"\nTotal";
            printingLabel3.Text += $"\n{totalCost.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //tenderedPrinting
            printingLabel2.Text += $"\n\nTendered";
            printingLabel3.Text += $"\n\n{tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //changePrinting
            printingLabel2.Text += $"\nChange";
            printingLabel3.Text += $"\n{change.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            //final receipt message printing
            printingLabel4.Text = $"Thank you for supporting us!";
            printingLabel4.Refresh();
            Thread.Sleep(1000);

            //new order button appears
            newOrderButton.Enabled = true;

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //resetting the numbers to zero
            coneTextBox.Text = "0";
            milkshakeTextBox.Text = "0";
            sundaeTextBox.Text = "0";
            tenderedTextBox.Text = "0";


            //resetting the labels
            totalsLabel.Text = "";
            changeLabel2.Text = "";
            printingLabel.Text = "";
            printingLabel2.Text = "";
            printingLabel3.Text = "";
            printingLabel4.Text = "";
            blackLabel2.Text = "";

            //making the buttons enabled
            calculateChangeButton.Enabled = false;
            receiptButton.Enabled = false;
            newOrderButton.Enabled = false;
        }

        
    }



}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxGonzalezSumeetSinghPizzaOrder
{
    public partial class Form1 : Form
    {
        //Initialize Pircing
         double TEN = 10.99;
         double Twelve = 12.99;
         double Fourteen = 14.99;
         double Sixteen = 16.99;
        //Initialize total 
        double total;
        double tax = 0.0795;
        double taxAmount;
        double subtotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void fourteeninradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void orderbutton_Click(object sender, EventArgs e)
        {
            //String name display in outputlabel
            string name = nametextBox.Text;
            Orderoutputlabel.Text = "Order For: " + name; 
            

            //Try + if-else statments 
            try
            {
                if (sizetextBox.Text == "10")
                {
                    total = TEN;
                    Costlabel.Text = "Total: $" + total + "\nTax: $" + taxAmount + "\nSubtotal: $" + subtotal;
                }
                else if (sizetextBox.Text == "12")
                {
                    total = Twelve;
                    Costlabel.Text = "Total: $" + total + "\nTax: $" + taxAmount + "\nSubtotal: $" + subtotal;
                }
                else if (sizetextBox.Text == "14")
                {
                    total = Fourteen;
                    taxAmount = total * tax;
                    subtotal = taxAmount + total;
                    Costlabel.Text = "Total: $" + total + "\nTax: $" + taxAmount + "\nSubtotal: $" + subtotal;
                }
                else if (sizetextBox.Text == "16")
                {
                    total = Sixteen;
                    taxAmount = total * tax;
                    subtotal = taxAmount + total;
                    Costlabel.Text = "Total: $" + total + "\nTax: $" + taxAmount + "\nSubtotal: $" + subtotal;
                }
                else if (sizetextBox.Text == "") //If no size is selected 12in by default
                {
                    MessageBox.Show("Size not Selected, 12in selected by default.");
                    total = Twelve;
                    taxAmount = total * tax;
                    subtotal = taxAmount + total;
                    Costlabel.Text = "Total: $" + total + "\nTax: $" + taxAmount + "\nSubtotal: $" + subtotal;
                }
                else
                {
                    //If a size if greater than the sizes availble error messgae + 12in by default
                    MessageBox.Show("Size Unavailable, 12in pizza will be charged by default.");
                    total = Twelve;
                    taxAmount = total * tax;
                    subtotal = taxAmount + total;
                    Costlabel.Text = "Total: $" + total + "\nTax: $" + taxAmount + "\nSubtotal: $" + subtotal;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Size Unavailable, 12in pizza will be charged by default.");
                total = Twelve;
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                Costlabel.Text = "Total: $" + total + "\nTax: $" + taxAmount + "\nSubtotal: $" + subtotal;
            }

            // Adding type of crust to output label
            //Initialize crust as UserControl input
            string crust = crusttextBox.Text;
            switch (crust)
            {
                case "h":
                case "H": Orderoutputlabel.Text = "Hello " + nametextBox.Text + "!\n\nYour Hand-Tossed pizza will be ready in 30 minutes!\n\nThank you for coming to Max n Sumeet's Blazzin Pizza!";
                    break;
                case "t":
                case "T": Orderoutputlabel.Text = "Hello " + nametextBox.Text + "!\n\nYour Thin-Crust pizza will be ready in 30 minutes!\n\nThank you for coming to Max n Sumeet's Blazzin Pizza!";
                    break;
                case "d":
                case "D":Orderoutputlabel.Text = "Hello " + nametextBox.Text + "!\n\nYour Deep-Dish pizza will be ready in 30 minutes!\n\nThank you for coming to Max n Sumeet's Blazzin Pizza!";
                    break;
                case "c":
                case "C": Orderoutputlabel.Text = "Hello " + nametextBox.Text + "!\n\nYour Cheesy-Crust pizza will be ready in 30 minutes!\n\nThank you for coming to Max n Sumeet's Blazzin Pizza!";
                    break;
                default: Orderoutputlabel.Text = "Hello " + nametextBox.Text + "!\n\nYour Hand-Tossed Pizza will be ready in 30 minutes!\n\nThank you for coming to Max n Sumeet's Blazzin Pizza!";
                    MessageBox.Show("Crust Unavailable, Hand-Tossed Will be selected by default.");
                    break;
            }
            if(pepperonicheckBox.Checked)
            {
                total += 1.25;
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                Costlabel.Text = "Total: $" + Math.Round(total,2) + "\nTax: $" + Math.Round(taxAmount,2) + "\nSubtotal: $" + Math.Round(subtotal,2); // String total to cost label
            }
            else
            {
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                Costlabel.Text = "Total: $" + Math.Round(total, 2) + "\nTax: $" + Math.Round(taxAmount, 2) + "\nSubtotal: $" + Math.Round(subtotal, 2); // String total to cost label
            }

            if (onioncheckBox.Checked)
            {
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                total += 1.25;
                Costlabel.Text = "Total: $" + Math.Round(total, 2) + "\nTax: $" + Math.Round(taxAmount, 2) + "\nSubtotal: $" + Math.Round(subtotal, 2); // String total to cost label
            }
            else
            {
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                Costlabel.Text = "Total: $" + Math.Round(total, 2) + "\nTax: $" + Math.Round(taxAmount, 2) + "\nSubtotal: $" + Math.Round(subtotal, 2); // String total to cost label
            }

            if (SausagecheckBox.Checked)
            {
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                total += 1.25;
                Costlabel.Text = "Total: $" + Math.Round(total, 2) + "\nTax: $" + Math.Round(taxAmount, 2) + "\nSubtotal: $" + Math.Round(subtotal, 2); // String total to cost label
            }
            else
            {
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                Costlabel.Text = "Total: $" + Math.Round(total, 2) + "\nTax: $" + Math.Round(taxAmount, 2) + "\nSubtotal: $" + Math.Round(subtotal, 2); // String total to cost label
            }

            if (MushroomcheckBox.Checked)
            {
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                total += 1.25;
                Costlabel.Text = "Total: $" + Math.Round(total, 2) + "\nTax: $" + Math.Round(taxAmount, 2) + "\nSubtotal: $" + Math.Round(subtotal, 2); // String total to cost label
            }
            else
            {
                taxAmount = total * tax;
                subtotal = taxAmount + total;
                Costlabel.Text = "Total: $" + Math.Round(total, 2) + "\nTax: $" + Math.Round(taxAmount, 2) + "\nSubtotal: $" + Math.Round(subtotal, 2); // String total to cost label
            }

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {// Close program
            this.Close();
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pepperonicheckBox_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void onioncheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SausagecheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MushroomcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            nametextBox.Text = "";
            Costlabel.Text = "";
            sizetextBox.Text = "";
            crusttextBox.Text = "";
            Orderoutputlabel.Text = "";
            pepperonicheckBox.Checked = false;
            MushroomcheckBox.Checked = false;
            SausagecheckBox.Checked = false;
            onioncheckBox.Checked = false;
            total = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vihcle_Rental_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string Customername = txtname.Text;
            if (!int.TryParse(txtage.Text, out int age)) {
                MessageBox.Show("enter a valid age ");
                return;
            }
            if (!int.TryParse(txtdays.Text, out int rentaldays)) {
                MessageBox.Show("enter a valid rental days");
                return;
            }
            if (!int.TryParse(txtexperience.Text, out int drivingExp))
            {
                MessageBox.Show("enter a valid driving experience");
                return;
            }

            //validate age and rental days 
            if (age < 18 || age > 80)
            {
                MessageBox.Show("Age must be between 18 and 80 ");
                return;
            }
            if(rentaldays<1 || rentaldays > 30)
            {
                MessageBox.Show("Rental Days must be between 1 and 30");
                return;
            }
            if (drivingExp < 0)
            {
                MessageBox.Show("Driving experience can not be negative");
                return;
            }
            //eligibility rules

            if (age < 21)
            {
                MessageBox.Show("Customers below 21 years are not eligible. ");
                return;
            }
            if (drivingExp < 1)
            {
                MessageBox.Show("Customers must have at least 1 year of driving experience. ");
                return;
            }
            string vehicletype;
            double dailyrate;

            if (rdoeconomy.Checked)
            {
                vehicletype = "Economy";
                dailyrate = 35;
            }else if (rdosuv.Checked)
            {
                vehicletype = "SUV";
                dailyrate = 60;
            }else if (rdoluxury.Checked)
            {
                vehicletype = "Luxury";
                dailyrate = 100;
            }
            if(age<25 && drivingExp < 3)
            {
                MessageBox.Show("Luxury requires age 25 or above and at least 3 years of driving experience.");
                return;
            }else
            {
                MessageBox.Show("please select vehicle type");
                return;
            }
            //Basic Rental Cost

            double basicRentalCost = dailyrate * rentaldays;
            double discountrate = 0;
            if (rentaldays >= 14)
                discountrate = 0.10;
            else if (rentaldays >= 7)
                discountrate = 0.05;

            double discount=basicRentalCost * discountrate;

            //young driver surcharge
            double surcharge = 0;
            if (age >= 21 && age <= 24)
                surcharge = (basicRentalCost - discount) * 0.10;

            double insurancecost = 0;
            if (chkinsurance.Checked)
            {
                insurancecost = 15 * rentaldays;
            }

            //final cost 
            double finalcost = basicRentalCost - discount + surcharge + insurancecost;

            //display results 
            listBox1.Items.Clear();

            listBox1.Items.Add("VEHICLE RENTAL SUMMARY");
            listBox1.Items.Add("------------------------------");
            listBox1.Items.Add("Customer Name: " + Customername);
            listBox1.Items.Add("Vehicle Type: " + vehicletype);
            listBox1.Items.Add("Basic Rental Cost: $" + basicRentalCost.ToString("F2"));
            listBox1.Items.Add("Discount: $" + discount.ToString("F2"));
            listBox1.Items.Add("Young Driver Surcharge: $" +
                               surcharge.ToString("F2"));
            listBox1.Items.Add("Insurance Cost: $" + insurancecost.ToString("F2"));
            listBox1.Items.Add("------------------------------");
            listBox1.Items.Add("Final Rental Cost: $" + finalcost.ToString("F2"));


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtexperience.Clear();
            txtdays.Clear();
            rdoeconomy.Checked = false;
            rdoluxury.Checked = false;
            rdosuv.Checked = false;
            chkinsurance.Checked = false;
            listBox1.Items.Clear();

            txtname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //creating variables
            String Food1, Food2;
            Double Price_Food1, Price_Food2, Amount_Tips, Sales_Text, Tips_Amount, Total_Amount, Net_Amount,full_pay;

            //constant
            const double Sales_vat = 15;
            //const double Tips_vat = 15;


            //assign variables
            Food1 = txtfood1.Text;
            Price_Food1 = double.Parse(txtpricefood1.Text);
            Food2 = txtfood2.Text;
            Price_Food2 = double.Parse(txtpricefood2.Text);
            Tips_Amount=double.Parse(txtamountip.Text);


            //calculatio
            try
            {
                Total_Amount = Price_Food1 + Price_Food2;

                Sales_Text = Total_Amount * (Sales_vat * 100);

               full_pay = Tips_Amount + Sales_Text + Total_Amount;

                Net_Amount = Total_Amount - Sales_Text;

                //display the ouput
               lblsalartext.Text = Sales_Text.ToString("c");
                lblTipAmount.Text = Tips_Amount.ToString("c");
                lblTotalAmount.Text = Total_Amount.ToString("c");
                lblfullpay.Text = full_pay.ToString("c");
                lblNetAmount.Text = Net_Amount.ToString("C");
            }

            catch { }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfood1.Clear();
            txtfood2.Clear();
            txtpricefood1.Clear();
            txtpricefood2.Clear();
            txtamountip.Clear();

            lblsalartext.Text = "";
            lblNetAmount.Text = "";
            lblTipAmount.Text = "";
            lblTotalAmount.Text = "";
            lblfullpay.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}

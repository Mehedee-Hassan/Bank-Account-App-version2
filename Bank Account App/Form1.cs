using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_App
{
    public partial class PersonUIForm : Form
    {

        double amount;

        public PersonUIForm()
        {

            InitializeComponent();
         
            depositButton.Enabled = false;
            widthdrawButton.Enabled = false;
        }

        private Account aAccount;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aAccount = new Account();
            aAccount.balance = 0;
            aAccount.name = accountNumberTextBox.Text;
            aAccount.number = accountNumberTextBox.Text;



            accountNumberTextBox.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;


            depositButton.Enabled = true;
            widthdrawButton.Enabled = true;

        }

        private void depositButton_Click(object sender, EventArgs e)
        {

            amount = 0;

            if (aAccount != null)
            {

                if(amountTextBox.Text != "")
                    amount = Convert.ToDouble(amountTextBox.Text);

                aAccount.Depsit(amount);
                amountTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Diposit Failed, Create account first");
            }
        }

        private void widthdraw_Click(object sender, EventArgs e)
        {
            amount = 0;

            if(aAccount != null){

            if (amountTextBox.Text != "")
                amount = Convert.ToDouble(amountTextBox.Text);
            
            aAccount.Widthdraw(amount);
            amountTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Withdraw Failed, Create account first");
            }
          
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
           // string message = aAccount.GetReport();
            string message = aAccount.name +
                ", your account number is : " +
                aAccount.number +
                "\nand it's balance is : " +
                aAccount.balance;
            MessageBox.Show(message);
            
        }

    }
}

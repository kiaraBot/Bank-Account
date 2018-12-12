// Alix Field           afield@cnm.edu          FieldP6_CSharp
// File: Form1.cs           _Form1 Code

using FieldP6_CSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Field.P6._CSharp
{
    public partial class Form1 : Form
    {
        // Declare Objects for Each Account Type
        BankAcct bronzeAcct = new BankAcct("Annie NoName", 12345, 500.00);
        SilverBankAcct silverAcct = new SilverBankAcct("Annie Warbucks", 23456, 1500.00, 234561212, 1212);
        GoldBankAcct goldAcct = new GoldBankAcct("Tom Petty", 34567, 25000.00, 345674545, 4545, 5.0);

        // Reference Array for Account Types
        BankAcct[] acctTypes = new BankAcct[3];

        // List Decleration
        private List<BankAcct> myAccount = new List<BankAcct>();

        public Form1()
        {
            InitializeComponent();

            // Array: Becomes Polymorphic w/ the addition of the gold and silver 			bank account objects
            acctTypes[0] = goldAcct;
            acctTypes[1] = silverAcct;
            acctTypes[2] = bronzeAcct;

            // List: Becomes Polymorphic w/ the addition of the gold and silver bank 	account objects
            myAccount.Add(goldAcct);
            myAccount.Add(silverAcct);
            myAccount.Add(bronzeAcct);

            // Intialize the Account Balance
            goldAcct.SavingAcctBalance = 25000.00;
            silverAcct.SavingAcctBalance = 1500.00;
            bronzeAcct.SavingAcctBalance = 500.00;

        }

        // Text Boxes Visible True According to Account Type
        private void cmbxAcctType_ValueMemberChanged(object sender, EventArgs e)
        {

        }


        // Transaction Button
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            // User Amount Variable
            double amount = 0;
            double.TryParse(txtbAmount.Text, out amount);

            // Display  Result Variables
            string displayResult = " ";
            double acctBalance = 0;        

            // Gold Account Transaction
            if (cmbxAcctType.SelectedIndex == 0)
            {              
                goldAcct.Amount = amount;
                if (rdbtnDeposit.Checked)
                {
                    goldAcct.Deposit();
                    lstbxTransactions.Items.Add("Deposit: " + amount);
                }
                if(rdbtnWithdraw.Checked)
                {
                    goldAcct.Withdraw();
                    lstbxTransactions.Items.Add("Withdraw: " + amount);
                }

                // Display Result
                displayResult = goldAcct.ToString();
                txtbResults.Text = displayResult;


                // List Box Account Balance Decleration
                goldAcct.SavingAcctBalance = acctBalance;
            }

            // Silver Account Transaction
            else if(cmbxAcctType.SelectedIndex == 1)
            {
                silverAcct.Amount = amount;
                if (rdbtnDeposit.Checked)
                {
                    silverAcct.Deposit();
                    lstbxTransactions.Items.Add("Deposit: " + amount);
                }
                if(rdbtnWithdraw.Checked)
                {
                    silverAcct.Withdraw();
                    lstbxTransactions.Items.Add("Withdraw: " + amount);
                }

                // Display Result
                displayResult = silverAcct.ToString();
                txtbResults.Text = displayResult;

                // List Box Account Balance Decleration
                silverAcct.SavingAcctBalance = acctBalance;
            }

            // Bronze(Bank) Account Transaction
            else if (cmbxAcctType.SelectedIndex == 2)
            {
                bronzeAcct.Amount = amount;
                if (rdbtnDeposit.Checked)
                {
                    bronzeAcct.Deposit();
                    lstbxTransactions.Items.Add("Deposit: " + amount);
                }
                if(rdbtnWithdraw.Checked)
                {
                    bronzeAcct.Withdraw();
                    lstbxTransactions.Items.Add("Withdraw: " + amount);
                }
                
                // Display Result
                displayResult = bronzeAcct.ToString();
                txtbResults.Text = displayResult;
            }
        }

        // Account Update Button
        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            // Account Variable Decleration
            string name = this.name.Text;

            double intRate = 0;         
            double.TryParse(txtbInterest.Text, out intRate);

            int acctNum = 0;
            int.TryParse(txtbAcctNum.Text, out acctNum);

            int atmNum = 0;
            int.TryParse(txtbAtmNum.Text, out atmNum);

            int pin = 0;
            int.TryParse(txtbAtmPin.Text, out pin);

            // Gold Account Update
            if (cmbxAcctType.SelectedIndex == 0)
            {
                goldAcct.Name = name;
                goldAcct.AccountNumber = acctNum;
                goldAcct.PIN = pin;
                goldAcct.ATMAcctNum = atmNum;
                goldAcct.Interest = intRate;
            }

            // Silver Account Update
            if (cmbxAcctType.SelectedIndex == 1)
            {
                silverAcct.Name = name;
                silverAcct.AccountNumber = acctNum;
                silverAcct.PIN = pin;
                silverAcct.ATMAcctNum = atmNum;
            }

            // Bronze(Bank) Account Update
            if (cmbxAcctType.SelectedIndex == 2)
            {
                bronzeAcct.Name = name;
                bronzeAcct.AccountNumber = acctNum;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls.ResetAllControls(this);
        }


    }
}

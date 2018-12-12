// Alix Field           afield@cnm.edu          FieldP6_CSharp
// File: BankAcct.cs            _Base Class

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldP6_CSharp
{
    public class BankAcct
    {
        // -------------------------------------- Constructors ------------------------------------------//

        // Chained Perameterless Constructor
        public BankAcct()
        {

        }

        // Overloaded Constructor
        public BankAcct(string name, int acctNum, double savAcctBal) 
        {
            Name = name;
            AccountNumber = acctNum;
            SavingAcctBalance = savAcctBal;
        }


        // --------------------------------------- Field Properties --------------------------------------//
        private string name;
        private int accountNumber;
        private double savingAcctBalance;

        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public double SavingAcctBalance { get; set; }
        public double Amount { get; set; }


        // ----------------------------------------- Virtual Methods ------------------------------------//

        public virtual double Deposit()
        {
            // Adds Money to the Savings Account Balance

            SavingAcctBalance += Amount;
            return SavingAcctBalance;
        }

        public virtual double Withdraw()
        {
            // Subtracts Money From the Savings Account Balance

            SavingAcctBalance -= Amount;

            return SavingAcctBalance;
        }

        public override string ToString()
        {

            return "Saving Account Summary: " + " Name: " + Name
                 + " Account Number: " + AccountNumber + " Account Balance: "
                 + SavingAcctBalance;
        }
    }
}

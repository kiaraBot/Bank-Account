// Alix Field           afield@cnm.edu          FieldP6_CSharp
// File: SilverBankAcct.cs           _Inherited Class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP6_CSharp
{
    public class SilverBankAcct : BankAcct
    {
        public SilverBankAcct()
        {

        }
        // ------------------------------------------ Constructor --------------------------------------------------//

        public SilverBankAcct(string name, int acctNum, double savAcctBal,
            int atmAcctNum, int pIN)
        {
            ATMAcctNum = atmAcctNum;
            PIN = pIN;
        }


        // ------------------------------------------- Field Properties ---------------------------------------------//

        public int ATMAcctNum { set; get; }
        public int PIN { set; get; }


        // --------------------------------------- Class Member Methods --------------------------------------//

        public override double Withdraw()
        {
            // Deducts: Bank Fee $2.50 from balance        
            double bankFee = 2.50;
            SavingAcctBalance -= bankFee;

            // Calculate New Balance
            SavingAcctBalance -= Amount;

            return SavingAcctBalance;
        }

        public override double Deposit()
        {
            // Deducts: Bank Fee $1.00 if balance less than $1000.00
            double bankFee = 1.00;
            if (SavingAcctBalance < 1000.00)
            {
                SavingAcctBalance -= bankFee;
            }

            // Add: Deposit Amount to Balance
            SavingAcctBalance += Amount;

            return SavingAcctBalance;
        }

        public override string ToString()
        {
            return base.ToString() + " ATM Account Number: " + ATMAcctNum + " PIN: " + PIN;
        }
    }
}

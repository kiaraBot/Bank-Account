// Alix Field       afield@cnm.edu      FieldP6_CSharp
// File: GoldBankAcct.cs          _Inherited Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP6_CSharp
{
    public class GoldBankAcct : SilverBankAcct
    {
        public GoldBankAcct()
        {

        }

        // -------------------------------------------- Constructors ------------------------------------------------//

        public GoldBankAcct(string name, int acctNum, double savAcctBal,
            int atmAcctNum, int pIN, double interest)
        {
            Interest = interest;
        }


        // ------------------------------------------ Field Properties -----------------------------------------------//

        public double Interest { get; set; }


        // -------------------------------------- Class Member Methods ----------------------------------------//
        public override double Withdraw()
        {
            // Deducts: Associated Bank Fees 
            // Adds: Earned Interest
            double bankFee = 2.50;
            if (SavingAcctBalance < 20000.00)
            {
                SavingAcctBalance += bankFee;
            }
            if (SavingAcctBalance >= 5000.00)
            {
                Interest *= SavingAcctBalance / 100;
                SavingAcctBalance += Interest;
            }

            // Subtracts: Withdraw Amount
            SavingAcctBalance -= Amount;

            return SavingAcctBalance;
        }

        public override double Deposit()
        {
            // Deducts: Associated Bank Fees
            // Adds: Associated Interest 
            double bankFee = 1.00;
            if (SavingAcctBalance < 20000.00)
            {
                SavingAcctBalance += bankFee;
            }
            else if (SavingAcctBalance >= 20000.00)
            {
                Interest *= SavingAcctBalance / 100;
                SavingAcctBalance += Interest;
            }

            // Adds: Deposit Amount
            SavingAcctBalance += Amount;

            return SavingAcctBalance;
        }

        public override string ToString()
        {
            return base.ToString() + " Investment: " + Interest;
        }
    }
}

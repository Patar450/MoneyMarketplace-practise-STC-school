using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MoneyMarketplace
{
    
    internal class BankAccount: Account
    {
        //Attributes are private --> starting with a small letter.//
        private int overdraft;
        public int Overdraft
        {
            get { return overdraft; }
            set { overdraft = value; }
        }

        //---Contructors---//
        public BankAccount(int ot )
        {
            overdraft = ot;
        }

        //--Registering default values.--//
        public BankAccount()
        {
            overdraft = 0;
        }

        public virtual int limitOverdraft(int overdraft)
        {
            overdraft = 500;
            return overdraft;
        }

        public override void adjustbalance(int withdrawal)
        {
            int baldraft = Balance + overdraft;
            if (Balance > withdrawal)
            {
                LastTrans = Balance;
                Balance = Balance - withdrawal;
            }
            else if (baldraft > withdrawal)
            {
                MessageBox.Show("You are in the Overdraft, you will incure charges of 19.99% at the end of the month, this charge keeps accumilating for the amount of days you keep the account in the overdraft.");
                LastTrans = baldraft;
                Balance = baldraft - withdrawal;
            }
            else
            {
                MessageBox.Show("That amount exeeds available balance, please choose a lesser amount.");
            }
        }
    }
}

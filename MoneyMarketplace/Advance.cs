using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMarketplace
{
    internal class Advance :BankAccount
    {
        private bool discounts;

        public bool Discounts
        {
            get { return discounts; }
            set { discounts = value; }
        }

        public Advance(bool dis)
        {
            discounts = dis;
        }

        public Advance()
        {
            discounts = false;
        }

        public override int limitOverdraft(int overdraft)
        {
            overdraft = -1000;
            return overdraft;
        }

        public override void ckbalance()
        {
            if (Balance < 14999)
            {
                MessageBox.Show("You are not eligible for an Advance account. Converting acocunt to bank account");
            }
            else if (Balance >= 15000 && Balance < 49999 && Bankname != "Advance")
            {
                MessageBox.Show("You are eligible for an Advance account. Converting your Profile from Premier to Advance or Bank Account");
                Bankname = "Advance";
                discounts = true;
            }

            MessageBox.Show("Balance is:" + Balance + "Eu");

        }
    }
}

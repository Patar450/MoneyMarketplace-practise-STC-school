using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMarketplace
{
    internal class Premier: Advance 
    {
        private bool creditcard;
        public bool Creditcard
        {
            get { return creditcard; }
            set { creditcard = value; }
        }

        public Premier(bool cc)
        {
            creditcard = cc;
        }

        public Premier()
        {
            creditcard = false;
        }

        public override void ckbalance()
        {
            if (Balance >= 50000 && Bankname == "Bank Account" && Bankname == "Advance" )
            {
                MessageBox.Show("You are eligible for a Premier account. Converting account to Premier");
                Bankname = "Premier";
                creditcard = true;
            }
            else if(Balance < 50000 && Bankname == "Premier")
            {
                MessageBox.Show("You are not eligible for a Premier account. Converting account to Advance or Bank Account");

                if (Balance < 14999)
                {
                    Bankname = "Bank Account";
                }
                else
                {
                    Bankname = "Advance";
                }
            }

            MessageBox.Show("Balance is:" + Balance + "Eu");
        }
    }
}

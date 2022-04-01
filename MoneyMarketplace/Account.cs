using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMarketplace
{
    internal class Account
    {
        private int id;
        private string name;
        private string pin;
        private int balance;
        private int lasttrans;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int LastTrans
        {
            get { return lasttrans; }
            set { lasttrans = value; }
        }

        public Account(int idn, string nam, string pim, int acc, int lt)
        {
            id = idn;
            name = nam;
            pin = pim;
            balance = acc;
            lasttrans = lt;
        }
        public Account()
        {
            id = 0;
            name = null;
            pin = null;
            balance = 0;
            lasttrans = 0;
        }

        public void adjustbalance(int withdrawal)
        {
            
            lasttrans = balance;
            balance = balance - withdrawal;
            MessageBox.Show("The amount of " + withdrawal + "EU has been deducted from the balance of " + lasttrans + "EU leaving the balance of: " + balance + "EU");
        }

        public void ckbalance()
        {
            MessageBox.Show("Balance is:" + balance);
        }

        public void printlstbalance()
        {
            MessageBox.Show("Previous balance was"+ lasttrans);
        }
    }
}

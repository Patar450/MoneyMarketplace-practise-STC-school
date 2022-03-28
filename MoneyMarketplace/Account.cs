using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMarketplace
{
    internal class Account
    {
        private int id;
        private string name;
        private string pin;
        private int balance;

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

        public Account(int idn, string nam, string pim, int acc)
        {
            id = idn;
            name = nam;
            pin = pim;
            balance = acc;
        }
        public Account()
        {
            id = 0;
            name = null;
            pin = null;
            balance = 0;
        }
    }
}

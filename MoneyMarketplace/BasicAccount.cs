using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMarketplace
{
    internal class BasicAccount
    {
        //Attributes are private --> starting with a small letter.//
        private int id;
        private string name;
        private string pin;
        private int balance;
        private int lasttrans;
        private int bankaccountnum;

        //Getters and Setters --> starting with a Capital Letter.//
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

        public int BankAcocuntnum
        {
            get { return bankaccountnum; }
            set { bankaccountnum = value; }
        }

        //---Contructors---//
        public BasicAccount(int idn, string nam, string pim, int acc, int lt, int accnum)
        {
            id = idn;
            name = nam;
            pin = pim;
            balance = acc;
            lasttrans = lt;
            bankaccountnum = accnum;
        }

        //--Registering default values.--//
        public BasicAccount()
        {
            id = 0;
            name = null;
            pin = null;
            balance = 0;
            lasttrans = 0;
            bankaccountnum = 0;
        }
        //-- Methods in Class--//
        public void adjustbalance(int withdrawal)
        {
            
            lasttrans = balance;
            balance = balance - withdrawal;
            MessageBox.Show("The amount of " + withdrawal + "EU has been deducted from the balance of " + lasttrans + "EU leaving the balance of: " + balance + "EU");
        }

        public void ckbalance()
        {
            MessageBox.Show("Balance is:" + balance+ "Eu");
        }

        public void printlstbalance()
        {
            MessageBox.Show("Previous balance was :"+ lasttrans + "Eu");
        }
    }
}

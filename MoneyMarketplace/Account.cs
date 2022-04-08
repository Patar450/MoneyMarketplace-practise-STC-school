using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Step 1 - Import Libraries
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MoneyMarketplace
{
    [Serializable()]
    internal class Account : ISerializable
    {
        //Attributes are private --> starting with a small letter.//

        //bank ID -- unique to all accounts
        private int id;
        //bank name that will determine what type of account it is
        private string bankname;
        //unique pin created by the user
        private string pin;
        // Balance of the bank account
        private int balance;
        //Last transaction from the bank account
        private int lasttrans;
        //Bank Holder
        private string clientname;
        //Holds bank created.
        private string datecreated;

        //Getters and Setters --> starting with a Capital Letter.//
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Bankname
        {
            get { return bankname; }
            set { bankname = value; }
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

        public string Datecreated
        {
            get { return datecreated; }
            set { datecreated = value; }
        }

        public string Clientname
        {
            get { return clientname; }
            set { clientname = value; }
        }

        //---Contructors---//
        public Account(int idn, string banam, string pim, int acc, int lt, string nam, string dateC)
        {
            id = idn;
            bankname = banam;
            pin = pim;
            balance = acc;
            lasttrans = lt;
            clientname = nam;
            datecreated = dateC;
        }

        //--Registering default values.--//
        public Account()
        {
            id = 0;
            bankname = null;
            pin = null;
            balance = 0;
            lasttrans = 0;
            clientname = null;
            datecreated = null;
        }
        //-- Methods in Class--//
        public virtual void adjustbalance(int withdrawal)
        {
            if (balance > withdrawal)
            {
                lasttrans = balance;
                balance = balance - withdrawal;
            }
            else
            {
                MessageBox.Show("That amount exeeds available balance, please choose a lesser amount.");
            }
            
        }

        public virtual void ckbalance()
        {
            
            if (balance > 50000)
            {
                MessageBox.Show("You are  eligible for an Advance account. Converting account to Advance");
                Bankname = "Advance";
            }
            else if (balance >= 15000 && Balance < 50000)
            {
                MessageBox.Show("You are eligible for an Premier account. Converting your Profile to Premier Account");
                Bankname = "Premier";
            }

            MessageBox.Show("Balance is:" + balance+ "Eu");
        }

        public void printlstbalance()
        {
            MessageBox.Show("Previous balance was :"+ lasttrans + "Eu");
        }

        //1. Get Object Data will set a key value pair to organize the data and prepare it for Serialization.
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID",id);
            info.AddValue("Bankname", bankname);
            info.AddValue("Balance", balance);
            info.AddValue("Client Name", clientname);
            info.AddValue("Pin", pin);
            info.AddValue("Last transaction",lasttrans);
            info.AddValue("Date Created", datecreated);
        }

        //2. De-Serializer - To Capture the data once read and revert it to the object it was originally saved
        public Account(SerializationInfo info, StreamingContext context)
        {
            id = (int)info.GetValue("ID", typeof(int));
            bankname = (string)info.GetValue("Bankname", typeof(string));
            balance = (int)info.GetValue("Balance", typeof(int));
            clientname = (string)info.GetValue("Client Name", typeof (string));
            pin = (string)info.GetValue("Pin", typeof(string));
            lasttrans = (int)info.GetValue("Last Transaction", typeof(int));
            datecreated = (string)info.GetValue("Date Created", typeof(string));
    }
    }
}

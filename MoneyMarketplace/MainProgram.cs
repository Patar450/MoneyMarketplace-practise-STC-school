using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMarketplace
{
    
    public partial class Form_load : Form
    {
        private int pinnum;
        private int curraccount = 0;
        private string pinnumstore = null;
        private int pincounter;
        private bool profile = false;
        private int menu = 0;
        private string amounth = " ";
        private int amountw;
        private int attempt;
        private string bankaccount;


        List<BasicAccount> Profile = new List<BasicAccount>();

        BasicAccount acc1;
        BasicAccount acc2;
        BasicAccount acc3;
        BasicAccount acc4;
        BasicAccount acc5;

        private void AddAccount(int tempid, string tempname, string temppin, int tempbalance, string tempaccname, string tempdate)
        {
            BasicAccount acc6;

            if (tempaccname == "Basic Account")
            {
                 acc6 = new BasicAccount();
            }
            else if (tempaccname == "Bank Account")
            {
                 acc6 = new BankAccount();
            }
            else if (tempaccname == "Advance")
            {
                 acc6 = new Advance();
            }
            else if (tempaccname == "Premier")
            {
                 acc6 = new Premier();
            }
            
            
            acc6.Id = tempid;
            acc6.Clientname = tempname;
            acc6.Balance = tempbalance;
            acc6.Bankname = tempaccname;
            acc6.Datecreated = tempdate;
            Profile.Add(acc6);

        }
        private void Menuorganizer()
        {
            //editing the richtextbox;
            richtxtbx.BackColor = Color.Black;
            richtxtbx.ReadOnly = true;
            richtxtbx.ForeColor = Color.White;
            richtxtbx.Font = new Font("Arial", 25);
            richtxtbx.SelectionAlignment = HorizontalAlignment.Center;

            //control over the display using var manu to change the display.
            switch (menu)
            {
                case 0:
                    richtxtbx.Text = "\n \n Money Market Place \n \n \n \n Enter Your Pin Number to login.\n";
                    break;
                case 1:
                    richtxtbx.Text = "\n \n Money Market Place \n \n \n" + Profile.ElementAt(curraccount).Clientname + ",\n What would you like to do from your "+ Profile.ElementAt(curraccount).Bankname + "?";
                    break;
                case 2:
                    richtxtbx.Text = "\n \n Money Market Place \n \n \n" + Profile.ElementAt(curraccount).Clientname + ",\n How much do you want to withdraw? \n";
                    break;
                case 3:
                    richtxtbx.Text = ("\n \n Money Market Place \n \n \n \nYour balance is: " + Profile.ElementAt(curraccount).Balance + "Eur");
                    break;
                case 4:
                    richtxtbx.Text = ("\n \n Money Market Place \n \n \n \n The amount of " + amounth + "EU has been deducted from the balance.");
                    break;
                case 5:
                    richtxtbx.Text = ("\n \n Money Market Place \n \n \n \n Press Enter Card to begin.");
                    break;
            }

        }
        //disabling the function buttons
        private void startup()
        {
            btnbalance.Enabled = false;
            btnwithdraw.Enabled = false;
            btnConfirm.Enabled = false;
            btnwithrec.Enabled = false;
            btndeny.Enabled = false;
            btnMenu.Enabled = false;
        }

        //disabling the whole keypad (since it is not needed.)
        private void disablekeypad()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn0.Enabled = false;
            btnA.Enabled = false;
            btnC.Enabled = false;
        }
        //enabled keypad.
        private void enablekeypad()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn0.Enabled = true;
            btnA.Enabled = false;
            btnC.Enabled = true;
        }

        //enabled buttons that are required
        private void loggedin()
        {
            btnwithdraw.Enabled = true;
            btnbalance.Enabled = true;
            btnwithrec.Enabled = true;
            btnMenu.Enabled = true;
            btnConfirm.Enabled = false;
            btndeny.Enabled = false;
            btncard.Enabled = false;
        }
        //enabled buttons that are required while disabling others.
        private void funcitoncall()
        {
            btnwithdraw.Enabled = false;
            btnbalance.Enabled = false;
            btnwithrec.Enabled = false;
            btnMenu.Enabled= false;
            btnConfirm.Enabled = true;
            btndeny.Enabled = true;
        }
        // big algorithm that too my innocence. (removed a lot of clutter by adding more methods linked to it).
        private void Lenghtchecker(int pinnum)
        {
            int counter = 0;
            //resets all counters
            if (pinnum == -1)
            {
                pincounter = 0;
                pinnum++;
                pinnumstore = null;
                menu = 0;
                Menuorganizer();
            }
            //whilst the pin is being entered the user would be able to see his input in *.
            else if (pincounter < 4)
            {
                pinnumstore += pinnum;
                richtxtbx.AppendText(Convert.ToString("*"));
                pincounter = pinnumstore.Length;
            }
            //once the Pin is 4 text long the following if statement gets executed. 
            else if (pinnumstore.Length == 4)
            {
                //a loop to check all acocunts saved on the class.
                for (curraccount = 0; curraccount < Profile.Count(); curraccount++)
                {
                    //algorithm checker
                    //MessageBox.Show("Curr account"+curraccount + "Profile count" + Convert.ToString(Profile.Count()) +"Pinnum store"+ pinnumstore + "Pinncounter:"+pincounter);

                    //if pin is corrcet
                    if (Profile.ElementAt(curraccount).Pin == pinnumstore)
                    {
                        disablekeypad();
                        loggedin();
                        menu = 1;
                        profile = true;
                        Menuorganizer();
                        break;
                    }
                    //IF Pin is incorrect
                    else if (curraccount == Profile.Count() -1)
                    {
                        //attempts up to 3 times before closing the program, for suspicion of stolen card.
                        attempt ++;

                        if (attempt == 3)
                        {
                            MessageBox.Show("PIN entered incorrectly, Card held. Please, speak to a staff in the branch for further assistance.");
                            this.Close();
                        }    
                        MessageBox.Show("Incorrect Pin please try again.");
                        pinnum = -1;
                        Lenghtchecker(pinnum);
                        break;
                    }
                }
                
            }             
        }
        //storing the amount that will be deducting the current balance (if confirmed)
        private void calc(int pinnum)
        {
            
            if (amounth.Length < 6)
            {
                amounth += pinnum;
                richtxtbx.AppendText(Convert.ToString(pinnum));
            }
            else
            {
                MessageBox.Show("Reach Maximum Input.");
                disablekeypad();
            }
            
        }

        
        public Form_load()
        {
            InitializeComponent();
        }
        //Keypad button controller (1 to check PIN, the other for the withdrawal function to use)
        private void btn1_Click(object sender, EventArgs e)
        {
            pinnum = 1;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pinnum = 2;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pinnum = 3;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pinnum = 4;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pinnum = 5;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pinnum = 6;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pinnum = 7;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pinnum = 8;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pinnum = 9;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pinnum = 0;
            if (profile == false)
            {
                Lenghtchecker(pinnum);
            }
            else
            {
                calc(pinnum);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn7_Load(object sender, EventArgs e)
        {
            
            // Adding pre-made accounts
            Profile.Add(acc1 = new BasicAccount(1, "Basic Account", "4321", 1500, 0, "James", "07 March 2019"));
            Profile.Add(acc2 = new BasicAccount(2, "Basic Account", "7812", 50000, 0, "Mary", "10 November 2009"));
            Profile.Add(acc3 = new BasicAccount(3, "Basic Account", "4371", 21867, 0, "Phil", "09 January 2002"));
            Profile.Add(acc4 = new BasicAccount(4, "Basic Account", "3214", 2179, 450, "Hayley", "07 June 1994"));
            Profile.Add(acc5 = new BasicAccount(0, "Basic Account", "0000", 0, 0, "defaultuser", DateTime.Today.ToString()));
            
            int tempid = Register.Global.Id;
            string tempname = Register.Global.name;
            string temppin = Register.Global.pin;
            int tempbalance = Register.Global.balance;
            string tempaccname = Register.Global.accname;
            string tempdate = Register.Global.datecreated;

            AddAccount(tempid, tempname, temppin, tempbalance, tempaccname, tempdate);

            Register.Global.Id = Profile.Count();
            //explained in the methods section
            menu = 5;
            Menuorganizer();
            startup();
            disablekeypad();
        }
        //Clears the Pin entered by mistake from user.
        private void btnC_Click(object sender, EventArgs e)
        {
            if(pincounter == 0)
            {
                MessageBox.Show("There is nothing to clear, please enter your pin.");
            }
            else
            {
                pinnum = -1;
                Lenghtchecker(pinnum);
            }
        }
        //send a method request from the class to display the persons balance.
        private void btnbalance_Click(object sender, EventArgs e)
        {
            menu = 3;
            Menuorganizer();
            Profile.ElementAt(curraccount).ckbalance();
        }
        //Sets up dis[play to prepare for the amount of money the user will take out.
        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            menu = 2;
            Menuorganizer();
            funcitoncall();
            enablekeypad();
        }
        //checks if the last transation happened if not an error message will be displayed.
        private void btnwithrec_Click(object sender, EventArgs e)
        {
           if (Profile.ElementAt(curraccount).LastTrans == 0)
            {
                MessageBox.Show("No Recent transaction found.");
            }
            else
            {
                Profile.ElementAt(curraccount).printlstbalance();
            }
        }
        //checks if the amount entered is less than the balance available, if it is it does the required function.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            amountw = Convert.ToInt16(amounth);

            menu = 4;
            int withdrawal = amountw;
            richtxtbx.Clear();
            Profile.ElementAt(curraccount).adjustbalance(withdrawal);
            Menuorganizer();
            loggedin();


        }
        //resets the program while keeping the account logged in.
        private void btndeny_Click(object sender, EventArgs e)
        {
            menu = 1;
            Menuorganizer();
            disablekeypad();
            loggedin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncard_Click(object sender, EventArgs e)
        {
            enablekeypad();
            menu = 0;
            Menuorganizer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu = 1;
            Menuorganizer();
            disablekeypad();
            loggedin();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    /*[13:16] Andrew Caruana
    sure - create some methods within the class

    [13:16] Andrew Caruana
    also you can have last transaction as part of your class

    [13:17] Andrew Caruana
    because you want to keep the last transaction in that object package
    */
    public partial class Form_load : Form
    {
        private int pinnum;
        private int numstore;
        private string numstore1;
        private int curraccount = 0;
        private bool profile = false;
        private string lasttrans = null;
        private string pinnumstore = null;
        private int pincounter;

        List<Account> Profile = new List<Account>();

        Account acc1;
        Account acc2;
        Account acc3;
        Account acc4;

        private void Menucleanser()
        {
            richtxtbx.Text = "\n \n Money Market Place \n \n \n"+ Profile.ElementAt(curraccount).Name + ",\n What would you like to do?";
        }

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
            btn0.Enabled=false;
            btnA.Enabled=false;
            btnC.Enabled=false;
        }

        private void Lenghtchecker(int pinnum)
        {
            int counter = 0;
            numstore1 = Convert.ToString(pinnum);

            if (pincounter < 4)
            {
                pinnumstore += pinnum;
                richtxtbx.AppendText(Convert.ToString(pinnum));
                pincounter = pinnumstore.Length;
            }
            else if (pinnumstore.Length == 4)
            {
                for (curraccount = 0; curraccount < Profile.Count(); curraccount++)
                {
                    if (Profile.ElementAt(curraccount).Pin == pinnumstore)
                    {
                        disablekeypad();
                        Menucleanser();
                        MessageBox.Show("Welcome " + Profile.ElementAt(curraccount).Name);
                        profile = true;
                        btnbalance.Enabled = true;
                        btnwithdraw.Enabled = true;
                        btnwithrec.Enabled = true;
                        counter = 0;
                        break;
                    }
                    else
                    {
                        counter = Profile.Count() * Profile.Count();
                    }
                    if (counter > Profile.Count())
                    {
                        richtxtbx.Enabled = true;
                        MessageBox.Show("Incorrect Pin please try again.");
                        this.Close();
                    }
                }
            }

        }
        private void restoftheprogram()
        {

            if (profile == false)
            {


            }
            else if (profile == true)
            {
                richtxtbx.Text += Convert.ToString(pinnum);
            }
        }
    



        
        public Form_load()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pinnum = 1;
            Lenghtchecker(pinnum);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pinnum = 2;
            Lenghtchecker(pinnum);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pinnum = 3;
            Lenghtchecker(pinnum);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pinnum = 4;
            Lenghtchecker(pinnum);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pinnum = 5;
            Lenghtchecker(pinnum);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pinnum = 6;
            Lenghtchecker(pinnum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pinnum = 7;
            Lenghtchecker(pinnum);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pinnum = 8;
            Lenghtchecker(pinnum);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pinnum = 9;
            Lenghtchecker(pinnum);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pinnum = 0;
            Lenghtchecker(pinnum);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn7_Load(object sender, EventArgs e)
        {
            // Adding pre-made accounts
            Profile.Add(acc1 = new Account(1, "James", "4321", 1500));
            Profile.Add(acc2 = new Account(2, "Mary", "7812", 2100));
            Profile.Add(acc3 = new Account(3, "Phil", "4371", 21867));
            Profile.Add(acc4 = new Account(4, "Hayley", "3214", 2179));

            //editing the richtextbox;
            richtxtbx.BackColor = Color.Black;
            richtxtbx.ReadOnly = true;
            richtxtbx.ForeColor = Color.White;
            richtxtbx.Font = new Font("Arial", 25);
            richtxtbx.SelectionAlignment = HorizontalAlignment.Center;
            richtxtbx.Text = "\n \n Money Market Place \n \n \n \n Enter Your Pin Number to login.\n Pin:";

            //disabling the function buttons
            btnbalance.Enabled = false;
            btnwithdraw.Enabled = false;
            btnConfirm.Enabled = false;
            btnwithrec.Enabled = false;
            btndeny.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //pincounter;
            if(pincounter == 0)
            {
                MessageBox.Show("There is nothing to clear, please enter your pin.");
            }
            else
            {
                //richtxtbx.Text = Text.Remove(Text.Length - pincounter);
                richtxtbx.Select(4, richtxtbx.GetFirstCharIndexFromLine(7));
                richtxtbx.SelectedText = "<blank>";
                //richtxtbx.Text.Remove(richtxtbx.Text.LastIndexOf('.'), pincounter);
            }            

        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
           richtxtbx.Text = ("\n \n Money Market Place \n \n \n \nYour balance is: "+ Profile.ElementAt(curraccount).Balance+ "Eur");
        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            richtxtbx.Enabled = true;
            richtxtbx.Clear();
            numstore = Convert.ToInt16(pinnum);
            btnwithdraw.Enabled=false;
            btnbalance.Enabled=false;
            btnwithrec.Enabled = false;
            btnConfirm.Enabled = true;
            btndeny.Enabled = true;
        }

        private void btnwithrec_Click(object sender, EventArgs e)
        {
           if (lasttrans == null)
            {
                MessageBox.Show("No Recent transaction found.");
            }
            else
            {
                MessageBox.Show(lasttrans.ToString());
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Profile.ElementAt(curraccount).Balance > Int32.Parse(richtxtbx.Text))
            {
                int temphold = Profile.ElementAt(curraccount).Balance - Int32.Parse(richtxtbx.Text);
                //lasttrans = ("The amount of " + txtbx1.Text + "EU has been deducted from the balance of " + Profile.ElementAt(curraccount).Balance + "EU leaving the balance of: " + temphold + "EU");
                Profile.ElementAt(curraccount).Balance = Profile.ElementAt(curraccount).Balance - Int32.Parse(richtxtbx.Text);
                btnwithdraw.Enabled = true;
                btnbalance.Enabled = true;
                btnwithrec.Enabled = true;
                btnConfirm.Enabled = false;
                btndeny.Enabled = false;
            }
            else
            {
                MessageBox.Show("That amount exeeds available balance, please choose a lesser amount.");
                richtxtbx.Clear();
            }
            
        }

        private void btndeny_Click(object sender, EventArgs e)
        {
            richtxtbx.Text = "\n \n Money Market Place \n \n \n \n Enter Your Pin Number to login.";
            richtxtbx.Clear();
            btnwithdraw.Enabled = true;
            btnbalance.Enabled = true;
            btnwithrec.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}

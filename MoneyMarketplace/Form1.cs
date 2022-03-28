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
        private int numstore;
        private int curraccount =0;
        private bool profile = false;
        private string lasttrans = null;

        List<Account> Profile = new List<Account>();

        Account acc1;
        Account acc2;
        Account acc3;
        Account acc4;
        private void Lenghtchecker(int pinnum)
        {
            int counter = 0;
            if (profile == false)
            {
                if (txtbx1.Text.Length != 4)
                {
                    txtbx1.AppendText(Convert.ToString(pinnum));
                }
                else
                {

                    for (curraccount = 0; curraccount < Profile.Count(); curraccount++)
                    {
                        if (Profile.ElementAt(curraccount).Pin == txtbx1.Text)
                        {
                            MessageBox.Show("Welcome " + Profile.ElementAt(curraccount).Name);
                            txtbx1.Clear();
                            profile = true;
                            txtbx1.Enabled = false;
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
                    }

                    if (counter > Profile.Count())
                    {
                        txtbx1.Enabled = true;
                        MessageBox.Show("Incorrect Pin please try again.");
                        txtbx1.Clear();
                    }
                }
            }
            else if (profile == true)
            {
                txtbx1.Text += Convert.ToString(pinnum);
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
            richtxtbx.Text = "\n \n Money Market Place \n \n \n \n Enter Your Pin Number to login.";

            //disabling the function buttons
            btnbalance.Enabled = false;
            btnwithdraw.Enabled = false;
            btnConfirm.Enabled = false;
            btnwithrec.Enabled = false;
            btndeny.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtbx1.Clear();
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
           richtxtbx.Text = ("\n \n Money Market Place \n \n \n \nYour balance is: "+ Profile.ElementAt(curraccount).Balance+ "Eur");
        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            txtbx1.Enabled = true;
            txtbx1.Clear();
            numstore = pinnum;
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
            if (Profile.ElementAt(curraccount).Balance > Int32.Parse(txtbx1.Text))
            {
                int temphold = Profile.ElementAt(curraccount).Balance - Int32.Parse(txtbx1.Text);
                lasttrans = ("The amount of "+txtbx1.Text+"EU has been deducted from the balance of "+ Profile.ElementAt(curraccount).Balance +"EU leaving the balance of: "+ temphold+"EU");
                Profile.ElementAt(curraccount).Balance = Profile.ElementAt(curraccount).Balance - Int32.Parse(txtbx1.Text);
                btnwithdraw.Enabled = true;
                btnbalance.Enabled = true;
                btnwithrec.Enabled = true;
                btnConfirm.Enabled = false;
                btndeny.Enabled = false;
            }
            else
            {
                MessageBox.Show("That amount exeeds available balance, please choose a lesser amount.");
                txtbx1.Clear();
            }
            
        }

        private void btndeny_Click(object sender, EventArgs e)
        {
            richtxtbx.Text = "\n \n Money Market Place \n \n \n \n Enter Your Pin Number to login.";
            txtbx1.Clear();
            btnwithdraw.Enabled = true;
            btnbalance.Enabled = true;
            btnwithrec.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

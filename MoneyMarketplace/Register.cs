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
    public partial class Register : Form
    {
        public static class Global
        {
            public static int Id;
            public static string name;
            public static string pin;
            public static int balance;
            public static string accname;
            public static string datecreated;
        }

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show();
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txbxbalance.Text.Length == 0 || txbxname.Text.Length == 0 || txbxpin.Text.Length == 0)
            {
                MessageBox.Show("Please, ensure that all details have been added");
            }
            else
            {
                Global.Id = Global.Id + 1;
                Global.name =txbxname.Text;
                Global.pin =txbxpin.Text;
                Global.balance = Convert.ToInt32(txbxbalance.Text);
                Global.datecreated = DateTime.Today.ToString();
                MessageBox.Show("Registration complete. Going back to main menu.");
                Form maienu = new Form();
                maienu.Show();
                this.Hide();
            }
        }

        private void txbxpin_TextChanged(object sender, EventArgs e)
        {
            txbxpin.Text = string.Concat(txbxpin.Text.Where(char.IsNumber));
        }

        private void txbxname_TextChanged(object sender, EventArgs e)
        {
            txbxname.Text = string.Concat(txbxname.Text.Where(char.IsLetter));
        }

        private void txbxbalance_TextChanged(object sender, EventArgs e)
        {
            txbxbalance.Text = string.Concat(txbxbalance.Text.Where(char.IsNumber));
            int num = Convert.ToInt32(txbxbalance.Text);
            if (num >= 50000)
            {
                txbxaccount.Text = "Premier";
                
            }
            if (num < 50000 && num >=15000)
            {
                txbxaccount.Text = "Advance";
                
            }
            if (num < 15000 && num >= 1000)
            {
                txbxaccount.Text = "Bank Account";
            }
            else if (num < 1000 && num >0)
            {
                txbxaccount.Text = "Basic Account";
            }
            else if (num == 0)
            {
                txbxaccount.Text = "Not eligible until funds are deposited";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txbxbalance.Text = "";
        }
    }
}

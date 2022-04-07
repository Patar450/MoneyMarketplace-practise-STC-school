namespace MoneyMarketplace
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbxname = new System.Windows.Forms.TextBox();
            this.txbxbalance = new System.Windows.Forms.TextBox();
            this.txbxpin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbxaccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbxname
            // 
            this.txbxname.Location = new System.Drawing.Point(7, 46);
            this.txbxname.Name = "txbxname";
            this.txbxname.Size = new System.Drawing.Size(98, 20);
            this.txbxname.TabIndex = 0;
            this.txbxname.TextChanged += new System.EventHandler(this.txbxname_TextChanged);
            // 
            // txbxbalance
            // 
            this.txbxbalance.Location = new System.Drawing.Point(9, 138);
            this.txbxbalance.Name = "txbxbalance";
            this.txbxbalance.Size = new System.Drawing.Size(177, 20);
            this.txbxbalance.TabIndex = 3;
            this.txbxbalance.TextChanged += new System.EventHandler(this.txbxbalance_TextChanged);
            // 
            // txbxpin
            // 
            this.txbxpin.Location = new System.Drawing.Point(9, 85);
            this.txbxpin.MaxLength = 4;
            this.txbxpin.Name = "txbxpin";
            this.txbxpin.Size = new System.Drawing.Size(33, 20);
            this.txbxpin.TabIndex = 4;
            this.txbxpin.TextChanged += new System.EventHandler(this.txbxpin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "What is your name?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "What would you like your PIN to be?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "How much will you be depositing today?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(419, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Welcome To Money Market!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbxaccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbxname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbxbalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbxpin);
            this.groupBox1.Location = new System.Drawing.Point(68, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 201);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // txbxaccount
            // 
            this.txbxaccount.Location = new System.Drawing.Point(111, 169);
            this.txbxaccount.Name = "txbxaccount";
            this.txbxaccount.ReadOnly = true;
            this.txbxaccount.Size = new System.Drawing.Size(119, 20);
            this.txbxaccount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Projected account:";
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(301, 272);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 12;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxname;
        private System.Windows.Forms.TextBox txbxbalance;
        private System.Windows.Forms.TextBox txbxpin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbxaccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button button1;
    }
}
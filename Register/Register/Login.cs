﻿using System;
using System.Windows.Forms;

namespace Register
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string login = email.Text;
            string pass = password.Text;
            if (DataBase.CheckUser(login, pass))
            {
                Admin adminpage = new Admin();
                if (login == "admin@gmail.com" && pass == "12345")
                {
                    adminpage.username = "Admin";
                    adminpage.ShowDialog();
                }
                adminpage.ShowDialog();
            }
        }
    }
}

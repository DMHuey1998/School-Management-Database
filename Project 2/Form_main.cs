using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            // confirm before logout
                var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                //if yes, hide this form
                this.Hide();
                Form_login fl = new Form_login();
                // show login window
                fl.Show();
                }


        }


        private void frmMain_FormClosing(object sender, FormClosedEventArgs e)
        {
            //exit the application if close the logout form
            Application.Exit();
        }
    }
}

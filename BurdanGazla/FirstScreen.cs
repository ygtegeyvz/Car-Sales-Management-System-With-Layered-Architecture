using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurdanGazla
{
    public partial class FirstScreen : Form
    {
        public FirstScreen()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {           
            AdminLogin_Form adminLoginForm = new AdminLogin_Form();
            this.Visible = false;
            adminLoginForm.ShowDialog();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            this.Visible = false;
            customerForm.ShowDialog();
        
        }
    }
}

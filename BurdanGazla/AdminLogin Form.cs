using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolver.Ninject;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace BurdanGazla
{
    public partial class AdminLogin_Form : Form
    {
        IUserService _userService;
        public AdminLogin_Form()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FirstScreen fs = new FirstScreen();
            this.Visible = false;
            fs.ShowDialog();
         
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                AdminForm adminForm = new AdminForm();
                if (ControlUserName())
                {
                    this.Visible = false;
                    adminForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı yada şifre!");
                }
            });  
        }

        private bool ControlUserName()
        {
           
            string userName = UserNameBox.Text;
            string password = passwordBox.Text;
            if (_userService.isValidLogin(userName, password))
            {
                return true;
            }
            else return false;
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }
    }
}

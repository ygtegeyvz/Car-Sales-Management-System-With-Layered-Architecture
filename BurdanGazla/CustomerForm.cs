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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            this.Visible = false;
            searchForm.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CustomerAddingAd addForm = new CustomerAddingAd();
            this.Visible = false;
            addForm.ShowDialog();
        }
    }
}

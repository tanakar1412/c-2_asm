using BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class Customer : Form
    {
        CustomerBLL customerBLL = new CustomerBLL();
        DataTable dt = new DataTable();

        public void load_dbCustomer()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("City", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Phone", typeof(string));

            var customer = customerBLL.GetAllCustomer();
            foreach (var cm in customer)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = cm.Id;
                dr["FirstName"] = cm.FirstName;
                dr["LastName"] = cm.LastName;
                dr["City"] = cm.City;
                dr["Country"] = cm.Country;
                dr["Phone"] = cm.Phone;
                dt.Rows.Add(dr);


            }
            dgvShowCM.DataSource = dt;

        }
        public Customer()
        {
            InitializeComponent();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TraCuu().Show();
            this.Hide();
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            load_dbCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            var FirstName = txtFirstName.Text;
            var LastName = txtLastName.Text;
            var City = txtCity.Text;
            var Country =txtCountry.Text;
            var Phone = txtPhone.Text;
            var newPerson = new Customer();
            







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class Order : Form
    {
        OrderBLL orderBLL = new OrderBLL();
        DataTable dt = new DataTable();

        public void load_dborder()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("OrderDate", typeof(DateTime));
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Columns.Add("TotalAmount", typeof(decimal));


            var od = orderBLL.GetAllOrders();
            foreach (var order in od)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = order.Id;
                dr["OrderDate"] = order.OrderDate;
                dr["CustomerId"] = order.CustomerId;
                dr["TotalAmount"] = order.TotalAmount;
                dt.Rows.Add(dr);

            }
            dgvShowOrder.DataSource = dt;

        }

        public Order()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TraCuu().Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            load_dborder();
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

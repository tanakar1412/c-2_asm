using BLL;
using DTO.Models;
using System.Data;

namespace GUII
{
    public partial class TraCuu : Form
    {

        ProductBLL productBLL = new ProductBLL();
        DataTable dt = new DataTable();
        public TraCuu()
        {
            InitializeComponent();
        }


        public void load_db()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("Package", typeof(string));
            dt.Columns.Add("IsDiscontinued", typeof(bool));


            var products = productBLL.GetAllProduct();
            foreach (var product in products)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = product.Id;
                dr["ProductName"] = product.ProductName;
                dr["UnitPrice"] = product.UnitPrice;
                dr["Package"] = product.Package;
                dr["IsDiscontinued"] = product.IsDiscontinued;
                dt.Rows.Add(dr);

            }
            dgvShow.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load_db();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Launch().Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TraCuu().Show();
            this.Hide();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void TraCuu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

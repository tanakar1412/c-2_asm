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
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            new BanHang().Show();
            this.Hide();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            new TraCuu().Show();
            this.Hide();
        }

        private void Launch_Load(object sender, EventArgs e)
        {

        }
    }
}

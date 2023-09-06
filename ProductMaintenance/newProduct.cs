using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class newProduct : Form
    {

        private Products products = null;
        public newProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            products = new Products
            {
                Code = txtCode.Text,
                Description = txtDescription.Text,
                Price = Convert.ToDecimal(txtPrice.Text)
            };
            this.Close();
        }

        public Products GetNewProducts()
        {
            this.ShowDialog();
            return products;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

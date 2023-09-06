namespace ProductMaintenance
{
    public partial class productMaintenance : Form
    {
        public productMaintenance()
        {
            InitializeComponent();
        }
        private List<String[]> product1 = null;

        private List<Products> products = null;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newProduct productForm = new();
            Products product = productForm.GetNewProducts();
            if (product != null)
            {
                products.Add(product);
            }
            FillProductListBox();
        }

        public void FillProductListBox()
        {
            lstProducts.Items.Clear();
            foreach (Products p in products)
            {
                lstProducts.Items.Add(p.GetDisplayedText("\t"));
            }
        }

        private void productMaintenance_Load(object sender, EventArgs e)
        {
            products = new();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstProducts.SelectedIndex;

            if (i != -1)
            {
                Products product = products[i];
                products.Remove(product);
                FillProductListBox();
            }
        }
    }
}
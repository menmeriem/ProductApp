using ProductApp.Interfaces;
using ProductApp.Repositories;
using ProductApp.Services;
using System.Xml.Linq;

namespace ProductApp
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productService;

        public Form1()
        {
            InitializeComponent();
            var repository = new InMemoryProductRepository();
            _productService = new ProductService(repository);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Please enter a valid price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _productService.AddProduct(txtName.Text, price);
                txtName.Text = "";
                txtPrice.Text = "";
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProducts()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _productService.GetProducts();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        
            var results = _productService.SearchProducts(txtSearch.Text);
            dataGridView1.DataSource = results;
        }
    }
}

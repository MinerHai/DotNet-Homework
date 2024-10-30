namespace KtraApp
{
    public partial class Form1 : Form
    {
        private ShoppingCart shoppingCart;
        public Form1()
        {
            InitializeComponent();
            shoppingCart = new ShoppingCart();
            InitializeProducts();
            InitializeCartView();

        }
        private void InitializeProducts()
        {
            var products = new List<Product>
    {
        new Product("Giày thể thao", 100000, 10, "Images/giay1.jpg"),
        new Product("Giày lười", 200000, 5, "Images/giay2.jpg")
    };

            dgvDSSP.Columns.Add("Image", "Ảnh");
            dgvDSSP.Columns.Add("Name", "Tên sản phẩm");
            dgvDSSP.Columns.Add("Price", "Giá");
            dgvDSSP.Columns.Add("Quantity", "Số lượng");

            foreach (var product in products)
            {
                Image productImage;

                if (File.Exists(product.ImagePath))
                {
                    productImage = Image.FromFile(product.ImagePath);
                }
                else
                {
                    productImage = null;
                }

                if (productImage != null)
                {
                    dgvDSSP.Rows.Add(productImage, product.Name, product.Price, product.Quantity);
                }
                else
                {
                    dgvDSSP.Rows.Add("chưa có ảnh", product.Name, product.Price, product.Quantity);
                }
            }
        }

        private void InitializeCartView()
        {
            dgvSPDC.Columns.Add("Name", "Tên sản phẩm");
            dgvSPDC.Columns.Add("Price", "Giá");
            dgvSPDC.Columns.Add("Quantity", "Số lượng");
            dgvSPDC.Columns.Add("Total", "Tổng giá trị");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvDSSP.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDSSP.SelectedRows[0];
                string productName = selectedRow.Cells["Name"].Value.ToString() ?? string.Empty;
                decimal productPrice = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                int productQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                var selectedProduct = new Product(productName, productPrice, productQuantity, null);

                shoppingCart.AddProduct(selectedProduct, 1);
                UpdateCartDisplay();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm vào giỏ hàng.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSPDC.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSPDC.SelectedRows[0];
                string productName = selectedRow.Cells["Name"].Value.ToString() ?? string.Empty;

                var productToRemove = shoppingCart.GetCartItems().Keys.FirstOrDefault(p => p.Name == productName);

                if (productToRemove != null)
                {
                    shoppingCart.RemoveProduct(productToRemove);
                    UpdateCartDisplay();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại trong giỏ hàng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng để xóa.");
            }
        }
        private void UpdateCartDisplay()
        {
            dgvSPDC.Rows.Clear();
            foreach (var item in shoppingCart.GetCartItems())
            {
                var product = item.Key;
                var quantity = item.Value;

                dgvSPDC.Rows.Add(product.Name, product.Price.ToString(), quantity.ToString(), (product.Price * quantity).ToString());
            }

            lblTotalQuantity.Text = $"Số lượng: {shoppingCart.CalculateTotalQuantity()}";
            lblTotalPrice.Text = $"Tổng giá trị: {shoppingCart.CalculateTotal()}";
        }

        private void lblDXXP_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công!");
                shoppingCart.Clear();
                UpdateCartDisplay();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
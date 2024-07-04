namespace Sale
{
    public partial class Form1 : Form
    {
        // Product list
        List<Dictionary<string, object>> productos = new List<Dictionary<string, object>>()
{
    new Dictionary<string, object>() { { "Nombre", "Laptop" }, { "Precio", 1200.99 } },
    new Dictionary<string, object>() { { "Nombre", "Mouse" }, { "Precio", 25.50 } },
    new Dictionary<string, object>() { { "Nombre", "Keyboard" }, { "Precio", 45.00 } },
    new Dictionary<string, object>() { { "Nombre", "Monitor" }, { "Precio", 300.75 } },
    new Dictionary<string, object>() { { "Nombre", "Printer" }, { "Precio", 150.30 } }
};


        // Lista de vendedores
        List<string> vendedores = new List<string>()
        {
            "Carlos Pérez",
            "Ana García",
            "Luis Fernández"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        //Llenar los combos
        private void cargarCombos()
        {
            // Llenar cmbPerson con los vendedores
            cmbPerson.Items.AddRange(vendedores.ToArray());

            // Llenar cmbProduct con los nombres de los productos
            foreach (var producto in productos)
            {
                cmbProduct.Items.Add(producto["Nombre"].ToString());
            }

        }
        //Agregar productos a la grilla
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado del combo
            string selectedProduct = cmbProduct.SelectedItem?.ToString();

            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            // Obtener la cantidad del NumericUpDown
            int amount = (int)numericAmount.Value;

            // Buscar el precio del producto en la lista de productos
            var selectedProductInfo = productos.First(p => p["Nombre"].ToString() == selectedProduct);
            double price = Convert.ToDouble(selectedProductInfo["Precio"]);


            // Calcular el total
            double total = amount * price;

            // Agregar los datos a la grilla
            dataGridProducts.Rows.Add(selectedProduct, price.ToString("C"), amount, total.ToString("C"));

            //Limpiar interfaz
            cmbProduct.SelectedIndex = -1;
            numericAmount.Value = numericAmount.Minimum;

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Verificar si hay filas en la grilla
            if (dataGridProducts.Rows.Count == 0)
            {
                MessageBox.Show("No data available to create a report.");
                return;
            }

            // Obtener el nombre del cliente y el vendedor
            string customerName = txtName.Text;
            string vendedor = cmbPerson.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please enter the customer's name.");
                return;
            }

            if (vendedor == null)
            {
                MessageBox.Show("Please select a salesperson.");
                return;
            }

            // Especificar la ruta de la carpeta de reports
            string reportsDirectory = @"C:\Users\fgfed\Desktop\Sale\Sale\reports";
            if (!Directory.Exists(reportsDirectory))
            {
                Directory.CreateDirectory(reportsDirectory);
            }

            // Crear el archivo de informe con fecha y hora en el nombre
            string reportFile = Path.Combine(reportsDirectory, $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
            using (StreamWriter writer = new StreamWriter(reportFile))
            {
                writer.WriteLine("Product Report");
                writer.WriteLine($"Customer: {customerName}");
                writer.WriteLine($"Salesperson: {vendedor}");
                writer.WriteLine("---------------------------");

                // Recorrer todas las filas de la grilla
                foreach (DataGridViewRow row in dataGridProducts.Rows)
                {
                    if (row.IsNewRow) continue; // Saltar la fila nueva vacía
                    string product = row.Cells["Product"].Value?.ToString() ?? "N/A";
                    string price = row.Cells["Price"].Value?.ToString() ?? "N/A";
                    string amount = row.Cells["Amount"].Value?.ToString() ?? "N/A";
                    string total = row.Cells["Total"].Value?.ToString() ?? "N/A";

                    writer.WriteLine($"Product: {product}");
                    writer.WriteLine($"Price: {price}");
                    writer.WriteLine($"Amount: {amount}");
                    writer.WriteLine($"Total: {total}");
                    writer.WriteLine("---------------------------");
                }
            }

            // Mostrar mensaje de éxito
            MessageBox.Show("Report created successfully in the reports folder!");

            // Limpiar los campos de texto y la grilla
            txtName.Text = string.Empty;
            cmbPerson.SelectedIndex = -1;
            dataGridProducts.Rows.Clear();
        }


        private void btmEmail_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Email y mostrarlo
            Email emailForm = new Email();
            emailForm.Show();
            // Esconder el formulario actual
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

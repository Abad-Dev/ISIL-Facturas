using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public const string DECIMALS = "N2";
        public List<Producto> productos = new List<Producto> { };
        public bool textChangedByCode = false;
        public bool changesSaved = false;
        public Form1()
        {
            InitializeComponent();
            FillGridView();
        }
        private void FillGridView()
        {
            grdProductos.Columns.Clear();
            FillColumnsGrid();
            foreach (var producto in productos)
            {
                grdProductos.Rows.Add(
                    producto.CodProducto,
                    producto.Descripcion,
                    producto.Cantidad,
                    producto.PrecioUnitario,
                    (producto.Cantidad * producto.PrecioUnitario).ToString(DECIMALS)
                );
            }
            btnDelete.Visible = productos.Count > 0;
            CalculateTotal();
        }

        private void FillColumnsGrid()
        {
            grdProductos.Columns.Add("CodProducto", "Código de Producto");
            grdProductos.Columns.Add("Descripcion", "Descripción");
            grdProductos.Columns.Add("Cantidad", "Cantidad");
            grdProductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            grdProductos.Columns.Add("Subtotal", "Subtotal");
        }

        private void CalculateTotal()
        {
            double total = 0;
            foreach (var producto in productos)
            {
                total += (producto.Cantidad * producto.PrecioUnitario);
            }

            lblTotal.Text = total.ToString(DECIMALS);
        }

        private void CalculateSubtotal()
        {
            decimal currentQty = Math.Truncate(numQty.Value);
            decimal currentPrice;
            bool priceIsNumeric = decimal.TryParse(txtPrecio.Text, out currentPrice);

            if (!priceIsNumeric)
            {
                MessageBox.Show("El precio ingresado es inválido.");
                return;
            }

            lblSubtotal.Text = (currentQty * currentPrice).ToString(DECIMALS);
        }

        private void EmptyFields()
        {
            textChangedByCode = true;

            txtCodProd.Text = string.Empty;
            txtDesc.Text = string.Empty;
            numQty.Value = 0;
            txtPrecio.Text = "0";
            lblSubtotal.Text = 0.ToString(DECIMALS);

            textChangedByCode = false;
        }

        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtCodProd.Text))
            {
                MessageBox.Show("El código de producto es obligatorio.");
                return false;
            }
            foreach (var producto in productos)
            {
                if (txtCodProd.Text == producto.CodProducto)
                {
                    MessageBox.Show("El código de producto no se puede repetir. Código existente: " + producto.CodProducto);
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("La descripción del producto no puede ser vacía.");
                return false;
            }
            if (numQty.Value <= 0)
            {
                MessageBox.Show("Debe haber mínimo 1 producto.");
                return false;
            }

            decimal currentPrice;
            bool priceIsNumeric = decimal.TryParse(txtPrecio.Text, out currentPrice);
            if (!priceIsNumeric || currentPrice <= 0)
            {
                MessageBox.Show("El precio del producto es inválido.");
                return false;
            }
            return true;
        }
        private void ClearScreen()
        {
            productos.Clear();
            EmptyFields();
            FillGridView();
        }

        private void SaveChanges()
        {
            string fechaHora = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string carpeta = @"C:\facturas-isil";
            string rutaArchivo = Path.Combine(carpeta, $"factura-{fechaHora}.txt");

            try
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                string productosJson = JsonSerializer.Serialize(productos);
                File.WriteAllText(rutaArchivo, productosJson);
                MessageBox.Show($"Datos guardados correctamente en: {rutaArchivo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}");
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (textChangedByCode) { return; }
            CalculateSubtotal();
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            if (textChangedByCode) { return; }
            CalculateSubtotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validateFields()) { return; }
            decimal currentPrice;
            bool priceIsNumeric = decimal.TryParse(txtPrecio.Text, out currentPrice);
            productos.Add(new Producto
            {
                CodProducto = txtCodProd.Text,
                Descripcion = txtDesc.Text,
                Cantidad = (int)numQty.Value,
                PrecioUnitario = (double)currentPrice
            });
            EmptyFields();
            FillGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdProductos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un producto.");
                return;
            }
            int index = grdProductos.SelectedRows[0].Index;
            productos.RemoveAt(index);
            FillGridView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0) { return; }

            if (changesSaved)
            {
                ClearScreen();
                changesSaved = false;
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Los cambios se guardarán automáticamente",
                "Nueva Factura",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.OK)
            {
                SaveChanges();
                ClearScreen();
                changesSaved = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            changesSaved = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\facturas-isil";
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Seleccionar archivo de productos";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaArchivo = openFileDialog.FileName;
                        string content = File.ReadAllText(rutaArchivo);
                        productos = JsonSerializer.Deserialize<List<Producto>>(content);
                        FillGridView();
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show($"El contenido del archivo está dañado o es inválido: {ex.Message}");
                        return;
                    }
                }
            }
        }

    }
}

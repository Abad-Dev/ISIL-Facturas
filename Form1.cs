using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public const string DECIMALS = "N2";
        public List<Producto> productos = new List<Producto> { };
        public bool textChangedByCode = false;
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
                MessageBox.Show("Hubo un error en el campo precio.");
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
    }
}

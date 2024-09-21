using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto> { };

        public Form1()
        {
            InitializeComponent();
            LlenarGridView();
        }
        private void LlenarGridView()
        {
            grdProductos.Columns.Clear();
            FillColumnsGrid();
            foreach (var producto in productos)
            {
                grdProductos.Rows.Add(producto.CodProducto, producto.Descripcion, producto.Cantidad, producto.PrecioUnitario, producto.Cantidad * producto.PrecioUnitario);
            }
        }

        private void FillColumnsGrid()
        {
            grdProductos.Columns.Add("CodProducto", "Código de Producto");
            grdProductos.Columns.Add("Descripcion", "Descripción");
            grdProductos.Columns.Add("Cantidad", "Cantidad");
            grdProductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            grdProductos.Columns.Add("Subtotal", "Subtotal");
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

            lblSubtotal.Text = (currentQty * currentPrice).ToString();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal();
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            CalculateSubtotal();
        }
    }
}

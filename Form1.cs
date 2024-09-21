using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto>
        {
            new Producto { CodProducto = 1, Descripcion = "Producto A", Cantidad = 10, PrecioUnitario = 5.50 },
            new Producto { CodProducto = 2, Descripcion = "Producto B", Cantidad = 20, PrecioUnitario = 3.75 },
            new Producto { CodProducto = 3, Descripcion = "Producto C", Cantidad = 15, PrecioUnitario = 8.25 }
        };

        public Form1()
        {
            InitializeComponent();
            LlenarGridView();
        }
        private void LlenarGridView()
        {
            grdProductos.Columns.Clear();
            LlenarColumnasGridView();
            foreach (var producto in productos)
            {
                grdProductos.Rows.Add(producto.CodProducto, producto.Descripcion, producto.Cantidad, producto.PrecioUnitario, producto.Cantidad * producto.PrecioUnitario);
            }
        }

        private void LlenarColumnasGridView()
        {
            grdProductos.Columns.Add("CodProducto", "Código de Producto");
            grdProductos.Columns.Add("Descripcion", "Descripción");
            grdProductos.Columns.Add("Cantidad", "Cantidad");
            grdProductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            grdProductos.Columns.Add("Subtotal", "Subtotal");
        }
    }
}

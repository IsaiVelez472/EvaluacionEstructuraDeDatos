namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Producto[] arregloProductos = new Producto[0];
        Venta[] arregloVentas = new Venta[0];
        Producto productoSeleccionado;

        public Form1()
        {
            InitializeComponent();

            dgProductos.Columns.Clear();
            dgProductos.Rows.Clear();

            dgProductos.Columns.Add("Producto", "Producto");
            dgProductos.Columns.Add("Cantidad", "Cantidad");
            dgProductos.Columns.Add("Valor", "Valor");

            btnAgregarProducto.Enabled = false;
            btnQuitarProducto.Enabled = false;
            btnAgregarVenta.Enabled = false;
            txtCantidadVendida.Enabled = false;
        }

        // ------------------------------------------------------------------- Eventos de campos de texto
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            deshabilitarBtnAgregarProducto();
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            deshabilitarBtnAgregarProducto();
        }

        private void txtCantidadVendida_TextChanged(object sender, EventArgs e)
        {
            deshabilitarBtnAgregarVenta();
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarProductoSeleccionado();
            deshabilitarBtnAgregarVenta();
            deshabilitarBtnQuitarProducto();
            deshabilitarTxtCantidadVenta();
        }

        // ------------------------------------------------------------------- Eventos de los botones
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            arregloProductos = AgregarProducto(arregloProductos, txtProducto.Text, int.Parse(txtValorUnitario.Text));
            ActualizarComboBox();
            txtProducto.Text = "";
            txtValorUnitario.Text = "";
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            arregloVentas = AgregarVenta(arregloVentas, productoSeleccionado, int.Parse(txtCantidadVendida.Text));
            llenarDataGrid();
            deshabilitarBtnQuitarProducto();

            txtCantidadVendida.Text = "";
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            arregloProductos = EliminarProducto(arregloProductos, arregloProductos[cmbProductos.SelectedIndex]);
            cmbProductos.SelectedIndex = -1;
            ActualizarComboBox();
        }

        private void btnProductoMasVendido_Click(object sender, EventArgs e)
        {
            if (arregloVentas.Length == 0) {
                txtProductoMasVendido.Text = "No hay datos de ventas o ingresos no disponibles.";
                return;
            }

            int[] cantidades = new int[arregloProductos.Length];

            foreach (var venta in arregloVentas)
            {
                int index = Array.IndexOf(arregloProductos, venta.Producto);
                cantidades[index] += venta.Cantidad;
            }

            int maxCantidad = -1;
            Producto productoMasVendido = null;

            for (int i = 0; i < arregloProductos.Length; i++)
            {
                if (cantidades[i] > maxCantidad)
                {
                    maxCantidad = cantidades[i];
                    productoMasVendido = arregloProductos[i];
                }
            }

            txtProductoMasVendido.Text = $"{productoMasVendido.NombreProducto} - {maxCantidad}";
            
        }

        private void btnProductoMenosIngresos_Click(object sender, EventArgs e)
        {
            if (arregloVentas.Length == 0)
            {
                txtProductoMenosIngresos.Text = "No hay datos de ventas o ingresos no disponibles.";
                return;
            }

            int[] ingresos = new int[arregloProductos.Length];
            Producto[] productosConMenosIngresos = new Producto[arregloProductos.Length];
            int count = 0;

            foreach (var venta in arregloVentas)
            {
                int index = Array.IndexOf(arregloProductos, venta.Producto);
                if (index != -1) ingresos[index] += venta.Valor;

            }

            int minIngreso = int.MaxValue;
            for (int i = 0; i < ingresos.Length; i++)
            {
                if (ingresos[i] < minIngreso && ingresos[i] > 0)
                {
                    minIngreso = ingresos[i];
                }
            }

            for (int i = 0; i < ingresos.Length; i++)
            {
                if (ingresos[i] == minIngreso)
                {
                    productosConMenosIngresos[count++] = arregloProductos[i];
                }
            }

            if (count > 0)
            {
                
                for (int i = 0; i < count; i++)
                {
                    txtProductoMenosIngresos.Text = $"{productosConMenosIngresos[i].NombreProducto} - ${minIngreso.ToString("N0")}, ";
                }
            }
        }

        // ------------------------------------------------------------------- Datagrid
        private void llenarDataGrid()
        {
            dgProductos.Rows.Clear();
            foreach (var venta in arregloVentas)
            {
                object[] fila = { venta.Producto.NombreProducto, venta.Cantidad, venta.Valor };
                dgProductos.Rows.Add(fila);
            }
        }

        // ------------------------------------------------------------------- Helpers
        private bool calcularSiTieneVentas()
        {
            bool tieneVentas = false;

            foreach (var venta in arregloVentas)
            {
                if (venta.Producto == productoSeleccionado) tieneVentas = true;
            }

            return tieneVentas;
        }

        private void actualizarProductoSeleccionado()
        {
            if (cmbProductos.SelectedIndex == -1) productoSeleccionado = null;
            else productoSeleccionado = arregloProductos[cmbProductos.SelectedIndex];
        }

        private void ActualizarComboBox()
        {
            cmbProductos.Items.Clear();
            for (int i = 0; i < arregloProductos.Length; i++)
            {
                cmbProductos.Items.Add(arregloProductos[i].ToString());
            }
        }
        private Producto[] AgregarProducto(Producto[] arr, string numbreProducto, int valorInotario)
        {
            Producto[] nuevoArreglo = new Producto[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                nuevoArreglo[i] = arr[i];
            }
            nuevoArreglo[arr.Length] = new Producto(numbreProducto, valorInotario);
            return nuevoArreglo;
        }

        private Producto[] EliminarProducto(Producto[] productos, Producto producto)
        {
            Producto[] nuevoArreglo = new Producto[productos.Length - 1];
            int index = 0;

            foreach (var prod in productos)
            {
                if (!prod.Equals(producto))
                {
                    nuevoArreglo[index++] = prod;
                }
            }

            return nuevoArreglo;
        }

        private Venta[] AgregarVenta(Venta[] arr, Producto producto, int cantidad)
        {
            Venta[] nuevoArreglo = new Venta[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                nuevoArreglo[i] = arr[i];
            }
            nuevoArreglo[arr.Length] = new Venta(producto, cantidad);
            return nuevoArreglo;
        }

        // ------------------------------------------------------------------- Deshabilitar campos dinamicamente
        private void deshabilitarBtnAgregarProducto()
        {
            if (txtProducto.Text.Length == 0 || txtValorUnitario.Text.Length == 0) btnAgregarProducto.Enabled = false;
            else btnAgregarProducto.Enabled = true;
        }

        private void deshabilitarBtnAgregarVenta()
        {
            if (txtCantidadVendida.Text.Length == 0 || cmbProductos.SelectedIndex == -1) btnAgregarVenta.Enabled = false;
            else btnAgregarVenta.Enabled = true;
        }

        private void deshabilitarBtnQuitarProducto()
        {
            if (cmbProductos.SelectedIndex == -1) btnQuitarProducto.Enabled = false;
            else btnQuitarProducto.Enabled = !calcularSiTieneVentas();
        }

        private void deshabilitarTxtCantidadVenta()
        {
            if (cmbProductos.SelectedIndex == -1) txtCantidadVendida.Enabled = false;
            else txtCantidadVendida.Enabled = true;
        }


    }
}

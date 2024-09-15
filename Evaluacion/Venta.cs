namespace Evaluacion
{
    internal class Venta
    {
        public Producto Producto;
        public int Cantidad, Valor;


        public Venta(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
            Valor = producto.ValorUnitario * cantidad;
        }
    }
}

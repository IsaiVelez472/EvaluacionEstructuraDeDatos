namespace Evaluacion
{
    internal class Producto
    {
        public string NombreProducto;
        public int ValorUnitario;

        public Producto(string nombreProducto, int valorUnitario)
        {
            NombreProducto = nombreProducto;
            ValorUnitario = valorUnitario;
        }

        public override string ToString()
        {
            return $"{NombreProducto} - ${ValorUnitario.ToString("N0")}";
        }
    }
}

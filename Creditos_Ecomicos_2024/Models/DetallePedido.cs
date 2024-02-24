namespace Creditos_Ecomicos_2024.Models
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public int ProductoId { get; set; }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
    }
}

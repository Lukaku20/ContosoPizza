namespace ContosoPizza.Models
{
    public class PizzaOrden
    {
        public int OrdenId { get; set; }
        public Orden Orden { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int Cantidad { get; set; }
    }
}
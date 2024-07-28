using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models
{
    public class Orden
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public decimal PrecioTotal { get; set; }

        // Navegación property
        public List<PizzaOrden> PizzasOrden { get; set; } = new();
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TetePizza.Model;

public class Pedidos
{
    [Key]
    public int idPedido { get; set; }

    public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

    public double precioPedido { get; set; }

    public Usuario? User { get; set; }
    
}
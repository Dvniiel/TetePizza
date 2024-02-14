using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TetePizza.Model;

public class Ingredientes
{
    [Key]
    public int  idIngrediente { get; set; }

    public string  nombreIngrediente { get; set; }

    public string tipo { get; set; }

    public int cantidad { get; set; }

    public double precio { get; set; }

    public bool IsGlutenFree { get; set; }

}

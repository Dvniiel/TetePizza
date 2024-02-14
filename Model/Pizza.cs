using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TetePizza.Model;

public class Pizza {

    [Key]
    public int idPizza { get; set;}

    [Required]
    public string? nombrePizza { get; set; }

    public double precioPizza {get; set;}

    public List<Ingredientes> Ingredients {get; set;}

}
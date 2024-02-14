using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TetePizza.Model;

public class Usuario
{
    [Key]
    public int idUsuario { get; set; }

    
    public string?  nombre { get; set; }


    public string? direccion { get; set; }

}
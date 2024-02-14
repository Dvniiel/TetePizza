using Microsoft.EntityFrameworkCore;
using TetePizza.Model;
using Microsoft.Extensions.Configuration;

namespace TetePizza.Data
{
    public class TetePizzaContext : DbContext
    {

        public TetePizzaContext(DbContextOptions<TetePizzaContext> options)
            : base(options)
        {

        }


        // DB SETS
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredientes> Ingredientes { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { idPizza = 1, nombrePizza = "Clasica", precioPizza = 13.10 },
                new Pizza { idPizza = 2, nombrePizza = "Veggie", precioPizza = 7.70 },
                new Pizza { idPizza = 3, nombrePizza = "Pepperoni", precioPizza = 7.00 },
                new Pizza { idPizza = 4, nombrePizza = "Margarita", precioPizza = 10.40 }
            );

            modelBuilder.Entity<Ingredientes>().HasData(

            new Ingredientes { idIngrediente = 1, nombreIngrediente = "Tomate", tipo = "Fruta", cantidad = 2, precio = 0.22, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 2, nombreIngrediente = "Prosciutto", tipo = "Carne", cantidad = 3, precio = 1.3, IsGlutenFree = false },
            new Ingredientes { idIngrediente = 3, nombreIngrediente = "Queso Parmesano", tipo = "Lácteo", cantidad = 4, precio = 2.5, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 4, nombreIngrediente = "Aceite de Oliva", tipo = "Condimento", cantidad = 1, precio = 3.0, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 5, nombreIngrediente = "Tomate", tipo = "Fruta", cantidad = 2, precio = 0.22, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 6, nombreIngrediente = "Espinaca", tipo = "Vegetal", cantidad = 1, precio = 0.3, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 7, nombreIngrediente = "Champiñones", tipo = "Hongos", cantidad = 2, precio = 0.25, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 8, nombreIngrediente = "Tomate", tipo = "Fruta", cantidad = 2, precio = 0.22, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 9, nombreIngrediente = "Pepperoni", tipo = "Carne", cantidad = 3, precio = 1.5, IsGlutenFree = false },
            new Ingredientes { idIngrediente = 10, nombreIngrediente = "Oregano", tipo = "Hierba", cantidad = 1, precio = 0.1, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 11, nombreIngrediente = "Tomate", tipo = "Fruta", cantidad = 2, precio = 0.22, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 12, nombreIngrediente = "Queso Mozzarella", tipo = "Lácteo", cantidad = 3, precio = 2.0, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 13, nombreIngrediente = "Queso Cheddar", tipo = "Lácteo", cantidad = 2, precio = 1.5, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 14, nombreIngrediente = "Queso Gouda", tipo = "Lácteo", cantidad = 2, precio = 1.8, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 15, nombreIngrediente = "Queso Brie", tipo = "Lácteo", cantidad = 2, precio = 2.2, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 16, nombreIngrediente = "Queso Roquefort", tipo = "Lácteo", cantidad = 2, precio = 3.5, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 17, nombreIngrediente = "Queso Gruyere", tipo = "Lácteo", cantidad = 2, precio = 2.6, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 18, nombreIngrediente = "Queso Emmental", tipo = "Lácteo", cantidad = 2, precio = 2.3, IsGlutenFree = true },
            new Ingredientes { idIngrediente = 18, nombreIngrediente = "Salchichas", tipo = "Carne", cantidad = 2, precio = 2.3, IsGlutenFree = true }
            );

            //modelBuilder.Entity<Pedidos>().HasData(
            //    new Pedidos {idPedido = 1, precioPedido = 10.40}
            //);



        }
    }
}

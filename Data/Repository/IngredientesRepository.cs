
using TetePizza.Model;
using System.Collections.Generic;

namespace TetePizza.Data
{
    public class IngredientesRepository : IIngredientesRepository
    {
        private List<Ingredientes> Ingredientes { get; set; }
        private  int nextId = 1;

        public IngredientesRepository()
        {


            Ingredientes = new List<Ingredientes>
            {

                new Ingredientes
                {
                    idIngrediente = 0,
                    nombreIngrediente = "tomate",
                    tipo = "fruta",
                    cantidad = 1,
                    precio = 0.50,
                    IsGlutenFree = false
                },

                new Ingredientes
                {
                    idIngrediente = 1,
                    nombreIngrediente = "pesto",
                    tipo = "salsa",
                    cantidad = 6,
                    precio = 1.1,
                    IsGlutenFree = true
                },

                new Ingredientes
                {
                    idIngrediente = 2,
                    nombreIngrediente = "queso",
                    tipo = "lacteo",
                    cantidad = 2,
                    precio = 3.5,
                    IsGlutenFree = true
                },

                new Ingredientes
                {
                    idIngrediente = 3,
                    nombreIngrediente = "aceite de oliva",
                    tipo = "Condimento",
                    cantidad = 1,
                    precio = 6.0,
                    IsGlutenFree = false
                },

                new Ingredientes
                {
                    idIngrediente = 4,
                    nombreIngrediente = "champiñones",
                    tipo = "Vegetal",
                    cantidad = 3,
                    precio = 0.8,
                    IsGlutenFree = true
                },

                new Ingredientes
                {
                    idIngrediente = 5,
                    nombreIngrediente = "pepperoni",
                    tipo = "Carne",
                    cantidad = 10,
                    precio = 2.5,
                    IsGlutenFree = false
                },

                new Ingredientes
                {
                    idIngrediente = 6,
                    nombreIngrediente = "olivas",
                    tipo = "fruta",
                    cantidad = 5,
                    precio = 0.1,
                    IsGlutenFree = true
                },

                new Ingredientes
                {
                    idIngrediente = 7,
                    nombreIngrediente = "oregano",
                    tipo = "hierba",
                    cantidad = 1,
                    precio = 0.4,
                    IsGlutenFree = false
                }
            };
        }



        public Ingredientes Get(int id) => Ingredientes.Find(i => i.idIngrediente == id);
        public List<Ingredientes> GetAll() => Ingredientes;
    }
}



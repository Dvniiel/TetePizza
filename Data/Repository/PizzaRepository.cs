
using System;
using System.Collections.Generic;
using System.Linq;
using TetePizza.Model;

namespace TetePizza.Data
{
    public class PizzaRepository : IPizzaRepository
    {
        private List<Pizza> Pizzas { get; set; }
        private int nextIdIngredient = 3;

        /*public PizzaRepository()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza
                {
                    idPizza = 1,
                    nombrePizza = "Clasica",
                    Ingredients = new List<Ingredientes>
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
                    },
                    
                    precioPizza = 13.10
                },




                new Pizza
                {

                    idPizza = 2,
                    nombrePizza = "Veggie",
                    Ingredients = new List<Ingredientes>
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
                            idIngrediente = 8,
                            nombreIngrediente = "oregano",
                            tipo = "hierba",
                            cantidad = 1,
                            precio = 0.4,
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
                            idIngrediente = 3,
                            nombreIngrediente = "aceite de oliva",
                            tipo = "Condimento",
                            cantidad = 1,
                            precio = 6.0,
                            IsGlutenFree = false
                        },
                    },
                    precioPizza = 7.70
                },



                new Pizza
                {

                    idPizza = 3,
                    nombrePizza = "Pepperoni",
                    Ingredients = new List<Ingredientes>
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
                            idIngrediente = 6,
                            nombreIngrediente = "pepperoni",
                            tipo = "Carne",
                            cantidad = 10,
                            precio = 2.5,
                            IsGlutenFree = false
                        },

                        new Ingredientes
                        {
                            idIngrediente = 8,
                            nombreIngrediente = "oregano",
                            tipo = "hierba",
                            cantidad = 1,
                            precio = 0.4,
                            IsGlutenFree = false
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
                            idIngrediente = 7,
                            nombreIngrediente = "olivas",
                            tipo = "fruta",
                            cantidad = 5,
                            precio = 0.1,
                            IsGlutenFree = true
                        },
                    },
                    precioPizza = 7.00
                },



                new Pizza
                {

                    idPizza = 4,
                    nombrePizza = "Margarita",
                    Ingredients = new List<Ingredientes>
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
                            idIngrediente = 2,
                            nombreIngrediente = "queso",
                            tipo = "lacteo",
                            cantidad = 2,
                            precio = 3.5,
                            IsGlutenFree = true
                        },
                        
                        new Ingredientes
                        {
                            idIngrediente = 8,
                            nombreIngrediente = "oregano",
                            tipo = "hierba",
                            cantidad = 1,
                            precio = 0.4,
                            IsGlutenFree = false
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

                    },
                    precioPizza = 10.40
                },
            };
        }*/

        public List<Pizza> GetAll() => Pizzas;


        public Pizza? Get(int idIngrediente) => Pizzas.FirstOrDefault(p => p.idPizza == idIngrediente);


        public void Add(Pizza pizza)
        {
            pizza.idPizza = nextIdIngredient++;
            Pizzas.Add(pizza);
        }


        public void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.idPizza == pizza.idPizza);
            if (index == -1)
                return;

            Pizzas[index] = pizza;
        }


        public void Delete(int idPizza)
        {
            var pizza = Get(idPizza);
            if (pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

    }
}


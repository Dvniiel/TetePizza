using TetePizza.Model;
using Microsoft.EntityFrameworkCore;

namespace TetePizza.Data
{
    public class PizzaEFRepository : IPizzaRepository
    {
        private readonly TetePizzaContext _context;

        public PizzaEFRepository(TetePizzaContext context)
        {
            _context = context;
        }


        // GET ALL
        public List<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }


        // GET POR ID
        public Pizza Get(int Id)
        {
            return _context.Pizzas.FirstOrDefault(pizza => pizza.idPizza == Id);
        }


        //POST
        public void Add(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            SaveChanges();
        }


        // DELETE
        public void Delete(int id)
        {
            var pizza = _context.Pizzas.FirstOrDefault(pizza => pizza.idPizza == id);
            if(pizza != null){
                _context.Pizzas.Remove(pizza);
            }
            SaveChanges();
        }


        // UPDATE
        public void Update(Pizza pizza)
        {
            _context.Pizzas.Update(pizza);
            SaveChanges();
        }



        // GUARDAR CAMBIOS (MENOS EN LOS GetAll y Get por ID)
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
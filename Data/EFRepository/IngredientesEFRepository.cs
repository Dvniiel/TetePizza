using TetePizza.Model;
using Microsoft.EntityFrameworkCore;

namespace TetePizza.Data
{
    public class IngredientesEFRepository : IIngredientesRepository
    {
        private readonly TetePizzaContext _context;

        public IngredientesEFRepository(TetePizzaContext context)
        {
            _context = context;
        }

        public List<Ingredientes> GetAll()
        {
            return _context.Ingredientes.ToList();
           
        }

        public Ingredientes Get(int Id)
        {
            return _context.Ingredientes.FirstOrDefault(ingredientes => ingredientes.idIngrediente == Id);
    
        }


        public void Add(Ingredientes ingredientes)
        {
            _context.Ingredientes.Add(ingredientes);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var ingredientes = _context.Ingredientes.FirstOrDefault(ingredientes => ingredientes.idIngrediente == id);
            if (ingredientes != null)
            {
                _context.Ingredientes.Remove(ingredientes);
            }
            SaveChanges();
        }

        public void Update(Ingredientes ingredientes)
        {
            _context.Ingredientes.Update(ingredientes);
            SaveChanges();
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
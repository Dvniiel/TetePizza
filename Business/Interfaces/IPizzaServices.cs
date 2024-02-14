using System.Dynamic;
using TetePizza.Model;

namespace TetePizza.Services
{
    public interface IPizzaService
    {
        List<Pizza> GetAll();

        Pizza Get(int id);

        void Add(Pizza pizza);
        
        void Update(Pizza pizza);

        void Delete(int id);
             
    }
}

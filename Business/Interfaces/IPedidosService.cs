using System.Dynamic;
using TetePizza.Model;

namespace TetePizza.Services
{
    public interface IPedidosService
    {

        Pedidos Get(int id);

        void Add(Pedidos pedidos);

        void AddPizzas(int id, List<Pizza> pizza);
        
    }
}

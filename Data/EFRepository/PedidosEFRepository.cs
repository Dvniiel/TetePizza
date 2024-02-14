using TetePizza.Model;
using Microsoft.EntityFrameworkCore;

namespace TetePizza.Data
{
    public class PedidosEFRepository : IPedidosRepository
    {
        private readonly TetePizzaContext _context;

        public PedidosEFRepository(TetePizzaContext context)
        {
            _context = context;
        }



        //GET ALL PEDIDOS
        public List<Pedidos> GetAll(){
            return _context.Pedidos.ToList();
            SaveChanges();
        }



        // GET DE PEDIDOS
        public Pedidos Get(int Id){
            return _context.Pedidos.FirstOrDefault(pedido => pedido.idPedido == Id);
            SaveChanges();
        }



        // POST PEDIDOS
        public void Add(Pedidos pedido){
            _context.Pedidos.Add(pedido);
            SaveChanges();
        }



        // DELETE PEDIODS
        public void Delete(int id){
            var pedido = _context.Pedidos.FirstOrDefault(pedido => pedido.idPedido == id);
            if(pedido != null){
                _context.Pedidos.Remove(pedido);
            }
            SaveChanges();
        }



        // UPDATE PEDIDOS
        public void Update(Pedidos pedido){
            _context.Pedidos.Update(pedido);
            SaveChanges();
        }



        // GUARDAR CAMBIOS
        public void SaveChanges(){
            _context.SaveChanges();
        }
    }
}
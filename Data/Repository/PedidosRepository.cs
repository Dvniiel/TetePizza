
using TetePizza.Model;
using System.Collections.Generic;
using System.Linq;

namespace TetePizza.Data;

public class PedidosRepository : IPedidosRepository
{

    private  List<Pedidos> Pedidos { get; set; }
    
    private int nextId = 1;


    public  PedidosRepository()
    {
        Pedidos = new List<Pedidos>();
    }


    public Pedidos? Get(int id) => Pedidos.FirstOrDefault(p => p.idPedido == id);

    public void Add(Pedidos pedido)
    {
        pedido.idPedido = nextId++;
        Pedidos.Add(pedido);
    }

    public void Update(Pedidos pedido)
    {
        var index = Pedidos.FindIndex(p => p.idPedido == pedido.idPedido);
        if (index == -1)
            return;

        Pedidos[index] = pedido;
    }
}

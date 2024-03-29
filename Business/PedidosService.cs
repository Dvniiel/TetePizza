﻿using TetePizza.Model;
using TetePizza.Data;
using System.Collections.Generic;

namespace TetePizza.Services
{
    public class PedidosService : IPedidosService
    {


        private readonly IPedidosRepository _pedidosRepository;



        public PedidosService(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }

        

        public void Add(Pedidos pedido)
        {
            _pedidosRepository.Add(pedido);
        }

        public void AddPizzas(int pedidoId, List<Pizza> pizzas)
        {
            var pedido = _pedidosRepository.Get(pedidoId);

            if (pedido != null)
            {
                pedido.Pizzas.AddRange(pizzas);
                pedido.precioPedido = pedido.Pizzas.Sum(p => p.precioPizza);
                _pedidosRepository.Update(pedido);
            }
        }




        public Pedidos Get(int id)
        {
            return _pedidosRepository.Get(id);
        }

        
    }
}

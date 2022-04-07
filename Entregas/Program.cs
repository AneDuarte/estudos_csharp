using System;
using Entregas.Entities;

namespace Entregas.Entities{
    class Program{
        static void Main(string[] args){
            
            Pedido pedido = new Pedido{
                Id = 1080,
                Momento = DateTime.Now,
                Status = Enums.StatusPedido.PagamentoPendente
            };
            
        }
    }
}

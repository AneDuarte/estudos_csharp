using System;
using Entregas.Entities.Enums;

namespace Entregas.Entities
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }  

        public override string ToString(){
            return $"Id {Id}, Momento: {Momento}, Status: {Status}";
        } 
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_v2
{
    class Pedido
    {
        public float id;
        public string tipoPedido;


        public Pedido(float numeroPedido, string tipoPedido)
        {
            this.id = numeroPedido;
            this.tipoPedido = tipoPedido;
        }

           

        public Pedido() { }



    }
}

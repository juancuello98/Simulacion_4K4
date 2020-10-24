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
        public string estado;

        public Pedido(float id, string estado)
        {
            this.id = id;
            this.estado = estado;
        }

        public Pedido() { }



    }
}

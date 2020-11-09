using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5_v2
{
    class PedidoCancelado
    {
        public int id;
        public string tipoPedidoCancelado;
        public double proximoTiempoCancelacion;
        public string empleadoDesignado;

        public PedidoCancelado(int id, string tipoPedidoCancelado, double proximoTiempoCancelacion, string empleadoDesignado)
        {
            this.id = id;
            this.tipoPedidoCancelado = tipoPedidoCancelado;
            this.proximoTiempoCancelacion = proximoTiempoCancelacion;
            this.empleadoDesignado = empleadoDesignado;
        }
    }
}

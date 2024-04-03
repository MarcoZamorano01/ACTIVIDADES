using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIENDAACTIVIDADES.DAL;
using TIENDAACTIVIDADES.MODELOS;

namespace TIENDAACTIVIDADES.BSS
{
    public class PedidoBss
    {
        PedidoDal dal = new PedidoDal();
        public DataTable ListaPedidoBss()
        {
            return dal.ListarPedidoDal();
        }
        public DataTable OtraListaPedidoBss()
        {
            return dal.ListarPedidosCliente();
        }
        public DataTable ListaPedidosTotales()
        {
            return dal.CalcularTotalPedidosPorCliente();
        }
        public void InsertarPedidosBss(PEDIDOS pedido)
        {
            dal.InsertarPedidoDal(pedido);
        }
        public PEDIDOS ObtenerPedidoIdBss(int id)
        {
            return dal.ObtenerPedidoId(id);
        }
        public void EditarPedidoBss(PEDIDOS pedido)
        {
            dal.EditarPedidoDal(pedido);
        }
        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedidoDal(id);
        }
    }
}

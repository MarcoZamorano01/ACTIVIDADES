using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIENDAACTIVIDADES.MODELOS;

namespace TIENDAACTIVIDADES.DAL
{
    public class PedidoDal
    {
        public DataTable ListarPedidoDal()
        {
            string cosulta = "select * from pedido";
            DataTable Lista = CONEXION.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }

        public List<PEDIDOS> ListarPedidosCliente(int idCliente)
        {
            string consulta = "select * from pedido where idcliente=" + idCliente;
            DataTable tabla = CONEXION.EjecutarDataTabla(consulta, "tabla");
            List<PEDIDOS> listaPedidos = new List<PEDIDOS>();
            foreach (DataRow fila in tabla.Rows)
            {
                PEDIDOS p = new PEDIDOS();
                p.IdPedido = Convert.ToInt32(fila["IdPedido"]);
                p.IdCliente = Convert.ToInt32(fila["IdCliente"]);
                p.Fecha = Convert.ToDateTime(fila["Fecha"]);
                p.Total = Convert.ToDecimal(fila["Total"]);
                p.Estado = fila["Estado"].ToString();
                listaPedidos.Add(p);
            }
            return listaPedidos;
        }

        public decimal CalcularTotalPedidosPorCliente(int idCliente)
        {
            string consulta = "select sum(Total) as TotalPedidos from pedido where idcliente=" + idCliente;
            DataTable tabla = CONEXION.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0 && tabla.Rows[0]["TotalPedidos"] != DBNull.Value)
            {
                return Convert.ToDecimal(tabla.Rows[0]["TotalPedidos"]);
            }
            return 0;
        }


        public void InsertarPedidoDal(PEDIDOS pedido)
        {
            string consulta = "insert into pedido values('" + pedido.IdCliente + "','" + pedido.Fecha + "'," + "'" + pedido.Total + "'," + "'Activo')";
            CONEXION.Ejecutar(consulta);
        }
        public PEDIDOS ObtenerPedidoId(int Id)
        {
            string consulta = "select * from pedido where idpedido=" + Id;
            DataTable tabla = CONEXION.EjecutarDataTabla(consulta, "asdas");
            PEDIDOS p = new PEDIDOS();
            if (tabla.Rows.Count > 0)
            {
                p.IdPedido = Convert.ToInt32(tabla.Rows[0]["IdCliente"]);
                p.IdCliente = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                p.Fecha = Convert.ToDateTime(tabla.Rows[0]["TipoCliente"]);
                p.Total = Convert.ToDecimal(tabla.Rows[0]["CodigoCliente"]);
                p.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return p;
        }
        public void EditarPedidoDal(PEDIDOS pedido)
        {
            string consulta = "update pedido set idcliente='" + pedido.IdCliente + "'," + "fecha='" + pedido.Fecha + "'," + "total='" + pedido.Total + "' " + "where idpedido=" + pedido.IdPedido;
            CONEXION.Ejecutar(consulta);
        }

        public void EliminarPedidoDal(int id)
        {
            string consulta = "delete from pedido where idpedido=" + id;
            CONEXION.Ejecutar(consulta);
        }
    }
}

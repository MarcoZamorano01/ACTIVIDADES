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
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListaClienteBss()
        {
            return dal.ListarClienteDal();
        }
        public DataTable OtraListaClienteBss()
        {
            return dal.OtraListarClienteDal();
        }
        public void InsertarClienteBss(CLIENTES cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public CLIENTES ObtenerClienteIdBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }
        public void EditarClienteBss(CLIENTES cl)
        {
            dal.EditarClienteDal(cl);
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}

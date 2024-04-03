using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIENDAACTIVIDADES.MODELOS;

namespace TIENDAACTIVIDADES.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string cosulta = "select * from cliente";
            DataTable Lista = CONEXION.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable OtraListarClienteDal()
        {
            string cosulta = "SELECT IDCLIENTE, NOMBRE+' '+APELLIDO AS NOMBRES\r\nFROM CLIENTE";
            DataTable Lista = CONEXION.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }

        public void InsertarClienteDal(CLIENTES cliente)
        {
            string consulta = "insert into cliente values('" + cliente.Nombre + "','" + cliente.Apellido + "','" + cliente.Correo + "','" + cliente.Telefono + "','" + cliente.Direccion + "')";
            CONEXION.Ejecutar(consulta);
        }
        public CLIENTES ObtenerClienteId(int Id)
        {
            string consulta = "select * from cliente where idcliente=" + Id;
            DataTable tabla = CONEXION.EjecutarDataTabla(consulta, "asdas");
            CLIENTES p = new CLIENTES();
            if (tabla.Rows.Count > 0)
            {
                p.IdCliente = Convert.ToInt32(tabla.Rows[0]["IdCliente"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Correo = tabla.Rows[0]["correo"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p.Direccion = tabla.Rows[0]["direccion"].ToString();
            }
            return p;
        }
        public void EditarClienteDal(CLIENTES cliente)
        {
            string consulta = "update cliente set nombre='" + cliente.Nombre + "'," + "apellido='" + cliente.Apellido + "'," + "correo='" + cliente.Correo + "'," + "telefono='" + cliente.Telefono + "'," + "direccion='" + cliente.Direccion + "' " + "where idcliente=" + cliente.IdCliente;
            CONEXION.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            CONEXION.Ejecutar(consulta);
        }
    }
}

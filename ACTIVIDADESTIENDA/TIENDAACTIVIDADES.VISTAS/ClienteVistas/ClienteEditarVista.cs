using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIENDAACTIVIDADES.BSS;
using TIENDAACTIVIDADES.MODELOS;

namespace TIENDAACTIVIDADES.VISTAS.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        CLIENTES cli = new CLIENTES();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
           idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)//cargar
        {
            cli = bss.ObtenerClienteIdBss(idx);
            //textBox1.Text = Convert.ToString(cli.IdPersona);
            textBox1.Text = cli.Nombre;
            textBox2.Text = cli.Apellido;
            textBox3.Text = cli.Correo;
            textBox4.Text = cli.Telefono;
            textBox5.Text = cli.Direccion;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            cli.Nombre = textBox1.Text;
            cli.Apellido = textBox2.Text;
            cli.Correo = textBox3.Text;
            cli.Telefono = textBox4.Text;
            cli.Direccion = textBox5.Text;

            bss.EditarClienteBss(cli);
            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)//cancelar
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}

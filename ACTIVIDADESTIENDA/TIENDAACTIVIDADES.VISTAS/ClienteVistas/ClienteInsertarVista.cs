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
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)//guardar
        {
            CLIENTES c = new CLIENTES();
            c.Nombre = textBox1.Text;
            c.Apellido = textBox2.Text;
            c.Correo = textBox3.Text;
            c.Telefono = textBox4.Text;
            c.Direccion = textBox5.Text;
            bss.InsertarClienteBss(c);
            MessageBox.Show("se guardo correctamente el cliente");
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

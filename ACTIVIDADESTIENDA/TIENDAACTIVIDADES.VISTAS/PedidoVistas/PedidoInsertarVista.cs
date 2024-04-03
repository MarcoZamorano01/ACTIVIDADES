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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TIENDAACTIVIDADES.MODELOS;
using TIENDAACTIVIDADES.VISTAS.ClienteVistas;

namespace TIENDAACTIVIDADES.VISTAS.PedidoVistas
{
    public partial class PedidoInsertarVista : Form
    {
        public PedidoInsertarVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static int IdClienteSelecionada = 0;
        ClienteBss bssCli = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)//seleccionar id cliente
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                CLIENTES cliente = bssCli.ObtenerClienteIdBss(IdClienteSelecionada);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }

        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            PEDIDOS p = new PEDIDOS();
            p.IdCliente = IdClienteSelecionada;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2);
            bss.InsertarPedidosBss(p);
            MessageBox.Show("se guardo correctamente el pedido");
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
        }
    }
}

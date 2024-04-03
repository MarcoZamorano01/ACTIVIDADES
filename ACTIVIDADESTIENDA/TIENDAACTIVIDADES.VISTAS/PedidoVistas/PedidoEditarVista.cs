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
using TIENDAACTIVIDADES.VISTAS.ClienteVistas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TIENDAACTIVIDADES.VISTAS.PedidoVistas
{
    public partial class PedidoEditarVista : Form
    {
        int idx = 0;
        PEDIDOS ped = new PEDIDOS();
        PedidoBss bss = new PedidoBss();
        public PedidoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//CANCELAR
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void PedidoEditarVista_Load(object sender, EventArgs e)//cargar
        {
            ped = bss.ObtenerPedidoIdBss(idx);
            textBox1.Text = Convert.ToString(ped.IdCliente);
            dateTimePicker1.Value = Convert.ToDateTime(ped.Fecha);
            textBox2.Text = Convert.ToString(ped.Total);
        }
        public static int IdClienteSelecionada = 0;
        ClienteBss BssCli = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)//seleccionar cliente
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                CLIENTES cliente = BssCli.ObtenerClienteIdBss(IdClienteSelecionada);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            ped.IdCliente = Convert.ToInt32(textBox1.Text);
            ped.Fecha = dateTimePicker1.Value;
            ped.Total = Convert.ToDecimal(textBox2.Text);

            bss.EditarPedidoBss(ped);
            MessageBox.Show("Datos Actualizados");
        }
    }
}

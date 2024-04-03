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
using TIENDAACTIVIDADES.VISTAS.ClienteVistas;

namespace TIENDAACTIVIDADES.VISTAS.PedidoVistas
{
    public partial class PedidoListarVista : Form
    {
        public PedidoListarVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        private void PedidoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaPedidoBss();
        }

        private void button1_Click(object sender, EventArgs e)//editar
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PedidoEditarVista fr = new PedidoEditarVista(IdPedidoSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaPedidoBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//agregar
        {
            PedidoInsertarVista fr = new PedidoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaPedidoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult reslut = MessageBox.Show("Esta seguro de eliminar este Pedido?", "ELIMINANDO", MessageBoxButtons.YesNo);
            if (reslut == DialogResult.Yes)
            {
                bss.EliminarPedidoBss(IdPedidoSeleccionada);
                dataGridView1.DataSource = bss.ListaPedidoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//seleccionar
        {
            //por especificar
        }
    }
}

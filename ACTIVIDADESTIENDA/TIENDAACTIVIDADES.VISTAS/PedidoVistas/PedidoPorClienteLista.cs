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
    public partial class PedidoPorClienteLista : Form
    {
        public PedidoPorClienteLista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        private void PedidoPorClienteLista_Load(object sender, EventArgs e)//carga
        {
            dataGridView1.DataSource = bss.ListarPedidosCliente();
        }

        private void button1_Click(object sender, EventArgs e)//MONTOS
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            MontosClienteListarVista fr = new MontosClienteListarVista(IdPedidoSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.OtraListarClienteDal();
            }

        }
    }
}

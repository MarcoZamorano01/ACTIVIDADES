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

namespace TIENDAACTIVIDADES.VISTAS.ClienteVistas
{
    public partial class SoloClienteListarVista : Form
    {
        public SoloClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void SoloClienteListarVista_Load(object sender, EventArgs e)//CARGAR
        {
            dataGridView1.DataSource = bss.OtraListaClienteBss();
        }

        private void button1_Click(object sender, EventArgs e)//SELECCIONAR
        {
            PedidoVistas.PedidoPorClienteLista.IdClienteSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}

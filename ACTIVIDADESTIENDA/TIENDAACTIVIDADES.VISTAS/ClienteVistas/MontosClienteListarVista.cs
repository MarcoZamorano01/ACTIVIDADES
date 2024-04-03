using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIENDAACTIVIDADES.VISTAS.ClienteVistas
{
    public partial class MontosClienteListarVista : Form
    {
        public MontosClienteListarVista()
        {
            InitializeComponent();
        }

        private void MontosClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaClienteBss();
        }
    }
}

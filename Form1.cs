using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsVendedor.Vendedor' Puede moverla o quitarla según sea necesario.
            this.vendedorTableAdapter.Fill(this.dsVendedor.Vendedor);
            dataGridView1.AutoResizeColumns(); 
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vendedorTableAdapter.Update(dsVendedor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

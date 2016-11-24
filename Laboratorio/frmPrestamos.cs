using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
            contexto = new laboratorioEntities();
            administradorEstados = new AdministradorEstados(contexto);
            administradorPrestamos = new AdministradorPrestamos(contexto);
        }

        laboratorioEntities contexto;
        AdministradorEstados administradorEstados;
        AdministradorPrestamos administradorPrestamos;

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            dgvPrestamos.AutoGenerateColumns = false;
            cmbEstado.Items.Add(new { Id = 0, Nombre = "Todos" });
            cmbEstado.Items.AddRange(administradorEstados.ObtenerEstadosPrestamo().ToArray());
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "Id";
            BuscarFiltrar();
        }

        void BuscarFiltrar()
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = administradorPrestamos.BuscarFiltrar(txtBuscar.Text, (int)(cmbEstado.SelectedValue??0));
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarFiltrar();
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarFiltrar();
        }
    }
}

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
    public partial class frmBuscarMaterial : Form
    {
        public frmBuscarMaterial()
        {
            InitializeComponent();
        }

        public laboratorioEntities Contexto { get; set; }
        AdministradorMateriales administradorMateriales;

        private void frmBuscarMaterial_Load(object sender, EventArgs e)
        {
            administradorMateriales = new AdministradorMateriales(Contexto);
            dgvMateriales.AutoGenerateColumns = false;
            dgvMateriales.DataSource = administradorMateriales.ObtenerTodos();
        }

        private void txtBuscarMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvMateriales.DataSource = null;
                dgvMateriales.DataSource = administradorMateriales
                                        .BuscarMateriales(txtBuscarMaterial.Text);
            }
        }

        public material Material { get; set; }

        private void dgvMateriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Material = (material)dgvMateriales.Rows[e.RowIndex].DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

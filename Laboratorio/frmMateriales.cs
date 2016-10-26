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
    public partial class frmMateriales : Form
    {
        public frmMateriales()
        {
            InitializeComponent();
            contexto = new laboratorioEntities();
            administradorMateriales = new AdministradorMateriales(contexto);
        }

        laboratorioEntities contexto;
        AdministradorMateriales administradorMateriales;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMaterial frmAgregar = new frmAgregarMaterial();
            frmAgregar.Contexto = contexto;

            DialogResult resultado = frmAgregar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                administradorMateriales.AgregarMaterial(frmAgregar.Material);
            }
        }

        private void frmMateriales_Load(object sender, EventArgs e)
        {
            administradorMateriales.Actualizado += AdministradorMateriales_Actualizado;
            dgvMateriales.AutoGenerateColumns = false;
            AdministradorMateriales_Actualizado();
        }

        private void AdministradorMateriales_Actualizado()
        {
            dgvMateriales.DataSource = null;
            dgvMateriales.DataSource = administradorMateriales.ObtenerTodos();
        }
    }
}

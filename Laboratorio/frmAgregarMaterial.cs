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
    public partial class frmAgregarMaterial : Form
    {
        public frmAgregarMaterial()
        {
            InitializeComponent();
        }


        public material Material { get; set; }
        public laboratorioEntities Contexto { get; set; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Material = new material();
            Material.Nombre = txtNombre.Text;
            Material.Descripcion = txtDescripcion.Text;
            Material.CategoriaId = (int)cmbCategoria.SelectedValue;
        }

        private void frmAgregarMaterial_Load(object sender, EventArgs e)
        {
            AdministradorCategorias administradorCategorias = new AdministradorCategorias(Contexto);
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = administradorCategorias.ObtenerTodas();
        }
    }
}

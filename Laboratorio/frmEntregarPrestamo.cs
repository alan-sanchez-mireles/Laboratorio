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
    public partial class frmEntregarPrestamo : Form
    {
        public frmEntregarPrestamo()
        {
            InitializeComponent();
        }

        laboratorioEntities contexto;

        private void frmEntregarPrestamo_Load(object sender, EventArgs e)
        {
            dgvMateriales.AutoGenerateColumns = false;
            DataGridViewComboBoxColumn columna = new DataGridViewComboBoxColumn();
            columna.Name = "EstadoMaterialId";
            columna.DataPropertyName = "EstadoMaterialId";
            columna.HeaderText = "Estado";
            columna.ValueMember = "Id";
            columna.DisplayMember = "Nombre";
            columna.DataSource = contexto.estadomaterial.ToList();
            dgvMateriales.Columns.Insert(3, columna);
        }
    }
}

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
    public partial class frmAgregarAlumno : Form
    {
        public frmAgregarAlumno()
        {
            InitializeComponent();
        }

        AdministradorCarreras administradorCarreras;
        public laboratorioEntities Contexto { get; set; }
        

        private void frmAgregarAlumno_Load(object sender, EventArgs e)
        {
            administradorCarreras = new AdministradorCarreras(Contexto);

            cmbCarrera.DataSource = administradorCarreras.ObtenerTodas();
            cmbCarrera.DisplayMember = "NombreCorto";
        }
    }
}

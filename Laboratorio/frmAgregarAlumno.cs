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

        public alumno Alumno { get; set; }

        private void frmAgregarAlumno_Load(object sender, EventArgs e)
        {
            administradorCarreras = new AdministradorCarreras(Contexto);

            cmbCarrera.DataSource = administradorCarreras.ObtenerTodas();
            cmbCarrera.DisplayMember = "NombreCorto";
            cmbCarrera.ValueMember = "Id";      
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno = new alumno();
            Alumno.NumeroControl = txtNumeroControl.Text;
            Alumno.Nombres = txtNombres.Text;
            Alumno.ApellidoPaterno = txtApellidoPaterno.Text;
            Alumno.ApellidoMaterno = txtApellidoMaterno.Text;
            Alumno.CarreraId = (int)cmbCarrera.SelectedValue;
            Close();
        }
    }
}

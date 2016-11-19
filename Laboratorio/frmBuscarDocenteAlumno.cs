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
    public partial class frmBuscarDocenteAlumno : Form
    {
        public frmBuscarDocenteAlumno()
        {
            InitializeComponent();
        }

        public laboratorioEntities Contexto { get; set; }
        AdministradorAlumnos administradorAlumnos;
        AdministradorDocentes administradorDocentes;

        private void frmBuscarDocenteAlumno_Load(object sender, EventArgs e)
        {
            dgvAlumnos.AutoGenerateColumns = dgvDocentes.AutoGenerateColumns = false;
            administradorAlumnos = new AdministradorAlumnos(Contexto);
            administradorDocentes = new AdministradorDocentes(Contexto);
            List<alumno> alumnos = administradorAlumnos.ObtenerTodos();
            dgvAlumnos.DataSource = alumnos;
            List<docente> docentes = administradorDocentes.ObtenerTodos();
            dgvDocentes.DataSource = docentes;
        }

        public alumno Alumno { get; set; }
        public docente Docente { get; set; }

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno = (alumno)dgvAlumnos.Rows[e.RowIndex].DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Docente = (docente)dgvDocentes.Rows[e.RowIndex].DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();               
        }

        private void txtBuscarAlumnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = administradorAlumnos
                                              .BuscarAlumnos(txtBuscarAlumnos.Text);
            }
        }

        private void txtBuscarAlumnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarDocentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvDocentes.DataSource = null;
                dgvDocentes.DataSource = administradorDocentes.BuscarDocente(txtBuscarDocentes.Text);
            }
        }
    }
}

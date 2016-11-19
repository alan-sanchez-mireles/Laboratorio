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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
            contexto = new laboratorioEntities();
            administradorAlumnos = new AdministradorAlumnos(contexto);
        }

        laboratorioEntities contexto;
        AdministradorAlumnos administradorAlumnos;

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.DataSource = administradorAlumnos.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarAlumno frmAgregarAlumno = new frmAgregarAlumno();
            frmAgregarAlumno.Contexto = contexto;

            DialogResult resultado = frmAgregarAlumno.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                administradorAlumnos.AgregarAlumno(frmAgregarAlumno.Alumno);
            }

        }
    }
}

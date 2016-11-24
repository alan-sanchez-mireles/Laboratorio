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
    public partial class frmCrearPrestamo : Form
    {
        public frmCrearPrestamo()
        {
            InitializeComponent();
            contexto = new laboratorioEntities();
            administradorDocentes = new AdministradorDocentes(contexto);
            administradorAlumnos = new AdministradorAlumnos(contexto);
            administradorPrestamos = new AdministradorPrestamos(contexto);
            administradorEstados = new AdministradorEstados(contexto);
        }

        laboratorioEntities contexto;
        AdministradorDocentes administradorDocentes;
        AdministradorAlumnos administradorAlumnos;
        AdministradorPrestamos administradorPrestamos;
        AdministradorEstados administradorEstados;

        private void frmCrearPrestamo_Load(object sender, EventArgs e)
        {
            dgvMateriales.AutoGenerateColumns = false;
            DataGridViewComboBoxColumn columna = new DataGridViewComboBoxColumn();
            columna.Name = "EstadoMaterialId";
            columna.DataPropertyName = "EstadoMaterialId";
            columna.HeaderText = "Estado";
            columna.ValueMember = "Id";
            columna.DisplayMember = "Nombre";
            columna.DataSource = administradorEstados.ObtenerEstadosMaterial();
            dgvMateriales.Columns.Insert(3,columna);
        }

        docente docente;
        alumno alumno;

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (txtClave.Text.Length == 4)
                {
                    int clave = int.Parse(txtClave.Text);
                    docente = administradorDocentes.ObtenerDocente(clave);
                    if (docente != null)
                    {
                        txtNombre.Text = string.Format("{0} {1} {2}",
                                        docente.Nombres,
                                        docente.ApellidoPaterno,
                                        docente.ApellidoMaterno);
                    }
                }
                else if (txtClave.Text.Length == 8)
                {
                    alumno = administradorAlumnos.ObtenerAlumno(txtClave.Text);
                    if (alumno != null)
                    {
                        txtNombre.Text = string.Format("{0} {1} {2}",
                                        alumno.Nombres,
                                        alumno.ApellidoPaterno,
                                        alumno.ApellidoMaterno);
                        txtCarrera.Text = alumno.carrera.NombreCorto;
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDocenteAlumno frmBuscar = new frmBuscarDocenteAlumno();
            frmBuscar.Contexto = contexto;
            DialogResult resultado = frmBuscar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                if (frmBuscar.Alumno!=null)
                {
                    alumno = frmBuscar.Alumno;
                    txtClave.Text = alumno.NumeroControl;
                    txtNombre.Text = string.Format("{0} {1} {2}",
                                        alumno.Nombres,
                                        alumno.ApellidoPaterno,
                                        alumno.ApellidoMaterno);
                    txtCarrera.Text = alumno.carrera.NombreCorto;
                }
                else
                {
                    docente = frmBuscar.Docente;
                    txtClave.Text = docente.NumeroEmpleado.ToString();
                    txtNombre.Text = string.Format("{0} {1} {2}",
                                        docente.Nombres,
                                        docente.ApellidoPaterno,
                                        docente.ApellidoMaterno);
                }
            }
        }

        List<MaterialPedido> materiales = new List<MaterialPedido>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmBuscarMaterial buscarMaterial = new frmBuscarMaterial();
            buscarMaterial.Contexto = contexto;
            DialogResult resultado = buscarMaterial.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MaterialPedido material = materiales.FirstOrDefault(x => x.MaterialId == buscarMaterial.Material.Id);
                if (material != null)
                {
                    material.Cantidad++;
                }
                else
                {
                    MaterialPedido materialPedido = new MaterialPedido();
                    materialPedido.NombreMaterial = buscarMaterial.Material.Nombre;
                    materialPedido.MaterialId = buscarMaterial.Material.Id;
                    materialPedido.Cantidad = 1;
                    materialPedido.EstadoMaterialId = 1;
                    materiales.Add(materialPedido);
                } 
                    dgvMateriales.DataSource = null;
                    dgvMateriales.DataSource = materiales;
                
            }
        }

        private void dgvMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MaterialPedido material = (MaterialPedido)dgvMateriales.Rows[e.RowIndex].DataBoundItem;
                materiales.Remove(material);

                dgvMateriales.DataSource = null;
                dgvMateriales.DataSource = materiales;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            prestamo prestamo = new prestamo();
            if (alumno!=null)
            {
                prestamo.AlumnoId = alumno.NumeroControl;
            }
            else
            {
                prestamo.DocenteId = docente.NumeroEmpleado;
            }
            prestamo.EstadoPrestamoId = 1;
            prestamo.Fecha = DateTime.Now;

            foreach (var material in materiales)
            {
                prestamomaterial prestamomaterial = new prestamomaterial();
                prestamomaterial.MaterialId = material.MaterialId;
                prestamomaterial.EstadoMaterialPrestamoId = material.EstadoMaterialId;
                prestamo.prestamomaterial.Add(prestamomaterial);
            }
            administradorPrestamos.Agregar(prestamo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            Material = Material == null? new material():Material;
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Image imagen = Image.FromFile(openFileDialog1.FileName);
                int ancho, alto;
                if (imagen.Width>imagen.Height)
                {
                    ancho = 200;
                    alto = (int)((double)imagen.Height / imagen.Width * 200);
                }
                else
                {
                    alto = 200;
                    ancho = (int)((double)imagen.Width / imagen.Height * 200);
                }
                Image imagenPequeña = imagen.GetThumbnailImage(ancho, alto, null, new IntPtr());
                pcbImagen.Image = imagenPequeña;

                using (MemoryStream ms = new MemoryStream())
                {
                    imagenPequeña.Save(ms, ImageFormat.Jpeg);

                    Material = Material == null ? new material() : Material;
                    Material.Imagen = ms.ToArray();         
                }
            }
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {

        }
    }
}

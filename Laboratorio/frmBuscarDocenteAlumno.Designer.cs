namespace Laboratorio
{
    partial class frmBuscarDocenteAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.NumeroControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.NumeroEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaternoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaternoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblBuscar);
            this.tabPage1.Controls.Add(this.txtBuscarAlumnos);
            this.tabPage1.Controls.Add(this.dgvAlumnos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumnos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(55, 6);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(589, 20);
            this.txtBuscarAlumnos.TabIndex = 0;
            this.txtBuscarAlumnos.TextChanged += new System.EventHandler(this.txtBuscarAlumnos_TextChanged);
            this.txtBuscarAlumnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarAlumnos_KeyPress);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroControl,
            this.Nombres,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Carrera});
            this.dgvAlumnos.Location = new System.Drawing.Point(6, 32);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(638, 267);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellDoubleClick);
            // 
            // NumeroControl
            // 
            this.NumeroControl.DataPropertyName = "NumeroControl";
            this.NumeroControl.HeaderText = "Número de control";
            this.NumeroControl.Name = "NumeroControl";
            this.NumeroControl.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.DataPropertyName = "ApellidoPaterno";
            this.ApellidoPaterno.HeaderText = "Apellido paterno";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.DataPropertyName = "ApellidoMaterno";
            this.ApellidoMaterno.HeaderText = "Apellido materno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "NombreCarrera";
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBuscarDocentes);
            this.tabPage2.Controls.Add(this.dgvDocentes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Docentes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(55, 6);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(589, 20);
            this.txtBuscarDocentes.TabIndex = 3;
            this.txtBuscarDocentes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDocentes_KeyPress);
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroEmpleado,
            this.NombresD,
            this.ApellidoPaternoD,
            this.ApellidoMaternoD});
            this.dgvDocentes.Location = new System.Drawing.Point(6, 32);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersVisible = false;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(638, 267);
            this.dgvDocentes.TabIndex = 0;
            this.dgvDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellContentClick);
            // 
            // NumeroEmpleado
            // 
            this.NumeroEmpleado.DataPropertyName = "NumeroEmpleado";
            this.NumeroEmpleado.HeaderText = "NumeroEmpleado";
            this.NumeroEmpleado.Name = "NumeroEmpleado";
            this.NumeroEmpleado.ReadOnly = true;
            // 
            // NombresD
            // 
            this.NombresD.DataPropertyName = "Nombres";
            this.NombresD.HeaderText = "Nombres";
            this.NombresD.Name = "NombresD";
            this.NombresD.ReadOnly = true;
            // 
            // ApellidoPaternoD
            // 
            this.ApellidoPaternoD.DataPropertyName = "ApellidoPaterno";
            this.ApellidoPaternoD.HeaderText = "Apellido paterno";
            this.ApellidoPaternoD.Name = "ApellidoPaternoD";
            this.ApellidoPaternoD.ReadOnly = true;
            // 
            // ApellidoMaternoD
            // 
            this.ApellidoMaternoD.DataPropertyName = "ApellidoMaterno";
            this.ApellidoMaternoD.HeaderText = "Apellido materno";
            this.ApellidoMaternoD.Name = "ApellidoMaternoD";
            this.ApellidoMaternoD.ReadOnly = true;
            // 
            // frmBuscarDocenteAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBuscarDocenteAlumno";
            this.Text = "frmBuscarDocenteAlumno";
            this.Load += new System.EventHandler(this.frmBuscarDocenteAlumno_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaternoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaternoD;
    }
}
namespace SistemaAcademico.Presentacion
{
    partial class ConsultarMateria
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvConsultarMateria = new System.Windows.Forms.DataGridView();
            this.ColNroCatedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCatedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarMateria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(646, 483);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(174, 45);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(346, 484);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(182, 43);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(57, 483);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(172, 45);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvConsultarMateria
            // 
            this.dgvConsultarMateria.AllowUserToAddRows = false;
            this.dgvConsultarMateria.AllowUserToDeleteRows = false;
            this.dgvConsultarMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNroCatedra,
            this.ColEstudiante,
            this.ColFecha,
            this.ColEstado,
            this.ColCatedra,
            this.Column4});
            this.dgvConsultarMateria.Location = new System.Drawing.Point(57, 169);
            this.dgvConsultarMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsultarMateria.Name = "dgvConsultarMateria";
            this.dgvConsultarMateria.ReadOnly = true;
            this.dgvConsultarMateria.RowHeadersWidth = 62;
            this.dgvConsultarMateria.Size = new System.Drawing.Size(764, 278);
            this.dgvConsultarMateria.TabIndex = 7;
            this.dgvConsultarMateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarMateria_CellContentClick);
            // 
            // ColNroCatedra
            // 
            this.ColNroCatedra.HeaderText = "Nro Catedra";
            this.ColNroCatedra.MinimumWidth = 8;
            this.ColNroCatedra.Name = "ColNroCatedra";
            this.ColNroCatedra.ReadOnly = true;
            this.ColNroCatedra.Width = 150;
            // 
            // ColEstudiante
            // 
            this.ColEstudiante.HeaderText = "Estudiante";
            this.ColEstudiante.MinimumWidth = 8;
            this.ColEstudiante.Name = "ColEstudiante";
            this.ColEstudiante.ReadOnly = true;
            this.ColEstudiante.Width = 120;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha Inscripcion";
            this.ColFecha.MinimumWidth = 8;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 120;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado Materia";
            this.ColEstado.MinimumWidth = 8;
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            this.ColEstado.Width = 120;
            // 
            // ColCatedra
            // 
            this.ColCatedra.HeaderText = "Catedra";
            this.ColCatedra.MinimumWidth = 8;
            this.ColCatedra.Name = "ColCatedra";
            this.ColCatedra.ReadOnly = true;
            this.ColCatedra.Width = 150;
            // 
            // Column4
            // 
            this.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column4.HeaderText = "Acciones";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaterias);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.lblResponsable);
            this.groupBox1.Controls.Add(this.lblHasta);
            this.groupBox1.Controls.Add(this.lblDesde);
            this.groupBox1.Location = new System.Drawing.Point(57, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(171, 83);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(258, 28);
            this.cboMaterias.TabIndex = 7;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(171, 48);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(258, 26);
            this.dtpHasta.TabIndex = 6;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(171, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(258, 26);
            this.dtpDesde.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(517, 45);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(157, 37);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(68, 92);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(70, 20);
            this.lblResponsable.TabIndex = 2;
            this.lblResponsable.Text = "Materias";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(68, 57);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 20);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(63, 23);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // ConsultarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 556);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvConsultarMateria);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarMateria";
            this.Text = "ConsultarMateria";
            this.Load += new System.EventHandler(this.ConsultarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarMateria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvConsultarMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroCatedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCatedra;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}
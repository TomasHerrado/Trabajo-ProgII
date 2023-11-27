namespace SistemaAcademico.Presentacion
{
    partial class InstripcionMateria
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.ColEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCatedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstadoMateria = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstudiantes = new System.Windows.Forms.ComboBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.dtpFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboCatedra = new System.Windows.Forms.ComboBox();
            this.lblCatedra = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.cboDocente = new System.Windows.Forms.ComboBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(597, 542);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(404, 542);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 35);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(199, 542);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.AllowUserToAddRows = false;
            this.dgvInscripcion.AllowUserToDeleteRows = false;
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEstudiante,
            this.ColCatedra,
            this.ColMateria,
            this.ColAcciones});
            this.dgvInscripcion.Location = new System.Drawing.Point(132, 319);
            this.dgvInscripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.ReadOnly = true;
            this.dgvInscripcion.RowHeadersWidth = 62;
            this.dgvInscripcion.Size = new System.Drawing.Size(664, 202);
            this.dgvInscripcion.TabIndex = 14;
            this.dgvInscripcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripcion_CellContentClick);
            // 
            // ColEstudiante
            // 
            this.ColEstudiante.HeaderText = "Estudiante";
            this.ColEstudiante.MinimumWidth = 8;
            this.ColEstudiante.Name = "ColEstudiante";
            this.ColEstudiante.ReadOnly = true;
            this.ColEstudiante.Width = 150;
            // 
            // ColCatedra
            // 
            this.ColCatedra.HeaderText = "Catedra";
            this.ColCatedra.MinimumWidth = 8;
            this.ColCatedra.Name = "ColCatedra";
            this.ColCatedra.ReadOnly = true;
            this.ColCatedra.Width = 150;
            // 
            // ColMateria
            // 
            this.ColMateria.HeaderText = "Materia";
            this.ColMateria.MinimumWidth = 8;
            this.ColMateria.Name = "ColMateria";
            this.ColMateria.ReadOnly = true;
            this.ColMateria.Width = 150;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.MinimumWidth = 8;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEstadoMateria);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.cboEstudiantes);
            this.groupBox1.Controls.Add(this.lblEstudiante);
            this.groupBox1.Controls.Add(this.dtpFechaInscripcion);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(416, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscripcion";
            // 
            // cboEstadoMateria
            // 
            this.cboEstadoMateria.FormattingEnabled = true;
            this.cboEstadoMateria.Location = new System.Drawing.Point(118, 152);
            this.cboEstadoMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboEstadoMateria.Name = "cboEstadoMateria";
            this.cboEstadoMateria.Size = new System.Drawing.Size(180, 28);
            this.cboEstadoMateria.TabIndex = 9;
            this.cboEstadoMateria.SelectedIndexChanged += new System.EventHandler(this.cboEstadoMateria_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(25, 155);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstudiantes
            // 
            this.cboEstudiantes.FormattingEnabled = true;
            this.cboEstudiantes.Location = new System.Drawing.Point(118, 47);
            this.cboEstudiantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboEstudiantes.Name = "cboEstudiantes";
            this.cboEstudiantes.Size = new System.Drawing.Size(180, 28);
            this.cboEstudiantes.TabIndex = 7;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(25, 47);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(86, 20);
            this.lblEstudiante.TabIndex = 1;
            this.lblEstudiante.Text = "Estudiante";
            // 
            // dtpFechaInscripcion
            // 
            this.dtpFechaInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(118, 100);
            this.dtpFechaInscripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(180, 26);
            this.dtpFechaInscripcion.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(25, 100);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // cboCatedra
            // 
            this.cboCatedra.FormattingEnabled = true;
            this.cboCatedra.Location = new System.Drawing.Point(150, 27);
            this.cboCatedra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCatedra.Name = "cboCatedra";
            this.cboCatedra.Size = new System.Drawing.Size(180, 28);
            this.cboCatedra.TabIndex = 6;
            // 
            // lblCatedra
            // 
            this.lblCatedra.AutoSize = true;
            this.lblCatedra.Location = new System.Drawing.Point(16, 36);
            this.lblCatedra.Name = "lblCatedra";
            this.lblCatedra.Size = new System.Drawing.Size(66, 20);
            this.lblCatedra.TabIndex = 0;
            this.lblCatedra.Text = "Catedra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCuatrimestre);
            this.groupBox2.Controls.Add(this.txtAño);
            this.groupBox2.Controls.Add(this.cboComision);
            this.groupBox2.Controls.Add(this.cboDocente);
            this.groupBox2.Controls.Add(this.cboMateria);
            this.groupBox2.Controls.Add(this.cboHorario);
            this.groupBox2.Controls.Add(this.lblCuatrimestre);
            this.groupBox2.Controls.Add(this.lblAño);
            this.groupBox2.Controls.Add(this.lblComision);
            this.groupBox2.Controls.Add(this.lblDocente);
            this.groupBox2.Controls.Add(this.lblMateria);
            this.groupBox2.Controls.Add(this.lblHorario);
            this.groupBox2.Controls.Add(this.lblCatedra);
            this.groupBox2.Controls.Add(this.cboCatedra);
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 285);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Catedra";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(151, 242);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(179, 26);
            this.txtCuatrimestre.TabIndex = 18;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(151, 204);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(179, 26);
            this.txtAño.TabIndex = 17;
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(151, 170);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(179, 28);
            this.cboComision.TabIndex = 16;
            // 
            // cboDocente
            // 
            this.cboDocente.FormattingEnabled = true;
            this.cboDocente.Location = new System.Drawing.Point(150, 136);
            this.cboDocente.Name = "cboDocente";
            this.cboDocente.Size = new System.Drawing.Size(180, 28);
            this.cboDocente.TabIndex = 15;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(150, 102);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(180, 28);
            this.cboMateria.TabIndex = 14;
            // 
            // cboHorario
            // 
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(150, 68);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(180, 28);
            this.cboHorario.TabIndex = 13;
            this.cboHorario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(20, 244);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(100, 20);
            this.lblCuatrimestre.TabIndex = 12;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(20, 211);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(38, 20);
            this.lblAño.TabIndex = 11;
            this.lblAño.Text = "Año";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(20, 169);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(74, 20);
            this.lblComision.TabIndex = 10;
            this.lblComision.Text = "Comision";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(20, 133);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(70, 20);
            this.lblDocente.TabIndex = 9;
            this.lblDocente.Text = "Docente";
            this.lblDocente.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(20, 101);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(62, 20);
            this.lblMateria.TabIndex = 8;
            this.lblMateria.Text = "Materia";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(20, 69);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(61, 20);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Horario";
            // 
            // InstripcionMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvInscripcion);
            this.Controls.Add(this.groupBox1);
            this.Name = "InstripcionMateria";
            this.Text = "InstripcionMateria";
            this.Load += new System.EventHandler(this.InstripcionMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEstadoMateria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstudiantes;
        private System.Windows.Forms.ComboBox cboCatedra;
        private System.Windows.Forms.Label lblCatedra;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.DateTimePicker dtpFechaInscripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.ComboBox cboDocente;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCatedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMateria;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}
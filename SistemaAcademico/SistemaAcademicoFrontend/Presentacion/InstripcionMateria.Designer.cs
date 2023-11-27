﻿namespace SistemaAcademicoFrontend.Presentacion
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
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(663, 678);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 44);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(449, 678);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 44);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(221, 678);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 44);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            this.dgvInscripcion.Location = new System.Drawing.Point(147, 399);
            this.dgvInscripcion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.ReadOnly = true;
            this.dgvInscripcion.RowHeadersWidth = 62;
            this.dgvInscripcion.Size = new System.Drawing.Size(738, 252);
            this.dgvInscripcion.TabIndex = 2;
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
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.cboEstadoMateria);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.cboEstudiantes);
            this.groupBox1.Controls.Add(this.lblEstudiante);
            this.groupBox1.Controls.Add(this.dtpFechaInscripcion);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Location = new System.Drawing.Point(32, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(462, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscripcion";
            // 
            // cboEstadoMateria
            // 
            this.cboEstadoMateria.FormattingEnabled = true;
            this.cboEstadoMateria.Location = new System.Drawing.Point(131, 190);
            this.cboEstadoMateria.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cboEstadoMateria.Name = "cboEstadoMateria";
            this.cboEstadoMateria.Size = new System.Drawing.Size(200, 33);
            this.cboEstadoMateria.TabIndex = 2;
            this.cboEstadoMateria.SelectedIndexChanged += new System.EventHandler(this.cboEstadoMateria_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(28, 194);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 28);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstudiantes
            // 
            this.cboEstudiantes.FormattingEnabled = true;
            this.cboEstudiantes.Location = new System.Drawing.Point(131, 59);
            this.cboEstudiantes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cboEstudiantes.Name = "cboEstudiantes";
            this.cboEstudiantes.Size = new System.Drawing.Size(200, 33);
            this.cboEstudiantes.TabIndex = 0;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstudiante.Location = new System.Drawing.Point(7, 59);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(112, 28);
            this.lblEstudiante.TabIndex = 1;
            this.lblEstudiante.Text = "Estudiante";
            this.lblEstudiante.Click += new System.EventHandler(this.lblEstudiante_Click);
            // 
            // dtpFechaInscripcion
            // 
            this.dtpFechaInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(131, 125);
            this.dtpFechaInscripcion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(200, 31);
            this.dtpFechaInscripcion.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(28, 125);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 28);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // cboCatedra
            // 
            this.cboCatedra.FormattingEnabled = true;
            this.cboCatedra.Location = new System.Drawing.Point(167, 34);
            this.cboCatedra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cboCatedra.Name = "cboCatedra";
            this.cboCatedra.Size = new System.Drawing.Size(200, 33);
            this.cboCatedra.TabIndex = 0;
            // 
            // lblCatedra
            // 
            this.lblCatedra.AutoSize = true;
            this.lblCatedra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCatedra.Location = new System.Drawing.Point(18, 45);
            this.lblCatedra.Name = "lblCatedra";
            this.lblCatedra.Size = new System.Drawing.Size(85, 28);
            this.lblCatedra.TabIndex = 0;
            this.lblCatedra.Text = "Catedra";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
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
            this.groupBox2.Location = new System.Drawing.Point(518, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(451, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Catedra";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(168, 302);
            this.txtCuatrimestre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(198, 31);
            this.txtCuatrimestre.TabIndex = 6;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(168, 255);
            this.txtAño.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(198, 31);
            this.txtAño.TabIndex = 5;
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(168, 212);
            this.cboComision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(198, 33);
            this.cboComision.TabIndex = 4;
            // 
            // cboDocente
            // 
            this.cboDocente.FormattingEnabled = true;
            this.cboDocente.Location = new System.Drawing.Point(167, 170);
            this.cboDocente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDocente.Name = "cboDocente";
            this.cboDocente.Size = new System.Drawing.Size(200, 33);
            this.cboDocente.TabIndex = 3;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(167, 128);
            this.cboMateria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(200, 33);
            this.cboMateria.TabIndex = 2;
            // 
            // cboHorario
            // 
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(167, 85);
            this.cboHorario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(200, 33);
            this.cboHorario.TabIndex = 1;
            this.cboHorario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuatrimestre.Location = new System.Drawing.Point(22, 305);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(134, 28);
            this.lblCuatrimestre.TabIndex = 12;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAño.Location = new System.Drawing.Point(53, 258);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(50, 28);
            this.lblAño.TabIndex = 11;
            this.lblAño.Text = "Año";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComision.Location = new System.Drawing.Point(22, 211);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(99, 28);
            this.lblComision.TabIndex = 10;
            this.lblComision.Text = "Comision";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDocente.Location = new System.Drawing.Point(22, 166);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(91, 28);
            this.lblDocente.TabIndex = 9;
            this.lblDocente.Text = "Docente";
            this.lblDocente.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.Location = new System.Drawing.Point(22, 126);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(86, 28);
            this.lblMateria.TabIndex = 8;
            this.lblMateria.Text = "Materia";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.Location = new System.Drawing.Point(22, 86);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 28);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Dia";
            // 
            // InstripcionMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1006, 762);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvInscripcion);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
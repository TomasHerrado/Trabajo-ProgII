namespace SistemaAcademico.Presentacion
{
    partial class FormVerDetalle
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
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCatedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(282, 131);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(258, 28);
            this.cboMaterias.TabIndex = 13;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(282, 87);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(258, 26);
            this.dtpHasta.TabIndex = 12;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(282, 42);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(258, 26);
            this.dtpDesde.TabIndex = 11;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(179, 134);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(70, 20);
            this.lblResponsable.TabIndex = 10;
            this.lblResponsable.Text = "Materias";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(179, 87);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 20);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(179, 47);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Desde";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCatedra,
            this.ColHorario,
            this.ColMateria,
            this.ColDocente,
            this.ColComision,
            this.ColAño,
            this.ColCuatri});
            this.dataGridView1.Location = new System.Drawing.Point(21, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(747, 234);
            this.dataGridView1.TabIndex = 14;
            // 
            // ColCatedra
            // 
            this.ColCatedra.HeaderText = "Nombre Catedra";
            this.ColCatedra.MinimumWidth = 8;
            this.ColCatedra.Name = "ColCatedra";
            this.ColCatedra.ReadOnly = true;
            this.ColCatedra.Width = 150;
            // 
            // ColHorario
            // 
            this.ColHorario.HeaderText = "Dia Semana";
            this.ColHorario.MinimumWidth = 8;
            this.ColHorario.Name = "ColHorario";
            this.ColHorario.ReadOnly = true;
            this.ColHorario.Width = 150;
            // 
            // ColMateria
            // 
            this.ColMateria.HeaderText = "Materia";
            this.ColMateria.MinimumWidth = 8;
            this.ColMateria.Name = "ColMateria";
            this.ColMateria.ReadOnly = true;
            this.ColMateria.Width = 150;
            // 
            // ColDocente
            // 
            this.ColDocente.HeaderText = "Docente";
            this.ColDocente.MinimumWidth = 8;
            this.ColDocente.Name = "ColDocente";
            this.ColDocente.ReadOnly = true;
            this.ColDocente.Width = 150;
            // 
            // ColComision
            // 
            this.ColComision.HeaderText = "Comision";
            this.ColComision.MinimumWidth = 8;
            this.ColComision.Name = "ColComision";
            this.ColComision.ReadOnly = true;
            this.ColComision.Width = 150;
            // 
            // ColAño
            // 
            this.ColAño.HeaderText = "Año";
            this.ColAño.MinimumWidth = 8;
            this.ColAño.Name = "ColAño";
            this.ColAño.ReadOnly = true;
            this.ColAño.Width = 150;
            // 
            // ColCuatri
            // 
            this.ColCuatri.HeaderText = "Cuatrimestre";
            this.ColCuatri.MinimumWidth = 8;
            this.ColCuatri.Name = "ColCuatri";
            this.ColCuatri.ReadOnly = true;
            this.ColCuatri.Width = 150;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(347, 445);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 47);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Name = "FormVerDetalle";
            this.Text = "FormVerDetalle";
            this.Load += new System.EventHandler(this.FormVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCatedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatri;
        private System.Windows.Forms.Button btnCerrar;
    }
}
namespace SistemaAcademicoFrontend.Presentacion
{
    partial class ConsultarEstudiante
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
            this.lblDni = new System.Windows.Forms.Label();
            this.cboDni = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.ColNroEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(246, 81);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(49, 28);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // cboDni
            // 
            this.cboDni.FormattingEnabled = true;
            this.cboDni.Location = new System.Drawing.Point(359, 73);
            this.cboDni.Name = "cboDni";
            this.cboDni.Size = new System.Drawing.Size(182, 33);
            this.cboDni.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(647, 72);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 34);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(221, 481);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 34);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Black;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(456, 481);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 34);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(680, 481);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.AllowUserToAddRows = false;
            this.dgvEstudiante.AllowUserToDeleteRows = false;
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNroEstudiante,
            this.ColNombre,
            this.ColApellido,
            this.ColNacimiento,
            this.ColDireccion,
            this.ColEmail});
            this.dgvEstudiante.Location = new System.Drawing.Point(107, 160);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.RowHeadersWidth = 62;
            this.dgvEstudiante.RowTemplate.Height = 33;
            this.dgvEstudiante.Size = new System.Drawing.Size(824, 294);
            this.dgvEstudiante.TabIndex = 6;
            // 
            // ColNroEstudiante
            // 
            this.ColNroEstudiante.HeaderText = "Nro Estudiante";
            this.ColNroEstudiante.MinimumWidth = 8;
            this.ColNroEstudiante.Name = "ColNroEstudiante";
            this.ColNroEstudiante.ReadOnly = true;
            this.ColNroEstudiante.Width = 150;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 8;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 150;
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.MinimumWidth = 8;
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            this.ColApellido.Width = 150;
            // 
            // ColNacimiento
            // 
            this.ColNacimiento.HeaderText = "Nacimiento";
            this.ColNacimiento.MinimumWidth = 8;
            this.ColNacimiento.Name = "ColNacimiento";
            this.ColNacimiento.ReadOnly = true;
            this.ColNacimiento.Width = 150;
            // 
            // ColDireccion
            // 
            this.ColDireccion.HeaderText = "Direccion";
            this.ColDireccion.MinimumWidth = 8;
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.ReadOnly = true;
            this.ColDireccion.Width = 150;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 8;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 150;
            // 
            // ConsultarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1029, 579);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboDni);
            this.Controls.Add(this.lblDni);
            this.Name = "ConsultarEstudiante";
            this.Text = "ConsultarEstudiante";
            this.Load += new System.EventHandler(this.ConsultarEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDni;
        private ComboBox cboDni;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnBorrar;
        private Button btnSalir;
        private DataGridView dgvEstudiante;
        private DataGridViewTextBoxColumn ColNroEstudiante;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColNacimiento;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn ColEmail;
    }
}
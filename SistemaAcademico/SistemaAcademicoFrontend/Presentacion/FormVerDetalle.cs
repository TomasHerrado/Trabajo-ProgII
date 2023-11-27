using SistemaAcademicoBackend.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademicoFrontend.Presentacion
{
    public partial class FormVerDetalle : Form
    {
        private int nroCatedra;
        public FormVerDetalle(int nroCatedra)
        {
            InitializeComponent();
            this.nroCatedra= nroCatedra;
        }

        private void FormVerDetalle_Load(object sender, EventArgs e)
        {
            string sp = "SP_CONSULTAR_DETALLE_INSCRIPCION";
            List<Parametro> lst = new List<Parametro>();

            lst.Add(new Parametro("@id_catedra", nroCatedra));

            DataTable tabla = new HelperDao().ObtenerInstancia().ConsultaSQL(sp, lst);
            bool primero = true;

            foreach (DataRow fila in tabla.Rows)
            {
                if (primero)
                {
                    cboMaterias.Text = fila["nombre_materia"].ToString();
                    dtpDesde.Value = Convert.ToDateTime(fila["fecha".ToString()]);
                    dtpHasta.Value = Convert.ToDateTime(fila["fecha".ToString()]);
                    primero = false;
                }
                dataGridView1.Rows.Add(new object[] { fila["nombre_catedra"].ToString(),
                    fila["dia_semana"].ToString(),
                    fila["nombre_materia"].ToString(),
                    fila["nombre_docente"].ToString(),
                    fila["nombre_comision"].ToString(),
                    fila["año"].ToString(),
                    fila["cuatrimestre"].ToString()});
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

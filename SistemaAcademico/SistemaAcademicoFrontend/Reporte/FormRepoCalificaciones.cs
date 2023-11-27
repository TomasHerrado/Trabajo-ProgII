using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademicoFrontend.Reporte
{
    public partial class FormRepoCalificaciones : Form
    {
        public FormRepoCalificaciones()
        {
            InitializeComponent();
        }

        private void FormRepoCalificaciones_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaAcademicoFrontend.Reporte.ReportCalificaciones.rdlc";
            
            //llenar DS en tiempo de ejecucion
            
            reportViewer1.RefreshReport();


        }
    }
}

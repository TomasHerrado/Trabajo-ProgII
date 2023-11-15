using SistemaAcademico.Entidades;
using SistemaAcademico.Servicios;
using SistemaAcademico.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class InscripcionEstudiante : Form
    {
        IServicio servicio = null; 
        Estudiantes nuevo= null;
        public InscripcionEstudiante(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
            servicio = new Servicios.Implementacion.Servicio();
            nuevo = new Estudiantes();
        }

        private void InscripcionEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

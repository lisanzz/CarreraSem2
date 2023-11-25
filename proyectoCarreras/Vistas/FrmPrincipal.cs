using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoCarreras.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
             "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaCarrera nuevaCarrera = new FrmNuevaCarrera();
            nuevaCarrera.ShowDialog();
            
        }

      

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAsignaturas consultarAsignaturas = new FrmConsultarAsignaturas();
            consultarAsignaturas.ShowDialog();
           
        }
    }
}

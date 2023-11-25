using proyectoCarreras.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoCarreras.Dominio;

namespace proyectoCarreras.Vistas
{
    public partial class FrmConsultarAsignaturas : Form
    {


        private AccesoBD accesoBD = new AccesoBD();
        public FrmConsultarAsignaturas()
        {
            InitializeComponent();
        }

        private void FrmConsultarAsignaturas_Load(object sender, EventArgs e)
        {
            CargarCombo();

        }

        private void CargarCombo()
        {
            List<Asignatura> lsta = new List<Asignatura>();
            lsta = accesoBD.ConsultarAsignatura();
            cboAsignaturas.DataSource = lsta;
            cboAsignaturas.ValueMember = "Id_asignatura";
            cboAsignaturas.DisplayMember = "Nombre";
            cboAsignaturas.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cboAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Asignatura a = (Asignatura)cboAsignaturas.SelectedItem;


            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                if (a.Id_asignatura == Convert.ToInt32(fila.Cells["ColId"].Value))
                {
                    MessageBox.Show("Ya consulto esta asignatura");
                    return;
                }

            }


            int id_asignatura = Convert.ToInt32(a.Id_asignatura);
            string nombre = a.Nombre;
           

            dgvAsignaturas.Rows.Add(id_asignatura, nombre);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
          "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}

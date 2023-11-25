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
    public partial class FrmNuevaCarrera : Form
    {
        Carrera carrera = new Carrera();
        AccesoBD accesoBD = new AccesoBD();
        public FrmNuevaCarrera()
        {
            InitializeComponent();
        }

        private void FrmNuevaCarrera_Load(object sender, EventArgs e)
        {
            cboMateria.DataSource = accesoBD.Consultar_SP("SP_consultar_asignaturas");
            cboMateria.ValueMember = "id_asignatura";
            cboMateria.DisplayMember = "nombre";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboMateria.SelectedItem.Equals(String.Empty))
            {
                MessageBox.Show("seleccione una materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAño.Text == "")
            {
                MessageBox.Show("Debe ingresar un año de cursado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!rbPrimerCuat.Checked && !rbSegundoCuat.Checked)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DetalleCarrera dc in carrera.DetallesCarrera)
            {
                if (dc.Materia.Nombre == cboMateria.Text)
                {
                    MessageBox.Show("Solo puede agregar una vez cada materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Asignatura asignatura = new Asignatura();
            asignatura.Id_asignatura = Convert.ToInt32(cboMateria.SelectedValue);
            asignatura.Nombre = cboMateria.Text;
            int anioCursado = int.Parse(txtAño.Text);
            int cuatrimestre = 0;
            if (rbPrimerCuat.Checked) cuatrimestre = 1;
            if (rbSegundoCuat.Checked) cuatrimestre = 2;

            DetalleCarrera detCarrera = new DetalleCarrera(anioCursado, cuatrimestre, asignatura);
            carrera.AgregarDetalle(detCarrera);
            dgvNuevaCarrera.Rows.Add(new Object[] { asignatura.Id_asignatura, asignatura.Nombre, anioCursado, cuatrimestre });
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera",
                "Atención", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            int id_carrera = accesoBD.AltaCarrera_SP("SP_insertar_carrera", carrera);
            accesoBD.AltaDetallesCarrera_SP("SP_insertar_detalleCarreras", id_carrera, carrera);

            MessageBox.Show("La carrera ha sido agregada", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
             "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {
            carrera.Nombre_Titulo = txtCarrera.Text;
        }

        public void Limpiar()
        {
            txtAño.Text = string.Empty;
            txtCarrera.Text = string.Empty;
            dgvNuevaCarrera.Rows.Clear();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCarreras.Dominio
{
    public class AccesoBD
    {
        private SqlConnection conexion = new SqlConnection(
            @"Data Source=(localdb)\local;Initial Catalog=Carreras;Integrated Security=True");
        private SqlCommand comando = new SqlCommand();

        private void ConfigurarComando_SP(string SPNombre)
        {
            comando.Connection = conexion;
            comando.CommandText = SPNombre;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public DataTable Consultar_SP(string SPNombre)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            ConfigurarComando_SP(SPNombre);
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            return tabla;
        }

        public void AltaDetallesCarrera_SP(string SPNombre, int id_carrera, Carrera carrera)
        {
            conexion.Open();
            ConfigurarComando_SP(SPNombre);

            for (int i = 0; i < carrera.DetallesCarrera.Count; i++)
            {
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@anioCursado", carrera.DetallesCarrera[i].AnioCursado);
                comando.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarrera[i].Cuatrimestre);
                comando.Parameters.AddWithValue("@id_asignatura", carrera.DetallesCarrera[i].Materia.Id_asignatura);
                comando.Parameters.AddWithValue("@id_carrera", id_carrera);

                comando.ExecuteNonQuery();
            }

            conexion.Close();
        }

        public int AltaCarrera_SP(string SPName, Carrera carrera)
        {
            int id_carrera;

            conexion.Open();
            ConfigurarComando_SP(SPName);
            comando.Parameters.AddWithValue("@nombre", carrera.Nombre_Titulo);

            SqlParameter param = new SqlParameter("@new_id_carrera", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            
            comando.Parameters.Clear();

            id_carrera = Convert.ToInt32(param.Value);

            conexion.Close();
            return id_carrera;
        }




        public List<Asignatura> ConsultarAsignatura()
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=Carreras;Integrated Security=True"))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "consultarAsignaturas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    List<Asignatura> lsta = new List<Asignatura>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        int id_asignatura = Convert.ToInt32(fila[0]);
                        string nombre = fila[1].ToString();

                        Asignatura a = new Asignatura(id_asignatura, nombre);
                        lsta.Add(a);
                    }
                    return lsta;
                }


            }
        }
    }
}


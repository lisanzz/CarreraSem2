using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCarreras.Dominio
{
    public class Asignatura
    {
        public int Id_asignatura { get; set; }

        public string Nombre { get; set; }


        public Asignatura(int id_asignatura, string nombre) 
        { 
            Id_asignatura = id_asignatura;
            Nombre = nombre;
        
        
        
        }

        public  Asignatura() 
        { 
            Id_asignatura = 0;
            Nombre = string.Empty;
        
        
        }

        public override string ToString()
        {
            return "Nombre de Asignatura: " + Nombre;
        }
    }
}

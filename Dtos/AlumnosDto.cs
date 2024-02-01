using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioObligatorio2C.Dtos
{
    internal class AlumnosDto
    {
        string nombre = "aaaaaaa";
        string dni = "aaaaa";
        int tle = 12345678;

        public AlumnosDto(string nombre, string dni, int tle)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.tle = tle;
        }

        public AlumnosDto() { }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Tle { get => tle; set => tle = value; }

        override
            public string ToString()
        { 
         string alumno = "nombre;  "+ this.nombre + "  dni:  " + this.dni + "  telefono:   "+ this.tle;
            return alumno;
        }
    }
}

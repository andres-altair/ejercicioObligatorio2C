using ejercicioObligatorio2C.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioObligatorio2C.Controladores
{
    internal interface alumnoInterfaz
    {
        public void darAltaAlumno(List<AlumnosDto> listaAntigua);
    }
}

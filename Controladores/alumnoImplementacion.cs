using ejercicioObligatorio2C.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioObligatorio2C.Controladores
{
    internal class alumnoImplementacion : alumnoInterfaz
    {
        public void darAltaAlumno(List<AlumnosDto> listaAntigua)
        {
                AlumnosDto cliente = crearCliente();
                listaAntigua.Add(cliente);
                Console.WriteLine(listaAntigua.ToString());
        }

            private AlumnosDto crearCliente()
            {
                AlumnosDto alumno = new AlumnosDto();

                
                Console.WriteLine("escribe tu nombre");
                cliente.Nombre = Console.ReadLine();
                Console.WriteLine("escribe tu dni");
                cliente.Dni = Console.ReadLine();
                Console.WriteLine("escribe tu telefono");
                cliente.Tle = Convert.ToInt32(Console.ReadLine());
                return alumno;
            }
        }
    }
}

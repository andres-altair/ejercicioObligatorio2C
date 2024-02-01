using ejercicioObligatorio2C.Controladores;
using ejercicioObligatorio2C.Dtos;
using System.ComponentModel.Design;

namespace ejercicioObligatorio2C
{
    class Program
    {

        static void Main(string[] args)
        {
            List<AlumnosDto> list = new List<AlumnosDto>();

            menuInterfaz mi = new menuImplementacion();
            alumnoInterfaz ai = new alumnoImplementacion();

            Console.WriteLine("cuantos alumnos hay");
            int num = Convert.ToInt32(Console.ReadLine());
             for (int i = 0; num < num; i++)
             {
                ai.darAltaAlumno(list);
             }

            Console.WriteLine("que alumno quires ver");
            string nombreA = Console.ReadLine();
            int contador= 0;
            AlumnosDto alumno = new AlumnosDto();
            if (alumno.Nombre.Equals(nombreA)) ;
            {
                contador++;
                Console.WriteLine(alumno.ToString );
               
                
            }
            else
            {
                Console.WriteLine("no existe"); 
                contador++;
            }
        }
    }
}

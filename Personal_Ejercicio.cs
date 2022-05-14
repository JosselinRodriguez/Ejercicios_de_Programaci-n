using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_calificado
{
    class Personal : Persona
    {

        public string seccion { set; get; }
        public Personal(String Seccion,String Nombre, String apellidos, int numero, String estado) : base(Nombre, apellidos, numero, estado)
        { 
            this.seccion = Seccion;
        }

        public void mostrar()
        {
            Console.WriteLine("    Ingrese el Personal del trabajo");
            Console.WriteLine("");
            Console.WriteLine("Seccion Asignada: "+seccion);
            Console.WriteLine("");
            Console.WriteLine("Nombre: "+nombre+ " - Apellido: "+ apellido);
            Console.WriteLine("Ingrese el Numero de Identificacion: "+ numero_identificacion);
            Console.WriteLine("Ingrese el Estado Civil: "+ estado_civil);
            Console.WriteLine("");
            seleccione();
            Console.WriteLine("");


        }
        public void seleccione()
        {
            String options;
            Console.WriteLine("Seleccione las Opciones alternas:");
            Console.WriteLine("Si desea cambiar el personal utilize Ingrese: 1");
            Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
            Console.WriteLine("Si desea salir utilize: salir ");
            options = Console.ReadLine();
            nuevo(options);
        }
        public void nuevo(String cambios)
        {
           
            switch (nuevo.ToString())
            {
                case "1":
                    nuevo_de_personal();
                    break;
                case "2":
                    nuevocivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void nuevo_personal()
        {
            String translado_nuevo;
            Console.WriteLine("Ingrese el nuevo translado de seccion");
            translado_nuevo = Console.ReadLine();
            Console.WriteLine("El cambio se realizo exitosamente");
            seccion = translado_nuevo;
        }
    }

}

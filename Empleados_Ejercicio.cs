using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_calificado
{
    class Empleados : Persona
    {

        public string numero_despacho { set; get; }
        public int anio { set; get; }

        public Empleados(String despacho,int Año, String Nombre, String apellidos, int numero, String estado) : base(Nombre, apellidos, numero, estado)
        {
            this.numero_despacho = despacho;
            this.año = Año;
        }

        public void mostrar()
        {
            Console.WriteLine("   Ingrese los  Empleados del trabajo");
            Console.WriteLine("");
            Console.WriteLine("Numero de Despacho: " + numero_despacho);
            Console.WriteLine("");
            Console.WriteLine("Ingrese año de incorporacion: " + año);
            Console.WriteLine("Nombre: " + nombre + " - Apellido: " + apellido);
            Console.WriteLine("Ingrese Numero de Identificacion: " + numero_identificacion);
            Console.WriteLine("Ingrese el Estado Civil: " + estado_civil);
            Console.WriteLine("");
            seleccione();
            Console.WriteLine("");
        }

            public void seleccione()
            {
                String options;
                Console.WriteLine("Seleccione las Opciones alternas:");
                Console.WriteLine("Si desea cambiar el despacho Ingrese: 1");
                Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
                Console.WriteLine("Si desea salir utilize: salir ");
                options = Console.ReadLine();
                nuevo(options);
            }
            public void nuevo(String nuevo)
            {

                switch (nuevo.ToString())
                {
                    case "1":
                    nuevo_despacho();
                        break;
                    case "2":
                        nuevocivil();
                        break;
                    case "salir":
                        Console.WriteLine("....");
                        break;

                }

            }
            public void nuevo_despacho()
        {
            String espacho_new;
            Console.WriteLine("Ingrese el nuevo despacho");
            espacho_new = Console.ReadLine();
            Console.WriteLine("El cambio de despacho se realizo exitosamente");
            numero_despacho = espacho_new;
        }
    }

}

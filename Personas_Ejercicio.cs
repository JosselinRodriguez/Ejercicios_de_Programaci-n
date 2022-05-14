using System;

namespace ejercicio_calificado
{
    class Persona{

        public string nombre { set; get; }
        public string apellido { set; get; }
        public int numero_identificacion { set; get; }
        public string estado_civil { set; get; }

        public Persona(String Nombre, String apellidos, int numero, String estado)
        {
            this.nombre = Nombre;
            this.apellido = apellidos;
            this.numero_identificacion = numero;
            this.estado_civil = estado; 
        }

        public void cambiocivil()
        {
            String nuevo_civil;
            do
            { 
             Console.WriteLine("Ingrese el Estado Civil");
             Console.WriteLine("- soltero ");
             Console.WriteLine("- casado ");
             Console.WriteLine("- viudo ");

                nuevo_civil = Console.ReadLine();

            if (nuevo_civil == "soltero") {
                estado_civil = nuevo_civil;
                Console.WriteLine("Se Cambio correctamente");
            }
            else if (nuevo_civil == "casado") {
                estado_civil = nuevo_civil;
                Console.WriteLine(" Se Cambio correctamente");
            }
            else if (nuevo_civil == "viudo") {
                estado_civil = nuevo_civil;
                Console.WriteLine(" Se Cambio correctamente");
            } else {
                    Console.WriteLine("El estado civil que ingresastes es Incorrecto");
                    Console.WriteLine("Ingrese el nuevo Estado Civil");
                    Console.WriteLine("- soltero ");
                    Console.WriteLine("- casado ");
                    Console.WriteLine("- viudo ");
                    nuevo_civil = Console.ReadLine();
                    Console.WriteLine("Se Cambio correctamente");

                }
            } while(nuevo_civil != null && nuevo_civil == "soltero" && nuevo_civil == "casado" && nuevo_civil == "viudo");
        }

    }
}

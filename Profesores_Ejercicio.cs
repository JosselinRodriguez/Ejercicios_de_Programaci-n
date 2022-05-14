using System;

namespace ejercicio_calificado
{
    class Profesores : Persona
    {

        public string departamento { set; get; }

        public Profesores(String depa,String Nombre, String apellidos, int numero, String estado) : base(Nombre, apellidos, numero, estado)
        {
            this.departamento = depa;
        }
        public void mostrar()
        {
            Console.WriteLine("    Ingrese el Personal de Profesores");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el Departamento Asignado: " + departamento);
            Console.WriteLine(""); 
            Console.WriteLine("Nombre: " + nombre + " - Apellido: " + apellido);
            Console.WriteLine("Ingrese el Numero de Identificacion: " + numero_identificacion);
            Console.WriteLine("Ingrese el Estado Civil: " + estado_civil);

            Console.WriteLine("");
            seleccione();
            Console.WriteLine("");

        }

        public void seleccione()
        {
            String options;
            Console.WriteLine("Seleccione las Opciones alternas:");
            Console.WriteLine("Si desea cambiar el personal  Ingrese: 1");
            Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
            Console.WriteLine("Si desea salir utilize la opción : salir ");
            options = Console.ReadLine();
            nuevo(options);
        }
        public void nuevo(String nuevo)
        {
          
            switch (nuevo.ToString())
            {
                case "1":
                    nuevo_departamento();
                    break;
                case "2":
                    nuevocivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;
         
            }

        }
        public void nuevo_departamento()
        {
            String departmento_nuevo;
            Console.WriteLine("Ingrese el nuevo departamento");
            departmento_nuevo = Console.ReadLine();
            Console.WriteLine("El cambio se realizó exitosamente");
            departamento = departmento_nuevo;
        }
    }
}

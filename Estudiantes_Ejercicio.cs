using System;

namespace ejercicio_calificado
{
    class Estudiantes:Persona
    {

        public string curso { set; get; }

        public Estudiantes(String Curso, String Nombre, String apellidos, int numero, String estado) :base(Nombre, apellidos, numero, estado)
        {
            this.curso = Curso;
        }
        public void mostrar()
        {
            Console.WriteLine("    Ingrese Matriculacion de Estudiantes");
            Console.WriteLine("");
            Console.WriteLine(" Ingrese Curso Asignado: " + curso);
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + nombre + " - Apellido: " + apellido);
            Console.WriteLine(" Ingrese el Numero de Identificacion: " + numero_identificacion);
            Console.WriteLine("Ingrese Estado Civil: " + estado_civil);
            Console.WriteLine("");
            seleccione();
            Console.WriteLine("");

        }
        public void seleccione()
        {
            String options;
            Console.WriteLine("seleccione las Opciones alternas:");
            Console.WriteLine("Si desea cambiar el curso utilize Ingrese: 1");
            Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
            Console.WriteLine("Si desea salir utilize: salir ");
            options = Console.ReadLine();
            nuevo(options);
        }
        public void nuevo(String cambios)
        {

            switch (cambios.ToString())
            {
                case "1":
                    curso_nuevo();
                    break;
                case "2":
                    cambiocivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void nuevo_curso()
        {
            String curso_new;
            Console.WriteLine("Ingrese el nuevo Curso");
            curso_new = Console.ReadLine();
            Console.WriteLine("El cambio de curso se realizo exitosamente");
            curso = curso_new;
        }
    }
}

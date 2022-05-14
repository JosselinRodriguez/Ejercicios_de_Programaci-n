
namespace ejercicio_calificado.Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Empleados empleados = new Empleados("Limpiador", 2022, "Juan", "Perez", 1, "Soltero");
            empleados.imprimir();
            Estudiantes estudiante = new Estudiantes("A260", "Adriana", "Rodríguez", 2, "Soltero");
            estudiante.imprimir();
            Personal personal = new Personal("Profesora ", "Marilin", "Chancay", 3, "Casada");
            personal.imprimir();
            Profesores profesores = new Profesores("Ingenieria Civil", "Johan", "Guiterrez", 3, "viudo");
            profesores.imprimir();
        }
    }
    }
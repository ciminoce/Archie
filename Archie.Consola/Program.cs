using Archie.Datos;

namespace Archie.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nomina nomina = new Nomina();
            string userSelection;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***********************************");
                Console.WriteLine("* Bethany's Pie Shop Employee App *");
                Console.WriteLine("***********************************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Cargados {nomina.GetCantidad()} empleado(s)\n\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*************************");
                Console.WriteLine("* Seleccione una acción *");
                Console.WriteLine("*************************");

                Console.WriteLine("1: Registrar empleado");
                Console.WriteLine("2: Ver todos (Tarjetas");
                Console.WriteLine("3: Ver todos (Listado)");
                Console.WriteLine("4: Guardar Empleados");
                Console.WriteLine("5: Cargar datos de un empleado");
                Console.WriteLine("9: Salir de la aplicación");
                Console.Write("Tu selección: ");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        Utilidades.RegistrarEmpleado(nomina);
                        break;
                    case "2":
                        Utilidades.MostrarEmpleados(nomina);
                        break;
                    case "3":
                        Utilidades.MostrarListaEmpleados(nomina);
                        break;
                    case "4":
                        //Utilidades.GuardarEmpleados(nomina);
                        break;
                    case "5":
                        Utilidades.CargarDatosEmpleado(nomina);
                        break;
                    case "6":
                        //Utilities.LoadEmployeeById(empleados);
                        break;
                    case "9": break;
                    default:
                        Console.WriteLine("Selección no válida.");
                        break;
                }
            }
            while (userSelection != "9");
            Console.WriteLine("Gracias por usar la aplicación");
        }

    }
}

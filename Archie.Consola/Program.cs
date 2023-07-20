﻿using Archie.Datos;
using Archie.Entidades;

namespace Archie.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nomina nomina = new Nomina();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.WriteLine("* Bethany's Pie Shop Employee App *");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;
            Console.ForegroundColor = ConsoleColor.Blue;


            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Cargados {nomina.GetCantidad()} empleado(s)\n\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*************************");
                Console.WriteLine("* Seleccione una acción *");
                Console.WriteLine("*************************");

                Console.WriteLine("1: Registrar empleado");
                Console.WriteLine("2: Ver todos");
                Console.WriteLine("3: Guardar");
                Console.WriteLine("4: Cargar datos de un empleado");
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
                        //Utilidades.GuardarEmpleado(nomina);
                        break;
                    case "4":
                        //Utilidades.CargarDatosEmpleado(nomina);
                        break;
                    case "5":
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

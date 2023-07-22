using Archie.Datos;
using Archie.Entidades;
using ConsoleTables;
using MiBiblioteca;
using System.Text;

namespace Archie.Consola
{
    public static class Utilidades
    {
        public static void RegistrarEmpleado(Nomina nomina)
        {
            Console.WriteLine("Ingreso de Datos del Empleado");
            Console.WriteLine("*****************************");
            int dni = IngresoDatos.PedirInt("Ingrese el DNI:");
            string primerNombre = IngresoDatos.PedirString("Ingrese el primer nombre:");
            string? segundoNombre = IngresoDatos.PedirStringNulo("Ingrese el segundo nombre:");
            string? tercerNombre = IngresoDatos.PedirStringNulo("Ingrese el tercer nombre:");
            string apellido = IngresoDatos.PedirString("Ingrese el apellido:");
            Console.Write("Ingrese la fecha de nacimiento:");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());//Si la ingreso mal
            Console.WriteLine("Seleccione una Sección");
            ConstruirMenuSecciones();
            int nroSeccion = IngresoDatos.PedirIntEnRango("Tu selección:",
                    (int)Seccion.Compras, (int)Seccion.Seguridad);
            Console.WriteLine("Seleccione Sexo:");
            ConstruirMenuSexo();
            int nroSexo = IngresoDatos.PedirIntEnRango("Tu selección:",
                (int)Sexo.Masculino, (int)Sexo.Femenino);

            Empleado empleado = new Empleado(dni, primerNombre, apellido, fechaNacimiento,
                (Seccion)nroSeccion, (Sexo)nroSexo, segundoNombre, tercerNombre);

            if (Empleado.Validar(empleado))
            {
                if (nomina + empleado)
                {
                    Console.WriteLine("Empleado creado");
                    Console.WriteLine("Empleado agregado a la nómina");
                }
                else
                {
                    Console.WriteLine("Empleado creado");
                    Console.WriteLine("Empleado NO agregado a la nómina");

                }

            }
            else
            {
                Console.WriteLine("Empleado no válido");
            }
            Console.ReadLine();
        }

        private static void ConstruirMenuSexo()
        {
            int contador = 1;
            foreach (string sexo in Enum.GetNames(typeof(Sexo)))
            {
                Console.WriteLine($"{contador}.{sexo}");
                contador++;
            }

        }

        public static void MostrarEmpleados(Nomina nomina)
        {
            Console.WriteLine("Listado de Empleados");
            if (nomina.GetCantidad() > 0)
            {
                foreach (Empleado itemEmpleado in nomina.GetEmpleados())
                {
                    Console.WriteLine(Empleado.MostrarDatos(itemEmpleado));
                }
                Console.WriteLine($"Se listaron {nomina.GetCantidad()} empleado/s");

            }
            else
            {
                Console.WriteLine("No hay empleados todavía");
            }
            Console.ReadLine();
        }

        private static void ConstruirMenuSecciones()
        {
            int contador = 1;
            foreach (string nombreSeccion in Enum.GetNames(typeof(Seccion)))
            {
                Console.WriteLine($"{contador}.{nombreSeccion}");
                contador++;
            }
        }

        public static void GuardarEmpleados(Nomina nomina)
        {
            if (nomina.GetCantidad() == 0)
            {
                Console.WriteLine("No hay empleados todavía");
                Console.ReadLine();
                return;
            }
            int contadorRegistros = nomina.GuardarDatosArchivo();
            Console.WriteLine("Registros guardados!!!");
            Console.WriteLine($"Se guardaron {contadorRegistros} registro/s");
            Console.ReadLine();
        }

        public static void MostrarListaEmpleados(Nomina nomina)
        {
            if (nomina.GetCantidad() == 0)
            {
                Console.WriteLine("No hay empleados todavía");
                Console.ReadLine();
                return;
            }
            ConsoleTable tabla = new ConsoleTable("Emp. Nro.", "DNI", "Empleado");
            int contadorEmpleados = 0;
            foreach (Empleado empleado in nomina.GetEmpleados())
            {
                contadorEmpleados++;
                tabla.AddRow($"{contadorEmpleados}",
                    $"{empleado.DNI}", $"{empleado.NombreCompleto()}");
            }
            Console.WriteLine(tabla.ToString());
            Console.ReadLine();
        }

        public static void CargarDatosEmpleado(Nomina nomina)
        {
            Console.WriteLine("Mostrar Datos de un Empleado");
            int dniBuscado = IngresoDatos.PedirInt("Ingrese el DNI a buscar:");
            Empleado empleadoBuscar = nomina.GetEmpleadoPorDni(dniBuscado);
            if (empleadoBuscar is null)
            {
                Console.WriteLine("DNI no encontrado!!!");
            }
            else
            {
                Console.WriteLine(Empleado.MostrarDatos(empleadoBuscar));
            }
            Console.ReadLine();
        }
    }
}

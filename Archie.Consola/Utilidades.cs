using Archie.Datos;
using Archie.Entidades;
using MiBiblioteca;

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
            DateTime fechaNacimiento=DateTime.Parse(Console.ReadLine());//Si la ingreso mal
            Console.WriteLine("Seleccione una Sección");
            ConstruirMenuSecciones();
            int nroSeccion = IngresoDatos.PedirIntEnRango("Tu selección:",
                    (int)Seccion.Compras, (int)Seccion.Seguridad);
            Empleado empleado=new Empleado(dni, primerNombre,apellido, fechaNacimiento,
                (Seccion)nroSeccion,segundoNombre, tercerNombre);

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

        public static void MostrarEmpleados(Nomina nomina)
        {
            Console.WriteLine("Listado de Empleados");
            if (nomina.GetCantidad()>0)
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
    }
}

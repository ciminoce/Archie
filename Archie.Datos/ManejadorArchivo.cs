using Archie.Entidades;
using System.Text;

namespace Archie.Datos
{
    public static class ManejadorArchivo
    {
        private static readonly string _directorio = @"D:\ArchieFer\";
        private static readonly string _archivo = "Personas.txt";

        static ManejadorArchivo() { 
            if(!Directory.Exists(_directorio)) {
                Directory.CreateDirectory(_directorio);
            }
        }

        public static List<Empleado> LeerArchivo()
        {
            List<Empleado> lista=new List<Empleado>();
            string nombreArchivo = $"{_directorio}{_archivo}";
            if (File.Exists(nombreArchivo))
            {
                /*Defino un objeto para poder leer del
                 * archivo secuencial */
                using (StreamReader lector = new StreamReader(nombreArchivo))
                {
                    while (!lector.EndOfStream)
                    {
                        Empleado empleado = ConstruirEmpleadoLeido(lector.ReadLine());
                        lista.Add(empleado);
                    }

                }
            }
            return lista;
        }

        public static int GuardarEnArchivo(List<Empleado> listaEmpleados)
        {
            //Defino un obj que se encargará de guardar la 
            //info en el archivo secuencial
            int contadorRegistros = 0;
            string nombreArchivo = $"{_directorio}{_archivo}";

            using (StreamWriter escritor = new StreamWriter(nombreArchivo))
            {
                foreach (Empleado empleado in listaEmpleados)
                {
                    contadorRegistros++;
                    string lineaGuardar = ConstruirLinea(empleado);
                    escritor.WriteLine(lineaGuardar);
                }
            }
            return contadorRegistros;

        }

        private static string ConstruirLinea(Empleado empleado)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{empleado.DNI}|{empleado.PrimerNombre}|");
            sb.Append($"{empleado.SegundoNombre}|{empleado.TercerNombre}|");
            sb.Append($"{empleado.Apellidos}|{empleado.FechaNacimiento.ToShortDateString()}|");
            sb.Append($"{empleado.Seccion.GetHashCode()}|{empleado.Sexo.GetHashCode()}");
            return sb.ToString();
        }

        private static Empleado ConstruirEmpleadoLeido(string lineaLeida)
        {
            /*Tomo la linea leída y la separo en un
             * array de strings con el método split de la
             * clase String */
            string[] arrayDeCampos = lineaLeida.Split('|');
            Empleado empleadoLeido = new Empleado()
            {
                DNI = int.Parse(arrayDeCampos[0]),
                PrimerNombre = arrayDeCampos[1],
                SegundoNombre = arrayDeCampos[2],
                TercerNombre = arrayDeCampos[3],
                Apellidos = arrayDeCampos[4],
                FechaNacimiento = DateTime.Parse(arrayDeCampos[5]),
                Seccion = (Seccion)Enum.Parse(typeof(Seccion), arrayDeCampos[6]),
                Sexo = (Sexo)int.Parse(arrayDeCampos[7]),

            };

            return empleadoLeido;

        }
    }
}

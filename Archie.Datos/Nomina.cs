using Archie.Entidades;
using System.Text;

namespace Archie.Datos
{
    public class Nomina
    {
        private List<Empleado> _listaEmpleados;
        private static bool hayCambios;

        private string nombreArchivoSecuencial = "Personas.txt";

        static Nomina()
        {
            hayCambios=false;
        }
        public Nomina()
        {
            _listaEmpleados=new List<Empleado>();
            LeerDatosArchivo();
        }

        private void LeerDatosArchivo()
        {
            if (File.Exists(nombreArchivoSecuencial)) 
            {
                /*Defino un objeto para poder leer del
                 * archivo secuencial */
                StreamReader lector = new StreamReader(nombreArchivoSecuencial);
                while (!lector.EndOfStream)
                {
                    Empleado empleado = ConstruirEmpleadoLeido(lector.ReadLine());
                    _listaEmpleados.Add(empleado);
                }
            }
        }
        public int GuardarDatosArchivo()
        {
            //Defino un obj que se encargará de guardar la 
            //info en el archivo secuencial
            int contadorRegistros = 0;
            using (StreamWriter escritor = new StreamWriter(nombreArchivoSecuencial))
            {
                foreach (Empleado empleado in _listaEmpleados)
                {
                    contadorRegistros++;
                    string lineaGuardar = ConstruirLinea(empleado);
                    escritor.WriteLine(lineaGuardar);
                }
            }
            return contadorRegistros;
        }

        private string ConstruirLinea(Empleado empleado)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{empleado.DNI}|{empleado.PrimerNombre}|");
            sb.Append($"{empleado.SegundoNombre}|{empleado.TercerNombre}|");
            sb.Append($"{empleado.Apellidos}|{empleado.FechaNacimiento.ToShortDateString()}|");
            sb.Append($"{empleado.Seccion.GetHashCode()}|{empleado.Sexo.GetHashCode()}");
            return sb.ToString();
        }

        private Empleado ConstruirEmpleadoLeido(string lineaLeida)
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

        public List<Empleado> GetEmpleados() => _listaEmpleados;
        public int GetCantidad()=>_listaEmpleados.Count;

        public Empleado GetEmpleadoPorDni(int dniBuscado)
        {
            return _listaEmpleados.SingleOrDefault(e => e.DNI == dniBuscado);
        }

        public static bool operator==(Nomina nomina, Empleado empleado)
        {
            foreach(Empleado empNomina in nomina.GetEmpleados())
            {
                if (empNomina==empleado)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator!=(Nomina nomina, Empleado empleado)
        {
            return !(nomina==empleado);
        }
        public static bool operator+(Nomina nomina, Empleado empleado)
        {
            if (nomina!=empleado)
            {
                nomina._listaEmpleados.Add(empleado);
                Nomina.hayCambios = true;
                return true;
            }
            return false;
        }
    }
}
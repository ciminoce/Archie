using System.Text;

namespace Archie.Entidades
{
    public class Empleado
    {
        public int DNI { get; set; }
        public string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? TercerNombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Seccion Seccion { get; set; }
        public int Edad { get; private set; }
        #region Constructores
        public Empleado(int dni, string primerNombre, string apellidos,
            DateTime fechaNacimiento, Seccion seccion, 
            string? segundoNombre = null, string? tercerNombre=null)
        {
            DNI = dni;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            TercerNombre = tercerNombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Seccion = seccion;
            Edad = SetEdad();
        }
        public Empleado()
        {
            
        }
        #endregion
        private int SetEdad()
        {
            return (int)Math.Truncate(
                DateTime.Today.Subtract(FechaNacimiento).TotalDays/365.25);
        }

        public string NombreCompleto()
        {
            if(TercerNombre!=null && TercerNombre != string.Empty)
            {
                if(SegundoNombre!=null && SegundoNombre != string.Empty)
                {
                    return @$"{Apellidos.ToUpper()}, {PrimerNombre} {SegundoNombre} {TercerNombre[0].ToString().ToUpper()}.";
                }
            }
            
            if (SegundoNombre != null && SegundoNombre != string.Empty)
            {
                return @$"{Apellidos.ToUpper()}, {PrimerNombre} {SegundoNombre[0].ToString().ToUpper()}.";
            }
            return @$"{Apellidos.ToUpper()}, {PrimerNombre}";
        }

        public static string MostrarDatos(Empleado empleado)
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"DNI:{empleado.DNI}");
            sb.AppendLine($"Nombre Completo:{empleado.NombreCompleto()}");
            sb.AppendLine($"Fecha Nacimiento:{empleado.FechaNacimiento.ToShortDateString()}");
            sb.AppendLine($"Edad: {empleado.Edad} años");
            sb.AppendLine($"Sección:{empleado.Seccion.ToString()}");
            return sb.ToString();
        }

        public static bool operator==(Empleado a, Empleado b)
        {
            return a.DNI == b.DNI;
        }
        public static bool operator!=(Empleado a, Empleado b)
        {
            return !(a == b);
        }
        public static bool operator==(Empleado a, int dni)
        {
            return a.DNI == dni;
        }
        public static bool operator!=(Empleado a, int dni)
        {
            return !(a.DNI == dni);
        }

        public static bool Validar(Empleado empleado)
        {
            if (empleado.DNI <= 0)
            {
                return false;
            }
            if (empleado.PrimerNombre ==null || empleado.PrimerNombre ==string.Empty)
            {
                return false;
            }
            if(empleado.TercerNombre !=null && empleado.TercerNombre !=string.Empty)
            {
                if (empleado.SegundoNombre == null || empleado.SegundoNombre == string.Empty)
                {
                    return false;
                }
            }
            if (empleado.Edad < 18)
            {
                return false;
            }
            return true;
        }
    }
}
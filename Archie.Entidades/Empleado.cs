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
        public Sexo Sexo { get; set; }

        public bool Activo { get; set; } = true;

        public int Edad { get { return SetEdad(); } }
        #region Constructores
        public Empleado(int dni, string primerNombre, string apellidos,
            DateTime fechaNacimiento, Seccion seccion,
            Sexo sexo,
            string? segundoNombre = null, string? tercerNombre=null)
        {
            DNI = dni;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            TercerNombre = tercerNombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Seccion = seccion;
            Sexo= sexo;
            //Edad = SetEdad();
        }
        public Empleado()
        {
            //Edad = SetEdad();
        }
        #endregion
        private int SetEdad()
        {
            return (int)Math.Truncate(
                DateTime.Today.Subtract(FechaNacimiento).TotalDays/365.25);
        }

        public string NombreCompleto()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append($"{Apellidos.ToUpper()}, {PrimerNombre}");

            if (TercerNombre != null && TercerNombre != string.Empty)
            {
                sb.Append($" {SegundoNombre} {TercerNombre[0].ToString().ToUpper()}.");
               
            }else if(SegundoNombre != null && SegundoNombre != string.Empty)
            {
                sb.Append($" {SegundoNombre[0].ToString().ToUpper()}.");
            }
            return sb.ToString();
        }

        public static string MostrarDatos(Empleado empleado)
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"DNI:{empleado.DNI}");
            sb.AppendLine($"Nombre Completo:{empleado.NombreCompleto()}");
            sb.AppendLine($"Fecha Nacimiento:{empleado.FechaNacimiento.ToShortDateString()}");
            sb.AppendLine($"Edad: {empleado.Edad} años");
            sb.AppendLine($"Sección:{empleado.Seccion.ToString()}");
            sb.AppendLine($"Sexo: {empleado.Sexo.ToString()}");
            return sb.ToString();
        }

        public static bool operator==(Empleado a, Empleado b)
        {
            if(a is not null && b is not null)
            {
                return a.DNI == b.DNI;

            }
            return false;
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
            
            if (!ValidarDni(empleado.DNI))
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

        private static bool ValidarDni(int DNI)
        {
            bool esValido = true;
            if (DNI <= 0)
            {
                esValido = false;
            }
            else if (DNI.ToString().Length != 8)
            {
                esValido = false;
            }
            return esValido;
        }
    }
}
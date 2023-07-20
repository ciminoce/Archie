using Archie.Entidades;

namespace Archie.Datos
{
    public class Nomina
    {
        private List<Empleado> _listaEmpleados;
        private static bool hayCambios;

        static Nomina()
        {
            hayCambios=false;
        }
        public Nomina()
        {
            _listaEmpleados=new List<Empleado>();
        }
        public List<Empleado> GetEmpleados() => _listaEmpleados;
        public int GetCantidad()=>_listaEmpleados.Count;

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
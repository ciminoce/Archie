using Archie.Entidades;

namespace Archie.Datos
{
    public class Nomina
    {
        private List<Empleado> _listaEmpleados;

        public Nomina()
        {
            _listaEmpleados = ManejadorArchivo.LeerArchivo();
        }
        public void ActualizarLista()
        {
            _listaEmpleados.Clear();
            _listaEmpleados = ManejadorArchivo.LeerArchivo();
        }
        public List<Empleado> GetEmpleados(bool estado) => _listaEmpleados
            .Where(e=>e.Activo==estado).ToList();
        public List<Empleado> GetEmpleados() => _listaEmpleados;

        public int GetCantidad() => _listaEmpleados.Count;

        public Empleado GetEmpleadoPorDni(int dniBuscado)
        {
            return _listaEmpleados.SingleOrDefault(e => e.DNI == dniBuscado);
        }

        //public int GuardarDatosArchivo()
        //{
        //    return ManejadorArchivo.GuardarEnArchivo(GetEmpleados());
        //}

        public static bool Editar(Nomina nomina, Empleado empleadoEditado)
        {
            if (nomina==empleadoEditado)
            {
                ManejadorArchivo.Editar(empleadoEditado);
                return true;
            }
            return false;//emp no existe!!!
        }

        public static bool operator ==(Nomina nomina, Empleado empleado)
        {
            foreach (Empleado empNomina in nomina.GetEmpleados())
            {
                if (empNomina == empleado)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Nomina nomina, Empleado empleado)
        {
            return !(nomina == empleado);
        }
        public static bool operator +(Nomina nomina, Empleado empleado)
        {
            if (nomina != empleado)
            {
                nomina._listaEmpleados.Add(empleado);
                ManejadorArchivo.Agregar(empleado);
                return true;
            }
            return false;
        }

        public static bool operator-(Nomina nomina, Empleado empleado)
        {
            if (nomina==empleado)
            {
                nomina._listaEmpleados.Remove(empleado);
                if (empleado.Activo)
                {
                    empleado.Activo = false;
                    ManejadorArchivo.BorradoLogico(empleado);
                }
                else
                {
                    ManejadorArchivo.Borrar(empleado);

                }
                
                return true;
            }
            return false;
        }

        public List<Empleado> FiltroPorSexo(Sexo sexo)
        {
            List<Empleado> listaFiltrada = _listaEmpleados
                .Where(e => e.Sexo == sexo).ToList();
            return listaFiltrada;
        }

        public List<Empleado> FiltrarPorSeccion(Seccion seccionSelecciona)
        {
            return _listaEmpleados
                .Where(e=>e.Seccion==seccionSelecciona)
                .ToList();
        }
    }
}
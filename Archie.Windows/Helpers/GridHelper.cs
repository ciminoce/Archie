using Archie.Entidades;

namespace Archie.Windows.Helpers
{
    public static class GridHelper
    {
        public static DataGridViewRow ConstruirFila(DataGridView grilla)
        {
            DataGridViewRow r= new DataGridViewRow();
            r.CreateCells(grilla);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, Empleado empleado)
        {
            r.Cells[0].Value = empleado.DNI;
            r.Cells[1].Value = empleado.NombreCompleto();
            r.Cells[2].Value = empleado.FechaNacimiento.ToShortDateString();
            r.Cells[3].Value = empleado.Edad;
            r.Cells[4].Value = empleado.Seccion;
            r.Cells[5].Value = empleado.Sexo;

            r.Tag = empleado;//lo guardo para trabajarlo luego en el form si quiero editar

        }

        public static void AgregarFila(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Add(r);
        }
    }
}

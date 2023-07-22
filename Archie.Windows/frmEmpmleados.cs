using Archie.Datos;
using Archie.Entidades;

namespace Archie.Windows
{
    public partial class frmEmpmleados : Form
    {
        private Nomina nomina;
        public frmEmpmleados()
        {
            InitializeComponent();
        }
        private List<Empleado> listaEmpleados;
        private void frmEmpmleados_Load(object sender, EventArgs e)
        {
            nomina = new Nomina();
            if (nomina.GetCantidad() > 0)
            {
                listaEmpleados = nomina.GetEmpleados();
                MostrarDatosEnGrilla();
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (Empleado empleadoEnLista in listaEmpleados)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, empleadoEnLista);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Empleado empleadoEnLista)
        {
            r.Cells[colDni.Index].Value = empleadoEnLista.DNI;
            r.Cells[colEmpleado.Index].Value = empleadoEnLista.NombreCompleto();
            r.Cells[colFecha.Index].Value = empleadoEnLista.FechaNacimiento.ToShortDateString();
            r.Cells[colEdad.Index].Value = empleadoEnLista.Edad;
            r.Cells[colSeccion.Index].Value = empleadoEnLista.Seccion;
            r.Cells[colSexo.Index].Value = empleadoEnLista.Sexo;

            r.Tag = empleadoEnLista;//lo guardo para trabajarlo luego en el form si quiero editar

        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmEmpleadosAE frm = new frmEmpleadosAE() { Text = "Nuevo Empleado" };
            frm.ShowDialog(this);
        }
    }
}
using Archie.Datos;
using Archie.Entidades;
using Archie.Windows.Helpers;
using Archie.Windows.Properties;

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
        private  bool  activos = true;
        private void frmEmpmleados_Load(object sender, EventArgs e)
        {
            //TODO: Modificar la grilla
            CargarComboSecciones();
            nomina = new Nomina();
            if (nomina.GetCantidad() > 0)
            {
                listaEmpleados = nomina.GetEmpleados(activos);
                MostrarDatosEnGrilla();
            }
        }

        private void CargarComboSecciones()
        {
            List<Seccion> listaSecciones = Enum.GetValues(typeof(Seccion))
                .Cast<Seccion>().ToList();
            tscboSecciones.Items.Clear();
            tscboSecciones.Items.Add("Seleccionar");
            foreach (Seccion seccion in listaSecciones)
            {
                tscboSecciones.Items.Add(seccion);
            }
            tscboSecciones.SelectedIndex = 0;
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (Empleado empleadoEnLista in listaEmpleados)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, empleadoEnLista);
                GridHelper.AgregarFila(dgvDatos, r);
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Fin del Programa",
                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleadosAE frm = new frmEmpleadosAE() { Text = "Nuevo Empleado" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            Empleado empleadoNuevo = frm.GetEmpleado();
            /*Lo agrego a la nómina */
            if (nomina + empleadoNuevo)
            {
                MessageBox.Show("Empleado agregado",
                    "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                /* estoy mostrando en la grilla */
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, empleadoNuevo);
                GridHelper.AgregarFila(dgvDatos, r);

            }
            else
            {
                MessageBox.Show("Empleado rechazado",
                    "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void masculinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltrarPorSexo(Sexo.Masculino);
        }

        private void FiltrarPorSexo(Sexo sexo)
        {
            listaEmpleados = nomina.FiltroPorSexo(sexo);
            MostrarDatosEnGrilla();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            listaEmpleados = nomina.GetEmpleados();
            MostrarDatosEnGrilla();
        }

        private void femeninoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltrarPorSexo(Sexo.Femenino);
        }

        private void tscboSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscboSecciones.SelectedIndex == 0)
            {
                return;
            }
            Seccion seccionSelecciona = (Seccion)tscboSecciones.SelectedItem;
            listaEmpleados = nomina.FiltrarPorSeccion(seccionSelecciona);
            MostrarDatosEnGrilla();

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            //TODO: Considerar baja lógica y física
            //TODO: Considerar recupero de datos borrados lógicos.
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Empleado empleadoSeleccionado = (Empleado)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar a" +
                $" {Empleado.MostrarDatos(empleadoSeleccionado)}?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            empleadoSeleccionado.Activo = false;
            if (nomina - empleadoSeleccionado)
            {
                //GridHelper.QuitarFila(dgvDatos, r);
                GridHelper.SetearFila(r, empleadoSeleccionado);
                MessageBox.Show("Registro eliminado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empleado no encontrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Empleado empleadoSeleccionado = (Empleado)r.Tag;
            frmEmpleadosAE frm = new frmEmpleadosAE() { Text = "Editar Empleado" };
            frm.SetEmpleado(empleadoSeleccionado);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            empleadoSeleccionado = frm.GetEmpleado();
            if (Nomina.Editar(nomina, empleadoSeleccionado))
            {
                GridHelper.SetearFila(r, empleadoSeleccionado);
                MessageBox.Show("Registro editado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empleado no encontrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbActivos_Click(object sender, EventArgs e)
        {
            if (tsbActivos.Text == "Activos")
            {
                activos = false;
                tsbActivos.Text = "Inactivos";
                tsbActivos.Image = Resources.unchecked_checkbox_36px;
                listaEmpleados = nomina.GetEmpleados(activos);
            }
            else
            {
                activos = true;
                tsbActivos.Text = "Activos";
                tsbActivos.Image = Resources.checked_checkbox_36px;
                listaEmpleados = nomina.GetEmpleados(activos);
            }
            MostrarDatosEnGrilla();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Empleado empleadoSeleccionado = (Empleado)r.Tag;
            if (empleadoSeleccionado.Activo)
            {
                return;

            }
            else
            {
                empleadoSeleccionado.Activo = true;
                Nomina.Editar(nomina, empleadoSeleccionado);
                nomina.ActualizarLista();
                listaEmpleados = nomina.GetEmpleados(activos);
                MostrarDatosEnGrilla();
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Empleado empleadoSeleccionado = (Empleado)r.Tag;
            if (nomina - empleadoSeleccionado)
            {
                GridHelper.SetearFila(r, empleadoSeleccionado);
                MessageBox.Show("Registro eliminado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            nomina.ActualizarLista();
            listaEmpleados = nomina.GetEmpleados(activos);
            MostrarDatosEnGrilla();
        }
    }
}
﻿using Archie.Entidades;
using Archie.Windows.Helpers;

namespace Archie.Windows
{
    public partial class frmEmpleadosAE : Form
    {
        public frmEmpleadosAE()
        {
            InitializeComponent();
        }
        private Empleado empleado;
        private bool esEdicion=false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboSecciones(ref cboSecciones);
            if (empleado!=null)
            {
                esEdicion = true;
                mtbDni.Text = empleado.DNI.ToString();
                mtbDni.Enabled= false;
                txtPrimerNombre.Text = empleado.PrimerNombre;
                txtSegundoNombre.Text=empleado.SegundoNombre;
                txtTercerNombre.Text = empleado.TercerNombre;
                txtApellidos.Text=empleado.Apellidos;
                dtpFechaNacimiento.Value = empleado.FechaNacimiento;
                cboSecciones.SelectedItem =(int) empleado.Seccion;
                if (empleado.Sexo == Sexo.Masculino)
                {
                    rbtMasculino.Checked = true;
                } else {
                    rbtFemenino.Checked = true;
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (empleado is null)
                {
                    empleado = new Empleado();
                }
                empleado.DNI = int.Parse(mtbDni.Text);
                empleado.PrimerNombre = txtPrimerNombre.Text;
                empleado.SegundoNombre = txtSegundoNombre.Text;
                empleado.TercerNombre = txtTercerNombre.Text;
                empleado.Apellidos = txtApellidos.Text;
                empleado.Seccion = (Seccion)cboSecciones.SelectedItem;
                empleado.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                empleado.Sexo = rbtMasculino.Checked ? Sexo.Masculino : Sexo.Femenino;

                if (!Empleado.Validar(empleado))
                {
                    MessageBox.Show("Empleado no válido!!!\nFavor de revisar",
                        "Errores",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }

            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!mtbDni.MaskCompleted)
            {
                esValido = false;
                errorProvider1.SetError(mtbDni, "DNI mal ingresado");
            }
            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                esValido = false;
                errorProvider1.SetError(txtPrimerNombre, "El primer nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                esValido = false;
                errorProvider1.SetError(txtApellidos, "El apellido es obligatorio");
            }
            return esValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Empleado GetEmpleado()
        {
            return empleado;
        }

        public void SetEmpleado(Empleado empleadoSeleccionado)
        {
            empleado = empleadoSeleccionado;
        }
    }
}

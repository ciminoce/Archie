namespace Archie.Windows
{
    partial class frmEmpleadosAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gbEmpleado = new GroupBox();
            txtApellidos = new TextBox();
            txtTercerNombre = new TextBox();
            txtSegundoNombre = new TextBox();
            txtPrimerNombre = new TextBox();
            btnCancelar = new Button();
            btnOK = new Button();
            gbSexo = new GroupBox();
            rbtFemenino = new RadioButton();
            rbtMasculino = new RadioButton();
            cboSecciones = new ComboBox();
            label3 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            mtbDni = new MaskedTextBox();
            errorProvider1 = new ErrorProvider(components);
            gbEmpleado.SuspendLayout();
            gbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbEmpleado
            // 
            gbEmpleado.Controls.Add(txtApellidos);
            gbEmpleado.Controls.Add(txtTercerNombre);
            gbEmpleado.Controls.Add(txtSegundoNombre);
            gbEmpleado.Controls.Add(txtPrimerNombre);
            gbEmpleado.Location = new Point(32, 55);
            gbEmpleado.Name = "gbEmpleado";
            gbEmpleado.Size = new Size(464, 150);
            gbEmpleado.TabIndex = 1;
            gbEmpleado.TabStop = false;
            gbEmpleado.Text = " Nombres y Apellido";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(15, 112);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Ingrese los apellidos";
            txtApellidos.Size = new Size(428, 23);
            txtApellidos.TabIndex = 3;
            // 
            // txtTercerNombre
            // 
            txtTercerNombre.Location = new Point(15, 84);
            txtTercerNombre.Name = "txtTercerNombre";
            txtTercerNombre.PlaceholderText = "Ingrese el tercer  nombre";
            txtTercerNombre.Size = new Size(428, 23);
            txtTercerNombre.TabIndex = 2;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(15, 55);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.PlaceholderText = "Ingrese el segundo  nombre";
            txtSegundoNombre.Size = new Size(428, 23);
            txtSegundoNombre.TabIndex = 1;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(15, 26);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.PlaceholderText = "Ingrese el primer nombre";
            txtPrimerNombre.Size = new Size(428, 23);
            txtPrimerNombre.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(605, 261);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 69);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(53, 261);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 69);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // gbSexo
            // 
            gbSexo.Controls.Add(rbtFemenino);
            gbSexo.Controls.Add(rbtMasculino);
            gbSexo.Location = new Point(519, 55);
            gbSexo.Name = "gbSexo";
            gbSexo.Size = new Size(228, 84);
            gbSexo.TabIndex = 2;
            gbSexo.TabStop = false;
            gbSexo.Text = " Sexo ";
            // 
            // rbtFemenino
            // 
            rbtFemenino.AutoSize = true;
            rbtFemenino.Location = new Point(17, 51);
            rbtFemenino.Name = "rbtFemenino";
            rbtFemenino.Size = new Size(78, 19);
            rbtFemenino.TabIndex = 1;
            rbtFemenino.Text = "Femenino";
            rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            rbtMasculino.AutoSize = true;
            rbtMasculino.Checked = true;
            rbtMasculino.Location = new Point(17, 26);
            rbtMasculino.Name = "rbtMasculino";
            rbtMasculino.Size = new Size(80, 19);
            rbtMasculino.TabIndex = 0;
            rbtMasculino.TabStop = true;
            rbtMasculino.Text = "Masculino";
            rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // cboSecciones
            // 
            cboSecciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSecciones.FormattingEnabled = true;
            cboSecciones.Location = new Point(103, 219);
            cboSecciones.Name = "cboSecciones";
            cboSecciones.Size = new Size(136, 23);
            cboSecciones.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 222);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 13;
            label3.Text = "Secciones:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(643, 154);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(104, 23);
            dtpFechaNacimiento.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 157);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 11;
            label2.Text = "Fecha Nacimiento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 10;
            label1.Text = "DNI:";
            // 
            // mtbDni
            // 
            mtbDni.Location = new Point(75, 26);
            mtbDni.Mask = "00000000";
            mtbDni.Name = "mtbDni";
            mtbDni.Size = new Size(53, 23);
            mtbDni.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEmpleadosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 357);
            Controls.Add(mtbDni);
            Controls.Add(gbEmpleado);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(gbSexo);
            Controls.Add(cboSecciones);
            Controls.Add(label3);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmpleadosAE";
            Text = "frmEmpleadosAE";
            gbEmpleado.ResumeLayout(false);
            gbEmpleado.PerformLayout();
            gbSexo.ResumeLayout(false);
            gbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbEmpleado;
        private TextBox txtApellidos;
        private TextBox txtTercerNombre;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerNombre;
        private Button btnCancelar;
        private Button btnOK;
        private GroupBox gbSexo;
        private RadioButton rbtFemenino;
        private RadioButton rbtMasculino;
        private ComboBox cboSecciones;
        private Label label3;
        private DateTimePicker dtpFechaNacimiento;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtbDni;
        private ErrorProvider errorProvider1;
    }
}
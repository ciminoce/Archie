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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label3 = new Label();
            cboSecciones = new ComboBox();
            groupBox1 = new GroupBox();
            rbtMasculino = new RadioButton();
            rbtFemenino = new RadioButton();
            btnOK = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 37);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 194);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(178, 191);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(104, 23);
            dtpFechaNacimiento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 246);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Secciones:";
            // 
            // cboSecciones
            // 
            cboSecciones.FormattingEnabled = true;
            cboSecciones.Items.AddRange(new object[] { "Compras", "Ventas", "RRHH", "Computos", "Seguridad" });
            cboSecciones.Location = new Point(178, 243);
            cboSecciones.Name = "cboSecciones";
            cboSecciones.Size = new Size(121, 23);
            cboSecciones.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtFemenino);
            groupBox1.Controls.Add(rbtMasculino);
            groupBox1.Location = new Point(512, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = " Sexo ";
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
            // rbtFemenino
            // 
            rbtFemenino.AutoSize = true;
            rbtFemenino.Location = new Point(17, 51);
            rbtFemenino.Name = "rbtFemenino";
            rbtFemenino.Size = new Size(78, 19);
            rbtFemenino.TabIndex = 0;
            rbtFemenino.Text = "Femenino";
            rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(66, 329);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 69);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(618, 329);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 69);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEmpleadosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(groupBox1);
            Controls.Add(cboSecciones);
            Controls.Add(label3);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmEmpleadosAE";
            Text = "frmEmpleadosAE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dtpFechaNacimiento;
        private Label label3;
        private ComboBox cboSecciones;
        private GroupBox groupBox1;
        private RadioButton rbtFemenino;
        private RadioButton rbtMasculino;
        private Button btnOK;
        private Button btnCancelar;
    }
}
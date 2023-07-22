namespace Archie.Windows
{
    partial class frmEmpmleados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpmleados));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton6 = new ToolStripButton();
            panelInferior = new Panel();
            panelGrid = new Panel();
            dgvDatos = new DataGridView();
            colDni = new DataGridViewTextBoxColumn();
            colEmpleado = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            colSeccion = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator1, toolStripButton4, toolStripButton5, toolStripSeparator2, toolStripButton6 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 35);
            toolStripButton1.Text = "Nuevo";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(43, 35);
            toolStripButton2.Text = "Borrar";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(41, 35);
            toolStripButton3.Text = "Editar";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(41, 35);
            toolStripButton4.Text = "Filtrar";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(63, 35);
            toolStripButton5.Text = "Actualizar";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(33, 35);
            toolStripButton6.Text = "Salir";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // panelInferior
            // 
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 350);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(800, 100);
            panelInferior.TabIndex = 1;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvDatos);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 38);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(800, 312);
            panelGrid.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colDni, colEmpleado, colFecha, colEdad, colSeccion, colSexo });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 312);
            dgvDatos.TabIndex = 0;
            // 
            // colDni
            // 
            colDni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            // 
            // colEmpleado
            // 
            colEmpleado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmpleado.HeaderText = "Empleado";
            colEmpleado.Name = "colEmpleado";
            colEmpleado.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFecha.HeaderText = "Fecha Nto.";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colEdad
            // 
            colEdad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colEdad.HeaderText = "Edad";
            colEdad.Name = "colEdad";
            colEdad.ReadOnly = true;
            colEdad.Width = 58;
            // 
            // colSeccion
            // 
            colSeccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSeccion.HeaderText = "Sección";
            colSeccion.Name = "colSeccion";
            colSeccion.ReadOnly = true;
            // 
            // colSexo
            // 
            colSexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSexo.HeaderText = "Sexo";
            colSexo.Name = "colSexo";
            colSexo.ReadOnly = true;
            // 
            // frmEmpmleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGrid);
            Controls.Add(panelInferior);
            Controls.Add(toolStrip1);
            Name = "frmEmpmleados";
            Text = "Form1";
            Load += frmEmpmleados_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton6;
        private Panel panelInferior;
        private Panel panelGrid;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colEmpleado;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colSeccion;
        private DataGridViewTextBoxColumn colSexo;
    }
}
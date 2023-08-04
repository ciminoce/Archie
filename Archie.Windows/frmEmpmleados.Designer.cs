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
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            secciónToolStripMenuItem = new ToolStripMenuItem();
            tscboSecciones = new ToolStripComboBox();
            sexoToolStripMenuItem = new ToolStripMenuItem();
            masculinoToolStripMenuItem = new ToolStripMenuItem();
            femeninoToolStripMenuItem = new ToolStripMenuItem();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbActivos = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panelInferior = new Panel();
            panelGrid = new Panel();
            dgvDatos = new DataGridView();
            colDni = new DataGridViewTextBoxColumn();
            colEmpleado = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            colSeccion = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewCheckBoxColumn();
            contxtMenu = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            borrarToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            contxtMenu.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbActivos, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 58);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.file_36px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 55);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_36px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 55);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_36px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 55);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { secciónToolStripMenuItem, sexoToolStripMenuItem });
            tsbFiltrar.Image = Properties.Resources.filled_filter_36px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(50, 55);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // secciónToolStripMenuItem
            // 
            secciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tscboSecciones });
            secciónToolStripMenuItem.Name = "secciónToolStripMenuItem";
            secciónToolStripMenuItem.Size = new Size(115, 22);
            secciónToolStripMenuItem.Text = "Sección";
            // 
            // tscboSecciones
            // 
            tscboSecciones.DropDownStyle = ComboBoxStyle.DropDownList;
            tscboSecciones.Name = "tscboSecciones";
            tscboSecciones.Size = new Size(121, 23);
            tscboSecciones.SelectedIndexChanged += tscboSecciones_SelectedIndexChanged;
            // 
            // sexoToolStripMenuItem
            // 
            sexoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { masculinoToolStripMenuItem, femeninoToolStripMenuItem });
            sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            sexoToolStripMenuItem.Size = new Size(115, 22);
            sexoToolStripMenuItem.Text = "Sexo";
            // 
            // masculinoToolStripMenuItem
            // 
            masculinoToolStripMenuItem.Name = "masculinoToolStripMenuItem";
            masculinoToolStripMenuItem.Size = new Size(129, 22);
            masculinoToolStripMenuItem.Text = "Masculino";
            masculinoToolStripMenuItem.Click += masculinoToolStripMenuItem_Click;
            // 
            // femeninoToolStripMenuItem
            // 
            femeninoToolStripMenuItem.Name = "femeninoToolStripMenuItem";
            femeninoToolStripMenuItem.Size = new Size(129, 22);
            femeninoToolStripMenuItem.Text = "Femenino";
            femeninoToolStripMenuItem.Click += femeninoToolStripMenuItem_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.restart_36px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 55);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 58);
            // 
            // tsbActivos
            // 
            tsbActivos.Image = Properties.Resources.checked_checkbox_36px;
            tsbActivos.ImageScaling = ToolStripItemImageScaling.None;
            tsbActivos.ImageTransparentColor = Color.Magenta;
            tsbActivos.Name = "tsbActivos";
            tsbActivos.Size = new Size(50, 55);
            tsbActivos.Text = "Activos";
            tsbActivos.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActivos.Click += tsbActivos_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 58);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.exit_36px;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(40, 55);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
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
            panelGrid.Location = new Point(0, 58);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(800, 292);
            panelGrid.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colDni, colEmpleado, colFecha, colEdad, colSeccion, colSexo, colActivo });
            dgvDatos.ContextMenuStrip = contxtMenu;
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 292);
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
            // colActivo
            // 
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // contxtMenu
            // 
            contxtMenu.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem, borrarToolStripMenuItem });
            contxtMenu.Name = "contxtMenu";
            contxtMenu.Size = new Size(124, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Image = Properties.Resources.restart_36px;
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(123, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Image = Properties.Resources.delete_file_36px;
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(123, 22);
            borrarToolStripMenuItem.Text = "Borrar";
            borrarToolStripMenuItem.Click += borrarToolStripMenuItem_Click;
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
            Text = "Lista de Empleados";
            Load += frmEmpmleados_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            contxtMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel panelInferior;
        private Panel panelGrid;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colEmpleado;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colSeccion;
        private DataGridViewTextBoxColumn colSexo;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem secciónToolStripMenuItem;
        private ToolStripComboBox tscboSecciones;
        private ToolStripMenuItem sexoToolStripMenuItem;
        private ToolStripMenuItem masculinoToolStripMenuItem;
        private ToolStripMenuItem femeninoToolStripMenuItem;
        private DataGridViewCheckBoxColumn colActivo;
        private ToolStripButton tsbActivos;
        private ToolStripSeparator toolStripSeparator3;
        private ContextMenuStrip contxtMenu;
        private ToolStripMenuItem restaurarToolStripMenuItem;
        private ToolStripMenuItem borrarToolStripMenuItem;
    }
}
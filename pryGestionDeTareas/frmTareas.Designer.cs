namespace pryGestionDeTareas
{
    partial class frmTareas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareas));
            this.grpCarga = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblCategoría = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btnGuardarTarea = new System.Windows.Forms.Button();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnCompletada = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.grpCarga.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCarga
            // 
            this.grpCarga.Controls.Add(this.btnGuardarTarea);
            this.grpCarga.Controls.Add(this.cmbUsuario);
            this.grpCarga.Controls.Add(this.dateTimePicker1);
            this.grpCarga.Controls.Add(this.cmbPrioridad);
            this.grpCarga.Controls.Add(this.cmbCategoria);
            this.grpCarga.Controls.Add(this.lbl);
            this.grpCarga.Controls.Add(this.lblFecha);
            this.grpCarga.Controls.Add(this.lblPrioridad);
            this.grpCarga.Controls.Add(this.lblCategoría);
            this.grpCarga.Controls.Add(this.lblDescripción);
            this.grpCarga.Controls.Add(this.txtDescripcion);
            this.grpCarga.Controls.Add(this.txtTitulo);
            this.grpCarga.Controls.Add(this.lblTitulo);
            this.grpCarga.Location = new System.Drawing.Point(12, 34);
            this.grpCarga.Name = "grpCarga";
            this.grpCarga.Size = new System.Drawing.Size(479, 453);
            this.grpCarga.TabIndex = 1;
            this.grpCarga.TabStop = false;
            this.grpCarga.Text = "CARGA DE TAREAS";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(134, 41);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(218, 26);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(134, 107);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(218, 46);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Location = new System.Drawing.Point(21, 110);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(96, 20);
            this.lblDescripción.TabIndex = 3;
            this.lblDescripción.Text = "Descripción:";
            // 
            // lblCategoría
            // 
            this.lblCategoría.AutoSize = true;
            this.lblCategoría.Location = new System.Drawing.Point(21, 179);
            this.lblCategoría.Name = "lblCategoría";
            this.lblCategoría.Size = new System.Drawing.Size(82, 20);
            this.lblCategoría.TabIndex = 4;
            this.lblCategoría.Text = "Categoría:";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(21, 238);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(75, 20);
            this.lblPrioridad.TabIndex = 5;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(21, 298);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(168, 20);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de vencimiento:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(21, 354);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(80, 20);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Asignar a:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Ventas",
            "Soporte",
            "Configuración"});
            this.cmbCategoria.Location = new System.Drawing.Point(134, 176);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 28);
            this.cmbCategoria.TabIndex = 2;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cmbPrioridad.Location = new System.Drawing.Point(134, 230);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(121, 28);
            this.cmbPrioridad.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 292);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Items.AddRange(new object[] {
            "Pedro",
            "Mariela",
            "Juan",
            "Gabriela"});
            this.cmbUsuario.Location = new System.Drawing.Point(134, 351);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 28);
            this.cmbUsuario.TabIndex = 9;
            // 
            // btnGuardarTarea
            // 
            this.btnGuardarTarea.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTarea.Location = new System.Drawing.Point(165, 400);
            this.btnGuardarTarea.Name = "btnGuardarTarea";
            this.btnGuardarTarea.Size = new System.Drawing.Size(142, 36);
            this.btnGuardarTarea.TabIndex = 10;
            this.btnGuardarTarea.Text = "Guardar tarea";
            this.btnGuardarTarea.UseVisualStyleBackColor = false;
            this.btnGuardarTarea.Click += new System.EventHandler(this.btnGuardarTarea_Click);
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.dgvTareas);
            this.grpListado.Location = new System.Drawing.Point(12, 506);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(806, 303);
            this.grpListado.TabIndex = 2;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "LISTADO DE TAREAS";
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Asignar,
            this.Prioridad,
            this.Estado,
            this.Vencimiento});
            this.dgvTareas.Location = new System.Drawing.Point(25, 25);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 62;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.Size = new System.Drawing.Size(775, 205);
            this.dgvTareas.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 8;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 150;
            // 
            // Asignar
            // 
            this.Asignar.HeaderText = "Asignado a:";
            this.Asignar.MinimumWidth = 8;
            this.Asignar.Name = "Asignar";
            this.Asignar.Width = 150;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.MinimumWidth = 8;
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // Vencimiento
            // 
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.MinimumWidth = 8;
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.Width = 150;
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnReportes);
            this.grpAcciones.Controls.Add(this.btnEliminar);
            this.grpAcciones.Controls.Add(this.btnCompletada);
            this.grpAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcciones.Location = new System.Drawing.Point(535, 44);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(277, 211);
            this.grpAcciones.TabIndex = 1;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "ACCIONES";
            // 
            // btnCompletada
            // 
            this.btnCompletada.BackColor = System.Drawing.Color.Lime;
            this.btnCompletada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletada.Location = new System.Drawing.Point(6, 31);
            this.btnCompletada.Name = "btnCompletada";
            this.btnCompletada.Size = new System.Drawing.Size(253, 43);
            this.btnCompletada.TabIndex = 0;
            this.btnCompletada.Text = "Marcar como completada";
            this.btnCompletada.UseVisualStyleBackColor = false;
            this.btnCompletada.Click += new System.EventHandler(this.btnCompletada_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(6, 87);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(253, 45);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar tarea";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(6, 150);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(253, 39);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Ver reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(845, 821);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpCarga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTareas";
            this.Text = "Gestión de tareas";
            this.grpCarga.ResumeLayout(false);
            this.grpCarga.PerformLayout();
            this.grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCarga;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblCategoría;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnGuardarTarea;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCompletada;
    }
}


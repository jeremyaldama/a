namespace EduSoft
{
    partial class frmGestionarSedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarSedes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblGestionSedes = new System.Windows.Forms.Label();
            this.tcSede = new System.Windows.Forms.TabControl();
            this.tpDatosGenerales = new System.Windows.Forms.TabPage();
            this.cbEstacionamiento = new System.Windows.Forms.CheckBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.lblAforo = new System.Windows.Forms.Label();
            this.cbCafeteria = new System.Windows.Forms.CheckBox();
            this.cbSalasEstudio = new System.Windows.Forms.CheckBox();
            this.cbBiblioteca = new System.Windows.Forms.CheckBox();
            this.cbAuditorio = new System.Windows.Forms.CheckBox();
            this.gbEjecutivoResp = new System.Windows.Forms.GroupBox();
            this.btnBuscarEjecutivoResponsable = new System.Windows.Forms.Button();
            this.txtNombreEjecutivoResp = new System.Windows.Forms.TextBox();
            this.txtDNIEjecutivoResp = new System.Windows.Forms.TextBox();
            this.lblNombreEjecutivoResp = new System.Windows.Forms.Label();
            this.lblDNIEjecutivoResp = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.txtCantAulas = new System.Windows.Forms.TextBox();
            this.lblCantAulas = new System.Windows.Forms.Label();
            this.cboTipoSede = new System.Windows.Forms.ComboBox();
            this.lblTipoSede = new System.Windows.Forms.Label();
            this.dtpFechaInauguracion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDSede = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblIDSede = new System.Windows.Forms.Label();
            this.tpProgramasAcademicos = new System.Windows.Forms.TabPage();
            this.btnEliminarProgramaAcademico = new System.Windows.Forms.Button();
            this.btnAgregarProgramaAcademico = new System.Windows.Forms.Button();
            this.lblListaProgramas = new System.Windows.Forms.Label();
            this.dgvProgramasAcademicos = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHorasCreditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombrePrograma = new System.Windows.Forms.TextBox();
            this.lblNombrePrograma = new System.Windows.Forms.Label();
            this.txtTipoPrograma = new System.Windows.Forms.TextBox();
            this.lblTipoPrograma = new System.Windows.Forms.Label();
            this.btnBuscarPrograma = new System.Windows.Forms.Button();
            this.txtClavePrograma = new System.Windows.Forms.TextBox();
            this.lblClavePrograma = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.tcSede.SuspendLayout();
            this.tpDatosGenerales.SuspendLayout();
            this.gbEjecutivoResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tpProgramasAcademicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramasAcademicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar,
            this.btnGuardar,
            this.btnNuevo,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1364, 30);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 27);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::EduSoft.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 27);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 27);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::EduSoft.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGestionSedes
            // 
            this.lblGestionSedes.AutoSize = true;
            this.lblGestionSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionSedes.Location = new System.Drawing.Point(16, 42);
            this.lblGestionSedes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionSedes.Name = "lblGestionSedes";
            this.lblGestionSedes.Size = new System.Drawing.Size(158, 20);
            this.lblGestionSedes.TabIndex = 1;
            this.lblGestionSedes.Text = "Gestión de Sedes";
            // 
            // tcSede
            // 
            this.tcSede.Controls.Add(this.tpDatosGenerales);
            this.tcSede.Controls.Add(this.tpProgramasAcademicos);
            this.tcSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcSede.Location = new System.Drawing.Point(20, 76);
            this.tcSede.Margin = new System.Windows.Forms.Padding(4);
            this.tcSede.Name = "tcSede";
            this.tcSede.SelectedIndex = 0;
            this.tcSede.Size = new System.Drawing.Size(1329, 447);
            this.tcSede.TabIndex = 2;
            // 
            // tpDatosGenerales
            // 
            this.tpDatosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosGenerales.Controls.Add(this.cbEstacionamiento);
            this.tpDatosGenerales.Controls.Add(this.lblDireccion);
            this.tpDatosGenerales.Controls.Add(this.txtDireccion);
            this.tpDatosGenerales.Controls.Add(this.txtAforo);
            this.tpDatosGenerales.Controls.Add(this.lblAforo);
            this.tpDatosGenerales.Controls.Add(this.cbCafeteria);
            this.tpDatosGenerales.Controls.Add(this.cbSalasEstudio);
            this.tpDatosGenerales.Controls.Add(this.cbBiblioteca);
            this.tpDatosGenerales.Controls.Add(this.cbAuditorio);
            this.tpDatosGenerales.Controls.Add(this.gbEjecutivoResp);
            this.tpDatosGenerales.Controls.Add(this.lblCaracteristicas);
            this.tpDatosGenerales.Controls.Add(this.txtCantAulas);
            this.tpDatosGenerales.Controls.Add(this.lblCantAulas);
            this.tpDatosGenerales.Controls.Add(this.cboTipoSede);
            this.tpDatosGenerales.Controls.Add(this.lblTipoSede);
            this.tpDatosGenerales.Controls.Add(this.dtpFechaInauguracion);
            this.tpDatosGenerales.Controls.Add(this.label2);
            this.tpDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.tpDatosGenerales.Controls.Add(this.lblNombre);
            this.tpDatosGenerales.Controls.Add(this.txtNombre);
            this.tpDatosGenerales.Controls.Add(this.txtIDSede);
            this.tpDatosGenerales.Controls.Add(this.pbFoto);
            this.tpDatosGenerales.Controls.Add(this.lblIDSede);
            this.tpDatosGenerales.Location = new System.Drawing.Point(4, 27);
            this.tpDatosGenerales.Margin = new System.Windows.Forms.Padding(4);
            this.tpDatosGenerales.Name = "tpDatosGenerales";
            this.tpDatosGenerales.Padding = new System.Windows.Forms.Padding(4);
            this.tpDatosGenerales.Size = new System.Drawing.Size(1321, 416);
            this.tpDatosGenerales.TabIndex = 0;
            this.tpDatosGenerales.Text = "Datos Generales";
            // 
            // cbEstacionamiento
            // 
            this.cbEstacionamiento.AutoSize = true;
            this.cbEstacionamiento.Location = new System.Drawing.Point(719, 375);
            this.cbEstacionamiento.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstacionamiento.Name = "cbEstacionamiento";
            this.cbEstacionamiento.Size = new System.Drawing.Size(156, 22);
            this.cbEstacionamiento.TabIndex = 17;
            this.cbEstacionamiento.Text = "Estacionamiento";
            this.cbEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(479, 98);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 18);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(583, 95);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(709, 24);
            this.txtDireccion.TabIndex = 20;
            // 
            // txtAforo
            // 
            this.txtAforo.Location = new System.Drawing.Point(852, 208);
            this.txtAforo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAforo.Name = "txtAforo";
            this.txtAforo.Size = new System.Drawing.Size(132, 24);
            this.txtAforo.TabIndex = 11;
            // 
            // lblAforo
            // 
            this.lblAforo.AutoSize = true;
            this.lblAforo.Location = new System.Drawing.Point(737, 212);
            this.lblAforo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAforo.Name = "lblAforo";
            this.lblAforo.Size = new System.Drawing.Size(97, 18);
            this.lblAforo.TabIndex = 18;
            this.lblAforo.Text = "Aforo Total:";
            // 
            // cbCafeteria
            // 
            this.cbCafeteria.AutoSize = true;
            this.cbCafeteria.Location = new System.Drawing.Point(1180, 375);
            this.cbCafeteria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCafeteria.Name = "cbCafeteria";
            this.cbCafeteria.Size = new System.Drawing.Size(98, 22);
            this.cbCafeteria.TabIndex = 19;
            this.cbCafeteria.Text = "Cafetería";
            this.cbCafeteria.UseVisualStyleBackColor = true;
            // 
            // cbSalasEstudio
            // 
            this.cbSalasEstudio.AutoSize = true;
            this.cbSalasEstudio.Location = new System.Drawing.Point(947, 375);
            this.cbSalasEstudio.Margin = new System.Windows.Forms.Padding(4);
            this.cbSalasEstudio.Name = "cbSalasEstudio";
            this.cbSalasEstudio.Size = new System.Drawing.Size(155, 22);
            this.cbSalasEstudio.TabIndex = 18;
            this.cbSalasEstudio.Text = "Salas de estudio";
            this.cbSalasEstudio.UseVisualStyleBackColor = true;
            // 
            // cbBiblioteca
            // 
            this.cbBiblioteca.AutoSize = true;
            this.cbBiblioteca.Location = new System.Drawing.Point(535, 375);
            this.cbBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.cbBiblioteca.Name = "cbBiblioteca";
            this.cbBiblioteca.Size = new System.Drawing.Size(104, 22);
            this.cbBiblioteca.TabIndex = 16;
            this.cbBiblioteca.Text = "Biblioteca";
            this.cbBiblioteca.UseVisualStyleBackColor = true;
            // 
            // cbAuditorio
            // 
            this.cbAuditorio.AutoSize = true;
            this.cbAuditorio.Location = new System.Drawing.Point(377, 375);
            this.cbAuditorio.Margin = new System.Windows.Forms.Padding(4);
            this.cbAuditorio.Name = "cbAuditorio";
            this.cbAuditorio.Size = new System.Drawing.Size(97, 22);
            this.cbAuditorio.TabIndex = 15;
            this.cbAuditorio.Text = "Auditorio";
            this.cbAuditorio.UseVisualStyleBackColor = true;
            // 
            // gbEjecutivoResp
            // 
            this.gbEjecutivoResp.Controls.Add(this.btnBuscarEjecutivoResponsable);
            this.gbEjecutivoResp.Controls.Add(this.txtNombreEjecutivoResp);
            this.gbEjecutivoResp.Controls.Add(this.txtDNIEjecutivoResp);
            this.gbEjecutivoResp.Controls.Add(this.lblNombreEjecutivoResp);
            this.gbEjecutivoResp.Controls.Add(this.lblDNIEjecutivoResp);
            this.gbEjecutivoResp.Location = new System.Drawing.Point(23, 250);
            this.gbEjecutivoResp.Margin = new System.Windows.Forms.Padding(4);
            this.gbEjecutivoResp.Name = "gbEjecutivoResp";
            this.gbEjecutivoResp.Padding = new System.Windows.Forms.Padding(4);
            this.gbEjecutivoResp.Size = new System.Drawing.Size(1271, 112);
            this.gbEjecutivoResp.TabIndex = 13;
            this.gbEjecutivoResp.TabStop = false;
            this.gbEjecutivoResp.Text = "Ejecutivo Responsable de la Sede";
            // 
            // btnBuscarEjecutivoResponsable
            // 
            this.btnBuscarEjecutivoResponsable.BackgroundImage = global::EduSoft.Properties.Resources.Search;
            this.btnBuscarEjecutivoResponsable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarEjecutivoResponsable.Location = new System.Drawing.Point(411, 36);
            this.btnBuscarEjecutivoResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEjecutivoResponsable.Name = "btnBuscarEjecutivoResponsable";
            this.btnBuscarEjecutivoResponsable.Size = new System.Drawing.Size(52, 28);
            this.btnBuscarEjecutivoResponsable.TabIndex = 13;
            this.btnBuscarEjecutivoResponsable.UseVisualStyleBackColor = true;
            this.btnBuscarEjecutivoResponsable.Click += new System.EventHandler(this.btnBuscarEjecutivoResponsable_Click);
            // 
            // txtNombreEjecutivoResp
            // 
            this.txtNombreEjecutivoResp.Location = new System.Drawing.Point(203, 68);
            this.txtNombreEjecutivoResp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEjecutivoResp.Name = "txtNombreEjecutivoResp";
            this.txtNombreEjecutivoResp.ReadOnly = true;
            this.txtNombreEjecutivoResp.Size = new System.Drawing.Size(583, 24);
            this.txtNombreEjecutivoResp.TabIndex = 14;
            // 
            // txtDNIEjecutivoResp
            // 
            this.txtDNIEjecutivoResp.Location = new System.Drawing.Point(203, 37);
            this.txtDNIEjecutivoResp.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIEjecutivoResp.Name = "txtDNIEjecutivoResp";
            this.txtDNIEjecutivoResp.ReadOnly = true;
            this.txtDNIEjecutivoResp.Size = new System.Drawing.Size(203, 24);
            this.txtDNIEjecutivoResp.TabIndex = 12;
            // 
            // lblNombreEjecutivoResp
            // 
            this.lblNombreEjecutivoResp.AutoSize = true;
            this.lblNombreEjecutivoResp.Location = new System.Drawing.Point(25, 71);
            this.lblNombreEjecutivoResp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEjecutivoResp.Name = "lblNombreEjecutivoResp";
            this.lblNombreEjecutivoResp.Size = new System.Drawing.Size(151, 18);
            this.lblNombreEjecutivoResp.TabIndex = 1;
            this.lblNombreEjecutivoResp.Text = "Nombre Completo:";
            // 
            // lblDNIEjecutivoResp
            // 
            this.lblDNIEjecutivoResp.AutoSize = true;
            this.lblDNIEjecutivoResp.Location = new System.Drawing.Point(148, 41);
            this.lblDNIEjecutivoResp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIEjecutivoResp.Name = "lblDNIEjecutivoResp";
            this.lblDNIEjecutivoResp.Size = new System.Drawing.Size(41, 18);
            this.lblDNIEjecutivoResp.TabIndex = 0;
            this.lblDNIEjecutivoResp.Text = "DNI:";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Location = new System.Drawing.Point(19, 377);
            this.lblCaracteristicas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(302, 18);
            this.lblCaracteristicas.TabIndex = 12;
            this.lblCaracteristicas.Text = "Características Adicionales de la Sede:";
            // 
            // txtCantAulas
            // 
            this.txtCantAulas.Location = new System.Drawing.Point(583, 208);
            this.txtCantAulas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantAulas.Name = "txtCantAulas";
            this.txtCantAulas.Size = new System.Drawing.Size(132, 24);
            this.txtCantAulas.TabIndex = 10;
            // 
            // lblCantAulas
            // 
            this.lblCantAulas.AutoSize = true;
            this.lblCantAulas.Location = new System.Drawing.Point(405, 212);
            this.lblCantAulas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantAulas.Name = "lblCantAulas";
            this.lblCantAulas.Size = new System.Drawing.Size(148, 18);
            this.lblCantAulas.TabIndex = 10;
            this.lblCantAulas.Text = "Cantidad de Aulas:";
            // 
            // cboTipoSede
            // 
            this.cboTipoSede.FormattingEnabled = true;
            this.cboTipoSede.Location = new System.Drawing.Point(583, 169);
            this.cboTipoSede.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoSede.Name = "cboTipoSede";
            this.cboTipoSede.Size = new System.Drawing.Size(709, 26);
            this.cboTipoSede.TabIndex = 9;
            this.cboTipoSede.SelectedIndexChanged += new System.EventHandler(this.cboTipoSede_SelectedIndexChanged);
            // 
            // lblTipoSede
            // 
            this.lblTipoSede.AutoSize = true;
            this.lblTipoSede.Location = new System.Drawing.Point(447, 174);
            this.lblTipoSede.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoSede.Name = "lblTipoSede";
            this.lblTipoSede.Size = new System.Drawing.Size(112, 18);
            this.lblTipoSede.TabIndex = 8;
            this.lblTipoSede.Text = "Tipo de Sede:";
            // 
            // dtpFechaInauguracion
            // 
            this.dtpFechaInauguracion.Location = new System.Drawing.Point(583, 132);
            this.dtpFechaInauguracion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInauguracion.Name = "dtpFechaInauguracion";
            this.dtpFechaInauguracion.Size = new System.Drawing.Size(709, 24);
            this.dtpFechaInauguracion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Inauguración:";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackgroundImage = global::EduSoft.Properties.Resources.Upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(287, 201);
            this.btnSubirFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(61, 42);
            this.btnSubirFoto.TabIndex = 5;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(395, 62);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre de la Sede:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(583, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(709, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // txtIDSede
            // 
            this.txtIDSede.Location = new System.Drawing.Point(583, 20);
            this.txtIDSede.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDSede.Name = "txtIDSede";
            this.txtIDSede.ReadOnly = true;
            this.txtIDSede.Size = new System.Drawing.Size(92, 24);
            this.txtIDSede.TabIndex = 1;
            this.txtIDSede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(23, 20);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(325, 222);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // lblIDSede
            // 
            this.lblIDSede.AutoSize = true;
            this.lblIDSede.Location = new System.Drawing.Point(444, 23);
            this.lblIDSede.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDSede.Name = "lblIDSede";
            this.lblIDSede.Size = new System.Drawing.Size(113, 18);
            this.lblIDSede.TabIndex = 0;
            this.lblIDSede.Text = "ID de la Sede:";
            // 
            // tpProgramasAcademicos
            // 
            this.tpProgramasAcademicos.BackColor = System.Drawing.SystemColors.Control;
            this.tpProgramasAcademicos.Controls.Add(this.btnEliminarProgramaAcademico);
            this.tpProgramasAcademicos.Controls.Add(this.btnAgregarProgramaAcademico);
            this.tpProgramasAcademicos.Controls.Add(this.lblListaProgramas);
            this.tpProgramasAcademicos.Controls.Add(this.dgvProgramasAcademicos);
            this.tpProgramasAcademicos.Controls.Add(this.txtNombrePrograma);
            this.tpProgramasAcademicos.Controls.Add(this.lblNombrePrograma);
            this.tpProgramasAcademicos.Controls.Add(this.txtTipoPrograma);
            this.tpProgramasAcademicos.Controls.Add(this.lblTipoPrograma);
            this.tpProgramasAcademicos.Controls.Add(this.btnBuscarPrograma);
            this.tpProgramasAcademicos.Controls.Add(this.txtClavePrograma);
            this.tpProgramasAcademicos.Controls.Add(this.lblClavePrograma);
            this.tpProgramasAcademicos.Location = new System.Drawing.Point(4, 27);
            this.tpProgramasAcademicos.Margin = new System.Windows.Forms.Padding(4);
            this.tpProgramasAcademicos.Name = "tpProgramasAcademicos";
            this.tpProgramasAcademicos.Padding = new System.Windows.Forms.Padding(4);
            this.tpProgramasAcademicos.Size = new System.Drawing.Size(1321, 416);
            this.tpProgramasAcademicos.TabIndex = 1;
            this.tpProgramasAcademicos.Text = "Programas Académicos";
            // 
            // btnEliminarProgramaAcademico
            // 
            this.btnEliminarProgramaAcademico.Location = new System.Drawing.Point(1089, 79);
            this.btnEliminarProgramaAcademico.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProgramaAcademico.Name = "btnEliminarProgramaAcademico";
            this.btnEliminarProgramaAcademico.Size = new System.Drawing.Size(51, 28);
            this.btnEliminarProgramaAcademico.TabIndex = 6;
            this.btnEliminarProgramaAcademico.Text = "-";
            this.btnEliminarProgramaAcademico.UseVisualStyleBackColor = true;
            this.btnEliminarProgramaAcademico.Click += new System.EventHandler(this.btnEliminarProgramaAcademico_Click);
            // 
            // btnAgregarProgramaAcademico
            // 
            this.btnAgregarProgramaAcademico.Location = new System.Drawing.Point(1035, 79);
            this.btnAgregarProgramaAcademico.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProgramaAcademico.Name = "btnAgregarProgramaAcademico";
            this.btnAgregarProgramaAcademico.Size = new System.Drawing.Size(51, 28);
            this.btnAgregarProgramaAcademico.TabIndex = 5;
            this.btnAgregarProgramaAcademico.Text = "+";
            this.btnAgregarProgramaAcademico.UseVisualStyleBackColor = true;
            this.btnAgregarProgramaAcademico.Click += new System.EventHandler(this.btnAgregarProgramaAcademico_Click);
            // 
            // lblListaProgramas
            // 
            this.lblListaProgramas.AutoSize = true;
            this.lblListaProgramas.Location = new System.Drawing.Point(13, 139);
            this.lblListaProgramas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaProgramas.Name = "lblListaProgramas";
            this.lblListaProgramas.Size = new System.Drawing.Size(341, 18);
            this.lblListaProgramas.TabIndex = 8;
            this.lblListaProgramas.Text = "Lista de Programas Académicos de la Sede:";
            // 
            // dgvProgramasAcademicos
            // 
            this.dgvProgramasAcademicos.AllowUserToAddRows = false;
            this.dgvProgramasAcademicos.AllowUserToDeleteRows = false;
            this.dgvProgramasAcademicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramasAcademicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Clave,
            this.Nombre,
            this.CantHorasCreditos,
            this.FechaInicioRealizacion});
            this.dgvProgramasAcademicos.Location = new System.Drawing.Point(16, 166);
            this.dgvProgramasAcademicos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProgramasAcademicos.Name = "dgvProgramasAcademicos";
            this.dgvProgramasAcademicos.ReadOnly = true;
            this.dgvProgramasAcademicos.RowHeadersWidth = 51;
            this.dgvProgramasAcademicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramasAcademicos.Size = new System.Drawing.Size(1284, 228);
            this.dgvProgramasAcademicos.TabIndex = 7;
            this.dgvProgramasAcademicos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProgramasAcademicos_CellFormatting);
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 125;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // CantHorasCreditos
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CantHorasCreditos.DefaultCellStyle = dataGridViewCellStyle5;
            this.CantHorasCreditos.HeaderText = "Cant. Horas/Créditos";
            this.CantHorasCreditos.MinimumWidth = 6;
            this.CantHorasCreditos.Name = "CantHorasCreditos";
            this.CantHorasCreditos.ReadOnly = true;
            this.CantHorasCreditos.Width = 170;
            // 
            // FechaInicioRealizacion
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaInicioRealizacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.FechaInicioRealizacion.HeaderText = "F. Inicio/Realización";
            this.FechaInicioRealizacion.MinimumWidth = 6;
            this.FechaInicioRealizacion.Name = "FechaInicioRealizacion";
            this.FechaInicioRealizacion.ReadOnly = true;
            this.FechaInicioRealizacion.Width = 170;
            // 
            // txtNombrePrograma
            // 
            this.txtNombrePrograma.Location = new System.Drawing.Point(233, 80);
            this.txtNombrePrograma.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePrograma.Name = "txtNombrePrograma";
            this.txtNombrePrograma.ReadOnly = true;
            this.txtNombrePrograma.Size = new System.Drawing.Size(783, 24);
            this.txtNombrePrograma.TabIndex = 4;
            // 
            // lblNombrePrograma
            // 
            this.lblNombrePrograma.AutoSize = true;
            this.lblNombrePrograma.Location = new System.Drawing.Point(21, 84);
            this.lblNombrePrograma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePrograma.Name = "lblNombrePrograma";
            this.lblNombrePrograma.Size = new System.Drawing.Size(179, 18);
            this.lblNombrePrograma.TabIndex = 5;
            this.lblNombrePrograma.Text = "Nombre del Programa:";
            // 
            // txtTipoPrograma
            // 
            this.txtTipoPrograma.Location = new System.Drawing.Point(233, 48);
            this.txtTipoPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoPrograma.Name = "txtTipoPrograma";
            this.txtTipoPrograma.ReadOnly = true;
            this.txtTipoPrograma.Size = new System.Drawing.Size(199, 24);
            this.txtTipoPrograma.TabIndex = 3;
            this.txtTipoPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipoPrograma
            // 
            this.lblTipoPrograma.AutoSize = true;
            this.lblTipoPrograma.Location = new System.Drawing.Point(57, 52);
            this.lblTipoPrograma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPrograma.Name = "lblTipoPrograma";
            this.lblTipoPrograma.Size = new System.Drawing.Size(148, 18);
            this.lblTipoPrograma.TabIndex = 3;
            this.lblTipoPrograma.Text = "Tipo de Programa:";
            // 
            // btnBuscarPrograma
            // 
            this.btnBuscarPrograma.Image = global::EduSoft.Properties.Resources.Search;
            this.btnBuscarPrograma.Location = new System.Drawing.Point(340, 15);
            this.btnBuscarPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPrograma.Name = "btnBuscarPrograma";
            this.btnBuscarPrograma.Size = new System.Drawing.Size(45, 28);
            this.btnBuscarPrograma.TabIndex = 2;
            this.btnBuscarPrograma.UseVisualStyleBackColor = true;
            this.btnBuscarPrograma.Click += new System.EventHandler(this.btnBuscarPrograma_Click);
            // 
            // txtClavePrograma
            // 
            this.txtClavePrograma.Location = new System.Drawing.Point(233, 16);
            this.txtClavePrograma.Margin = new System.Windows.Forms.Padding(4);
            this.txtClavePrograma.Name = "txtClavePrograma";
            this.txtClavePrograma.ReadOnly = true;
            this.txtClavePrograma.Size = new System.Drawing.Size(101, 24);
            this.txtClavePrograma.TabIndex = 1;
            this.txtClavePrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClavePrograma
            // 
            this.lblClavePrograma.AutoSize = true;
            this.lblClavePrograma.Location = new System.Drawing.Point(43, 20);
            this.lblClavePrograma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClavePrograma.Name = "lblClavePrograma";
            this.lblClavePrograma.Size = new System.Drawing.Size(161, 18);
            this.lblClavePrograma.TabIndex = 0;
            this.lblClavePrograma.Text = "Clave del Programa:";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmGestionarSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 538);
            this.Controls.Add(this.tcSede);
            this.Controls.Add(this.lblGestionSedes);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionarSedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Gestión de Sedes";
            this.Load += new System.EventHandler(this.frmGestionarSedes_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tcSede.ResumeLayout(false);
            this.tpDatosGenerales.ResumeLayout(false);
            this.tpDatosGenerales.PerformLayout();
            this.gbEjecutivoResp.ResumeLayout(false);
            this.gbEjecutivoResp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tpProgramasAcademicos.ResumeLayout(false);
            this.tpProgramasAcademicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramasAcademicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblGestionSedes;
        private System.Windows.Forms.TabControl tcSede;
        private System.Windows.Forms.TabPage tpDatosGenerales;
        private System.Windows.Forms.TabPage tpProgramasAcademicos;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDSede;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblIDSede;
        private System.Windows.Forms.DateTimePicker dtpFechaInauguracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoSede;
        private System.Windows.Forms.Label lblTipoSede;
        private System.Windows.Forms.CheckBox cbCafeteria;
        private System.Windows.Forms.CheckBox cbSalasEstudio;
        private System.Windows.Forms.CheckBox cbBiblioteca;
        private System.Windows.Forms.CheckBox cbAuditorio;
        private System.Windows.Forms.GroupBox gbEjecutivoResp;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.TextBox txtCantAulas;
        private System.Windows.Forms.Label lblCantAulas;
        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.Label lblAforo;
        private System.Windows.Forms.Button btnBuscarEjecutivoResponsable;
        private System.Windows.Forms.TextBox txtNombreEjecutivoResp;
        private System.Windows.Forms.TextBox txtDNIEjecutivoResp;
        private System.Windows.Forms.Label lblNombreEjecutivoResp;
        private System.Windows.Forms.Label lblDNIEjecutivoResp;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.CheckBox cbEstacionamiento;
        private System.Windows.Forms.Label lblListaProgramas;
        private System.Windows.Forms.DataGridView dgvProgramasAcademicos;
        private System.Windows.Forms.TextBox txtNombrePrograma;
        private System.Windows.Forms.Label lblNombrePrograma;
        private System.Windows.Forms.TextBox txtTipoPrograma;
        private System.Windows.Forms.Label lblTipoPrograma;
        private System.Windows.Forms.Button btnBuscarPrograma;
        private System.Windows.Forms.TextBox txtClavePrograma;
        private System.Windows.Forms.Label lblClavePrograma;
        private System.Windows.Forms.Button btnEliminarProgramaAcademico;
        private System.Windows.Forms.Button btnAgregarProgramaAcademico;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHorasCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioRealizacion;
    }
}


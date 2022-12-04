namespace CapaPresentacion.ControlesDeUsuario
{
    partial class UC_VerLiquidaciones
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VerLiquidaciones));
            this.dgvLiquidaciones = new System.Windows.Forms.DataGridView();
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtJubilacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExtras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtPAMI = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAnticipos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidaciones)).BeginInit();
            this.paneltop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLiquidaciones
            // 
            this.dgvLiquidaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLiquidaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLiquidaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLiquidaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiquidaciones.Location = new System.Drawing.Point(0, 89);
            this.dgvLiquidaciones.Name = "dgvLiquidaciones";
            this.dgvLiquidaciones.RowHeadersWidth = 51;
            this.dgvLiquidaciones.Size = new System.Drawing.Size(894, 706);
            this.dgvLiquidaciones.TabIndex = 43;
            this.dgvLiquidaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLiquidaciones_CellContentClick_1);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.White;
            this.paneltop.Controls.Add(this.btnExportar);
            this.paneltop.Controls.Add(this.panel2);
            this.paneltop.Controls.Add(this.btnBuscar);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(900, 84);
            this.paneltop.TabIndex = 45;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExportar.Location = new System.Drawing.Point(0, 17);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(76, 49);
            this.btnExportar.TabIndex = 39;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbPeriodo);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtbusqueda);
            this.panel2.Location = new System.Drawing.Point(94, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 49);
            this.panel2.TabIndex = 37;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(97, 10);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(284, 28);
            this.cmbPeriodo.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(25, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 20);
            this.label18.TabIndex = 79;
            this.label18.Text = "Período:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.AcceptsReturn = true;
            this.txtbusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(418, 12);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(217, 24);
            this.txtbusqueda.TabIndex = 37;
            this.txtbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBuscar.Location = new System.Drawing.Point(758, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 49);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGuardar.Location = new System.Drawing.Point(6, 617);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(372, 61);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtJubilacion
            // 
            this.txtJubilacion.ForeColor = System.Drawing.Color.Crimson;
            this.txtJubilacion.Location = new System.Drawing.Point(139, 454);
            this.txtJubilacion.Name = "txtJubilacion";
            this.txtJubilacion.ReadOnly = true;
            this.txtJubilacion.Size = new System.Drawing.Size(184, 26);
            this.txtJubilacion.TabIndex = 26;
            this.txtJubilacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(50, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Jubilación:";
            // 
            // txtBruto
            // 
            this.txtBruto.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBruto.Location = new System.Drawing.Point(140, 327);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.ReadOnly = true;
            this.txtBruto.Size = new System.Drawing.Size(184, 26);
            this.txtBruto.TabIndex = 24;
            this.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(28, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sueldo Bruto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Año:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEliminar.Location = new System.Drawing.Point(6, 729);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(372, 59);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtOS
            // 
            this.txtOS.ForeColor = System.Drawing.Color.Crimson;
            this.txtOS.Location = new System.Drawing.Point(139, 486);
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(184, 26);
            this.txtOS.TabIndex = 39;
            this.txtOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(41, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Obra Social:";
            // 
            // txtExtras
            // 
            this.txtExtras.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtExtras.Location = new System.Drawing.Point(139, 357);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Size = new System.Drawing.Size(184, 26);
            this.txtExtras.TabIndex = 41;
            this.txtExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExtras.TextChanged += new System.EventHandler(this.txtExtras_TextChanged);
            this.txtExtras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtras_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(55, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Hs. Extra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Mes:";
            // 
            // gbx
            // 
            this.gbx.BackColor = System.Drawing.SystemColors.Window;
            this.gbx.Controls.Add(this.btnRecibo);
            this.gbx.Controls.Add(this.label15);
            this.gbx.Controls.Add(this.label17);
            this.gbx.Controls.Add(this.txtBono);
            this.gbx.Controls.Add(this.txtPAMI);
            this.gbx.Controls.Add(this.txtPuesto);
            this.gbx.Controls.Add(this.txtIngreso);
            this.gbx.Controls.Add(this.txtJubilacion);
            this.gbx.Controls.Add(this.txtLegajo);
            this.gbx.Controls.Add(this.label3);
            this.gbx.Controls.Add(this.txtConcepto);
            this.gbx.Controls.Add(this.txtOS);
            this.gbx.Controls.Add(this.txtMes);
            this.gbx.Controls.Add(this.label4);
            this.gbx.Controls.Add(this.txtAnio);
            this.gbx.Controls.Add(this.label16);
            this.gbx.Controls.Add(this.label14);
            this.gbx.Controls.Add(this.txtNeto);
            this.gbx.Controls.Add(this.label13);
            this.gbx.Controls.Add(this.txtAnticipos);
            this.gbx.Controls.Add(this.label12);
            this.gbx.Controls.Add(this.label7);
            this.gbx.Controls.Add(this.txtNombre);
            this.gbx.Controls.Add(this.label8);
            this.gbx.Controls.Add(this.label9);
            this.gbx.Controls.Add(this.txtApellido);
            this.gbx.Controls.Add(this.label10);
            this.gbx.Controls.Add(this.label11);
            this.gbx.Controls.Add(this.txtCuil);
            this.gbx.Controls.Add(this.label6);
            this.gbx.Controls.Add(this.label5);
            this.gbx.Controls.Add(this.txtExtras);
            this.gbx.Controls.Add(this.btnEliminar);
            this.gbx.Controls.Add(this.label1);
            this.gbx.Controls.Add(this.label2);
            this.gbx.Controls.Add(this.txtBruto);
            this.gbx.Controls.Add(this.btnGuardar);
            this.gbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbx.Location = new System.Drawing.Point(900, 0);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(378, 795);
            this.gbx.TabIndex = 44;
            this.gbx.TabStop = false;
            this.gbx.Text = "Liquidación";
            // 
            // btnRecibo
            // 
            this.btnRecibo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibo.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRecibo.Location = new System.Drawing.Point(6, 671);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(372, 61);
            this.btnRecibo.TabIndex = 78;
            this.btnRecibo.Text = "Ver Recibo";
            this.btnRecibo.UseVisualStyleBackColor = false;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(81, 521);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 76;
            this.label15.Text = "PAMI:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(75, 393);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 20);
            this.label17.TabIndex = 74;
            this.label17.Text = "Bonos:";
            // 
            // txtBono
            // 
            this.txtBono.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBono.Location = new System.Drawing.Point(140, 390);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(184, 26);
            this.txtBono.TabIndex = 75;
            this.txtBono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBono.TextChanged += new System.EventHandler(this.txtBono_TextChanged);
            this.txtBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBono_KeyPress);
            // 
            // txtPAMI
            // 
            this.txtPAMI.ForeColor = System.Drawing.Color.Crimson;
            this.txtPAMI.Location = new System.Drawing.Point(140, 518);
            this.txtPAMI.Name = "txtPAMI";
            this.txtPAMI.ReadOnly = true;
            this.txtPAMI.Size = new System.Drawing.Size(184, 26);
            this.txtPAMI.TabIndex = 77;
            this.txtPAMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(139, 295);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            this.txtPuesto.Size = new System.Drawing.Size(184, 26);
            this.txtPuesto.TabIndex = 73;
            this.txtPuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(139, 263);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.ReadOnly = true;
            this.txtIngreso.Size = new System.Drawing.Size(184, 26);
            this.txtIngreso.TabIndex = 72;
            this.txtIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(139, 127);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(184, 26);
            this.txtLegajo.TabIndex = 71;
            this.txtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(140, 95);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.Size = new System.Drawing.Size(184, 26);
            this.txtConcepto.TabIndex = 70;
            this.txtConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(231, 58);
            this.txtMes.Name = "txtMes";
            this.txtMes.ReadOnly = true;
            this.txtMes.Size = new System.Drawing.Size(92, 26);
            this.txtMes.TabIndex = 68;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(140, 58);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.ReadOnly = true;
            this.txtAnio.Size = new System.Drawing.Size(50, 26);
            this.txtAnio.TabIndex = 67;
            this.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(52, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 20);
            this.label16.TabIndex = 65;
            this.label16.Text = "Concepto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(22, 579);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 20);
            this.label14.TabIndex = 60;
            this.label14.Text = "Neto a Cobrar:";
            // 
            // txtNeto
            // 
            this.txtNeto.BackColor = System.Drawing.SystemColors.Info;
            this.txtNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeto.Location = new System.Drawing.Point(140, 573);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(184, 29);
            this.txtNeto.TabIndex = 61;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(55, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 58;
            this.label13.Text = "Anticipos:";
            // 
            // txtAnticipos
            // 
            this.txtAnticipos.ForeColor = System.Drawing.Color.Crimson;
            this.txtAnticipos.Location = new System.Drawing.Point(139, 422);
            this.txtAnticipos.Name = "txtAnticipos";
            this.txtAnticipos.Size = new System.Drawing.Size(184, 26);
            this.txtAnticipos.TabIndex = 59;
            this.txtAnticipos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAnticipos.TextChanged += new System.EventHandler(this.txtAnticipos_TextChanged);
            this.txtAnticipos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnticipos_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Legajo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(184, 26);
            this.txtNombre.TabIndex = 45;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(19, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Fecha Ingreso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(65, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(139, 197);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(184, 26);
            this.txtApellido.TabIndex = 47;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(72, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Puesto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(85, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "CUIL:";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(139, 231);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.ReadOnly = true;
            this.txtCuil.Size = new System.Drawing.Size(184, 26);
            this.txtCuil.TabIndex = 49;
            this.txtCuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UC_VerLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLiquidaciones);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.gbx);
            this.Name = "UC_VerLiquidaciones";
            this.Size = new System.Drawing.Size(1278, 795);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidaciones)).EndInit();
            this.paneltop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLiquidaciones;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtJubilacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAnticipos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPAMI;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnExportar;
    }
}

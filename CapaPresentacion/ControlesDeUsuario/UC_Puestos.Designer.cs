namespace CapaPresentacion.ControlesDeUsuario
{
    partial class UC_Puestos
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
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExtras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.paneltop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPuestos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPuestos.Location = new System.Drawing.Point(0, 60);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.Size = new System.Drawing.Size(894, 735);
            this.dgvPuestos.TabIndex = 40;
            this.dgvPuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuestos_CellContentClick);
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.panel2);
            this.paneltop.Controls.Add(this.btnNuevo);
            this.paneltop.Controls.Add(this.btnBuscar);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(894, 60);
            this.paneltop.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.busqueda);
            this.panel2.Location = new System.Drawing.Point(163, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 48);
            this.panel2.TabIndex = 37;
            // 
            // busqueda
            // 
            this.busqueda.AcceptsReturn = true;
            this.busqueda.BackColor = System.Drawing.SystemColors.Window;
            this.busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqueda.Location = new System.Drawing.Point(5, 12);
            this.busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(574, 24);
            this.busqueda.TabIndex = 37;
            this.busqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNuevo.Location = new System.Drawing.Point(3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(154, 51);
            this.btnNuevo.TabIndex = 36;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBuscar.Location = new System.Drawing.Point(752, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 50);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbx
            // 
            this.gbx.BackColor = System.Drawing.SystemColors.Window;
            this.gbx.Controls.Add(this.label5);
            this.gbx.Controls.Add(this.txtExtras);
            this.gbx.Controls.Add(this.label4);
            this.gbx.Controls.Add(this.txtSueldo);
            this.gbx.Controls.Add(this.btnEliminar);
            this.gbx.Controls.Add(this.label1);
            this.gbx.Controls.Add(this.txtDenominacion);
            this.gbx.Controls.Add(this.label2);
            this.gbx.Controls.Add(this.txtHs);
            this.gbx.Controls.Add(this.label3);
            this.gbx.Controls.Add(this.txtDias);
            this.gbx.Controls.Add(this.btnGuardar);
            this.gbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbx.Location = new System.Drawing.Point(894, 0);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(384, 795);
            this.gbx.TabIndex = 41;
            this.gbx.TabStop = false;
            this.gbx.Text = "Puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(35, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sueldo Bruto:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(147, 178);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(184, 26);
            this.txtSueldo.TabIndex = 39;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(75)))), ((int)(((byte)(35)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEliminar.Location = new System.Drawing.Point(6, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(372, 59);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Denominación:";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(147, 78);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(184, 26);
            this.txtDenominacion.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hs Semanales:";
            // 
            // txtHs
            // 
            this.txtHs.Location = new System.Drawing.Point(147, 112);
            this.txtHs.Name = "txtHs";
            this.txtHs.Size = new System.Drawing.Size(184, 26);
            this.txtHs.TabIndex = 24;
            this.txtHs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHs_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Días Semana:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(147, 146);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(184, 26);
            this.txtDias.TabIndex = 26;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGuardar.Location = new System.Drawing.Point(6, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(372, 61);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(24, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Valor Hs. Extra:";
            // 
            // txtExtras
            // 
            this.txtExtras.Location = new System.Drawing.Point(147, 210);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Size = new System.Drawing.Size(184, 26);
            this.txtExtras.TabIndex = 41;
            this.txtExtras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtras_KeyPress);
            // 
            // UC_Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.gbx);
            this.Name = "UC_Puestos";
            this.Size = new System.Drawing.Size(1278, 795);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.paneltop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExtras;
    }
}

namespace Ul_Granos_y_Mas
{
	partial class Compra_de_insumos
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
			this.dgvCompra = new System.Windows.Forms.DataGridView();
			this.gbxOpciones = new System.Windows.Forms.GroupBox();
			this.pnlSubMenu = new System.Windows.Forms.Panel();
			this.rbtCliente = new System.Windows.Forms.RadioButton();
			this.rbtMes = new System.Windows.Forms.RadioButton();
			this.pnlEspacio = new System.Windows.Forms.Panel();
			this.lblNombreSubMenu = new System.Windows.Forms.Label();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnELiminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.lblproyecto = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.pnlCabecera = new System.Windows.Forms.Panel();
			this.lblCabecera = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.txtMes = new System.Windows.Forms.TextBox();
			this.lblMes = new System.Windows.Forms.Label();
			this.cbxCliente = new System.Windows.Forms.ComboBox();
			this.txtProyecto = new System.Windows.Forms.TextBox();
			this.lblFecha = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
			this.gbxOpciones.SuspendLayout();
			this.pnlSubMenu.SuspendLayout();
			this.gbxDatos.SuspendLayout();
			this.pnlCabecera.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCompra
			// 
			this.dgvCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
			this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCompra.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCompra.Location = new System.Drawing.Point(0, 155);
			this.dgvCompra.Name = "dgvCompra";
			this.dgvCompra.Size = new System.Drawing.Size(1326, 505);
			this.dgvCompra.TabIndex = 8;
			// 
			// gbxOpciones
			// 
			this.gbxOpciones.Controls.Add(this.pnlSubMenu);
			this.gbxOpciones.Controls.Add(this.btnEditar);
			this.gbxOpciones.Controls.Add(this.btnELiminar);
			this.gbxOpciones.Controls.Add(this.btnBuscar);
			this.gbxOpciones.Controls.Add(this.btnNuevo);
			this.gbxOpciones.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbxOpciones.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.gbxOpciones.Location = new System.Drawing.Point(0, 64);
			this.gbxOpciones.Name = "gbxOpciones";
			this.gbxOpciones.Size = new System.Drawing.Size(1326, 91);
			this.gbxOpciones.TabIndex = 7;
			this.gbxOpciones.TabStop = false;
			this.gbxOpciones.Text = "Opciones:";
			// 
			// pnlSubMenu
			// 
			this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.pnlSubMenu.Controls.Add(this.rbtCliente);
			this.pnlSubMenu.Controls.Add(this.rbtMes);
			this.pnlSubMenu.Controls.Add(this.pnlEspacio);
			this.pnlSubMenu.Controls.Add(this.lblNombreSubMenu);
			this.pnlSubMenu.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlSubMenu.Location = new System.Drawing.Point(440, 81);
			this.pnlSubMenu.Name = "pnlSubMenu";
			this.pnlSubMenu.Size = new System.Drawing.Size(200, 100);
			this.pnlSubMenu.TabIndex = 5;
			this.pnlSubMenu.Visible = false;
			// 
			// rbtCliente
			// 
			this.rbtCliente.AutoSize = true;
			this.rbtCliente.Dock = System.Windows.Forms.DockStyle.Top;
			this.rbtCliente.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtCliente.Location = new System.Drawing.Point(34, 55);
			this.rbtCliente.Name = "rbtCliente";
			this.rbtCliente.Size = new System.Drawing.Size(166, 29);
			this.rbtCliente.TabIndex = 8;
			this.rbtCliente.TabStop = true;
			this.rbtCliente.Text = "Cliente";
			this.rbtCliente.UseVisualStyleBackColor = true;
			// 
			// rbtMes
			// 
			this.rbtMes.AutoSize = true;
			this.rbtMes.Dock = System.Windows.Forms.DockStyle.Top;
			this.rbtMes.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtMes.Location = new System.Drawing.Point(34, 26);
			this.rbtMes.Name = "rbtMes";
			this.rbtMes.Size = new System.Drawing.Size(166, 29);
			this.rbtMes.TabIndex = 7;
			this.rbtMes.TabStop = true;
			this.rbtMes.Text = "Mes";
			this.rbtMes.UseVisualStyleBackColor = true;
			this.rbtMes.CheckedChanged += new System.EventHandler(this.rbtMes_CheckedChanged);
			// 
			// pnlEspacio
			// 
			this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.pnlEspacio.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlEspacio.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlEspacio.Location = new System.Drawing.Point(0, 26);
			this.pnlEspacio.Name = "pnlEspacio";
			this.pnlEspacio.Size = new System.Drawing.Size(34, 74);
			this.pnlEspacio.TabIndex = 6;
			// 
			// lblNombreSubMenu
			// 
			this.lblNombreSubMenu.AutoSize = true;
			this.lblNombreSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNombreSubMenu.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.lblNombreSubMenu.Location = new System.Drawing.Point(0, 0);
			this.lblNombreSubMenu.Name = "lblNombreSubMenu";
			this.lblNombreSubMenu.Size = new System.Drawing.Size(113, 26);
			this.lblNombreSubMenu.TabIndex = 0;
			this.lblNombreSubMenu.Text = "Buscar por:";
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Location = new System.Drawing.Point(964, 36);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(220, 50);
			this.btnEditar.TabIndex = 3;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnELiminar
			// 
			this.btnELiminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnELiminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnELiminar.Location = new System.Drawing.Point(692, 36);
			this.btnELiminar.Name = "btnELiminar";
			this.btnELiminar.Size = new System.Drawing.Size(220, 50);
			this.btnELiminar.TabIndex = 2;
			this.btnELiminar.Text = "Eliminar";
			this.btnELiminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnELiminar.UseVisualStyleBackColor = false;
			this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Location = new System.Drawing.Point(420, 36);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(220, 50);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.Location = new System.Drawing.Point(148, 36);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(220, 50);
			this.btnNuevo.TabIndex = 0;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.lblFecha);
			this.gbxDatos.Controls.Add(this.txtProyecto);
			this.gbxDatos.Controls.Add(this.cbxCliente);
			this.gbxDatos.Controls.Add(this.dtpFecha);
			this.gbxDatos.Controls.Add(this.lblMes);
			this.gbxDatos.Controls.Add(this.lblproyecto);
			this.gbxDatos.Controls.Add(this.txtMes);
			this.gbxDatos.Controls.Add(this.lblCliente);
			this.gbxDatos.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbxDatos.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.gbxDatos.Location = new System.Drawing.Point(0, 64);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(1326, 0);
			this.gbxDatos.TabIndex = 6;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos:";
			// 
			// lblproyecto
			// 
			this.lblproyecto.AutoSize = true;
			this.lblproyecto.Location = new System.Drawing.Point(29, 39);
			this.lblproyecto.Name = "lblproyecto";
			this.lblproyecto.Size = new System.Drawing.Size(114, 33);
			this.lblproyecto.TabIndex = 3;
			this.lblproyecto.Text = "Proyecto:";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(494, 41);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(96, 33);
			this.lblCliente.TabIndex = 1;
			this.lblCliente.Text = "Cliente:";
			// 
			// pnlCabecera
			// 
			this.pnlCabecera.Controls.Add(this.lblCabecera);
			this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
			this.pnlCabecera.Name = "pnlCabecera";
			this.pnlCabecera.Size = new System.Drawing.Size(1326, 64);
			this.pnlCabecera.TabIndex = 5;
			// 
			// lblCabecera
			// 
			this.lblCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCabecera.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCabecera.Location = new System.Drawing.Point(0, 0);
			this.lblCabecera.Name = "lblCabecera";
			this.lblCabecera.Size = new System.Drawing.Size(1326, 64);
			this.lblCabecera.TabIndex = 0;
			this.lblCabecera.Text = "Compra de Insumos y Utilidades del pedido";
			this.lblCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(326, 35);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(162, 37);
			this.dtpFecha.TabIndex = 4;
			this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
			// 
			// txtMes
			// 
			this.txtMes.Location = new System.Drawing.Point(722, 37);
			this.txtMes.Name = "txtMes";
			this.txtMes.ReadOnly = true;
			this.txtMes.Size = new System.Drawing.Size(235, 37);
			this.txtMes.TabIndex = 2;
			// 
			// lblMes
			// 
			this.lblMes.AutoSize = true;
			this.lblMes.Location = new System.Drawing.Point(649, 39);
			this.lblMes.Name = "lblMes";
			this.lblMes.Size = new System.Drawing.Size(67, 33);
			this.lblMes.TabIndex = 3;
			this.lblMes.Text = "Mes:";
			// 
			// cbxCliente
			// 
			this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCliente.FormattingEnabled = true;
			this.cbxCliente.Location = new System.Drawing.Point(596, 37);
			this.cbxCliente.Name = "cbxCliente";
			this.cbxCliente.Size = new System.Drawing.Size(235, 41);
			this.cbxCliente.TabIndex = 5;
			// 
			// txtProyecto
			// 
			this.txtProyecto.Location = new System.Drawing.Point(149, 37);
			this.txtProyecto.Name = "txtProyecto";
			this.txtProyecto.Size = new System.Drawing.Size(235, 37);
			this.txtProyecto.TabIndex = 6;
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(390, 39);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(85, 33);
			this.lblFecha.TabIndex = 7;
			this.lblFecha.Text = "Fecha:";
			// 
			// Compra_de_insumos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(1326, 660);
			this.Controls.Add(this.dgvCompra);
			this.Controls.Add(this.gbxOpciones);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.pnlCabecera);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Compra_de_insumos";
			this.Text = "Compra_de_insumos";
			((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
			this.gbxOpciones.ResumeLayout(false);
			this.pnlSubMenu.ResumeLayout(false);
			this.pnlSubMenu.PerformLayout();
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			this.pnlCabecera.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCompra;
		private System.Windows.Forms.GroupBox gbxOpciones;
		private System.Windows.Forms.Panel pnlSubMenu;
		private System.Windows.Forms.RadioButton rbtCliente;
		private System.Windows.Forms.RadioButton rbtMes;
		private System.Windows.Forms.Panel pnlEspacio;
		private System.Windows.Forms.Label lblNombreSubMenu;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnELiminar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.Label lblproyecto;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Panel pnlCabecera;
		private System.Windows.Forms.Label lblCabecera;
		private System.Windows.Forms.ComboBox cbxCliente;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label lblMes;
		private System.Windows.Forms.TextBox txtMes;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.TextBox txtProyecto;
	}
}
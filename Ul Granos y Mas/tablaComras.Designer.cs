namespace Ul_Granos_y_Mas
{
	partial class tablaCompras
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
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnELiminar = new System.Windows.Forms.Button();
			this.btnImportar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.cbxUnidad = new System.Windows.Forms.ComboBox();
			this.cbxProducto = new System.Windows.Forms.ComboBox();
			this.nudCantidadEntregada = new System.Windows.Forms.NumericUpDown();
			this.nudCantidadSolicitada = new System.Windows.Forms.NumericUpDown();
			this.lblCantidadEntregada = new System.Windows.Forms.Label();
			this.lblCantidadSolicitada = new System.Windows.Forms.Label();
			this.lblUnidad = new System.Windows.Forms.Label();
			this.lblProducto = new System.Windows.Forms.Label();
			this.pnlCabecera = new System.Windows.Forms.Panel();
			this.lblCabecera = new System.Windows.Forms.Label();
			this.btnVisualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
			this.gbxOpciones.SuspendLayout();
			this.gbxDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadEntregada)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadSolicitada)).BeginInit();
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
			this.dgvCompra.Size = new System.Drawing.Size(1310, 466);
			this.dgvCompra.TabIndex = 16;
			// 
			// gbxOpciones
			// 
			this.gbxOpciones.Controls.Add(this.btnEditar);
			this.gbxOpciones.Controls.Add(this.btnELiminar);
			this.gbxOpciones.Controls.Add(this.btnVisualizar);
			this.gbxOpciones.Controls.Add(this.btnImportar);
			this.gbxOpciones.Controls.Add(this.btnNuevo);
			this.gbxOpciones.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbxOpciones.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.gbxOpciones.Location = new System.Drawing.Point(0, 64);
			this.gbxOpciones.Name = "gbxOpciones";
			this.gbxOpciones.Size = new System.Drawing.Size(1310, 91);
			this.gbxOpciones.TabIndex = 15;
			this.gbxOpciones.TabStop = false;
			this.gbxOpciones.Text = "Opciones:";
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Location = new System.Drawing.Point(283, 36);
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
			this.btnELiminar.Location = new System.Drawing.Point(546, 36);
			this.btnELiminar.Name = "btnELiminar";
			this.btnELiminar.Size = new System.Drawing.Size(220, 50);
			this.btnELiminar.TabIndex = 2;
			this.btnELiminar.Text = "Eliminar";
			this.btnELiminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnELiminar.UseVisualStyleBackColor = false;
			this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
			// 
			// btnImportar
			// 
			this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImportar.Location = new System.Drawing.Point(809, 36);
			this.btnImportar.Name = "btnImportar";
			this.btnImportar.Size = new System.Drawing.Size(220, 50);
			this.btnImportar.TabIndex = 1;
			this.btnImportar.Text = "Importar";
			this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnImportar.UseVisualStyleBackColor = false;
			this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.Location = new System.Drawing.Point(20, 36);
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
			this.gbxDatos.Controls.Add(this.cbxUnidad);
			this.gbxDatos.Controls.Add(this.cbxProducto);
			this.gbxDatos.Controls.Add(this.nudCantidadEntregada);
			this.gbxDatos.Controls.Add(this.nudCantidadSolicitada);
			this.gbxDatos.Controls.Add(this.lblCantidadEntregada);
			this.gbxDatos.Controls.Add(this.lblCantidadSolicitada);
			this.gbxDatos.Controls.Add(this.lblUnidad);
			this.gbxDatos.Controls.Add(this.lblProducto);
			this.gbxDatos.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbxDatos.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.gbxDatos.Location = new System.Drawing.Point(0, 64);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(1310, 0);
			this.gbxDatos.TabIndex = 14;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos:";
			// 
			// cbxUnidad
			// 
			this.cbxUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxUnidad.FormattingEnabled = true;
			this.cbxUnidad.Location = new System.Drawing.Point(474, 35);
			this.cbxUnidad.Name = "cbxUnidad";
			this.cbxUnidad.Size = new System.Drawing.Size(235, 41);
			this.cbxUnidad.TabIndex = 9;
			// 
			// cbxProducto
			// 
			this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxProducto.FormattingEnabled = true;
			this.cbxProducto.Location = new System.Drawing.Point(120, 35);
			this.cbxProducto.Name = "cbxProducto";
			this.cbxProducto.Size = new System.Drawing.Size(235, 41);
			this.cbxProducto.TabIndex = 8;
			this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
			// 
			// nudCantidadEntregada
			// 
			this.nudCantidadEntregada.Location = new System.Drawing.Point(1187, 37);
			this.nudCantidadEntregada.Name = "nudCantidadEntregada";
			this.nudCantidadEntregada.Size = new System.Drawing.Size(120, 37);
			this.nudCantidadEntregada.TabIndex = 7;
			// 
			// nudCantidadSolicitada
			// 
			this.nudCantidadSolicitada.Location = new System.Drawing.Point(883, 37);
			this.nudCantidadSolicitada.Name = "nudCantidadSolicitada";
			this.nudCantidadSolicitada.Size = new System.Drawing.Size(120, 37);
			this.nudCantidadSolicitada.TabIndex = 7;
			// 
			// lblCantidadEntregada
			// 
			this.lblCantidadEntregada.AutoSize = true;
			this.lblCantidadEntregada.Location = new System.Drawing.Point(1008, 39);
			this.lblCantidadEntregada.Name = "lblCantidadEntregada";
			this.lblCantidadEntregada.Size = new System.Drawing.Size(174, 33);
			this.lblCantidadEntregada.TabIndex = 3;
			this.lblCantidadEntregada.Text = "Cantidad Ent.:";
			// 
			// lblCantidadSolicitada
			// 
			this.lblCantidadSolicitada.AutoSize = true;
			this.lblCantidadSolicitada.Location = new System.Drawing.Point(713, 39);
			this.lblCantidadSolicitada.Name = "lblCantidadSolicitada";
			this.lblCantidadSolicitada.Size = new System.Drawing.Size(165, 33);
			this.lblCantidadSolicitada.TabIndex = 3;
			this.lblCantidadSolicitada.Text = "Cantidad Sol.:";
			// 
			// lblUnidad
			// 
			this.lblUnidad.AutoSize = true;
			this.lblUnidad.Location = new System.Drawing.Point(365, 39);
			this.lblUnidad.Name = "lblUnidad";
			this.lblUnidad.Size = new System.Drawing.Size(103, 33);
			this.lblUnidad.TabIndex = 3;
			this.lblUnidad.Text = "Unidad:";
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.Location = new System.Drawing.Point(2, 39);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(118, 33);
			this.lblProducto.TabIndex = 3;
			this.lblProducto.Text = "Producto:";
			// 
			// pnlCabecera
			// 
			this.pnlCabecera.Controls.Add(this.lblCabecera);
			this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
			this.pnlCabecera.Name = "pnlCabecera";
			this.pnlCabecera.Size = new System.Drawing.Size(1310, 64);
			this.pnlCabecera.TabIndex = 13;
			// 
			// lblCabecera
			// 
			this.lblCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCabecera.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCabecera.Location = new System.Drawing.Point(0, 0);
			this.lblCabecera.Name = "lblCabecera";
			this.lblCabecera.Size = new System.Drawing.Size(1310, 64);
			this.lblCabecera.TabIndex = 0;
			this.lblCabecera.Text = "Compra de Insumos y Utilidades del pedido";
			this.lblCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnVisualizar
			// 
			this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVisualizar.Location = new System.Drawing.Point(1072, 36);
			this.btnVisualizar.Name = "btnVisualizar";
			this.btnVisualizar.Size = new System.Drawing.Size(220, 50);
			this.btnVisualizar.TabIndex = 1;
			this.btnVisualizar.Text = "Visualizar";
			this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVisualizar.UseVisualStyleBackColor = false;
			this.btnVisualizar.Click += new System.EventHandler(this.btnImportar_Click);
			// 
			// tablaCompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(1310, 621);
			this.Controls.Add(this.dgvCompra);
			this.Controls.Add(this.gbxOpciones);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.pnlCabecera);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "tablaCompras";
			this.Text = "tablaComras";
			((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
			this.gbxOpciones.ResumeLayout(false);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadEntregada)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadSolicitada)).EndInit();
			this.pnlCabecera.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCompra;
		private System.Windows.Forms.GroupBox gbxOpciones;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnELiminar;
		private System.Windows.Forms.Button btnImportar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.ComboBox cbxProducto;
		private System.Windows.Forms.NumericUpDown nudCantidadEntregada;
		private System.Windows.Forms.NumericUpDown nudCantidadSolicitada;
		private System.Windows.Forms.Label lblCantidadEntregada;
		private System.Windows.Forms.Label lblCantidadSolicitada;
		private System.Windows.Forms.Label lblUnidad;
		private System.Windows.Forms.Label lblProducto;
		private System.Windows.Forms.Panel pnlCabecera;
		private System.Windows.Forms.Label lblCabecera;
		private System.Windows.Forms.ComboBox cbxUnidad;
		private System.Windows.Forms.Button btnVisualizar;
	}
}
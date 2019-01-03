namespace Ul_Granos_y_Mas
{
	partial class Clientes
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblNombre = new System.Windows.Forms.Label();
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.lblNit = new System.Windows.Forms.Label();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.lblNombre2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.gbxOpciones = new System.Windows.Forms.GroupBox();
			this.btnEditar = new imageButton.buttonImage();
			this.btnEliminar = new imageButton.buttonImage();
			this.btnBuscar = new imageButton.buttonImage();
			this.btnNuevo = new imageButton.buttonImage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rbtNit = new System.Windows.Forms.RadioButton();
			this.rbtNombre = new System.Windows.Forms.RadioButton();
			this.pnlEspacio = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.gbxDatos.SuspendLayout();
			this.gbxOpciones.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblNombre);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1326, 64);
			this.panel1.TabIndex = 0;
			// 
			// lblNombre
			// 
			this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblNombre.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(0, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(1326, 64);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Clientes";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.lblNit);
			this.gbxDatos.Controls.Add(this.txtNit);
			this.gbxDatos.Controls.Add(this.lblNombre2);
			this.gbxDatos.Controls.Add(this.txtNombre);
			this.gbxDatos.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbxDatos.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.gbxDatos.Location = new System.Drawing.Point(0, 64);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(1326, 0);
			this.gbxDatos.TabIndex = 1;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos:";
			// 
			// lblNit
			// 
			this.lblNit.AutoSize = true;
			this.lblNit.Location = new System.Drawing.Point(740, 38);
			this.lblNit.Name = "lblNit";
			this.lblNit.Size = new System.Drawing.Size(61, 33);
			this.lblNit.TabIndex = 3;
			this.lblNit.Text = "Nit:";
			// 
			// txtNit
			// 
			this.txtNit.Location = new System.Drawing.Point(807, 36);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(235, 37);
			this.txtNit.TabIndex = 2;
			// 
			// lblNombre2
			// 
			this.lblNombre2.AutoSize = true;
			this.lblNombre2.Location = new System.Drawing.Point(311, 38);
			this.lblNombre2.Name = "lblNombre2";
			this.lblNombre2.Size = new System.Drawing.Size(104, 33);
			this.lblNombre2.TabIndex = 1;
			this.lblNombre2.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(421, 36);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(235, 37);
			this.txtNombre.TabIndex = 0;
			// 
			// gbxOpciones
			// 
			this.gbxOpciones.Controls.Add(this.btnEditar);
			this.gbxOpciones.Controls.Add(this.btnEliminar);
			this.gbxOpciones.Controls.Add(this.btnBuscar);
			this.gbxOpciones.Controls.Add(this.btnNuevo);
			this.gbxOpciones.Controls.Add(this.panel3);
			this.gbxOpciones.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbxOpciones.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.gbxOpciones.Location = new System.Drawing.Point(0, 64);
			this.gbxOpciones.Name = "gbxOpciones";
			this.gbxOpciones.Size = new System.Drawing.Size(1326, 91);
			this.gbxOpciones.TabIndex = 3;
			this.gbxOpciones.TabStop = false;
			this.gbxOpciones.Text = "Opciones:";
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(18)))));
			this.btnEditar.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.editarSF;
			this.btnEditar.Image = global::Ul_Granos_y_Mas.Properties.Resources.editarNF;
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(955, 35);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnEditar.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.editarNF;
			this.btnEditar.Size = new System.Drawing.Size(220, 50);
			this.btnEditar.TabIndex = 6;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(18)))));
			this.btnEliminar.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.borrarSF;
			this.btnEliminar.Image = global::Ul_Granos_y_Mas.Properties.Resources.borrarNF;
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(685, 35);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnEliminar.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.borrarNF;
			this.btnEliminar.Size = new System.Drawing.Size(220, 50);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(18)))));
			this.btnBuscar.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.BuscarR;
			this.btnBuscar.Image = global::Ul_Granos_y_Mas.Properties.Resources.BuscarN;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(421, 36);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnBuscar.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.BuscarN;
			this.btnBuscar.Size = new System.Drawing.Size(220, 50);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(18)))));
			this.btnNuevo.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.guardarSF1;
			this.btnNuevo.Image = global::Ul_Granos_y_Mas.Properties.Resources.guardarNF;
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(159, 36);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnNuevo.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.guardarNF;
			this.btnNuevo.Size = new System.Drawing.Size(220, 50);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.panel3.Controls.Add(this.rbtNit);
			this.panel3.Controls.Add(this.rbtNombre);
			this.panel3.Controls.Add(this.pnlEspacio);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel3.Location = new System.Drawing.Point(440, 81);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 100);
			this.panel3.TabIndex = 5;
			this.panel3.Visible = false;
			// 
			// rbtNit
			// 
			this.rbtNit.AutoSize = true;
			this.rbtNit.Dock = System.Windows.Forms.DockStyle.Top;
			this.rbtNit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtNit.Location = new System.Drawing.Point(34, 55);
			this.rbtNit.Name = "rbtNit";
			this.rbtNit.Size = new System.Drawing.Size(166, 29);
			this.rbtNit.TabIndex = 8;
			this.rbtNit.TabStop = true;
			this.rbtNit.Text = "Nit";
			this.rbtNit.UseVisualStyleBackColor = true;
			this.rbtNit.Click += new System.EventHandler(this.rbtNit_Click);
			// 
			// rbtNombre
			// 
			this.rbtNombre.AutoSize = true;
			this.rbtNombre.Dock = System.Windows.Forms.DockStyle.Top;
			this.rbtNombre.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtNombre.Location = new System.Drawing.Point(34, 26);
			this.rbtNombre.Name = "rbtNombre";
			this.rbtNombre.Size = new System.Drawing.Size(166, 29);
			this.rbtNombre.TabIndex = 7;
			this.rbtNombre.TabStop = true;
			this.rbtNombre.Text = "Nombre";
			this.rbtNombre.UseVisualStyleBackColor = true;
			this.rbtNombre.Click += new System.EventHandler(this.rbtNombre_Click);
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 26);
			this.label4.TabIndex = 0;
			this.label4.Text = "Buscar por:";
			// 
			// dgvClientes
			// 
			this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
			this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvClientes.Location = new System.Drawing.Point(0, 155);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.Size = new System.Drawing.Size(1326, 505);
			this.dgvClientes.TabIndex = 4;
			// 
			// Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(1326, 660);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.gbxOpciones);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Clientes";
			this.Text = "Clientes ";
			this.panel1.ResumeLayout(false);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			this.gbxOpciones.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.Label lblNit;
		private System.Windows.Forms.TextBox txtNit;
		private System.Windows.Forms.Label lblNombre2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.GroupBox gbxOpciones;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rbtNit;
		private System.Windows.Forms.RadioButton rbtNombre;
		private System.Windows.Forms.Panel pnlEspacio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvClientes;
		private imageButton.buttonImage btnEditar;
		private imageButton.buttonImage btnEliminar;
		private imageButton.buttonImage btnBuscar;
		private imageButton.buttonImage btnNuevo;
	}
}
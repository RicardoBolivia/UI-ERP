namespace Ul_Granos_y_Mas
{
	partial class FormImportar
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
			this.pnlFormPadre = new System.Windows.Forms.Panel();
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pnlCabecera = new System.Windows.Forms.Panel();
			this.gbxOpciones = new System.Windows.Forms.GroupBox();
			this.dgvImportar = new System.Windows.Forms.DataGridView();
			this.btnCancelar = new imageButton.buttonImage();
			this.btnImportar = new imageButton.buttonImage();
			this.btnAceptar = new imageButton.buttonImage();
			this.otbLogo = new System.Windows.Forms.PictureBox();
			this.pnlFormPadre.SuspendLayout();
			this.pnlLogo.SuspendLayout();
			this.pnlCabecera.SuspendLayout();
			this.gbxOpciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvImportar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.otbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlFormPadre
			// 
			this.pnlFormPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlFormPadre.Controls.Add(this.dgvImportar);
			this.pnlFormPadre.Controls.Add(this.gbxOpciones);
			this.pnlFormPadre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlFormPadre.Location = new System.Drawing.Point(0, 45);
			this.pnlFormPadre.Name = "pnlFormPadre";
			this.pnlFormPadre.Size = new System.Drawing.Size(800, 405);
			this.pnlFormPadre.TabIndex = 6;
			// 
			// pnlLogo
			// 
			this.pnlLogo.Controls.Add(this.lblTitulo);
			this.pnlLogo.Controls.Add(this.otbLogo);
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(189, 45);
			this.pnlLogo.TabIndex = 13;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Bold);
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
			this.lblTitulo.Location = new System.Drawing.Point(41, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(148, 45);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Granos y mas";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlCabecera
			// 
			this.pnlCabecera.BackColor = System.Drawing.Color.Black;
			this.pnlCabecera.Controls.Add(this.pnlLogo);
			this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
			this.pnlCabecera.Name = "pnlCabecera";
			this.pnlCabecera.Size = new System.Drawing.Size(800, 45);
			this.pnlCabecera.TabIndex = 5;
			this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
			// 
			// gbxOpciones
			// 
			this.gbxOpciones.Controls.Add(this.btnImportar);
			this.gbxOpciones.Controls.Add(this.btnCancelar);
			this.gbxOpciones.Controls.Add(this.btnAceptar);
			this.gbxOpciones.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbxOpciones.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.gbxOpciones.Location = new System.Drawing.Point(0, 0);
			this.gbxOpciones.Name = "gbxOpciones";
			this.gbxOpciones.Size = new System.Drawing.Size(798, 91);
			this.gbxOpciones.TabIndex = 16;
			this.gbxOpciones.TabStop = false;
			this.gbxOpciones.Text = "Opciones:";
			// 
			// dgvImportar
			// 
			this.dgvImportar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
			this.dgvImportar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvImportar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvImportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvImportar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvImportar.Location = new System.Drawing.Point(0, 91);
			this.dgvImportar.Name = "dgvImportar";
			this.dgvImportar.Size = new System.Drawing.Size(798, 312);
			this.dgvImportar.TabIndex = 19;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(18)))));
			this.btnCancelar.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.cancelG;
			this.btnCancelar.Image = global::Ul_Granos_y_Mas.Properties.Resources.cancelN;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(291, 35);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnCancelar.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.cancelN;
			this.btnCancelar.Size = new System.Drawing.Size(220, 50);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
			// 
			// btnImportar
			// 
			this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImportar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(18)))));
			this.btnImportar.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.importarG;
			this.btnImportar.Image = global::Ul_Granos_y_Mas.Properties.Resources.importarN;
			this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImportar.Location = new System.Drawing.Point(570, 35);
			this.btnImportar.Name = "btnImportar";
			this.btnImportar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnImportar.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.importarN;
			this.btnImportar.Size = new System.Drawing.Size(220, 50);
			this.btnImportar.TabIndex = 5;
			this.btnImportar.Text = "Importar";
			this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnImportar.UseVisualStyleBackColor = false;
			this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(18)))));
			this.btnAceptar.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.aceptarG;
			this.btnAceptar.Image = global::Ul_Granos_y_Mas.Properties.Resources.aceptarN;
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(12, 35);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnAceptar.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.aceptarN;
			this.btnAceptar.Size = new System.Drawing.Size(220, 50);
			this.btnAceptar.TabIndex = 5;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
			// 
			// otbLogo
			// 
			this.otbLogo.Dock = System.Windows.Forms.DockStyle.Left;
			this.otbLogo.Image = global::Ul_Granos_y_Mas.Properties.Resources.logoSolo;
			this.otbLogo.Location = new System.Drawing.Point(0, 0);
			this.otbLogo.Name = "otbLogo";
			this.otbLogo.Size = new System.Drawing.Size(41, 45);
			this.otbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.otbLogo.TabIndex = 0;
			this.otbLogo.TabStop = false;
			// 
			// FormImportar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlFormPadre);
			this.Controls.Add(this.pnlCabecera);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormImportar";
			this.Text = "FormImportar";
			this.pnlFormPadre.ResumeLayout(false);
			this.pnlLogo.ResumeLayout(false);
			this.pnlCabecera.ResumeLayout(false);
			this.gbxOpciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvImportar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.otbLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlFormPadre;
		private System.Windows.Forms.DataGridView dgvImportar;
		private System.Windows.Forms.GroupBox gbxOpciones;
		private imageButton.buttonImage btnAceptar;
		private System.Windows.Forms.Panel pnlLogo;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox otbLogo;
		private System.Windows.Forms.Panel pnlCabecera;
		private imageButton.buttonImage btnImportar;
		private imageButton.buttonImage btnCancelar;
	}
}
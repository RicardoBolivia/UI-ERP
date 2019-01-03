namespace Ul_Granos_y_Mas
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.lblLema = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.pnlCabecera = new System.Windows.Forms.Panel();
			this.pnlFormPadre = new System.Windows.Forms.Panel();
			this.tmrTransicion = new System.Windows.Forms.Timer(this.components);
			this.cibMinimizar = new MyImageButton.CustomImageButton();
			this.cibEspacio1 = new MyImageButton.CustomImageButton();
			this.cibCerrar = new MyImageButton.CustomImageButton();
			this.cibEspacio0 = new MyImageButton.CustomImageButton();
			this.cibMenu = new MyImageButton.CustomImageButton();
			this.pcbPestaña = new System.Windows.Forms.PictureBox();
			this.pcbLogo = new System.Windows.Forms.PictureBox();
			this.btnGrafica = new imageButton.buttonImage();
			this.btnInicio = new imageButton.buttonImage();
			this.btbBolsas = new imageButton.buttonImage();
			this.btnCalculadora = new imageButton.buttonImage();
			this.btnCliente = new imageButton.buttonImage();
			this.btnProducto = new imageButton.buttonImage();
			this.btnNotas = new imageButton.buttonImage();
			this.btnTablas = new imageButton.buttonImage();
			this.btnManual = new imageButton.buttonImage();
			this.btnAcercaDe = new imageButton.buttonImage();
			this.pnlMenu.SuspendLayout();
			this.pnlCabecera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cibMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cibEspacio1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cibCerrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cibEspacio0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cibMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbPestaña)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.Black;
			this.pnlMenu.Controls.Add(this.btnGrafica);
			this.pnlMenu.Controls.Add(this.pcbPestaña);
			this.pnlMenu.Controls.Add(this.btnInicio);
			this.pnlMenu.Controls.Add(this.btbBolsas);
			this.pnlMenu.Controls.Add(this.btnCalculadora);
			this.pnlMenu.Controls.Add(this.btnCliente);
			this.pnlMenu.Controls.Add(this.btnProducto);
			this.pnlMenu.Controls.Add(this.btnNotas);
			this.pnlMenu.Controls.Add(this.btnTablas);
			this.pnlMenu.Controls.Add(this.lblLema);
			this.pnlMenu.Controls.Add(this.lblNombre);
			this.pnlMenu.Controls.Add(this.pcbLogo);
			this.pnlMenu.Controls.Add(this.btnManual);
			this.pnlMenu.Controls.Add(this.btnAcercaDe);
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(260, 705);
			this.pnlMenu.TabIndex = 1;
			// 
			// lblLema
			// 
			this.lblLema.AutoSize = true;
			this.lblLema.Font = new System.Drawing.Font("Stencil", 6.25F);
			this.lblLema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblLema.Location = new System.Drawing.Point(100, 33);
			this.lblLema.Name = "lblLema";
			this.lblLema.Size = new System.Drawing.Size(157, 10);
			this.lblLema.TabIndex = 10;
			this.lblLema.Text = "!Comprometidos con la calidad!";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblNombre.Location = new System.Drawing.Point(52, 6);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(212, 34);
			this.lblNombre.TabIndex = 9;
			this.lblNombre.Text = "GRANOS Y MAS";
			// 
			// pnlCabecera
			// 
			this.pnlCabecera.BackColor = System.Drawing.Color.Black;
			this.pnlCabecera.Controls.Add(this.cibMinimizar);
			this.pnlCabecera.Controls.Add(this.cibEspacio1);
			this.pnlCabecera.Controls.Add(this.cibCerrar);
			this.pnlCabecera.Controls.Add(this.cibEspacio0);
			this.pnlCabecera.Controls.Add(this.cibMenu);
			this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCabecera.Location = new System.Drawing.Point(260, 0);
			this.pnlCabecera.Name = "pnlCabecera";
			this.pnlCabecera.Size = new System.Drawing.Size(1106, 45);
			this.pnlCabecera.TabIndex = 3;
			// 
			// pnlFormPadre
			// 
			this.pnlFormPadre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlFormPadre.Location = new System.Drawing.Point(260, 45);
			this.pnlFormPadre.Name = "pnlFormPadre";
			this.pnlFormPadre.Size = new System.Drawing.Size(1106, 660);
			this.pnlFormPadre.TabIndex = 4;
			// 
			// tmrTransicion
			// 
			this.tmrTransicion.Enabled = true;
			this.tmrTransicion.Interval = 5;
			this.tmrTransicion.Tick += new System.EventHandler(this.tmrTransicion_Tick);
			// 
			// cibMinimizar
			// 
			this.cibMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
			this.cibMinimizar.Image = global::Ul_Granos_y_Mas.Properties.Resources.MinimizarSF;
			this.cibMinimizar.ImageHover = global::Ul_Granos_y_Mas.Properties.Resources.MinimizarNF;
			this.cibMinimizar.ImageNormal = global::Ul_Granos_y_Mas.Properties.Resources.MinimizarSF;
			this.cibMinimizar.Location = new System.Drawing.Point(1010, 0);
			this.cibMinimizar.Name = "cibMinimizar";
			this.cibMinimizar.Size = new System.Drawing.Size(38, 45);
			this.cibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.cibMinimizar.TabIndex = 12;
			this.cibMinimizar.TabStop = false;
			this.cibMinimizar.Click += new System.EventHandler(this.cibMinimizar_Click);
			// 
			// cibEspacio1
			// 
			this.cibEspacio1.Dock = System.Windows.Forms.DockStyle.Right;
			this.cibEspacio1.ImageHover = null;
			this.cibEspacio1.ImageNormal = null;
			this.cibEspacio1.Location = new System.Drawing.Point(1048, 0);
			this.cibEspacio1.Name = "cibEspacio1";
			this.cibEspacio1.Size = new System.Drawing.Size(10, 45);
			this.cibEspacio1.TabIndex = 9;
			this.cibEspacio1.TabStop = false;
			// 
			// cibCerrar
			// 
			this.cibCerrar.Dock = System.Windows.Forms.DockStyle.Right;
			this.cibCerrar.Image = global::Ul_Granos_y_Mas.Properties.Resources.CerrarNF;
			this.cibCerrar.ImageHover = global::Ul_Granos_y_Mas.Properties.Resources.CerrarSF;
			this.cibCerrar.ImageNormal = global::Ul_Granos_y_Mas.Properties.Resources.CerrarNF;
			this.cibCerrar.Location = new System.Drawing.Point(1058, 0);
			this.cibCerrar.Name = "cibCerrar";
			this.cibCerrar.Size = new System.Drawing.Size(38, 45);
			this.cibCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.cibCerrar.TabIndex = 8;
			this.cibCerrar.TabStop = false;
			this.cibCerrar.Click += new System.EventHandler(this.cibCerrar_Click);
			// 
			// cibEspacio0
			// 
			this.cibEspacio0.Dock = System.Windows.Forms.DockStyle.Right;
			this.cibEspacio0.ImageHover = null;
			this.cibEspacio0.ImageNormal = null;
			this.cibEspacio0.Location = new System.Drawing.Point(1096, 0);
			this.cibEspacio0.Name = "cibEspacio0";
			this.cibEspacio0.Size = new System.Drawing.Size(10, 45);
			this.cibEspacio0.TabIndex = 7;
			this.cibEspacio0.TabStop = false;
			// 
			// cibMenu
			// 
			this.cibMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.cibMenu.Image = global::Ul_Granos_y_Mas.Properties.Resources.MenuNF;
			this.cibMenu.ImageHover = global::Ul_Granos_y_Mas.Properties.Resources.MenuSF;
			this.cibMenu.ImageNormal = global::Ul_Granos_y_Mas.Properties.Resources.MenuNF;
			this.cibMenu.Location = new System.Drawing.Point(0, 0);
			this.cibMenu.Name = "cibMenu";
			this.cibMenu.Size = new System.Drawing.Size(41, 45);
			this.cibMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.cibMenu.TabIndex = 6;
			this.cibMenu.TabStop = false;
			this.cibMenu.Click += new System.EventHandler(this.cibMenu_Click);
			// 
			// pcbPestaña
			// 
			this.pcbPestaña.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pcbPestaña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
			this.pcbPestaña.Location = new System.Drawing.Point(0, 89);
			this.pcbPestaña.Name = "pcbPestaña";
			this.pcbPestaña.Size = new System.Drawing.Size(7, 50);
			this.pcbPestaña.TabIndex = 29;
			this.pcbPestaña.TabStop = false;
			// 
			// pcbLogo
			// 
			this.pcbLogo.BackgroundImage = global::Ul_Granos_y_Mas.Properties.Resources.logoTransparente;
			this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pcbLogo.Image = global::Ul_Granos_y_Mas.Properties.Resources.logoSolo;
			this.pcbLogo.Location = new System.Drawing.Point(1, 1);
			this.pcbLogo.Name = "pcbLogo";
			this.pcbLogo.Size = new System.Drawing.Size(50, 45);
			this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbLogo.TabIndex = 0;
			this.pcbLogo.TabStop = false;
			// 
			// btnGrafica
			// 
			this.btnGrafica.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnGrafica.BackColor = System.Drawing.Color.Black;
			this.btnGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGrafica.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnGrafica.ForeColor = System.Drawing.SystemColors.Control;
			this.btnGrafica.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnGrafica.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.GraficasSF;
			this.btnGrafica.Image = global::Ul_Granos_y_Mas.Properties.Resources.GraficasNF;
			this.btnGrafica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGrafica.Location = new System.Drawing.Point(1, 439);
			this.btnGrafica.Name = "btnGrafica";
			this.btnGrafica.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.GraficasNF;
			this.btnGrafica.Size = new System.Drawing.Size(260, 50);
			this.btnGrafica.TabIndex = 33;
			this.btnGrafica.Text = "Grafica y Estadistica";
			this.btnGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGrafica.UseVisualStyleBackColor = false;
			// 
			// btnInicio
			// 
			this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnInicio.BackColor = System.Drawing.Color.Black;
			this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInicio.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnInicio.ForeColor = System.Drawing.SystemColors.Control;
			this.btnInicio.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnInicio.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.InicioSF;
			this.btnInicio.Image = global::Ul_Granos_y_Mas.Properties.Resources.InicioNF;
			this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInicio.Location = new System.Drawing.Point(1, 89);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.InicioNF;
			this.btnInicio.Size = new System.Drawing.Size(260, 50);
			this.btnInicio.TabIndex = 32;
			this.btnInicio.Text = "Inicio";
			this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInicio.UseVisualStyleBackColor = false;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btbBolsas
			// 
			this.btbBolsas.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btbBolsas.BackColor = System.Drawing.Color.Black;
			this.btbBolsas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btbBolsas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btbBolsas.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btbBolsas.ForeColor = System.Drawing.SystemColors.Control;
			this.btbBolsas.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btbBolsas.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.BolsasSF;
			this.btbBolsas.Image = global::Ul_Granos_y_Mas.Properties.Resources.BolsasNF;
			this.btbBolsas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btbBolsas.Location = new System.Drawing.Point(1, 139);
			this.btbBolsas.Name = "btbBolsas";
			this.btbBolsas.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.BolsasNF;
			this.btbBolsas.Size = new System.Drawing.Size(260, 50);
			this.btbBolsas.TabIndex = 32;
			this.btbBolsas.Text = "Bolsas";
			this.btbBolsas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btbBolsas.UseVisualStyleBackColor = false;
			// 
			// btnCalculadora
			// 
			this.btnCalculadora.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnCalculadora.BackColor = System.Drawing.Color.Black;
			this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCalculadora.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnCalculadora.ForeColor = System.Drawing.SystemColors.Control;
			this.btnCalculadora.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnCalculadora.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.CalculadoraSF;
			this.btnCalculadora.Image = global::Ul_Granos_y_Mas.Properties.Resources.CalculadoraNF;
			this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCalculadora.Location = new System.Drawing.Point(1, 189);
			this.btnCalculadora.Name = "btnCalculadora";
			this.btnCalculadora.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.CalculadoraNF;
			this.btnCalculadora.Size = new System.Drawing.Size(260, 50);
			this.btnCalculadora.TabIndex = 32;
			this.btnCalculadora.Text = "Calculadora";
			this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCalculadora.UseVisualStyleBackColor = false;
			// 
			// btnCliente
			// 
			this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnCliente.BackColor = System.Drawing.Color.Black;
			this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCliente.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnCliente.ForeColor = System.Drawing.SystemColors.Control;
			this.btnCliente.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnCliente.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.ClientesSF;
			this.btnCliente.Image = global::Ul_Granos_y_Mas.Properties.Resources.ClientesNF;
			this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCliente.Location = new System.Drawing.Point(1, 239);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.ClientesNF;
			this.btnCliente.Size = new System.Drawing.Size(260, 50);
			this.btnCliente.TabIndex = 32;
			this.btnCliente.Text = "Cliente";
			this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCliente.UseVisualStyleBackColor = false;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
			// 
			// btnProducto
			// 
			this.btnProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnProducto.BackColor = System.Drawing.Color.Black;
			this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnProducto.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnProducto.ForeColor = System.Drawing.SystemColors.Control;
			this.btnProducto.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnProducto.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.ProductoSF;
			this.btnProducto.Image = global::Ul_Granos_y_Mas.Properties.Resources.ProductoNF;
			this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducto.Location = new System.Drawing.Point(1, 289);
			this.btnProducto.Name = "btnProducto";
			this.btnProducto.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.ProductoNF;
			this.btnProducto.Size = new System.Drawing.Size(260, 50);
			this.btnProducto.TabIndex = 32;
			this.btnProducto.Text = "Producto";
			this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProducto.UseVisualStyleBackColor = false;
			this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click_1);
			// 
			// btnNotas
			// 
			this.btnNotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnNotas.BackColor = System.Drawing.Color.Black;
			this.btnNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNotas.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnNotas.ForeColor = System.Drawing.SystemColors.Control;
			this.btnNotas.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnNotas.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.notasDeEntregaSF;
			this.btnNotas.Image = global::Ul_Granos_y_Mas.Properties.Resources.notasDeEntregaNF;
			this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNotas.Location = new System.Drawing.Point(1, 339);
			this.btnNotas.Name = "btnNotas";
			this.btnNotas.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.notasDeEntregaNF;
			this.btnNotas.Size = new System.Drawing.Size(260, 50);
			this.btnNotas.TabIndex = 32;
			this.btnNotas.Text = "Notas de entrega";
			this.btnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNotas.UseVisualStyleBackColor = false;
			// 
			// btnTablas
			// 
			this.btnTablas.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnTablas.BackColor = System.Drawing.Color.Black;
			this.btnTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnTablas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnTablas.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnTablas.ForeColor = System.Drawing.SystemColors.Control;
			this.btnTablas.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnTablas.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.CompraSFs;
			this.btnTablas.Image = global::Ul_Granos_y_Mas.Properties.Resources.ComprasNF;
			this.btnTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTablas.Location = new System.Drawing.Point(1, 389);
			this.btnTablas.Name = "btnTablas";
			this.btnTablas.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.ComprasNF;
			this.btnTablas.Size = new System.Drawing.Size(260, 50);
			this.btnTablas.TabIndex = 32;
			this.btnTablas.Text = "Tabla de Com. y Gan.";
			this.btnTablas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTablas.UseVisualStyleBackColor = false;
			this.btnTablas.Click += new System.EventHandler(this.btnTablas_Click);
			// 
			// btnManual
			// 
			this.btnManual.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnManual.BackColor = System.Drawing.Color.Black;
			this.btnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnManual.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnManual.ForeColor = System.Drawing.SystemColors.Control;
			this.btnManual.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnManual.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.manualSF;
			this.btnManual.Image = global::Ul_Granos_y_Mas.Properties.Resources.manualNF;
			this.btnManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnManual.Location = new System.Drawing.Point(0, 601);
			this.btnManual.Name = "btnManual";
			this.btnManual.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.manualNF;
			this.btnManual.Size = new System.Drawing.Size(260, 50);
			this.btnManual.TabIndex = 32;
			this.btnManual.Text = "Manual";
			this.btnManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnManual.UseVisualStyleBackColor = false;
			this.btnManual.Click += new System.EventHandler(this.btnTablas_Click);
			// 
			// btnAcercaDe
			// 
			this.btnAcercaDe.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnAcercaDe.BackColor = System.Drawing.Color.Black;
			this.btnAcercaDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAcercaDe.Font = new System.Drawing.Font("Miriam CLM", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnAcercaDe.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAcercaDe.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(20)))));
			this.btnAcercaDe.HoverImage = global::Ul_Granos_y_Mas.Properties.Resources.informacionSF;
			this.btnAcercaDe.Image = global::Ul_Granos_y_Mas.Properties.Resources.informacionNF;
			this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAcercaDe.Location = new System.Drawing.Point(0, 651);
			this.btnAcercaDe.Name = "btnAcercaDe";
			this.btnAcercaDe.NormalImage = global::Ul_Granos_y_Mas.Properties.Resources.informacionNF;
			this.btnAcercaDe.Size = new System.Drawing.Size(260, 50);
			this.btnAcercaDe.TabIndex = 32;
			this.btnAcercaDe.Text = "Acerca De";
			this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAcercaDe.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(1366, 705);
			this.Controls.Add(this.pnlFormPadre);
			this.Controls.Add(this.pnlCabecera);
			this.Controls.Add(this.pnlMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlMenu.ResumeLayout(false);
			this.pnlMenu.PerformLayout();
			this.pnlCabecera.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cibMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cibEspacio1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cibCerrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cibEspacio0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cibMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbPestaña)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.PictureBox pcbLogo;
		private System.Windows.Forms.Panel pnlMenu;
		private System.Windows.Forms.Label lblLema;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Panel pnlCabecera;
		private System.Windows.Forms.Panel pnlFormPadre;
		private MyImageButton.CustomImageButton cibMenu;
		private MyImageButton.CustomImageButton cibMinimizar;
		private MyImageButton.CustomImageButton cibEspacio1;
		private MyImageButton.CustomImageButton cibCerrar;
		private MyImageButton.CustomImageButton cibEspacio0;
		private System.Windows.Forms.Timer tmrTransicion;
		private System.Windows.Forms.PictureBox pcbPestaña;
		private imageButton.buttonImage btnInicio;
		private imageButton.buttonImage btbBolsas;
		private imageButton.buttonImage btnCalculadora;
		private imageButton.buttonImage btnCliente;
		private imageButton.buttonImage btnProducto;
		private imageButton.buttonImage btnNotas;
		private imageButton.buttonImage btnTablas;
		private imageButton.buttonImage btnAcercaDe;
		private imageButton.buttonImage btnManual;
		private imageButton.buttonImage btnGrafica;
	}
}


using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ul_Granos_y_Mas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
		}
		private int R = 255;   
		private int B = 0;   
		private int G = 0;
	
		private void cibMenu_Click(object sender, EventArgs e)
		{
			if (pnlMenu.Width == 260)
				pnlMenu.Width = 50;
			else
				pnlMenu.Width = 260;
		}

		private void cibCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cibMinimizar_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void tmrTransicion_Tick(object sender, EventArgs e)
		{
			if (R == 255)
				B = B + 1;
			if (B == 252)
			{
				R = R - 1;
				if (R == 5)
				{
					R = 6;
					B = 252;
				}
			}
			if (R == 6 & B == 252)
				G = G + 1; 
			if (G == 252)
			{
				B = B - 1;
				if (B == 5)
					B = 6;
			}
			if (B == 6 & G == 252)
				R = R + 1;
			if (R == 252 & B == 6)
			{
				G = G - 1;
				if (G == 5)
					G = 6;
			}
			if (G == 6 & B == 6)
			{
				R = 255;
				G = 0;
				B = 0;
			}
			lblLema.ForeColor = Color.FromArgb(R, G, B);
			lblNombre.ForeColor = Color.FromArgb(R, G, B);
		}
		private void AbrirFormInPanel(object formHijo)
		{
			if (this.pnlFormPadre.Controls.Count > 0)
				this.pnlFormPadre.Controls.RemoveAt(0);
			Form fh = formHijo as Form;
			fh.TopLevel = false;
			fh.FormBorderStyle = FormBorderStyle.None;
			fh.Dock = DockStyle.Fill;
			this.pnlFormPadre.Controls.Add(fh);
			this.pnlFormPadre.Tag = fh;
			fh.Show();
		}
		private void btnBolsa_Click(object sender, EventArgs e)
		{
			
		}

		private void cibBolsas_Click(object sender, EventArgs e)
		{
			
		}

		private void btnCliente_Click(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y != cibCliente.Location.Y)
			{
				AbrirFormInPanel(new Clientes());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, cibCliente.Location.Y);
				pnlMenu.Width = 50;
			}
		}

		private void cibCliente_Click(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y != cibCliente.Location.Y)
			{
				AbrirFormInPanel(new Clientes());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, cibCliente.Location.Y);
				pnlMenu.Width = 50;
			}
		}
			private void Form1_Load(object sender, EventArgs e)
		{
			Conexion cn = new Conexion();
			if (!cn.Conectar())
				System.Diagnostics.Process.Start("C:/wamp/wampmanager.exe");
		}

		private void btnProducto_Click(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y != cibProducto.Location.Y)
			{
				AbrirFormInPanel(new Productos());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, cibProducto.Location.Y);
				pnlMenu.Width = 50;
			}
		}

		private void cibProducto_Click(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y != cibProducto.Location.Y)
			{
				AbrirFormInPanel(new Productos());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, cibProducto.Location.Y);
				pnlMenu.Width = 50;
			}
		}

		private void btnTabla_Click(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y != cibTabla.Location.Y)
			{
				AbrirFormInPanel(new Compra_de_insumos());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, cibTabla.Location.Y);
				pnlMenu.Width = 50;
			}
		}

		private void cibTabla_Click(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y!= cibTabla.Location.Y)
			{
				AbrirFormInPanel(new Compra_de_insumos());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, cibTabla.Location.Y);
				pnlMenu.Width = 50;
			}			
		}
	}
}

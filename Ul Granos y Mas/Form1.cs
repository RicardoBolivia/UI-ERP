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
			CambioPanel.pnlFormPadre = this.pnlFormPadre;
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
		private void Form1_Load(object sender, EventArgs e)
		{
			Conexion cn = new Conexion();
			if (!cn.Conectar())
				System.Diagnostics.Process.Start("C:/wamp/wampmanager.exe");
		}

		private void btnInicio_Click(object sender, EventArgs e)
		{

		}

		private void btnCliente_Click_1(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y != btnInicio.Location.Y && pcbPestaña.Location.Y != btnCliente.Location.Y)
			{
				DialogResult resp = MessageBox.Show("Esta seguro de cambiar de pestaña, todos los datos que no se guardaron se eliminaran", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (resp == DialogResult.Yes)
				{
					AbrirFormInPanel(new Clientes());
					pcbPestaña.Location = new Point(pcbPestaña.Location.X, btnCliente.Location.Y);
					pnlMenu.Width = 50;
				}
			}
			else
			{
				AbrirFormInPanel(new Clientes());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, btnCliente.Location.Y);
				pnlMenu.Width = 50;
			}
		}

		private void btnProducto_Click_1(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y != btnInicio.Location.Y && pcbPestaña.Location.Y != btnProducto.Location.Y)
			{
				DialogResult resp =  MessageBox.Show("Esta seguro de cambiar de pestaña, todos los datos que no se guardaron se eliminaran", "Granos y Mas", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (resp == DialogResult.Yes)
				{
					AbrirFormInPanel(new Productos());
					pcbPestaña.Location = new Point(pcbPestaña.Location.X, btnProducto.Location.Y);
					pnlMenu.Width = 50;
				}
			}
			else
			{
				AbrirFormInPanel(new Productos());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, btnProducto.Location.Y);
				pnlMenu.Width = 50;
			}
		}

		private void btnTablas_Click(object sender, EventArgs e)
		{
			if (pcbPestaña.Location.Y != btnInicio.Location.Y && pcbPestaña.Location.Y != btnTablas.Location.Y)
			{
				DialogResult resp = MessageBox.Show("Esta seguro de cambiar de pestaña, todos los datos que no se guardaron se eliminaran", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (resp == DialogResult.Yes)
				{
					AbrirFormInPanel(new Compra_de_insumos());
					pcbPestaña.Location = new Point(pcbPestaña.Location.X, btnTablas.Location.Y);
					pnlMenu.Width = 50;
				}
			}
			else
			{
				AbrirFormInPanel(new Compra_de_insumos());
				pcbPestaña.Location = new Point(pcbPestaña.Location.X, btnTablas.Location.Y);
				pnlMenu.Width = 50;
			} 
		}
	}
}

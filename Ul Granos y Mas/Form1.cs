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
        }
		private int R = 255;   
		private int B = 0;   
		private int G = 0;
		private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void cibMenu_Click(object sender, EventArgs e)
		{
			if (pnlMenu.Width == 260)
				pnlMenu.Width = 50;
			else
				pnlMenu.Width = 260;
		}

		private void cibCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cibMaximizar_Click(object sender, EventArgs e)
		{
			if (cibMaximizar.Image == Properties.Resources.maximizarSF)
			{
				cibMaximizar.Image = Properties.Resources.restaurarNF;
				cibMaximizar.ImageHover = Properties.Resources.restaurarSF;
				cibMaximizar.ImageNormal = Properties.Resources.restaurarNF;
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				cibMaximizar.Image = Properties.Resources.maximizarNF;
				cibMaximizar.ImageHover = Properties.Resources.maximizarSF;
				cibMaximizar.ImageNormal = Properties.Resources.maximizarNF;
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void cibMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
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
	}
}

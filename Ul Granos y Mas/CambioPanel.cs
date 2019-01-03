using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ul_Granos_y_Mas
{
	public class CambioPanel
	{
		public static Panel pnlFormPadre;
		public CambioPanel(object formHijo)
		{
			AbrirFormInPanel(formHijo, pnlFormPadre);
		}
		private void AbrirFormInPanel(object formHijo, Panel padre)
		{
			if (padre.Controls.Count > 0)
				padre.Controls.RemoveAt(0);
			Form fh = formHijo as Form;
			fh.TopLevel = false;
			fh.FormBorderStyle = FormBorderStyle.None;
			fh.Dock = DockStyle.Fill;
			padre.Controls.Add(fh);
			padre.Tag = fh;
			fh.Show();
		}
	}
}

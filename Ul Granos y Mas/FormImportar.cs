using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ul_Granos_y_Mas
{
	public partial class FormImportar : Form
	{
		Conexion fn = new Conexion();
		string idCliente;
		string idCabecera;
		public FormImportar(string idCliente, string idCabecera)
		{
			this.idCliente = idCliente;
			this.idCabecera = idCabecera;
			InitializeComponent();
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Archivos de Excel (*.xls;*.xlsx;*.xlsm)|*.xls;*.xlsx;*.xlsm";
			dialog.FileName = string.Empty;
			dialog.Title = "Importar datos desde Excel";
			try
			{
				if (dialog.ShowDialog() == DialogResult.OK)
					dgvImportar.DataSource = retornetExcel(dialog.FileName);
			}
			catch { }
		}

		private DataView retornetExcel(string name)
		{
			string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;HDR=Yes;IMEX=1;MAXSCANROWS=0'", name);
			//Crear DataSet
			DataSet ds = new DataSet();
			OleDbConnection conector = default(OleDbConnection);
			//Abrir Conexion
			try
			{
				conector = new OleDbConnection(conexion);
				conector.Open();
				//Crear consulta
				OleDbCommand consulta = default(OleDbCommand);
				consulta = new OleDbCommand("select Producto, `Cantidad compra`, Unidad, `Cantidad venta` from [Hoja1$]", conector);
				//Crear Adaptador
				OleDbDataAdapter adaptador = new OleDbDataAdapter();
				adaptador.SelectCommand = consulta;
				
				//Llenamos Adaptador
				adaptador.Fill(ds);
				//Cerrar conexion
				conector.Close();
				//Regresamos DataView
			}
			catch (Exception)
			{
				MessageBox.Show("Porfavor cierre el documento antes de importarlo", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
			return ds.Tables[0].DefaultView;
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		private void ObtenerPrecio(string consulta, string unidad, string pp, string pc, out string precioProveedor, out string precioCliente)
		{
			int pos = 0;
			string captura = "";
			for (int i = 0; i < consulta.Length; i++)
			{
				if (consulta[i] == ',' || i == consulta.Length - 1)
				{
					if (captura == unidad)
						i = consulta.Length + 1;
					else
					{
						consulta = "";
					}
				}
				else
					captura += consulta[i];
			}//obtenemos la posicion de la coma donde se encontraran los datos
			captura = "";
			int contadorDeComas = 0;
			for (int i = 0; i < pp.Length; i++)
			{
				if (contadorDeComas == pos && pp[i] != ',')
					captura += pp[i];
				else if (pp[i] == ',')
					contadorDeComas++;
			}
			precioProveedor = captura;
			captura = "";
			contadorDeComas = 0;
			for (int i = 0; i < pc.Length; i++)
			{
				if (contadorDeComas == pos && pc[i] != ',')
					captura += pc[i];
				else if (pc[i] == ',')
					contadorDeComas++;
			}
			precioCliente = captura;
			captura = "";
			Conexion fn = new Conexion();
		}
		private double Truncate(double value, int decimales)
		{
			double aux_value = Math.Pow(10, decimales);
			return (Math.Truncate(value * aux_value) / aux_value);
		}

		private void btnAceptar_Click_1(object sender, EventArgs e)
		{
			if (dgvImportar.Columns.Count == 4)
			{
				for (int i = 0; i < dgvImportar.RowCount - 1; i++)
				{
					string producto = dgvImportar.Rows[i].Cells[0].Value.ToString();
					string cantidad = dgvImportar.Rows[i].Cells[1].Value.ToString();
					string unidad = dgvImportar.Rows[i].Cells[2].Value.ToString();
					string cantidadEntrega = cantidad;
					string precioProveedor = fn.ObtenerCampo("call sp_producto('" + producto.ToUpper() + "', '0', '0', '0', '" + idCliente + "', '0', '0', 'obtenerPU')");
					//call granosymas.sp_producto('des', dur, 'un', 'pu', 'cli', 'proo', id, 'Ssave');
					string precioCliente = fn.ObtenerCampo("call sp_producto('" + producto.ToUpper() + "', '0', '0', '0', '" + idCliente + "', '0', '0', 'obtenerPC')");
					string unidades = fn.ObtenerCampo("call sp_producto('" + producto.ToUpper() + "', '0', '0', '0', '" + idCliente + "', '0', '0', 'obtenerUnidad')");
					if (precioCliente != "" && precioProveedor != "" && unidades != "")
					{
						ObtenerPrecio(unidades, unidad, precioProveedor, precioCliente, out precioProveedor, out precioCliente);
						unidades = unidad;
						string totalProveedor = (Truncate(Convert.ToDouble(cantidad) * Convert.ToDouble(precioProveedor), 4)).ToString();
						string totalCliente = (Truncate(Convert.ToDouble(cantidadEntrega) * Convert.ToDouble(precioCliente), 3)).ToString();
						string margen = (Truncate(Convert.ToDouble(precioProveedor) - Convert.ToDouble(precioCliente), 3)).ToString();
						string margenProcentual = ((Truncate(Convert.ToDouble(margen) / Convert.ToDouble(precioCliente), 3)) * 100).ToString() + '%';
						fn.actualizar("call sp_compra('" + cantidad + "', '" + precioProveedor + "', '" + totalProveedor + "', '" + producto + "', '" + unidades + "', '" + cantidadEntrega + "', '" + precioCliente + "', '" + totalCliente + "', '" + margen + "', '" + margenProcentual + "', '" + idCabecera + "','0', 'save')");
					}
					else
						MessageBox.Show("El producto " + producto + "no existe o esta mal escrito porfavor vuelva a intentarlo", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
				}
			}
			else
				MessageBox.Show("Tiene que importar solo 3 columnas: \n 1.- Producto \n 2.- Cantidad \n 3.- Unidad", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnCancelar_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnImportar_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Archivos de Excel (*.xls;*.xlsx;*.xlsm)|*.xls;*.xlsx;*.xlsm";
			dialog.FileName = string.Empty;
			dialog.Title = "Importar datos desde Excel";
			try
			{
				if (dialog.ShowDialog() == DialogResult.OK)
					dgvImportar.DataSource = retornetExcel(dialog.FileName);
			}
			catch { }
		}
	}
}

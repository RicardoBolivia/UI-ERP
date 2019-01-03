using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Ul_Granos_y_Mas
{
	public partial class tablaCompras : Form
	{
		Conexion fn = new Conexion();
		string idCliente;
		string idCabecera;
		string id = "";
		public tablaCompras(string compras, string idCabecera)
		{
			idCliente = compras;
			this.idCabecera = idCabecera;
			InitializeComponent();
			fn.LlenarComboBox("call granosymas.sp_producto('0', 0, '0', '0', '0', '0', 0, 'load');", cbxProducto, "DESCRIPCION");
			dgvCompra.DataSource= fn.llenarGrid(Query("load"));
		}
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			if (btnNuevo.Text == "Nuevo")
			{
				btnNuevo.Text = "Guardar";
				HabilitarControles(0);
				BloquearControles(1);
			}//Se habilita El guardado de un nuevo cliente
			else if (btnNuevo.Text == "Guardar Edicion")
			{
				if (cbxProducto.Text != "" && cbxUnidad.Text.ToUpper() != "" && nudCantidadEntregada.Text.ToUpper() != "0" && nudCantidadSolicitada.Text.ToUpper() != "0")
				{
					btnNuevo.Text = "Nuevo";
					if (fn.actualizar(Query("edit")))
						MessageBox.Show("Se actualizo correctamente la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					else
						MessageBox.Show("Error al actualizar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
					MessageBox.Show("Porfavor inserte todos los campos correspondientes", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				HabilitarControles(2);
				BloquearControles(0);
			}//Se actualiza un cliente
			else if (cbxProducto.Text != "" && cbxUnidad.Text.ToUpper() != "" && nudCantidadEntregada.Text.ToUpper() != "0" && nudCantidadSolicitada.Text.ToUpper() != "0")
			{
				if (fn.actualizar(Query("save")))
					MessageBox.Show("Se guardo correctamente en la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				else
					MessageBox.Show("Error al insertar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnNuevo.Text = "Nuevo";
				HabilitarControles(1);
				BloquearControles(0);
			}//Se guarda un nuevo cliente
			else
				MessageBox.Show("Porfavor inserte todos los campos correspondientes", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			dgvCompra.DataSource = fn.llenarGrid(Query("load"));
		}
		private void BloquearControles(int caso)
		{
			switch (caso)
			{
				case 0://Oculta todo el gbxDatos
					gbxDatos.Size = new Size(1326, 0);
					nudCantidadSolicitada.Value = 0;
					nudCantidadEntregada.Value = 0;
					break;
				case 1://Bloquea el funcionamiento de todo menos btnNuevo
					btnImportar.Enabled = false;
					btnEditar.Enabled = false;
					btnELiminar.Enabled = false;
					break;
			}
		}
		private void HabilitarControles(int caso)
		{
			switch (caso)
			{
				case 0://Habilita todo el gbxDatos					
					gbxDatos.Size = new Size(1326, 90);
					break;
				case 1://habilita los botones despues de crear un nuevo cliente
					btnImportar.Enabled = true;
					btnEditar.Enabled = true;
					btnELiminar.Enabled = true;
					break;
			}
		}
		private string Query(string opcion)
		{
			if (opcion != "load" && opcion != "delete")
			{
				string cantidad = nudCantidadSolicitada.Value.ToString();
				string cantidadEntrega = nudCantidadEntregada.Value.ToString();
				string producto = cbxProducto.Text;
				string precioProveedor = fn.ObtenerCampo("call sp_producto('" + producto.ToUpper() + "', '0', '0', '0', '" + idCliente + "',  '0', '" + id + "', 'obtenerPU')");
				string precioCliente = fn.ObtenerCampo("call sp_producto('" + producto.ToUpper() + "', '0', '0', '0', '" + idCliente + "',  '0', '" + id + "', 'obtenerPC')");
				string unidades = fn.ObtenerCampo("call sp_producto('" + producto.ToUpper() + "', '0', '0', '0', '" + idCliente + "', '0', '" + id + "', 'obtenerUnidad')");
				ObtenerPrecio(unidades, cbxUnidad.Text, precioProveedor, precioCliente, out precioProveedor, out precioCliente);
				unidades = cbxUnidad.Text;
				string totalProveedor = (Truncate(Convert.ToDouble(cantidad) * Convert.ToDouble(precioProveedor), 4)).ToString();
				string totalCliente = (Truncate(Convert.ToDouble(cantidadEntrega) * Convert.ToDouble(precioCliente), 3)).ToString();
				string margen = (Truncate(Convert.ToDouble(precioProveedor) - Convert.ToDouble(precioCliente), 3)).ToString();
				string margenProcentual = ((Truncate(Convert.ToDouble(margen) / Convert.ToDouble(precioCliente), 3))*100).ToString() + '%';
				return "call sp_compra('" + cantidad + "', '" + precioProveedor + "', '" + totalProveedor + "', '" + producto + "', '" + unidades + "', '" + cantidadEntrega + "', '" + precioCliente + "', '" + totalCliente + "', '" + margen + "', '" + margenProcentual + "', '" + idCabecera +"', '" + id + "', '" + opcion + "')";
			}
			else
				return "call granosymas.sp_compra(0, 0, 0, '0', '0', 0, 0, 0, 0, 0,  '"+ idCabecera +"', 0,'" + opcion + "')";
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
		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvCompra.SelectedRows.Count > 0)
			{
				cbxUnidad.Text = dgvCompra.CurrentRow.Cells["UNIDAD"].Value.ToString();
				cbxProducto.Text = dgvCompra.CurrentRow.Cells["PRODUCTO"].Value.ToString();
				nudCantidadEntregada.Text = dgvCompra.CurrentRow.Cells["CANTIDAD DE ENTREGA"].Value.ToString();
				nudCantidadSolicitada.Text = dgvCompra.CurrentRow.Cells["CANTIDAD"].Value.ToString();
				id = dgvCompra.CurrentRow.Cells["Id"].Value.ToString();
				btnNuevo.Text = "Guardar Edicion";
				BloquearControles(1);
				HabilitarControles(0);
			}
			else
				MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void btnELiminar_Click(object sender, EventArgs e)
		{
			if (dgvCompra.SelectedRows.Count > 0)
			{
				id = dgvCompra.CurrentRow.Cells["Id"].Value.ToString();
				if (fn.eliminar(Query("delete")))
					MessageBox.Show("Exito al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Error al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dgvCompra.DataSource = fn.llenarGrid(Query("load"));
			}
			else
				MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void btnImportar_Click(object sender, EventArgs e)
		{
			FormImportar frm = new FormImportar(idCliente, idCabecera);
			frm.ShowDialog();
			dgvCompra.DataSource= fn.llenarGrid(Query("load"));
		}

		private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			string unidades = fn.ObtenerCampo("call sp_producto('" + cbxProducto.Text + "', 0, '0', '0', '" + idCliente + "', '0', 0,  'obtenerUnidad')");
			string unidad = "";
			cbxUnidad.DataSource = null;
			cbxUnidad.Items.Clear();
			for (int i = 0; i < unidades.Length; i++)
			{
				if (unidades[i] == ',')
				{
					cbxUnidad.Items.Add(unidad);
					unidad = "";
				}
				else
					unidad += unidades[i];
			}
			cbxUnidad.Items.Add(unidad);
		}
	}
}

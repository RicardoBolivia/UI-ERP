using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ul_Granos_y_Mas
{
	public partial class Productos : Form
	{
        Conexion fn = new Conexion();
		string id = "";
		public Productos()
		{
			InitializeComponent();
			dgvProducto.DataSource = fn.llenarGrid("call load_producto");
			fn.LlenarComboBox("CALL show_clientes", cbxCliente, "NOMBRE");
		}
		private void button6_Click(object sender, EventArgs e)
		{
			if (gbxDatos.Height > 0)
			{
				if (rbtCliente.Checked && cbxCliente.Text != "-Escoja un Cliente-")
				{
					dgvProducto.DataSource = fn.llenarGrid("call search_clienteProducto('" + cbxCliente.Text + "')");
					BloquearControles(0);
					HabilitarControles(4);
				}
				else if (rbtNombre.Checked && txtNombre.Text != "")
				{
					dgvProducto.DataSource = fn.llenarGrid("call search_nombreProducto('" + txtNombre.Text + "')");
					BloquearControles(0);
					HabilitarControles(4);
				}
				else if (rbtNombreCliente.Checked && cbxCliente.Text != "-Escoja un Cliente-" && txtNombre.Text != "")
				{
					dgvProducto.DataSource = fn.llenarGrid("call search_nombreClienteProducto('" + cbxCliente.Text + "', '" + txtNombre.Text + "')");
					BloquearControles(0);
					HabilitarControles(4);
				}
			}
			else
			{
				gbxOpciones.Size = new Size(1326, 195);
				pnlSubMenu.Visible = true;
			}
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
				if (txtNombre.Text != "" && txtPrecioU.Text != "" && txtUnidad.Text != "" && nudDuracion.Value != 0 && cbxCliente.Text != "-Escoja un Cliente-" && txtPrecioProveedor.Text != "")
				{
					btnNuevo.Text = "Nuevo";
					if (fn.actualizar("call edit_producto('" + txtNombre.Text + "', '" + nudDuracion.Text + "', '" + txtUnidad.Text + "', '" + txtPrecioU.Text + "', '" + cbxCliente.Text + "', '" + txtPrecioProveedor.Text + "', '" + id + "')"))
						MessageBox.Show("Se actualizo correctamente la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					else
						MessageBox.Show("Error al actualizar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
					MessageBox.Show("Porfavor iserte todos los campos correspondientes", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				HabilitarControles(2);
				BloquearControles(0);
			}//Se actualiza un cliente
			else if (txtNombre.Text != "" && txtPrecioU.Text != "" && txtUnidad.Text != "" && nudDuracion.Value != 0 && cbxCliente.Text != "-Escoja un Cliente-" && txtPrecioProveedor.Text != "")
			{
				if (fn.insertar("call create_preoducto('" + txtNombre.Text + "', '" + nudDuracion.Text + "', '" + txtUnidad.Text + "', '" + txtPrecioU.Text + "', '" + cbxCliente.Text + "', '" + txtPrecioProveedor.Text + "')"))
					MessageBox.Show("Se guardo correctamente en la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				else
					MessageBox.Show("Error al insertar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnNuevo.Text = "Nuevo";
				HabilitarControles(2);
				BloquearControles(0);
			}//Se guarda un nuevo cliente
			else
				MessageBox.Show("Porfavor iserte todos los campos correspondientes", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			dgvProducto.DataSource = fn.llenarGrid("call load_producto");
		}
		private void BloquearControles(int caso)
		{
			switch (caso)
			{
				case 0://Oculta todo el gbxDatos
					gbxDatos.Size = new Size(1326, 0);
					txtPrecioU.Clear();
					txtUnidad.Clear();
					txtNombre.Clear();
					nudDuracion.Value = 0;
					break;
				case 1://Bloquea el funcionamiento de todo menos btnNuevo
					btnBuscar.Enabled = false;
					btnEditar.Enabled = false;
					btnEliminar.Enabled = false;
					btnAcutalizar.Enabled = false;
					break;
				case 2://Bloquea el funcionamiento de todo menos btnBuscar
					btnNuevo.Enabled = false;
					btnEditar.Enabled = false;
					btnEliminar.Enabled = false;
					btnAcutalizar.Enabled = false;
					break;
			}
		}
		private void HabilitarControles(int caso)
		{
			switch (caso)
			{
				case 0://Habilita todo el gbxDatos
					lblDuracion.Visible = true;
					lblCliente.Visible = true;
					lblUnidad.Visible = true;
					lblPrecioU.Visible = true;
					lblNombre.Visible = true;
					lblPrecioProveedor.Visible = true;
					txtNombre.Visible = true;
					txtPrecioU.Visible = true;
					txtUnidad.Visible = true;
					nudDuracion.Visible = true;
					cbxCliente.Visible = true;
					txtPrecioProveedor.Visible = true;
					lblNombre.Location = new Point(291 - 35, 39);
					lblCliente.Location = new Point(808 - 35, 39);
					lblDuracion.Location = new Point(602 - 35, 39);
					lblPrecioU.Location = new Point(524 - 35, 82);
					lblUnidad.Location = new Point(217 - 35, 82);
					lblPrecioProveedor.Location = new Point(869 - 35, 84);
					txtNombre.Location = new Point(401 - 35, 37);
					txtPrecioU.Location = new Point(663 - 35, 80);
					txtUnidad.Location = new Point(323 - 35, 80);
					nudDuracion.Location = new Point(728 - 35, 37);
					cbxCliente.Location = new Point(910 - 35, 35);
					txtPrecioProveedor.Location = new Point(1024 - 35, 82);
					gbxDatos.Size = new Size(1326, 140);
					cbxCliente.Text = "-Escoja un Cliente-";
					break;
				case 1://Habilita el Nombre del gbxDatos
					lblDuracion.Visible = false;
					lblCliente.Visible = false;
					lblUnidad.Visible = false;
					lblPrecioU.Visible = false;
					lblNombre.Visible = true;
					lblPrecioProveedor.Visible = false;
					txtNombre.Visible = true;
					txtPrecioU.Visible = false;
					txtUnidad.Visible = false;
					nudDuracion.Visible = false;
					cbxCliente.Visible = false;
					txtPrecioProveedor.Visible = false;
					lblNombre.Location = new Point(497, 41);					
					txtNombre.Location = new Point(607, 39);					
					gbxOpciones.Size = new Size(1326, 90);
					gbxDatos.Size = new Size(1326, 90);
					pnlSubMenu.Visible = false;
					break;
				case 2://habilita los botones despues de crear un nuevo cliente
					btnBuscar.Enabled = true;
					btnEditar.Enabled = true;
					btnEliminar.Enabled = true;
					btnAcutalizar.Enabled = true;
					break;
				case 3://Habilita el Cliente del gbxDatos
					lblDuracion.Visible = false;
					lblCliente.Visible = true;
					lblUnidad.Visible = false;
					lblPrecioU.Visible = false;
					lblNombre.Visible = false;
					lblPrecioProveedor.Visible = false;
					txtNombre.Visible = false;
					txtPrecioU.Visible = false;
					txtUnidad.Visible = false;
					nudDuracion.Visible = false;
					cbxCliente.Visible = true;
					txtPrecioProveedor.Visible = false;
					lblCliente.Location = new Point(505, 41);
					cbxCliente.Location = new Point(607, 37);
					gbxDatos.Size = new Size(1326, 90);
					gbxOpciones.Size = new Size(1326, 90);
					pnlSubMenu.Visible = false;
					cbxCliente.Text = "-Escoja un Cliente-";
					break;
				case 4://Habilita los botones depues de buscar
					btnNuevo.Enabled = true;
					btnEditar.Enabled = true;
					btnEliminar.Enabled = true;
					btnAcutalizar.Enabled = true;
					break;
				case 5://Habilita el Nobre y el Cliente del gbxDatos
					lblDuracion.Visible = false;
					lblCliente.Visible = true;
					lblUnidad.Visible = false;
					lblPrecioU.Visible = false;
					lblNombre.Visible = true;
					lblPrecioProveedor.Visible = false;
					txtNombre.Visible = true;
					txtPrecioU.Visible = false;
					txtUnidad.Visible = false;
					nudDuracion.Visible = false;
					cbxCliente.Visible = true;
					txtPrecioProveedor.Visible = false;
					lblCliente.Location = new Point(692 - 35, 37);
					cbxCliente.Location = new Point(794 - 35, 33);
					lblNombre.Location = new Point(379 - 35, 37);
					txtNombre.Location = new Point(489 - 35, 35);
					gbxDatos.Size = new Size(1326, 90);
					gbxOpciones.Size = new Size(1326, 90);
					pnlSubMenu.Visible = false;
					cbxCliente.Text = "-Escoja un Cliente-";
					break;
			}
		}
		private void rbtNombre_Click(object sender, EventArgs e)
		{
			HabilitarControles(1);
			BloquearControles(2);
		}
		private void rbtCliente_Click(object sender, EventArgs e)
		{
			HabilitarControles(3);
			BloquearControles(2);
		}
		private void rbtNombreCliente_Click(object sender, EventArgs e)
		{
			HabilitarControles(5);
			BloquearControles(2);
		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvProducto.SelectedRows.Count > 0)
			{
				txtNombre.Text = dgvProducto.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
				nudDuracion.Text = dgvProducto.CurrentRow.Cells["DURACION"].Value.ToString();
				txtUnidad.Text = dgvProducto.CurrentRow.Cells["UNIDAD"].Value.ToString();
				txtPrecioU.Text = dgvProducto.CurrentRow.Cells["PRECIO UNITARIO"].Value.ToString();
				cbxCliente.Text = dgvProducto.CurrentRow.Cells["CLIENTE"].Value.ToString();
				txtPrecioProveedor.Text = dgvProducto.CurrentRow.Cells["PRECIO PROVEEDOR"].Value.ToString();
				id = dgvProducto.CurrentRow.Cells["Id"].Value.ToString();
				btnNuevo.Text = "Guardar Edicion";
				BloquearControles(1);
				HabilitarControles(0);
			}
			else
				MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void btnAcutalizar_Click(object sender, EventArgs e)
		{
			dgvProducto.DataSource = fn.llenarGrid("call load_producto");
		}
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvProducto.SelectedRows.Count > 0)
			{
				id = dgvProducto.CurrentRow.Cells["Id"].Value.ToString();
				if (fn.eliminar("call delete_producto('" + id + "')"))
					MessageBox.Show("Exito al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Error al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dgvProducto.DataSource = fn.llenarGrid("call load_producto");
			}
			else
				MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}

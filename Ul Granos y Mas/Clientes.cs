using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ul_Granos_y_Mas
{
	public partial class Clientes : Form
	{
        Conexion fn = new Conexion();
		string id = "";
		public Clientes()
		{
			InitializeComponent();
			dgvClientes.DataSource = fn.llenarGrid("call load_table");
		}
		private void button6_Click(object sender, EventArgs e)
		{
			if (gbxDatos.Height == 0)
			{
				gbxOpciones.Size = new Size(1326, 170);
				panel3.Visible = true;
			}
			else
			{
				if (rbtNit.Checked && txtNit.Text != "")
				{
					dgvClientes.DataSource = fn.llenarGrid("search_nit_cliente('" + txtNit.Text + "')");
					BloquearControles(0);
					HabilitarControles(4);
				}
				else if(txtNombre.Text != "")
				{
					dgvClientes.DataSource = fn.llenarGrid("call search_nombre_cliente('" + txtNombre.Text + "')");
					BloquearControles(0);
					HabilitarControles(4);
				}
			}
		}//
		private void button5_Click(object sender, EventArgs e)
		{
			if (btnNuevo.Text == "Nuevo")
			{
				btnNuevo.Text = "Guardar";
				HabilitarControles(0);
				BloquearControles(1);
			}//Se habilita El guardado de un nuevo cliente
			else if (btnNuevo.Text == "Guardar Edicion")
			{
				if (txtNit.Text != "" && txtNit.Text != "")
				{
					btnNuevo.Text = "Nuevo";
					if (fn.actualizar("call edit_cliente('" + txtNit.Text + "', '" + txtNombre.Text + "', '" + id + "')"))
						MessageBox.Show("Se actualizo correctamente la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					else
						MessageBox.Show("Error al actualizar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
					MessageBox.Show("Porfavor iserte todos los campos correspondientes", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				HabilitarControles(2);
				BloquearControles(0);
			}//Se actualiza un cliente
			else if (txtNit.Text != "" && txtNombre.Text != "")
			{
				if (fn.insertar("call create_clientes('" + txtNit.Text + "', '" + txtNombre.Text + "')"))
					MessageBox.Show("Se guardo correctamente en la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				else
					MessageBox.Show("Error al insertar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnNuevo.Text = "Nuevo";
				HabilitarControles(2);
				BloquearControles(0);
			}//Se guarda un nuevo cliente
			else
				MessageBox.Show("Porfavor iserte todos los campos correspondientes", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			dgvClientes.DataSource = fn.llenarGrid("call load_table");
		}
		private void BloquearControles(int caso)
		{
			switch (caso)
			{
				case 0://Oculta todo el gbxDatos
					gbxDatos.Size = new Size(1326, 0);
					txtNit.Clear();
					txtNombre.Clear();
					break;
				case 1://Bloquea el funcionamiento de todo menos btnNuevo
					btnBuscar.Enabled = false;
					btnEditar.Enabled = false;
					btnELiminar.Enabled = false;
					break;
				case 2://Bloquea el funcionamiento de todo menos btnBuscar
					btnNuevo.Enabled = false;
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
					lblNit.Visible = true;
					lblNombre2.Visible = true;
					txtNombre.Visible = true;
					txtNit.Visible = true;
					txtNombre.Location = new Point(421, 36);
					lblNombre.Location = new Point(311, 38);
					txtNit.Location = new Point(807, 36);
					lblNit.Location = new Point(740, 38);
					gbxDatos.Size=new Size(1326, 90);
					break;
				case 1://Habilita el nit del gbxDatos
					lblNit.Visible = true;
					txtNit.Visible = true;
					lblNombre2.Visible = false;
					txtNombre.Visible = false;
					txtNit.Location = new Point(648, 36);
					lblNit.Location = new Point(579, 38);
					gbxDatos.Size = new Size(1326, 90);
					break;
				case 2://habilita los botones despues de crear un nuevo cliente
					btnBuscar.Enabled = true;
					btnEditar.Enabled = true;
					btnELiminar.Enabled = true;
					break;
				case 3://Habilita el nombre del gbxDatos
					lblNombre.Visible = true;
					txtNombre.Visible = true;
					lblNit.Visible = false;
					txtNit.Visible = false;
					txtNombre.Location = new Point(648, 36);
					lblNombre2.Location = new Point(538, 38);
					gbxDatos.Size = new Size(1326, 90);
					break;
				case 4://Habilita los botones depues de buscar
					btnNuevo.Enabled = true;
					btnEditar.Enabled = true;
					btnELiminar.Enabled = true;
					break;
			}
		}
		private void rbtNit_Click(object sender, EventArgs e)
		{
			BuscarMenu();
		}
		private void BuscarMenu()
		{
			gbxOpciones.Size = new Size(1326, 100);
			panel3.Visible = false;
			if (rbtNombre.Checked)
			{
				HabilitarControles(3);
				BloquearControles(2);
			}
			else
			{
				HabilitarControles(1);
				BloquearControles(2);
			}
		}
		private void rbtNombre_Click(object sender, EventArgs e)
		{
			BuscarMenu();
		}
		private void btnELiminar_Click(object sender, EventArgs e)
		{
			if (dgvClientes.SelectedRows.Count > 0)
			{
				id = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
				if (fn.eliminar("call delete_clientes('" + id + "')"))
					MessageBox.Show("Exito al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Error al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dgvClientes.DataSource = fn.llenarGrid("call load_table");
			}
			else
				MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvClientes.SelectedRows.Count > 0)
			{
				txtNit.Text = dgvClientes.CurrentRow.Cells["NIT"].Value.ToString();
				txtNombre.Text = dgvClientes.CurrentRow.Cells["NOMBRE"].Value.ToString();
				id = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
				btnNuevo.Text = "Guardar Edicion";
				BloquearControles(1);
				HabilitarControles(0);
			}
			else
				MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}

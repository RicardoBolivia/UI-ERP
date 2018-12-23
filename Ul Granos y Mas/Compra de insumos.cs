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
	public partial class Compra_de_insumos : Form
	{
		Conexion fn = new Conexion();
		string id = "0";
		public Compra_de_insumos()
		{
			InitializeComponent();
			fn.LlenarComboBox("call sp_cliente('', '" + txtMes.Text.ToUpper() + "', '" + id + "', 'load')", cbxCliente,"NOMBRE");
			dgvCompra.DataSource = fn.llenarGrid("call sp_cabecera('" + txtMes.Text + "', '" + fn.DateTimeSQL(dtpFecha) + "', '" + cbxCliente.Text.ToUpper() + "', '" + txtProyecto.Text.ToUpper() + "', '" + id + "', 'load')");
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
				if (txtMes.Text !="" && fn.DateTimeSQL(dtpFecha) != "" && cbxCliente.Text.ToUpper() != "" && txtProyecto.Text.ToUpper() != "")
				{
					btnNuevo.Text = "Nuevo";
					if (fn.actualizar("call sp_cabecera('" + txtMes.Text + "', '" + fn.DateTimeSQL(dtpFecha) + "', '" + cbxCliente.Text.ToUpper() + "', '" + txtProyecto.Text.ToUpper() + "', '" + id + "', 'edit')"))
						MessageBox.Show("Se actualizo correctamente la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					else
						MessageBox.Show("Error al actualizar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
					MessageBox.Show("Porfavor inserte todos los campos correspondientes", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				HabilitarControles(2);
				BloquearControles(0);
			}//Se actualiza un cliente
			else if (txtMes.Text != "" && fn.DateTimeSQL(dtpFecha) != "" && cbxCliente.Text.ToUpper() != "" && txtProyecto.Text.ToUpper() != "")
			{
				if (fn.insertar("call sp_cabecera('" + txtMes.Text + "', '" + fn.DateTimeSQL(dtpFecha) + "', '" + cbxCliente.Text.ToUpper() + "', '" + txtProyecto.Text.ToUpper() + "', '" + id + "', 'save')"))
					MessageBox.Show("Se guardo correctamente en la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				else
					MessageBox.Show("Error al insertar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnNuevo.Text = "Nuevo";
				HabilitarControles(2);
				BloquearControles(0);
			}//Se guarda un nuevo cliente
			else
				MessageBox.Show("Porfavor inserte todos los campos correspondientes", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			dgvCompra.DataSource = fn.llenarGrid("call sp_cabecera('" + txtMes.Text + "', '" + fn.DateTimeSQL(dtpFecha) + "', '" + cbxCliente.Text.ToUpper() + "', '" + txtProyecto.Text.ToUpper() + "', '" + id + "', 'load')");
		}
		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			txtMes.Text = Literal(dtpFecha.Value.Month);
		}
		public string Literal(int n)
		{
			string mes = "Error";
			switch (n)
			{
				case 1:
						mes = "Enero";
					break;
				case 2:
						mes = "Febrero";
					break;
				case 3:
						mes = "Marzo";
					break;
				case 4:					
						mes = "Abril";					
					break;
				case 5:					
						mes = "Mayo";					
					break;
				case 6:					
						mes = "Junio";					
					break;
				case 7:					
						mes = "Julio";					
					break;
				case 8:
						mes = "Agosto";					
					break;
				case 9:					
						mes = "Septiembre";					
					break;
				case 10:					
						mes = "Octubre";					
					break;
				case 11:					
						mes = "Noviembre";					
					break;
				case 12:					
						mes = "Diciembre";					
					break;
			}
			return mes;
		}
		private void BloquearControles(int caso)
		{
			switch (caso)
			{
				case 0://Oculta todo el gbxDatos
					gbxDatos.Size = new Size(1326, 0);
					txtProyecto.Clear();
					txtProyecto.Clear();
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
					pnlSubMenu.Visible = false;
					break;
			}
		}
		private void HabilitarControles(int caso)
		{
			switch (caso)
			{
				case 0://Habilita todo el gbxDatos
					lblproyecto.Visible = true;
					lblCliente.Visible = true;
					lblFecha.Visible = true;
					lblMes.Visible = true;
					txtProyecto.Visible = true;
					txtMes.Visible = true;
					cbxCliente.Visible = true;
					dtpFecha.Visible = true;
					lblproyecto.Location = new Point(29, 39);
					lblCliente.Location = new Point(963, 39);
					lblFecha.Location = new Point(390, 39);
					lblMes.Location = new Point(649, 39);
					txtProyecto.Location = new Point(149, 37);
					txtMes.Location = new Point(722, 37);
					cbxCliente.Location = new Point(1065, 35);
					dtpFecha.Location = new Point(481, 37);
					gbxDatos.Size = new Size(1326, 90);
					break;
				case 1://Habilita el mes del gbxDatos
					lblproyecto.Visible = false;
					lblCliente.Visible = false;
					lblFecha.Visible = true;
					lblMes.Visible = true;
					txtProyecto.Visible = false;
					txtMes.Visible = true;
					cbxCliente.Visible = false;
					dtpFecha.Visible = true;
					lblFecha.Location = new Point(390, 39);
					lblMes.Location = new Point(649, 39);
					txtMes.Location = new Point(722, 37);
					dtpFecha.Location = new Point(481, 37);
					gbxDatos.Size = new Size(1326, 90);
					break;
				case 2://habilita los botones despues de crear un nuevo cliente
					btnBuscar.Enabled = true;
					btnEditar.Enabled = true;
					btnELiminar.Enabled = true;
					break;
				case 3://Habilita el Cliente del gbxDatos
					lblproyecto.Visible = false;
					lblCliente.Visible = true;
					lblFecha.Visible = false;
					lblMes.Visible = false;
					txtProyecto.Visible = false;
					txtMes.Visible = false;
					cbxCliente.Visible = true;
					dtpFecha.Visible = false;
					lblCliente.Location = new Point(494, 41);
					cbxCliente.Location = new Point(596, 37);
					gbxDatos.Size = new Size(1326, 90);
					break;
				case 4://Habilita los botones depues de buscar
					btnNuevo.Enabled = true;
					btnEditar.Enabled = true;
					btnELiminar.Enabled = true;
					break;
			}
		}
		private void rbtMes_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtMes.Checked)
			{
				BloquearControles(2);
				HabilitarControles(1);
				gbxOpciones.Size = new Size(1326, 90);
			}
			else
			{
				BloquearControles(2);
				HabilitarControles(3);
				gbxOpciones.Size = new Size(1326, 90);	
			}
		}
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (gbxDatos.Height == 0)
			{
				gbxOpciones.Size = new Size(1326, 170);
				pnlSubMenu.Visible = true;
			}
			else
			{
				if (txtMes.Text != "")
				{
					dgvCompra.DataSource = fn.llenarGrid("call sp_cabecera('" + txtMes.Text + "', '" + fn.DateTimeSQL(dtpFecha) + "', '" + cbxCliente.Text.ToUpper() + "', '" + txtProyecto.Text.ToUpper() + "', '" + id + "', 'mes')");
					BloquearControles(0);
					HabilitarControles(4);
				}
				else 
				{
					dgvCompra.DataSource = fn.llenarGrid("call sp_cabecera('" + txtMes.Text + "', '" + fn.DateTimeSQL(dtpFecha) + "', '" + cbxCliente.Text.ToUpper() + "', '" + txtProyecto.Text.ToUpper() + "', '" + id + "', 'cliente')");
					BloquearControles(0);
					HabilitarControles(4);
				}
			}
		}

		private void btnELiminar_Click(object sender, EventArgs e)
		{
			if (dgvCompra.SelectedRows.Count > 0)
			{
				id = dgvCompra.CurrentRow.Cells["Id"].Value.ToString();
				if (fn.eliminar("call sp_cabecera('" + txtMes.Text + "', '" + fn.DateTimeSQL(dtpFecha) + "', '" + cbxCliente.Text.ToUpper() + "', '" + txtProyecto.Text.ToUpper() + "', '" + id + "', 'delete')"))
					MessageBox.Show("Exito al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Error al eliminar con la base de datos", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dgvCompra.DataSource = fn.llenarGrid("call sp_cabecera('" + txtMes.Text + "', '" + fn.DateTimeSQL(dtpFecha) + "', '" + cbxCliente.Text.ToUpper() + "', '" + txtProyecto.Text.ToUpper() + "', '" + id + "', 'load')");
			}
			else
				MessageBox.Show("Seleccione una columna", "Granos y Mas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvCompra.SelectedRows.Count > 0)
			{
				txtMes.Text = dgvCompra.CurrentRow.Cells["MES"].Value.ToString();
				txtProyecto.Text = dgvCompra.CurrentRow.Cells["PROYECTO"].Value.ToString();
				dtpFecha.Text= dgvCompra.CurrentRow.Cells["FECHA"].Value.ToString();
				cbxCliente.Text = dgvCompra.CurrentRow.Cells["CLIENTE"].Value.ToString();
				id = dgvCompra.CurrentRow.Cells["id"].Value.ToString();
				btnNuevo.Text = "Guardar Edicion";
				BloquearControles(1);
				HabilitarControles(0);
			}
		}
	}
}

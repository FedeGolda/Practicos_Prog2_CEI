﻿using Obligatorio2023Prog2.Clases;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogeado.getVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogeado.getVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogeado.getVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogeado.getVerAlquileres();
            Master.FindControl("lnkUsuarios").Visible = BaseDeDatos.usuarioLogeado.getVerUsuarios();

            if (!IsPostBack)
            {
                // Verificar si hay clientes en la lista
                if (BaseDeDatos.listaClientes.Count > 0)
                {
                    // Asignar la lista de vehículos como origen de datos para el GridView
                    gvClientes.DataSource = BaseDeDatos.listaClientes;
                    gvClientes.DataBind();
                }
            }
        }

        // ...

        protected void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si los TextBox están vacíos
                if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    lblMensajeCliente.Text = "Todos los campos son obligatorios. Complete la información.";
                    lblMensajeCliente.ForeColor = System.Drawing.Color.Red;
                    lblMensajeCliente.Visible = true;  // Mostrar el mensaje de error
                    return;
                }

                // Verificar si ya existe un cliente con la misma cédula
                if (BaseDeDatos.listaClientes.Any(cliente => cliente.getCedula() == txtCedula.Text))
                {
                    // Mostrar un mensaje de error
                    lblMensajeCliente.Text = "Ya existe un cliente con esa cédula.";
                    lblMensajeCliente.ForeColor = System.Drawing.Color.Red;
                    lblMensajeCliente.Visible = true;  // Mostrar el mensaje de error
                    return;
                }

                // Crear un nuevo cliente y asignar los valores
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.setCedula(txtCedula.Text);
                nuevoCliente.setNombre(txtNombre.Text);
                nuevoCliente.setApellido(txtApellido.Text);
                nuevoCliente.setDireccion(txtDireccion.Text);

                // Verificar la validez de la cédula uruguaya utilizando la nueva función Validate
                if (!Cliente.Validate(nuevoCliente.getCedula()))
                {
                    // Mostrar un mensaje de error
                    lblMensajeCliente.Text = "La cédula no es válida. Por favor, ingrese una cédula uruguaya válida.";
                    lblMensajeCliente.ForeColor = System.Drawing.Color.Red;
                    lblMensajeCliente.Visible = true;  // Mostrar el mensaje de error
                    return;
                }

                // Agregar el cliente a la lista
                BaseDeDatos.listaClientes.Add(nuevoCliente);

                LimpiarCampos();

                // Actualizar la GridView
                gvClientes.DataSource = BaseDeDatos.listaClientes;
                gvClientes.DataBind();

                lblMensajeCliente.Text = "Cliente ingresado correctamente";
                lblMensajeCliente.ForeColor = System.Drawing.Color.Green;
                lblMensajeCliente.Visible = true;

                // Redirigir para refrescar la página
                Response.Redirect(Request.RawUrl);
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                Console.WriteLine("Excepción: " + ex.Message);
            }
        }

        protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string cedula = gvClientes.DataKeys[e.RowIndex].Values[0].ToString();

                foreach (var cliente in BaseDeDatos.listaClientes)
                {
                    if (cliente.getCedula() == cedula)
                    {
                        BaseDeDatos.listaClientes.Remove(cliente);
                        break;
                    }
                }

                this.gvClientes.EditIndex = -1;
                this.gvClientes.DataSource = BaseDeDatos.listaClientes;
                this.gvClientes.DataBind();

                // Redirigir para refrescar la página
                Response.Redirect(Request.RawUrl);
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                Console.WriteLine("Excepción: " + ex.Message);
            }
        }

        protected void gvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow filaSeleccionada = gvClientes.Rows[e.RowIndex];
                string cedula = gvClientes.DataKeys[e.RowIndex].Values[0].ToString();

                string nombre = (filaSeleccionada.FindControl("txtNombreGrid") as TextBox).Text;
                string apellido = (filaSeleccionada.FindControl("txtApellidoGrid") as TextBox).Text;
                string direccion = (filaSeleccionada.FindControl("txtDireccionGrid") as TextBox).Text;

                // Buscar el cliente a actualizar por la cédula original
                Cliente clienteToUpdate = BaseDeDatos.listaClientes.Find(v => v.getCedula() == cedula);

                if (clienteToUpdate != null)
                {
                    clienteToUpdate.setCedula(cedula);
                    clienteToUpdate.setNombre(nombre);
                    clienteToUpdate.setApellido(apellido);
                    clienteToUpdate.setDireccion(direccion);

                    gvClientes.EditIndex = -1;
                    BindData(); // Método para actualizar la GridView

                    // Mostrar mensaje de actualización
                    lblMensajeCliente.Text = "Cliente actualizado correctamente";
                    lblMensajeCliente.ForeColor = System.Drawing.Color.Green;
                    lblMensajeCliente.Visible = true;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                Console.WriteLine("Excepción: " + ex.Message);
            }
        }






        protected void gvClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvClientes.EditIndex = -1;
            gvClientes.DataSource = BaseDeDatos.listaClientes;
            gvClientes.DataBind();
        }

        protected void gvClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvClientes.EditIndex = e.NewEditIndex;
            BindData(); // Método para actualizar la GridView
        }


        private void LimpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
        }

        private void BindData()
        {
            gvClientes.DataSource = BaseDeDatos.listaClientes;
            gvClientes.DataBind();
        }
    }
}

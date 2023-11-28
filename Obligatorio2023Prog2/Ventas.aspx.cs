﻿using Obligatorio2023Prog2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                cboCleintes.DataSource = BaseDeDatos.listaClientes;
                cboCleintes.DataTextField = "Cedula";
                cboCleintes.DataBind();
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.setCedula(cboCleintes.SelectedItem.Value);
            venta.setMatricula(cboVehiculos.SelectedItem.Value);
            venta.setFechaVenta(DateTime.Now);
            venta.setPrecio(Convert.ToInt32(lblPrecio.Text));
            venta.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);

            BaseDeDatos.listaVentas.Add(venta);

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == cboVehiculos.SelectedItem.Value)
                {
                    vehiculo.Activo = false;
                    break;
                }
            }

            cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
            cboVehiculos.DataTextField = "Matricula";
            cboVehiculos.DataBind();

            Response.Write("<script>alert('Venta ingresada correctamente')</script>");
        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == Matricula)
                {
                    lblPrecio.Text = vehiculo.getPrecioVenta().ToString();
                    lblPrecio.Visible = true;
                    lblPrecioSimbolo.Visible = true;
                }
            }

        }
    }
}

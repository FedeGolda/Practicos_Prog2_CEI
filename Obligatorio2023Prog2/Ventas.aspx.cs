using Obligatorio2023Prog2.Clases;
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
  
        }



        protected void lvVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén la matrícula seleccionada
            string matriculaSeleccionada = lvVehiculos.SelectedDataKey.Value.ToString();

            // Buscar el vehículo correspondiente en tu lista de vehículos
            Vehiculo vehiculoSeleccionado = BaseDeDatos.listaVehiculos.Find(v => v.getMatricula() == matriculaSeleccionada);

            // Ahora puedes hacer lo que necesites con el vehículo seleccionado
            // Por ejemplo, mostrar sus detalles en la página o realizar alguna operación de venta
        }



    }
}
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Obligatorio2023Prog2
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
            routes.MapPageRoute("Clientes", "Clientes", "~/Clases/Clientes.aspx");
            routes.MapPageRoute("Vehiculos", "Vehiculos", "~/Vehiculos.aspx");
            routes.MapPageRoute("Alquileres", "Alquileres", "~/Alquileres.aspx");
            routes.MapPageRoute("Ventas", "Ventas", "~/Ventas.aspx");
        }
    }
}

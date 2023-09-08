using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalFormacion
{
    internal class AdministradorUsuario : Usuario
    {
        public AdministradorUsuario(int id, string nombre, string apellido, DateTime fechaAlta):base(id, nombre, apellido, fechaAlta)
        {
            
        }

        public void Gestionar()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATO;
using ENTIDADES;

namespace LOGICA
{
    public class LUsuario
    {
        public DArbolUsuario Usuari;

        public LUsuario()
        {
            Usuari = DArbolUsuario.Instancia;  //Usar instancia compartida
        }
        public int Registrar(EUsuario obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.CodigoUsuario == 0)
                Mensaje += "Es necesario el documento del usuario\n";

            if (string.IsNullOrWhiteSpace(obj.NombreCompleto))
                Mensaje += "Es necesario el nombre completo del usuario\n";

            if (string.IsNullOrWhiteSpace(obj.Clave))
                Mensaje += "Es necesario la clave del usuario\n";

            if (Mensaje != "")
                return 0;

            return Usuari.Registrar(obj, out Mensaje);
        }
        public bool Editar(EUsuario obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.CodigoUsuario == 0)
                Mensaje += "Es necesario el documento del usuario\n";

            if (string.IsNullOrWhiteSpace(obj.NombreCompleto))
                Mensaje += "Es necesario el nombre completo del usuario\n";

            if (string.IsNullOrWhiteSpace(obj.Clave))
                Mensaje += "Es necesario la clave del usuario\n";

            if (Mensaje != "")
                return false;

            return Usuari.Editar(obj, out Mensaje);
        }
        public bool Eliminar(EUsuario obj, out string Mensaje)
        {
            return Usuari.EliminarUsuario(obj.IdUsuario, out Mensaje);
        }
        public EUsuario BuscarUsuario(int documento, string clave)
        {
            return Usuari.BuscarUsuario(documento, clave);
        }
        public DNodoArbolUsuario ObtenerPrimerNodo()
        {
            return Usuari.RaizPrincipal;
        }
    }
}

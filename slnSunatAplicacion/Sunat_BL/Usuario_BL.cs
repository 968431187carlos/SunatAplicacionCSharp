using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunat_BE;
using Sunat_AD;

namespace Sunat_BL
{
    public class Usuario_BL
    {
        public int ValidarUsuario(string username, string pass) {
            var objSunat = new Usuario_AD();
            return objSunat.ValidarUsuario(username,pass);
        }
    }
}

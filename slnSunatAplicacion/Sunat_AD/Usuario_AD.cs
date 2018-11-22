using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunat_BE;

namespace Sunat_AD
{
    public class Usuario_AD
    {
        public int ValidarUsuario(string username,string pass ) {
            var db = new BD_Sunat1Entities();

            return Convert.ToInt16(db.ValidarUsuario(username, pass).FirstOrDefault());
        }
    }
}

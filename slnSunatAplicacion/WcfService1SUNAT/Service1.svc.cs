using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sunat_BE;
using Sunat_BL;

namespace WcfService1SUNAT
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        
         public List<ObtenerEmpresaTodas_Result> ObtenerListaEmpresas()
        {
            var objBL = new Empresa_BL();
            return objBL.ObtenerListaEmpresas();
        }

        public List<ObtenerEmpresa_Result> ObtenerEmpresa(string pIdempresa, string pLlave)
        {
            var objBL = new Empresa_BL();
            return objBL.ObtenerEmpresa(pIdempresa, pLlave);
        }

        public int ValidarUsuario(string username, string pass)
        {
            var objBL = new Usuario_BL();
            return objBL.ValidarUsuario(username,pass);
        }

        public string AgregarEmpresa(string pIdEmpresa, string pNombre, string pLlave, int pEstado)
        {
            Empresa_BL objBL = new Empresa_BL();
            return objBL.AgregarEmpresa(pIdEmpresa, pNombre, pLlave, pEstado);
        }

        public string ModificarEmpresa(string pIdEmpresa, string pNombre, string pLlave, int pEstado)
        {
            Empresa_BL objBL = new Empresa_BL();
            return objBL.ModificarEmpresa(pIdEmpresa, pNombre, pLlave, pEstado);
        }

        public string BorrarEmpresa(string pIdEmpresa)
        {
            Empresa_BL objBL = new Empresa_BL();
            return objBL.BorrarEmpresa(pIdEmpresa);
        }
    }
}

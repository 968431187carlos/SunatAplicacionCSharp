using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunat_AD;
using Sunat_BE;

namespace Sunat_BL
{
   public class Empresa_BL
    {
        
        public List<ObtenerEmpresaTodas_Result> ObtenerListaEmpresas()
        {
            Empresa_AD objAD = new Empresa_AD();
            return objAD.ObtenerListaEmpresas();
        }

        public List<ObtenerEmpresa_Result> ObtenerEmpresa(string pIdempresa, string pLlave)            
        {
            Empresa_AD objAD = new Empresa_AD();
            return objAD.ObtenerEmpresa(pIdempresa, pLlave);
        }
        public string AgregarEmpresa(String pIdEmpresa, string pNombre, string pLlave, int pEstado)
        {
            Empresa_AD objAD = new Empresa_AD();
            return objAD.AgregarEmpresa(pIdEmpresa, pNombre, pLlave, pEstado);

        }
        public string ModificarEmpresa(String pIdEmpresa, string pNombre, string pLlave, int pEstado)
        {
            Empresa_AD objAD = new Empresa_AD();
            return objAD.ModificarEmpresa(pIdEmpresa, pNombre, pLlave, pEstado);

        }

        public string BorrarEmpresa(String pIdEmpresa)
        {
            Empresa_AD objAD = new Empresa_AD();
            return objAD.BorrarEmpresa(pIdEmpresa);

        }


    }


}

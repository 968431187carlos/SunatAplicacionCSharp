using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunat_BE;

namespace Sunat_AD
{
    public class Empresa_AD
    {
        public List<ObtenerEmpresaTodas_Result> ObtenerListaEmpresas()
        {
            try
            {
                var db = new BD_Sunat1Entities();
                return db.ObtenerEmpresaTodas().ToList();
                
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public List<ObtenerEmpresa_Result> ObtenerEmpresa(string pIdempresa, string pLlave)
        {
            try
            {
                var db = new BD_Sunat1Entities();
                return db.ObtenerEmpresa(pIdempresa, pLlave).ToList();
                
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public string AgregarEmpresa(string pIdEmpresa, string pNombre, string pLlave, int pEstado)
        {
            int vResult = 0;
            try
            {
                using (var db = new BD_Sunat1Entities())
                {
                    vResult = db.AgregarEmpresa(pIdEmpresa, pNombre, pLlave, pEstado);
                    return "Empresa Agregada";
                }


            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }

        public string ModificarEmpresa(string pIdEmpresa, string pNombre, string pLlave, int pEstado)
        {
            int vResult = 0;
            try
            {
                using (var db = new BD_Sunat1Entities())
                {
                    vResult = db.ModificarEmpresa(pIdEmpresa, pNombre, pLlave, pEstado);
                    return "Empresa Modificada";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }

        }

        public string BorrarEmpresa(string pIdEmpresa)
        {
            int vResult = 0;
            try
            {
                using (var db = new BD_Sunat1Entities())
                {
                    vResult = db.BorrarEmpresa(pIdEmpresa);
                    return "Empresa Eliminada";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }


        }


    }
    
}


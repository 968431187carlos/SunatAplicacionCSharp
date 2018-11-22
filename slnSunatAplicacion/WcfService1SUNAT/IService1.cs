using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sunat_BE;

namespace WcfService1SUNAT
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<ObtenerEmpresaTodas_Result> ObtenerListaEmpresas();

        [OperationContract]
        List<ObtenerEmpresa_Result> ObtenerEmpresa(string pIdempresa, string pLlave);

        [OperationContract]
        int ValidarUsuario(string username, string pass);

        [OperationContract]
        string AgregarEmpresa(string pIdEmpresa, string pNombre, string pLlave, int pEstado);

        [OperationContract]
        string ModificarEmpresa(string pIdEmpresa, string pNombre, string pLlave, int pEstado);

        [OperationContract]
        string BorrarEmpresa(string pIdEmpresa);
    }



}

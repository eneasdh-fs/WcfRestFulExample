using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using model = CineMark.models;

namespace CineMark.Programming
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRespository" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Contract
    {
        [OperationContract]
        [WebGet(UriTemplate = "/", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<model.Programming> all();
        
        [OperationContract]
        [WebGet(UriTemplate = "/programmning/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        model.Programming findOrFail();
    }
}

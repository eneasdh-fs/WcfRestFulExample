using CineMark.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using model = CineMark.models;

namespace CineMark.Movie
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMovieRepository" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Contract
    {
        [OperationContract]
        [WebGet(UriTemplate = "genres", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<model.Genre> genres();

        [OperationContract]
        [WebGet(UriTemplate = "/genres/{id}/movies", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        model.Genre filter(String id);


        [OperationContract]
        [WebGet(UriTemplate = "/{name}/", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        model.Movie findOrFail(String name);
        
 
        [OperationContract]
        [WebGet(UriTemplate = "/", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<model.Movie> all();




       // [WebGet(UriTemplate = "/getAll", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
  
     //   [WebGet(UriTemplate = "/get/{idCliente}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
    
    //    [WebInvoke(UriTemplate = "/create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]
 

      //  [WebInvoke(UriTemplate = "/update", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped)]


      //  [WebInvoke(UriTemplate = "/delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST")]


    }
}

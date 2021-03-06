﻿using CineMark.Response;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using model = CineMark.models;

namespace CineMark.Payment
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRepository" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Contract
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/payments/{programming_id}/programming/?client={client}&quantity={quantity}&element={element}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        Json store(String programming_id, String client, String quantity, String element);

        [OperationContract]
        [WebGet(UriTemplate = "/", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
         List<model.Payment> all();

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        model.Payment find(String id);


    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using model = CineMark.models;
namespace CineMark.Products
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Repository" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Repository.svc o Repository.svc.cs en el Explorador de soluciones e inicie la depuración.

    [AutomapServiceBehavior]
    public class Repository : Contract
    {
        protected readonly Entities Context;

        public Repository(Entities Context)
        {
            this.Context = Context;
        }


        public List<models.Product> all()
        {
            List<products> products = Context.products.ToList();

            return Mapper.Map<List<products>, List<model.Product>>(products);            
        }
    }
}

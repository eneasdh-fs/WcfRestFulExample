using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AutoMapper;
using model = CineMark.models;

namespace CineMark.Programming
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Respository" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Respository.svc o Respository.svc.cs en el Explorador de soluciones e inicie la depuración.
    
    [AutomapServiceBehavior]
    public class Repository : Contract
    {

        protected readonly Entities Context;

        public Repository(Entities Context)
        {
            this.Context = Context;
        }


        public List<models.Programming> all()
        {
            List<programming> programming = Context.programming.Include("movies").ToList();

            return Mapper.Map<List<programming>, List<model.Programming>>(programming);
        }

        public models.Programming findOrFail(String id)
        {
            int programming_id = int.Parse(id);
            programming programming = Context.programming.Include("movies").First(x => x.id == programming_id);
            return Mapper.Map<programming, model.Programming>(programming);
        }
    }
}

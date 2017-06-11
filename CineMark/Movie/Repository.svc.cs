using AutoMapper;
using CineMark.Exceptions;
using CineMark.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using model = CineMark.models;

namespace CineMark.Movie
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MovieRepository" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MovieRepository.svc o MovieRepository.svc.cs en el Explorador de soluciones e inicie la depuración.


    [AutomapServiceBehavior]
    public class Repository : Contract
    {
        protected readonly Entities Context;

        public Repository(Entities Context)
        {
            this.Context = Context;
        }

        public List<model.Genre> genres()
        {
            List<genres> genres = this.Context.genres.ToList();

            return Mapper.Map<List<genres>, List<model.Genre>>(genres);
        }

        public model.Genre filter(string id)
        {
            int identity = int.Parse(id);
            genres genre = this.Context.genres.Include("movies").Where(x => x.id == identity).FirstOrDefault();


            if (genre == null)
            {
                throw new NotFoundModelException();
            }


            return Mapper.Map<genres, model.Genre>(genre);
        }


        public List<model.Movie> all()
        {
            List<movies> movies = this.Context.movies.Include("genres").ToList();

            return Mapper.Map<List<movies>, List<model.Movie>>(movies);
        }
        
        public model.Movie findOrFail(String name)
        {

            movies movie = this.Context.movies.Where(m => m.url == name).FirstOrDefault();

            if(movie == null) {
                throw new NotFoundModelException();
            }

            return Mapper.Map<movies, model.Movie>(movie);
        }



    }
}

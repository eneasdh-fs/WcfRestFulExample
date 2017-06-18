using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CineMark.models;
using model = CineMark.models;
namespace CineMark
{
    public class AutomapBootstrap
    {
        public static void InitializeMap()
        {
            Mapper.Initialize(cfg => {
                /* genres */
                cfg.CreateMap<genres, model.Genre>().ReverseMap();
                cfg.CreateMap<model.Genre, genres>().ReverseMap();
                cfg.CreateMap<genres, model.MovieGenre>().ReverseMap();

                /* movies */
                cfg.CreateMap<movies, model.Movie>().ReverseMap();
                cfg.CreateMap<movies, model.GenreMovies>().ReverseMap();

                /* programming */
                cfg.CreateMap<programming, model.Programming>().ReverseMap().ForMember(x => x.release_at, x => x.ToString());

                /* products */
                cfg.CreateMap<products, model.Product>().ReverseMap();            
            });
            
        }

    }
}
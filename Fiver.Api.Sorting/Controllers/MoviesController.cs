using Fiver.Api.Sorting.Lib;
using Fiver.Api.Sorting.Models.Movies;
using Fiver.Api.Sorting.OtherLayers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Fiver.Api.Sorting.Controllers
{
    [Route("movies")]
    public class MoviesController : Controller
    {
        private readonly IMovieService service;

        public MoviesController(IMovieService service)
        {
            this.service = service;
        }

        [HttpGet(Name = "GetMovies")]
        public IActionResult Get(SortingParams sortingParams)
        {
            var model = service.GetMovies(sortingParams);
            
            var outputModel = new MovieOutputModel
            {
                Items = model.Select(m => ToMovieInfo(m)).ToList(),
            };
            return Ok(outputModel);
        }
        
        #region " Mappings "

        private MovieInfo ToMovieInfo(Movie model)
        {
            return new MovieInfo
            {
                Id = model.Id,
                Title = model.Title,
                ReleaseYear = model.ReleaseYear,
                Summary = model.Summary,
                LeadActor = model.LeadActor,
                LastReadAt = DateTime.Now
            };
        }

        #endregion
    }
}

using Fiver.Api.Sorting.Lib;
using System.Collections.Generic;

namespace Fiver.Api.Sorting.OtherLayers
{
    public interface IMovieService
    {
        List<Movie> GetMovies(SortingParams sortingParams);
    }
}

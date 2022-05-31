using MyMovieApp.Data.DataConnection;
using MyMovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMovieApp.Data.Repository
{
    public class MovieTime : IMovieTime
    {
        MovieDbContext _movieDbContext;

        public MovieTime(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public string AddMovieTime(ShowMovieTime movieTime)
        {
            _movieDbContext.MovieTime.Add(movieTime);
            _movieDbContext.SaveChanges();
            return "Movie Time Added Successfully...!!";
        }

        public List<ShowMovieTime> showAllMovie()
        {
            return _movieDbContext.MovieTime.ToList();
        }

    }
}

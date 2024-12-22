using demo_mvc.Data.Base;
using demo_mvc.Data.ViewModels;
using demo_mvc.Models;
using System;

namespace demo_mvc.Data.Service
{
    public interface IMoviesService :IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}

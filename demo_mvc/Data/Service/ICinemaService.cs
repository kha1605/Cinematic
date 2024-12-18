using demo_mvc.Models;

namespace demo_mvc.Data.Service
{
    public interface ICinemaService
    {
        Task<IEnumerable<Cinema>> GetAllAsync();
        Task<Cinema> GetByIdAsync(int id);
        Task AddAsync(Cinema cinema);
        Task<Cinema> UpdateAsync(int id, Cinema cinema);
        Task DeleteAsync(int id);
    }
}

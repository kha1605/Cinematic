using demo_mvc.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace demo_mvc.Data.Service
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();  
        Task< Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task <Actor> UpdateAsync(int id,Actor actor);
        Task DeleteAsync(int id);
    }
}

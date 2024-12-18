using demo_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace demo_mvc.Data.Service
{
    public class CInemaService : ICinemaService
    {
        private readonly AppDbContext _context;

        public CInemaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Cinema cinema)
        {
            await _context.Cinemas.AddAsync(cinema);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            _context.Cinemas.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cinema>> GetAllAsync()
        {
            var result = await _context.Cinemas.ToListAsync();
            return result;
        }

        public async Task<Cinema> GetByIdAsync(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Cinema> UpdateAsync(int id, Cinema newcinema)
        {
            _context.Update(newcinema);
            await _context.SaveChangesAsync();
            return newcinema;
        }
    }
}


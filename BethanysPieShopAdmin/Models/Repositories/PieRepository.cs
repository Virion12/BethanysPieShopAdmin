
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopAdmin.Models.Repositories
{
    public class PieRepository : IPieRepository
    {
        private readonly BPSDdContext _context;

        public PieRepository(BPSDdContext context)
        {
            _context = context;
        }

        public async Task<int> AddPieAsync(Pie pie)
        {
            _context.Pies.Add(pie);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pie>> GetAllPiesAsync()
        {
            return await _context.Pies.OrderBy(p => p.PieId).AsNoTracking().ToListAsync();        }

        public async Task<Pie> GetPieById(int id)
        {
            return await _context.Pies.Include(p => p.Ingredients).Include(p => p.Category).AsNoTracking().FirstOrDefaultAsync(p => p.PieId == id);
        }
    }
}

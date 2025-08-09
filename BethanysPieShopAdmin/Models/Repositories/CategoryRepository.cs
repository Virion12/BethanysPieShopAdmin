using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopAdmin.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BPSDdContext _context;

        public CategoryRepository(BPSDdContext bPSDdContext)
        {
            _context = bPSDdContext;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(c => c.CategoryId);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.OrderBy(c => c.CategoryId).ToListAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
             return await _context.Categories.Include(p => p.Pies)
                .FirstOrDefaultAsync(c => c.CategoryId == id);
        }
    }
}

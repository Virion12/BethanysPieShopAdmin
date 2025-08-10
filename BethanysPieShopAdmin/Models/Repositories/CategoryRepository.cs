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

        public async Task<int> AddCategoryAsync(Category category)
        {
             bool isany = await _context.Categories.AnyAsync(C => C.CategoryName == category.CategoryName);

            if (isany)
            {
                throw new Exception("A categorry with this uid is already in the database");
            }
            _context.Categories.Add(category);
            return await _context.SaveChangesAsync();

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

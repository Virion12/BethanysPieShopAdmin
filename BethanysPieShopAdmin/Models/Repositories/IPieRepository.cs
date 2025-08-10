namespace BethanysPieShopAdmin.Models.Repositories
{
    public interface IPieRepository
    {
        Task<IEnumerable<Pie>> GetAllPiesAsync();
        Task<Pie> GetPieById(int id);
        Task<int> AddPieAsync(Pie pie);

    }
}

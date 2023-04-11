using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface ICategory : IBaseRepository<Category>{
    Task<Category> GetDetailedCategoryAsync(int sn);
    Task<List<Category>> GetAllCategoriesDetailedAsync(int CurrentPage, int PageSize);
}
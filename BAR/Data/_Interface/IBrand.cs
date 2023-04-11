using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IBrand : IBaseRepository<Brand>{
    Task<Brand> GetDetailedBrandAsync(int sn);
    Task<List<Brand>> GetAllBrandsDetailedAsync(int CurrentPage, int PageSize);
    Task<List<Brand>> GetBrandsOfThisCategory(Category ThisCategory,int CurrentPage, int PageSize);
}
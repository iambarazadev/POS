using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface ITax : IBaseRepository<Tax>{
    Task<Tax> GetDetailedTaxAsync(int sn);
    Task<List<Tax>> GetAllTaxesDetailedAsync(int CurrentPage, int PageSize);
    Task<List<Tax>> GetTaxesOfThisCategory(Category ThisCategory,int CurrentPage, int PageSize);
}
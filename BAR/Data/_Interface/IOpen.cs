using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IOpen : IBaseRepository<Open>{
    Task<Open> GetDetailedOpenAsync(int sn);
    Task<List<Open>> GetAllOpensDetailedAsync(int CurrentPage, int PageSize);
}
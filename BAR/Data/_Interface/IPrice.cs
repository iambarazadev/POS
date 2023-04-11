using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IPrice : IBaseRepository<Price>{
    Task<Price> GetDetailedPriceAsync(int sn);
    Task<List<Price>> GetAllPricesDetailedAsync(int CurrentPage, int PageSize);
}
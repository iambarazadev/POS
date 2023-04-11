using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IProduct : IBaseRepository<Product>{
    Task<Product> GetDetailedProductAsync(int sn);
    Task<List<Product>> GetAllProductsDetailedAsync(int CurrentPage, int PageSize);
}
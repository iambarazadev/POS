using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface ISupplier : IBaseRepository<Supplier>{
    Task<Supplier> GetDetailedSupplierAsync(int sn);
    Task<List<Supplier>> GetAllSuppliersDetailedAsync(int CurrentPage, int PageSize);
}
using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IProductGrn : IBaseRepository<ProductGrn>{
    int GetStockBeforeDate(int? Gid, int? Pid);
}
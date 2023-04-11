using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IProductOpen : IBaseRepository<ProductOpen>{
    int GetStockBeforeDate(int? Oid, int? Pid);
}
using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IStockAdjustmentProduct : IBaseRepository<StockAdjustmentProduct>{
    int GetStockAdjustmentBeforeDate(int? Sid, int? Pid);
}
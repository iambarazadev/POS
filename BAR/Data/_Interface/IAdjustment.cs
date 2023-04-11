using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IStockAdjustment : IBaseRepository<StockAdjustment>{
    Task<StockAdjustment> GetDetailedStockAdjustmentAsync(int sn);
    Task<List<StockAdjustment>> GetAllStockAdjustmentsDetailedAsync(int CurrentPage, int PageSize);
}
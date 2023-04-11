using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IHold : IBaseRepository<Hold>{
    Task<Hold> GetDetailedHoldAsync(int sn);
    Task<List<Hold>> GetAllHoldsDetailedAsync(int CurrentPage, int PageSize);
    Task<List<Hold>> GetAllHoldsDateWiseDetailedAsync(DateTime FromDate, DateTime ToDate);
    Task<List<Hold>> GetAllHoldsDateWiseWithUserDetailedAsync(DateTime FromDate, DateTime ToDate, int Uid);
}
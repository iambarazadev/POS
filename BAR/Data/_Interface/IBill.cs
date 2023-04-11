using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IBill : IBaseRepository<Bill>{
    Task<Bill> GetDetailedBillAsync(int sn);
    Task<List<Bill>> GetAllBillsDetailedAsync(int CurrentPage, int PageSize);
    Task<List<Bill>> GetAllBillsDateWiseDetailedAsync(DateTime FromDate, DateTime ToDate);
    Task<List<Bill>> GetAllBillsDateWiseWithUserDetailedAsync(DateTime FromDate, DateTime ToDate, int Uid);
}
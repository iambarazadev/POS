using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface ILog : IBaseRepository<Log>{
    Task<Log> GetDetailedLogAsync(int sn);
    Task<List<Log>> GetAllLogsDetailedAsync(int CurrentPage, int PageSize);
}
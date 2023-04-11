using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IGrn : IBaseRepository<Grn>{
    Task<Grn> GetDetailedGrnAsync(int sn);
    Task<List<Grn>> GetAllGrnsDetailedAsync(int CurrentPage, int PageSize);
}
using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IUser : IBaseRepository<User>{
    Task<User> GetDetailedUserAsync(int sn);
    Task<List<User>> GetAllUsersDetailedAsync(int CurrentPage, int PageSize);
}
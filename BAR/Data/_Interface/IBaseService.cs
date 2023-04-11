using System.Linq.Expressions;
using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IBaseRepository<T> where T : class{
    
    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    void UpdateRange(List<T> entities);
    
    Task<List<T>> GetAllRecords(int PageSize, int CurrentPage);
     
    int GetNoRecords();
    int GetIndexOf(T entity);
    
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
     
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities); 
    
}
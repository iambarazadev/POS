using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly BarContext _Context;
    internal DbSet<T>? MyDbSet {get;set;}
    
    public BaseRepository(BarContext ctx){
       
       this._Context = ctx ;
       this.MyDbSet = _Context.Set<T>(); 
    }
    
     
    public async Task AddAsync(T entity){
        await MyDbSet
        .AddAsync(entity); 
    }

    public async Task AddRangeAsync(IEnumerable<T> entities){
        await MyDbSet
        .AddRangeAsync(entities);
    }


    public void Remove(T entity){
       if(MyDbSet.Any()){
            MyDbSet
            .Remove(entity); 
       }
    }

    public void RemoveRange(IEnumerable<T> entities){
       if(MyDbSet.Any()){
            MyDbSet
            .RemoveRange(entities); 
       }
    }

    public virtual void Update(T entity){
        if(MyDbSet.Any()){
            MyDbSet
            .Update(entity); 
        } 
    }

    public void UpdateRange(List<T> entities){
       
       if(MyDbSet.Any()){
            MyDbSet
            .UpdateRange(entities); 
       }
    }

    public int GetNoRecords(){
        int Nothing = 0;
        if(MyDbSet.Any()){
           return  MyDbSet
            .ToList()
            .Count(); 
        }
        else{
            return Nothing;
        }  
    }

    public int GetIndexOf(T entity){
        int Nothing = 0;
            if(MyDbSet.Any()){
            return  MyDbSet
            .ToList()
            .IndexOf(entity); 
        }
        else{
            return Nothing;
        }
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate){
        List<T> Nothing = new();
        
        if(MyDbSet.Any()){
           return await MyDbSet
            .Where(predicate)
            .ToListAsync();  
        }else{
            return Nothing;
        } 
        
    }
    
    public async Task<List<T>> GetAllRecords(int PageSize, int CurrentPage){
        
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .ToListAsync();
        }
        else{
            return null;
        }
    }
    
    

}
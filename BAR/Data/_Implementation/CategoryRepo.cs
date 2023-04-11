using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class CategoryRepo :BaseRepository<Category>, ICategory{
    public CategoryRepo(BarContext ctx )
    : base(ctx)
    {}
  
  public async Task<Category> GetDetailedCategoryAsync(int sn){
        Category Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.CategoryId == sn)
            .Include(h => h.Log)
            .Include(g => g.User)
            .Include(a => a.Product)
                .ThenInclude(c => c.Brand)
            .Include(a => a.Product)
                .ThenInclude(c => c.ProductBarcode)
            .Include(a => a.Product)
                .ThenInclude(d => d.ProductPrice)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Category>> GetAllCategoriesDetailedAsync(int CurrentPage, int PageSize){
        List<Category> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(h => h.Log)
            .Include(g => g.User)
            .Include(a => a.Product)
                .ThenInclude(c => c.Brand)
            .Include(a => a.Product)
                .ThenInclude(c => c.ProductBarcode)
            .Include(a => a.Product)
                .ThenInclude(d => d.ProductPrice)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


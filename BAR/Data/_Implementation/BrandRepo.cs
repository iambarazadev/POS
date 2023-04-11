using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class BrandRepo :BaseRepository<Brand>, IBrand{
    public BrandRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Brand> GetDetailedBrandAsync(int sn){
        Brand Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.BrandId == sn)
            .Include(h => h.Log)
            .Include(g => g.User)
            .Include(a => a.Product)
                .ThenInclude(b => b.Category)
            .Include(a => a.Product)
                .ThenInclude(c => c.ProductBarcode)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Brand>> GetAllBrandsDetailedAsync(int CurrentPage, int PageSize){
        List<Brand> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(h => h.Log)
            .Include(g => g.User)
            .Include(a => a.Product)
                .ThenInclude(b => b.Category)
            .Include(a => a.Product)
                .ThenInclude(c => c.ProductBarcode)
            .OrderBy(x => x.BrandId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Brand>> GetBrandsOfThisCategory(Category ThisCategory, int CurrentPage, int PageSize){
        List<Brand> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(h => h.Log)
            .Include(g => g.User)
            .ToListAsync();
        }else{
            return Nothing;
        }
    }
}


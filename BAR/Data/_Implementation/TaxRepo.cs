using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class TaxRepo :BaseRepository<Tax>, ITax{
    public TaxRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Tax> GetDetailedTaxAsync(int sn){
        Tax Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.TaxId == sn)
            .Include(a => a.Product)
                .ThenInclude(b => b.Category)
            .Include(a => a.Product)
                .ThenInclude(c => c.ProductBarcode)
            .Include(a => a.Product)
                .ThenInclude(d => d.Brand)
            .Include(h => h.Log)
            .Include(g => g.User)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Tax>> GetAllTaxesDetailedAsync(int CurrentPage, int PageSize){
        List<Tax> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(l => l.Log)
            .Include(k => k.User)
            .Include(a => a.Product)
                .ThenInclude(b => b.Category)
            .Include(a => a.Product)
                .ThenInclude(c => c.ProductBarcode)
            .Include(a => a.Product)
                .ThenInclude(d => d.Brand)
            .OrderBy(x => x.TaxId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Tax>> GetTaxesOfThisCategory(Category ThisCategory, int CurrentPage, int PageSize){
        List<Tax> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .ToListAsync();
        }else{
            return Nothing;
        }
    }
}


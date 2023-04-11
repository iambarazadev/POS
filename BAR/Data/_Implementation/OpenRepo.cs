using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class OpenRepo :BaseRepository<Open>, IOpen{
    public OpenRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Open> GetDetailedOpenAsync(int sn){
        Open Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.OpenId == sn)
            .Include(a => a.ProductOpen)
                .ThenInclude(b => b.Product)
                    .ThenInclude(e => e.StockAdjustmentProduct)
                        .ThenInclude(f => f.StockAdjustment)
            .Include(a => a.ProductOpen)
                .ThenInclude(b => b.Product)
                    .ThenInclude(g => g.ProductPrice)
                        .ThenInclude(h => h.Price)
            .Include(a => a.ProductOpen)
                .ThenInclude(b => b.Product)
                    .ThenInclude(y => y.ProductBarcode)
            .Include(d => d.User)
            .Include(i => i.Log)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Open>> GetAllOpensDetailedAsync(int CurrentPage, int PageSize){
        List<Open> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.ProductOpen)
                .ThenInclude(b => b.Product)
                    .ThenInclude(e => e.StockAdjustmentProduct)
                        .ThenInclude(f => f.StockAdjustment)
            .Include(a => a.ProductOpen)
                .ThenInclude(b => b.Product)
                    .ThenInclude(g => g.ProductPrice)
                        .ThenInclude(h => h.Price)
            .Include(a => a.ProductOpen)
                .ThenInclude(b => b.Product)
                    .ThenInclude(y => y.ProductBarcode)
            .Include(d => d.User)
            .OrderBy(x => x.OpenId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


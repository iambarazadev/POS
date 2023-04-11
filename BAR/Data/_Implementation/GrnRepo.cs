using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class GrnRepo :BaseRepository<Grn>, IGrn{
    public GrnRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Grn> GetDetailedGrnAsync(int sn){
        Grn Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.GrnId == sn)
            .Include(a => a.ProductGrn)
                .ThenInclude(b => b.Product)
                    .ThenInclude(e => e.StockAdjustmentProduct)
                        .ThenInclude(f => f.StockAdjustment)
            .Include(a => a.ProductGrn)
                .ThenInclude(b => b.Product)
                    .ThenInclude(g => g.ProductPrice)
                        .ThenInclude(h => h.Price)
            .Include(a => a.ProductGrn)
                .ThenInclude(b => b.Product)
                    .ThenInclude(y => y.ProductBarcode)
            .Include(a => a.ProductGrn)
                .ThenInclude(b => b.Product)
                    .ThenInclude(z => z.ProductOpen)
            .Include(c => c.Supplier)
            .Include(d => d.User)
            .Include(i => i.Log)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Grn>> GetAllGrnsDetailedAsync(int CurrentPage, int PageSize){
        List<Grn> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.ProductGrn)
                .ThenInclude(b => b.Product)
                    .ThenInclude(e => e.StockAdjustmentProduct)
                        .ThenInclude(f => f.StockAdjustment)
            .Include(a => a.ProductGrn)
                .ThenInclude(b => b.Product)
                    .ThenInclude(g => g.ProductPrice)
                        .ThenInclude(h => h.Price)
            .Include(a => a.ProductGrn)
                .ThenInclude(b => b.Product)
                    .ThenInclude(y => y.ProductBarcode)
            .Include(a => a.ProductGrn)
                .ThenInclude(b => b.Product)
                    .ThenInclude(z => z.ProductOpen)
            .Include(c => c.Supplier)
            .Include(d => d.User)
            .Include(i => i.Log)
            .OrderBy(x => x.GrnId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


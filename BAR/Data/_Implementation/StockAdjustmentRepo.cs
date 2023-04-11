using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class StockAdjustmentRepo :BaseRepository<StockAdjustment>, IStockAdjustment{
    public StockAdjustmentRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<StockAdjustment> GetDetailedStockAdjustmentAsync(int sn){
        StockAdjustment Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.StockAdjustmentId == sn)
            .Include(a => a.StockAdjustmentProduct)
                .ThenInclude(b => b.Product)
                    .ThenInclude(d => d.ProductGrn)
                        .ThenInclude(e => e.Grn)
            .Include(a => a.StockAdjustmentProduct)
                .ThenInclude(b => b.Product)
                    .ThenInclude(d => d.ProductBarcode)
            .Include(a => a.StockAdjustmentProduct)
                .ThenInclude(b => b.Product)
                    .ThenInclude(e => e.ProductOpen)
            .Include(c => c.User)
            .Include(l => l.Log)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<StockAdjustment>> GetAllStockAdjustmentsDetailedAsync(int CurrentPage, int PageSize){
        List<StockAdjustment> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.StockAdjustmentProduct)
                .ThenInclude(b => b.Product)
                    .ThenInclude(d => d.ProductGrn)
                        .ThenInclude(e => e.Grn)
            .Include(a => a.StockAdjustmentProduct)
                .ThenInclude(b => b.Product)
                    .ThenInclude(d => d.ProductBarcode)
            .Include(a => a.StockAdjustmentProduct)
                .ThenInclude(b => b.Product)
                    .ThenInclude(e => e.ProductOpen)
            .Include(c => c.User)
            .Include(l => l.Log)
            .OrderBy(x => x.StockAdjustmentId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}
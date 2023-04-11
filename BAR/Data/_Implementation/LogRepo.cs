using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class LogRepo :BaseRepository<Log>, ILog{
    public LogRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Log> GetDetailedLogAsync(int sn){
        Log Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.LogId == sn)
            .Include(a => a.Product)
            .Include(b => b.Grn)
            .Include(c => c.Supplier)
            .Include(d => d.Category)
            .Include(e => e.Brand)
            .Include(f => f.Price)
            .Include(g => g.StockAdjustment)
            .Include(h => h.User)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Log>> GetAllLogsDetailedAsync(int CurrentPage, int PageSize){
        List<Log> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.Product)
            .Include(b => b.Grn)
            .Include(c => c.Supplier)
            .Include(d => d.Category)
            .Include(e => e.Brand)
            .Include(f => f.Price)
            .Include(g => g.StockAdjustment)
            .Include(h => h.User)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


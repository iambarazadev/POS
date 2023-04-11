using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class HoldRepo :BaseRepository<Hold>, IHold{
    public HoldRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Hold> GetDetailedHoldAsync(int sn){
        Hold Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.HoldId == sn)
            .Include(a => a.ProductHold)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductHold)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(d => d.User)
            .Include(e => e.Log)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Hold>> GetAllHoldsDetailedAsync(int CurrentPage, int PageSize){
        List<Hold> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.ProductHold)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductHold)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(d => d.User)
            .OrderBy(x => x.HoldId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
    
    
    public async Task<List<Hold>> GetAllHoldsDateWiseDetailedAsync(DateTime FromDate, DateTime ToDate){
        List<Hold> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Where(e => e.HoldDateCreated >= FromDate)
            .Where(f => f.HoldDateCreated <= ToDate)
            .Include(a => a.ProductHold)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductHold)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(d => d.User)
            .OrderBy(x => x.HoldId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Hold>> GetAllHoldsDateWiseWithUserDetailedAsync(DateTime FromDate, DateTime ToDate, int Uid){
        List<Hold> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Where(g => g.UserId == Uid)
            .Where(e => e.HoldDateCreated >= FromDate)
            .Where(f => f.HoldDateCreated <= ToDate)
            .Include(a => a.ProductHold)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductHold)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(d => d.User)
            .OrderBy(x => x.HoldId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}



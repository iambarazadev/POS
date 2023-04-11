using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class UserRepo :BaseRepository<User>, IUser{
    public UserRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<User> GetDetailedUserAsync(int sn){
        User Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.UserId == sn)
            .Include(a => a.Product)
            .Include(b => b.Grn)
            .Include(c => c.Supplier)
            .Include(d => d.Category)
            .Include(e => e.Brand)
            .Include(f => f.Price)
            .Include(g => g.StockAdjustment)
            .Include(h => h.Log)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<User>> GetAllUsersDetailedAsync(int CurrentPage, int PageSize){
        List<User> Nothing = new();
        
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
            .Include(h => h.Log)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


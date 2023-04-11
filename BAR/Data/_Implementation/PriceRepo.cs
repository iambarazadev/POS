using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class PriceRepo :BaseRepository<Price>, IPrice{
    public PriceRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Price> GetDetailedPriceAsync(int sn){
        Price Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.PriceId == sn)
            .Include(a => a.ProductPrice)
                .ThenInclude(b => b.Product)
                    .ThenInclude(y => y.ProductBarcode)
            .Include(a => a.ProductPrice)
                .ThenInclude(b => b.Product)
                    .ThenInclude(z => z.ProductGrn)
            .Include(a => a.ProductPrice)
                .ThenInclude(b => b.Product)
                    .ThenInclude(d => d.ProductOpen)
            .Include(n => n.User)
            .Include(i => i.Log)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Price>> GetAllPricesDetailedAsync(int CurrentPage, int PageSize){
        List<Price> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.ProductPrice)
                .ThenInclude(b => b.Product)
                    .ThenInclude(y => y.ProductBarcode)
            .Include(a => a.ProductPrice)
                .ThenInclude(b => b.Product)
                    .ThenInclude(z => z.ProductGrn)
            .Include(n => n.User)
            .OrderBy(x => x.PriceId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
    
}


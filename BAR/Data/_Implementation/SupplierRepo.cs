using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class SupplierRepo :BaseRepository<Supplier>, ISupplier{
    public SupplierRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Supplier> GetDetailedSupplierAsync(int sn){
        Supplier Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.SupplierId == sn)
            .Include(a => a.Grn)
                .ThenInclude(c => c.User)
            .Include(a => a.Grn)
                .ThenInclude(d => d.ProductGrn)
            .Include(b => b.User)
            .Include(i => i.Log)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Supplier>> GetAllSuppliersDetailedAsync(int CurrentPage, int PageSize){
        List<Supplier> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.Grn)
                .ThenInclude(c => c.User)
            .Include(a => a.Grn)
                .ThenInclude(d => d.ProductGrn)
            .Include(b => b.User)
            .OrderBy(x => x.SupplierId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


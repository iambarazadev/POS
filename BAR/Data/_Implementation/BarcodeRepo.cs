using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class BarcodeRepo :BaseRepository<Barcode>, IBarcode{
    public BarcodeRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Barcode> GetDetailedBarcodeAsync(int sn){
        Barcode Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.BarcodeId == sn)
            .Include(a => a.ProductBarcode)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductBarcode)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(a => a.ProductBarcode)
                .ThenInclude(b => b.Product)
                    .ThenInclude(d => d.ProductOpen)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Barcode>> GetAllBarcodesDetailedAsync(int CurrentPage, int PageSize){
        List<Barcode> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.ProductBarcode)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductBarcode)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .OrderBy(x => x.BarcodeId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


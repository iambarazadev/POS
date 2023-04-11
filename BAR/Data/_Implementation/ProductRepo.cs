using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class ProductRepo :BaseRepository<Product>, IProduct{
    public ProductRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Product> GetDetailedProductAsync(int sn){
        Product Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.ProductId == sn)
            .Include(y => y.ProductBarcode)
            .Include(a => a.Brand)
            .Include(b => b.Category)
            .Include(c => c.User)
            .Include(k => k.Tax)
            .Include(l => l.Log)
            .Include(d => d.ProductGrn)
                .ThenInclude(i => i.Grn)
                    .ThenInclude(j => j.Supplier)
            .Include(d => d.ProductGrn)
                .ThenInclude(i => i.Grn)
                    .ThenInclude(k => k.User)
            .Include(e => e.StockAdjustmentProduct)
                .ThenInclude(n => n.StockAdjustment)
                    .ThenInclude(o => o.User)
            .Include(f => f.ProductPrice)
                .ThenInclude(l => l.Price)
                    .ThenInclude(m => m.User)
            .Include(d => d.ProductOpen)
                .ThenInclude(dd => dd.Open)
                    .ThenInclude(cc => cc.User)
            .Include(g => g.Specs)
            .Include(h => h.ProductBill)
                .ThenInclude(i => i.Bill)
                    .ThenInclude(j => j.User)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Product>> GetAllProductsDetailedAsync(int CurrentPage, int PageSize){
        List<Product> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(y => y.ProductBarcode)
            .Include(a => a.Brand)
            .Include(b => b.Category)
            .Include(c => c.User)
            .Include(k => k.Tax)
            .Include(l => l.Log)
            .Include(d => d.ProductGrn)
                .ThenInclude(i => i.Grn)
                    .ThenInclude(j => j.Supplier)
            .Include(d => d.ProductGrn)
                .ThenInclude(i => i.Grn)
                    .ThenInclude(k => k.User)
            .Include(e => e.StockAdjustmentProduct)
                .ThenInclude(n => n.StockAdjustment)
                    .ThenInclude(o => o.User)
            .Include(f => f.ProductPrice)
                .ThenInclude(l => l.Price)
                    .ThenInclude(m => m.User)
            .Include(d => d.ProductOpen)
                .ThenInclude(dd => dd.Open)
                    .ThenInclude(cc => cc.User)
            .Include(g => g.Specs)
            .Include(h => h.ProductBill)
                .ThenInclude(i => i.Bill)
                    .ThenInclude(j => j.User)
            .OrderBy(h => h.ProductId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class BillRepo :BaseRepository<Bill>, IBill{
    public BillRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public async Task<Bill> GetDetailedBillAsync(int sn){
        Bill Nothing = new();
        
        if(sn > 0 && MyDbSet.Any()){
            return await MyDbSet
            .Where(x => x.BillId == sn)
            .Include(a => a.ProductBill)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductBill)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(d => d.User)
            .Include(h => h.Log)
            .SingleOrDefaultAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Bill>> GetAllBillsDetailedAsync(int CurrentPage, int PageSize){
        List<Bill> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .Include(a => a.ProductBill)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductBill)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(d => d.User)
            .Include(h => h.Log)
            .OrderBy(x => x.BillId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Bill>> GetAllBillsDateWiseDetailedAsync(DateTime FromDate, DateTime ToDate){
        List<Bill> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Where(e => e.BillDateCreated >= FromDate)
            .Where(f => f.BillDateCreated <= ToDate)
            .Include(a => a.ProductBill)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductBill)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(d => d.User)
            .Include(h => h.Log)
            .OrderBy(x => x.BillId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
    
    public async Task<List<Bill>> GetAllBillsDateWiseWithUserDetailedAsync(DateTime FromDate, DateTime ToDate, int Uid){
        List<Bill> Nothing = new();
        
        if(MyDbSet.Any()){
            return await MyDbSet
            .Where(g => g.UserId == Uid)
            .Where(e => e.BillDateCreated >= FromDate)
            .Where(f => f.BillDateCreated <= ToDate)
            .Include(l => l.Log)
            .Include(a => a.ProductBill)
                .ThenInclude(b => b.Product)
                    .ThenInclude(b => b.ProductPrice)
            .Include(a => a.ProductBill)
                .ThenInclude(b => b.Product)
                    .ThenInclude(c => c.ProductGrn)
            .Include(d => d.User)
            .Include(h => h.Log)
            .OrderBy(x => x.BillId)
            .ToListAsync();
        }
        else{
            return Nothing;
        }
    }
}


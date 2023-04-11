using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class ProductGrnRepo :BaseRepository<ProductGrn>, IProductGrn{
    public ProductGrnRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public int GetStockBeforeDate(int? Gid, int? Pid){
        int Nothing = 0;
        
        if(MyDbSet.Any()){
            return (int)MyDbSet
            .Where((a => a.GrnId < Gid))
            .Where((b => b.ProductId == Pid ))
            .Sum(a => a.ProductItemQty);   
        }
        else{
            return Nothing;
        }
    }
}
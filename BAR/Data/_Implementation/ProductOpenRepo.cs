using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class ProductOpenRepo :BaseRepository<ProductOpen>, IProductOpen{
    public ProductOpenRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public int GetStockBeforeDate(int? Oid, int? Pid){
        int Nothing = 0;
        
        if(MyDbSet.Any()){
            return (int)MyDbSet
            .Where((a => a.OpenId < Oid))
            .Where((b => b.ProductId == Pid ))
            .Sum(a => a.ProductItemQty);   
        }
        else{
            return Nothing;
        }
    }
}
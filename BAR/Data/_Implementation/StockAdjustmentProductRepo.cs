using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class StockAdjustmentProductRepo :BaseRepository<StockAdjustmentProduct>, IStockAdjustmentProduct{
    public StockAdjustmentProductRepo(BarContext ctx )
    : base(ctx)
    {}
    
    public int GetStockAdjustmentBeforeDate(int? Sid, int? Pid){
        int Nothing = 0;
        
        if(MyDbSet.Any()){
            return (int)MyDbSet
            .Where((a => a.StockAdjustmentId < Sid))
            .Where((b => b.ProductId == Pid ))
            .Sum(a => a.QtyAdjusted);   
        }
        else{
            return Nothing;
        }
    }
}
using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class ProductHoldRepo :BaseRepository<ProductHold>, IProductHold{
    public ProductHoldRepo(BarContext ctx )
    : base(ctx)
    {}
}
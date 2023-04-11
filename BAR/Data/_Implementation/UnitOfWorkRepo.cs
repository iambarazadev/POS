using BAR.Data.Database;
using BAR.Data._Interface;
using BAR.Data._Implementation;
using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BAR.Data._Implementation;

public class UnitOfWork : IUnitOfWork
{
    private readonly BarContext _Context;
   
    public UnitOfWork(BarContext ctx){
        this. _Context = ctx ;
        this.Categories = new CategoryRepo(_Context);
        this.Brands = new BrandRepo(_Context);
        this.Products = new ProductRepo(_Context);
        this.Suppliers = new SupplierRepo(_Context);
        this.Grns = new GrnRepo(_Context);
        this.Bills = new BillRepo(_Context);
        this.Taxes = new TaxRepo(_Context);
        this.Holds = new HoldRepo(_Context);
        this.ProductGrns = new ProductGrnRepo(_Context);
        this.Users = new UserRepo(_Context);
        this.StockAdjustments = new StockAdjustmentRepo(_Context);
        this.StockAdjustmentProducts = new StockAdjustmentProductRepo(_Context);
        this.Prices = new PriceRepo(_Context);
        this.ProductPrices = new ProductPriceRepo(_Context);
        this.Barcodes = new BarcodeRepo(_Context);
        this.Opens = new OpenRepo(_Context);
        this.ProductOpens = new ProductOpenRepo(_Context);
        this.ProductBills = new ProductBillRepo(_Context);
        this.ProductHolds = new ProductHoldRepo(_Context);
        this.Logs = new LogRepo(_Context);
    } 
    
    public ICategory Categories{get; private set;}
    public IBrand Brands{get; private set;}
    public IBill Bills{get; private set;}
    public ITax Taxes{get; private set;}
    public IHold Holds{get; private set;}
    public IProduct Products{get; private set;}
    public ISupplier Suppliers{get; private set;}
    public IGrn Grns{get; private set;}
    public IOpen Opens{get; private set;}
    public IProductOpen ProductOpens{get; private set;}
    public IProductBill ProductBills{get; private set;}
    public IProductHold ProductHolds{get; private set;}
    public IProductGrn ProductGrns{get; private set;}
    public IUser Users{get; private set;}
    public IStockAdjustment StockAdjustments{get; private set;}
    public IStockAdjustmentProduct StockAdjustmentProducts{get; private set;}
    public IPrice Prices{get; private set;}
    public IProductPrice ProductPrices{get; private set;}
    public IBarcode Barcodes{get; private set;}
    public ILog Logs{get; private set;}
    
    public async Task CompleteAsync(){ 
       await  _Context.SaveChangesAsync();
    }
    
    public void Complete(){ 
        _Context.SaveChanges();
    }

    public void Dispose(){
        _Context.Dispose();
    }
}

using BAR.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BAR.Data.Database;

public class BarContext : DbContext{
    
   protected readonly IConfiguration Configuration;

   public BarContext(IConfiguration configuration){
      Configuration = configuration; 
    }
   
    protected override void OnConfiguring(DbContextOptionsBuilder options){
        
        // connect to mysql with connection string from app settings 
        var connectionString = Configuration.GetConnectionString("Default");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
      }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        
    // Many To Many Product To Grn Via ProductGrns  
      modelBuilder.Entity<ProductGrn>()
      .HasKey(sc => new { sc.ProductId, sc.GrnId });
    
      modelBuilder.Entity<ProductGrn>()
      .HasOne<Product>(sc => sc.Product)
      .WithMany(s => s.ProductGrn)
      .HasForeignKey(sc => sc.ProductId);
      
      modelBuilder.Entity<ProductGrn>()
      .HasOne<Grn>(sc => sc.Grn)
      .WithMany(s => s.ProductGrn)
      .HasForeignKey(sc => sc.GrnId);
      

    // Many To Many Retail Adjustments, Price via ProductsPrice
      modelBuilder.Entity<ProductPrice>()
      .HasKey(sc => new { sc.ProductId, sc.PriceId });
    
      modelBuilder.Entity<ProductPrice>()
      .HasOne<Product>(sc => sc.Product)
      .WithMany(s => s.ProductPrice)
      .HasForeignKey(sc => sc.ProductId);
      
      modelBuilder.Entity<ProductPrice>()
      .HasOne<Price>(sc => sc.Price)
      .WithMany(s => s.ProductPrice)
      .HasForeignKey(sc => sc.PriceId); 
     
    
    // Many To Many Stock Adjustments, Product via StockAdjustmentsProduct
      modelBuilder.Entity<StockAdjustmentProduct>()
      .HasKey(sc => new { sc.StockAdjustmentId, sc.ProductId });
    
      modelBuilder.Entity<StockAdjustmentProduct>()
      .HasOne<StockAdjustment>(sc => sc.StockAdjustment)
      .WithMany(s => s.StockAdjustmentProduct)
      .HasForeignKey(sc => sc.StockAdjustmentId);
      
      modelBuilder.Entity<StockAdjustmentProduct>()
      .HasOne<Product>(sc => sc.Product)
      .WithMany(s => s.StockAdjustmentProduct)
      .HasForeignKey(sc => sc.ProductId); 
      
      
      // Many To Many Retail Adjustments, Price via ProductsPrice
      modelBuilder.Entity<ProductBill>()
      .HasKey(sc => new { sc.ProductId, sc.BillId });
    
      modelBuilder.Entity<ProductBill>()
      .HasOne<Product>(sc => sc.Product)
      .WithMany(s => s.ProductBill)
      .HasForeignKey(sc => sc.ProductId);
      
      modelBuilder.Entity<ProductBill>()
      .HasOne<Bill>(sc => sc.Bill)
      .WithMany(s => s.ProductBill)
      .HasForeignKey(sc => sc.BillId); 
      
      
      // Many To Many RBarcode product
      modelBuilder.Entity<ProductBarcode>()
      .HasKey(sc => new { sc.ProductId, sc.BarcodeId });
    
      modelBuilder.Entity<ProductBarcode>()
      .HasOne<Product>(sc => sc.Product)
      .WithMany(s => s.ProductBarcode)
      .HasForeignKey(sc => sc.ProductId);
      
      modelBuilder.Entity<ProductBarcode>()
      .HasOne<Barcode>(sc => sc.Barcode)
      .WithMany(s => s.ProductBarcode)
      .HasForeignKey(sc => sc.BarcodeId); 
      
      // Many To Many open product
      modelBuilder.Entity<ProductOpen>()
      .HasKey(sc => new { sc.ProductId, sc.OpenId });
    
      modelBuilder.Entity<ProductOpen>()
      .HasOne<Product>(sc => sc.Product)
      .WithMany(s => s.ProductOpen)
      .HasForeignKey(sc => sc.ProductId);
      
      modelBuilder.Entity<ProductOpen>()
      .HasOne<Open>(sc => sc.Open)
      .WithMany(s => s.ProductOpen)
      .HasForeignKey(sc => sc.OpenId); 
      
      
      // Many To Many Hold product
      modelBuilder.Entity<ProductHold>()
      .HasKey(sc => new { sc.ProductId, sc.HoldId });
    
      modelBuilder.Entity<ProductHold>()
      .HasOne<Product>(sc => sc.Product)
      .WithMany(s => s.ProductHold)
      .HasForeignKey(sc => sc.ProductId);
      
      modelBuilder.Entity<ProductHold>()
      .HasOne<Hold>(sc => sc.Hold)
      .WithMany(s => s.ProductHold)
      .HasForeignKey(sc => sc.HoldId); 

    } 
    
    
    
    public virtual DbSet<Product> products {get;set;}
    public virtual DbSet<Category> categories {get;set;}
    public virtual DbSet<Grn> grns {get;set;}
    public virtual DbSet<Bill> bills {get;set;}
    public virtual DbSet<Tax> taxes {get;set;}
    public virtual DbSet<Open> opens {get;set;}
    public virtual DbSet<Supplier> suppliers {get;set;}
    public virtual DbSet<Brand> brands {get;set;}
    public virtual DbSet<Specs> specs {get;set;}
    public virtual DbSet<StockAdjustment> stockadjustments {get;set;}
    public virtual DbSet<User> users {get;set;}
    public virtual DbSet<Price> prices {get;set;}
    public virtual DbSet<Barcode> barcodes {get;set;}
    public virtual DbSet<ProductBarcode> productbarcodes {get;set;}
    public virtual DbSet<ProductGrn> productgrns {get;set;}
    public virtual DbSet<ProductOpen> productopens {get;set;}
    public virtual DbSet<StockAdjustmentProduct> stockadjustmentproducts {get;set;}
    public virtual DbSet<ProductPrice> productprices {get;set;}
    public virtual DbSet<ProductBill> productbills {get;set;}
    public virtual DbSet<Hold> holds {get;set;}
    public virtual DbSet<ProductHold> productholds {get;set;}
    public virtual DbSet<Log> logs {get;set;}
  
    
}
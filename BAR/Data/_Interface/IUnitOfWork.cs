using System;

namespace BAR.Data._Interface;

public interface IUnitOfWork : IDisposable {
   ICategory Categories {get;}
   IBrand Brands {get;}
   ISupplier Suppliers {get;}
   IGrn Grns {get;}
   IOpen Opens {get;}
   IBill Bills {get;}
   ITax Taxes {get;}
   IHold Holds {get;}
   IProduct Products{get;}
   IProductGrn ProductGrns {get;}
   IProductOpen ProductOpens {get;}
   IProductPrice ProductPrices {get;}
   IProductBill ProductBills {get;}
   IProductHold ProductHolds {get;}
   IUser Users {get;}
   IBarcode Barcodes {get;}
   IStockAdjustment StockAdjustments {get;}
   IStockAdjustmentProduct StockAdjustmentProducts {get;}
   IPrice Prices {get;}
   ILog Logs {get;}
   Task CompleteAsync();
   void Complete();
   void Dispose();
}
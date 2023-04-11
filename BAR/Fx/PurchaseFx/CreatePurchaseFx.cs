using System;
using System.ComponentModel.DataAnnotations;
namespace BAR.Fx.PurchaseFx;

public class CreatePurchaseFx{
    public string GrnReceiptCode { get; set; } = "";
    public double GrnReceiptAmount {get;set;}
    public DateTime GrnReceiptDateCreated { get; set; } 
    public int SupplierId {get;set;}
    public int? ProductItemQty {get;set;} = null;
    public int? StockAtPurchaseTime {get;set;} = null;
    public double? ProductItemCost {get;set;} = null;
    public double? OldPrice {get;set;} = null;
    public double? LatestPrice {get;set;} = null;
    public int? ProductId {get;set;} = null;
    public string ProductCode {get;set;}
    public string ProductCaption {get;set;}="";
}
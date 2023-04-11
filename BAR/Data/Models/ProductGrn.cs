using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class ProductGrn{
    
    public int? GrnId { get; set; } 
    public virtual Grn? Grn {get;set;}   
    
    public int? ProductId { get; set; } 
    public virtual Product? Product {get;set;}
    
    public int StockAtPurchaseTime{get;set;}
    public int? ProductItemQty{get;set;}
    public double? ProductItemCost{get;set;}
    
    //ctor
    public ProductGrn()
    {
        this.ProductId = null;
        this.Product = null;
        this.GrnId = null;
        this.Grn = null;
        this.ProductItemCost = null;
        this.ProductItemQty = null;
        this.StockAtPurchaseTime = 0;
    }

}
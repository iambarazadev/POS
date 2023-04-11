using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class ProductHold{
    
    [ForeignKey("Product")]
    public int? ProductId {get;set;}
    public virtual Product? Product {get;set;}
    
    [ForeignKey("Hold")]
    public int? HoldId {get;set;}
    public virtual Hold? Hold {get;set;}
    
    public int QtyPurchased {get;set;}
    public double HoldItemPrice {get;set;}
    public double HoldItemCost { get; set; }

    //ctor
    public ProductHold()
    {
        this.ProductId = null;
        this.Product = null;
        this.HoldId = null;
        this.Hold = null;
        this.QtyPurchased = 0;
        this.HoldItemPrice = 0.0;
        this.HoldItemCost = 0.0;
    }
}
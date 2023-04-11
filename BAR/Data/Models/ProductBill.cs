using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class ProductBill{
    
    [ForeignKey("Product")]
    public int? ProductId {get;set;}
    public virtual Product? Product {get;set;}
    
    [ForeignKey("Bill")]
    public int? BillId {get;set;}
    public virtual Bill? Bill {get;set;}
    
    public int QtyPurchased {get;set;}
    public double BillItemPrice {get;set;}
    public double BillItemCost {get;set;}
    
    //ctor
    public ProductBill()
    {
        this.ProductId = null;
        this.Product = null;
        this.BillId = null;
        this.Bill = null;
        this.BillItemPrice = 0.0;
    }
}
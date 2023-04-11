using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class ProductPrice{
       
    public int? ProductId {get;set;}
    public Product? Product {get;set;}
      
    public int? PriceId {get;set;}
    public Price? Price {get;set;}
    
    public double OldPrice {get;set;}
    public double LatestPrice {get;set;}
    public double AtThisAverageCost {get;set;}
    public int AtStock {get;set;}
    public string Status {get;set;}
    
    //ctor
    public ProductPrice()
    {
        this.ProductId = null;
        this.Product = null;
        this.PriceId = null;
        this.Price = null;
        this.OldPrice = 0.0;
        this.LatestPrice = 0.0;
        this.AtThisAverageCost = 0.0;
        this.AtStock = 0;
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class ProductOpen{
    
    public double? ProductItemCost{get;set;}
    public int? ProductItemQty{get;set;} = 0;
     
    public int? OpenId { get; set; } 
    public virtual Open? Open {get;set;}   
    
    public int? ProductId { get; set; } 
    public virtual Product? Product {get;set;}
    
    //ctor
    public ProductOpen()
    {
        this.ProductId = null;
        this.Product = null;
        this.OpenId = null;
        this.Open = null;
        this.ProductItemCost = null;
        this.ProductItemQty = null;
    }
}
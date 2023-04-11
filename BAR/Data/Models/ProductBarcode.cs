using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class ProductBarcode{
       
    public int? ProductId {get;set;}
    public Product? Product {get;set;}
      
    public int? BarcodeId {get;set;}
    public Barcode? Barcode {get;set;}
  
    public string? BarcodeNumber{get;set;}
    
    // ctor
    public ProductBarcode()
    {
        this.ProductId = null;
        this.Product = null;
        this.BarcodeId = null;
        this.Barcode = null;
        this.BarcodeNumber = null;
    }
}
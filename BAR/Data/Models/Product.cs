using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Product{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId{get;set;}
    public string? ProductCode { get; set; } 
    
    [Required(ErrorMessage="Product Caption, Range Characters(2 - 50) characters"),MaxLength(50),MinLength(2),DataType(DataType.Text)]  
    public string? ProductCaption { get; set; } 
    public DateTime ProductDateCreated {get;set;}
    
    
// related Many To One Model
    
    public int? CategoryId {get;set;}
    public virtual Category? Category{get;set;}
    
    public int? BrandId {get;set;}
    public virtual Brand? Brand{get;set;}
    
    public int? TaxId {get;set;}
    public virtual Tax? Tax{get;set;}
    
    // One To Many One Product can be updated by Many User
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    
    public virtual List<ProductGrn>? ProductGrn{get;set;}  
    public virtual List<ProductOpen>? ProductOpen{get;set;}  
    public virtual List<StockAdjustmentProduct>? StockAdjustmentProduct{get;set;}
    public virtual List<ProductPrice>? ProductPrice{get;set;}
    public virtual List<ProductBill>? ProductBill{get;set;}
    public virtual List<ProductHold>? ProductHold{get;set;}
    public virtual List<ProductBarcode>? ProductBarcode {get;set;}
    
    // One to one with specs
    public virtual Specs? Specs{get;set;}
    
    //Ctor
    public Product()
    {
        this.ProductId = default;
        this.ProductCode = null;
        this.ProductCaption = null;
        this.CategoryId = null;
        this.Category = null;
        this.BrandId = null;
        this.Brand = null;
        this.UserId = null;
        this.User = null;
        this.LogId = null;
        this.Log = null;
        this.TaxId = 1;
        this.ProductDateCreated = DateTime.Now;
        
    }
}
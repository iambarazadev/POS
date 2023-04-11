using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Fx.ProductFx;

public class CreateOrUpdateProductFx{
    
    public string? ProductCode { get; set; } 
    
    [Required(ErrorMessage="Reuired, Range Characters(2 - 25) characters"),MaxLength(25),MinLength(2),DataType(DataType.Text)]  
    public string? ProductCaption { get; set; } 
    
    public int? CategoryId {get;set;}
    public int? BrandId {get;set;}
    
    public int TaxId {get;set;}
    
    [Required(ErrorMessage="Reuired, Range Characters(5 - 50) characters"),MaxLength(50),MinLength(5),DataType(DataType.Text)]  
    public string? Description {get;set;}
    public List<string>? ProductBarcode {get;set;}
    
    //Ctor
    public CreateOrUpdateProductFx()
    {
        this.CategoryId = null;
        this.BrandId = null;
        this.TaxId = 1;
        this.Description = null;
        this.ProductCaption = null;
        this.ProductBarcode = new();
    }
}
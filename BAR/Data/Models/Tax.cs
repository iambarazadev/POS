using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Tax{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaxId {get;set;}
    public string? TaxCode {set;get;}
    
    [Required(ErrorMessage="Tax Caption, Range Characters(2 - 50) characters"),MaxLength(50),MinLength(2),DataType(DataType.Text)] 
    public string? TaxCaption {set;get;}
    
    public double? TaxValue {get;set;}
    
    [Required(ErrorMessage="Please enter your Message, Range Characters(10 - 300)"),MaxLength(600),MinLength(3),DataType(DataType.Text)] 
    public string? TaxDescription {set;get;}
    public DateTime TaxDateCreated {set;get;}
    
    
#nullable enable
    
    // Many Products can be stored in this Tax
    public virtual List<Product>? Product {get;set;}
    
    // One To Many Single user at a time can update this Tax
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    
    // ctor
    public Tax()
    {
        this.TaxId = default;
        this.TaxCode = null;
        this.TaxValue = null;
        this.TaxCaption = null;
        this.TaxDescription = null;
        this.UserId = null;
        this.User = null;
        this.LogId = null;
        this.Log = null;
        this.TaxDateCreated = DateTime.Now;
    }
}
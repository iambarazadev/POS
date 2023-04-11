using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Brand{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BrandId {get;set;}
    public string? BrandCode {set;get;}
    
    [Required(ErrorMessage="Brand Caption, Range Characters(2 - 50) characters"),MaxLength(50),MinLength(2),DataType(DataType.Text)] 
    public string? BrandCaption {set;get;}
    
    [Required(ErrorMessage="Please enter your Message, Range Characters(10 - 300)"),MaxLength(600),MinLength(3),DataType(DataType.Text)] 
    public string? BrandDescription {set;get;}
    public DateTime BrandDateCreated {set;get;}
    
    
#nullable enable
    
    // Many Products can be stored in this Brand
    public virtual List<Product>? Product {get;set;}
    
    // One To Many Single user at a time can update this Brand
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    
    // ctor
    public Brand()
    {
        this.BrandId = default;
        this.BrandCode = null;
        this.BrandCaption = null;
        this.BrandDescription = null;
        this.UserId = null;
        this.User = null;
        this.LogId = null;
        this.Log = null;
        this.BrandDateCreated = DateTime.Now;
    }
}
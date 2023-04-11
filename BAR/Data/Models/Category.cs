using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Category{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryId {get;set;}
    public string? CategoryCode {set;get;}
    
    [Required(ErrorMessage="Category Caption, Range Characters(2 - 50) characters"),MaxLength(50),MinLength(2),DataType(DataType.Text)] 
    public string? CategoryCaption {set;get;}
    
    [Required(ErrorMessage="Please enter your Message, Range Characters(10 - 300)"),MaxLength(600),MinLength(3),DataType(DataType.Text)] 
    public string? CategoryDescription {set;get;}
    public DateTime CategoryDateCreated {set;get;}
    
    
#nullable enable
    
    // Many Products can be stored in this Category
    public virtual List<Product>? Product {get;set;}
    
    // One To Many Single user at a time can update this category
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    
    // ctor
    public Category()
    {
        this.CategoryId = default;
        this.CategoryCode = null;
        this.CategoryCaption = null;
        this.CategoryDescription = null;
        this.UserId = null;
        this.User = null;
        this.LogId = null;
        this.Log = null;
        this.CategoryDateCreated = DateTime.Now;
    }
}
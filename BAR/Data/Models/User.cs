using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class User{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId {get;set;}
    public string? UserCode {get;set;}
     
    [Required(ErrorMessage="Valid e-mail address please!"),MaxLength(30),MinLength(3),DataType(DataType.EmailAddress)]
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")] 
    public string? UserEmail {get;set;}
    
    public string? UserPhone {get;set;}
     
    [Required(ErrorMessage="Please enter name"),MaxLength(20),MinLength(2)] 
    public string? UserFirstName {get;set;}
     
    [Required(ErrorMessage="Please enter name"),MaxLength(20),MinLength(2)]
    public string? UserLastName {get;set;}
    
    [Required(ErrorMessage="Please assign Access Level")] 
    public string? UserAccessLevel {get;set;} 
    public DateTime UserDateCreated {get;set;}
     
    [Required]
    [StringLength(18, ErrorMessage = "Min 8 chars atleast one numb, char & symbol", MinimumLength = 6)]
    [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
    [DataType(DataType.Password)] 
    public string? UserPassword {get;set;}
    
    [Required(ErrorMessage="Please enter your Message, Range Characters(3 - 300)"),MaxLength(600),MinLength(3),DataType(DataType.Text)] 
    public string? UserAddress {get;set;}
     
    [Required(ErrorMessage="Please assign User Status")] 
    public string? UserStatus {get;set;}

#nullable enable 
    // collections foreign keys
    public virtual List<Product>? Product {get;set;}  
    public virtual List<Grn>? Grn {get;set;}  
    public virtual List<Category>? Category {get;set;}  
    public virtual List<Brand>? Brand {get;set;} 
    public virtual List<Supplier>? Supplier {get;set;}
    public virtual List<Price>? Price{get;set;}
    public virtual List<Bill>? Bill {get;set;}  
    public virtual List<StockAdjustment>? StockAdjustment{get;set;}
    public virtual List<Open>? Open{get;set;} 
    public virtual List<Log>? Log {get;set;}  
    public virtual List<Tax>? Tax {get;set;}  
    public virtual List<Hold>? Hold {get;set;}  
    
    
    public User()
    {
        this.UserId = default;
        this.UserCode = null;
        this.UserFirstName = null;
        this.UserLastName = null;
        this.UserEmail = null;
        this.UserPhone = null;
        this.UserAccessLevel = null;
        this.UserDateCreated = DateTime.Now;
    }
}

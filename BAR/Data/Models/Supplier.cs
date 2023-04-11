using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Supplier{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SupplierId{get;set;}
    public string? SupplierCode {get;set;}
   
    [Required(ErrorMessage="Supplier Name Range Characters(2 - 100) characters"),MaxLength(100),MinLength(2),DataType(DataType.Text)]  
    public string? SupplierName {get;set;}
    
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")] 
    public string? SupplierEmail {get;set;}
   
    [Required(ErrorMessage="Supplier Phone Number is Required :")] 
    public string? SupplierPhone {get;set;}
    
    public string? SupplierTIN {get;set;}
   
    [Required(ErrorMessage="Address has to be 3 - 10 characters")]
    [DataType(DataType.Text)]
    [MaxLength(100), MinLength(3)] 
    public string? SupplierAddress {get;set;}
    
    [Required(ErrorMessage="Describe with atleast 3 - 10 characters")]
    [DataType(DataType.Text)]
    [MaxLength(100), MinLength(3)] 
    public string? SupplierDescription {get;set;}
    
    public DateTime SupplierDateCreated {get;set;}
    
    

#nullable enable   
    
    // collections foreign keys
    public virtual List<Grn>? Grn {get;set;} 
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    
    public Supplier()
    {
        this.SupplierId = default;
        this.SupplierCode = null;
        this.SupplierName = null;
        this.SupplierEmail = null;
        this.SupplierPhone = null;
        this.SupplierTIN = null;
        this.SupplierDescription = null;
        this.SupplierAddress = null;
        this.SupplierDateCreated = DateTime.Now;
    }
    
}
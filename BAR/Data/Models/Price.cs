using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Price{
    
    // Retail Price Info
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PriceId {get;set;} 
    public string? PriceCode{get;set;}
    public DateTime DateOfIssue {get;set;}
    public string? PriceReason {get;set;}
    public virtual List<ProductPrice>? ProductPrice{get;set;}
    public int? UserId {get;set;}
    public User? User{get;set;} 
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    public string? PricePurpose {get;set;}
    
    //Ctor
    public Price()
    {
        this.PriceId = default;
        this.PriceCode = null;
        this.PriceReason = null;
        this.PricePurpose = null;
        this.UserId = null;
        this.User = null;
        this.LogId = null;
        this.Log = null;
        this.DateOfIssue = DateTime.Now;
    }
}
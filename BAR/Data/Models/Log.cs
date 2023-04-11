using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Log{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LogId {get;set;}
    public string? LogCode {get;set;}
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public DateTime LogDateTimeIn {get;set;}
    public DateTime LogDateTimeOut {get;set;}
    public DateTime LogDateCreated {get;set;}
   
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
    public virtual List<Tax>? Tax {get;set;}  
    public virtual List<Hold>? Hold {get;set;}  
    
    public Log()
    {
        this.LogDateTimeIn = DateTime.Now;
        this.LogDateCreated = DateTime.Now;
    }
}
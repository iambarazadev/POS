using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class StockAdjustment{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StockAdjustmentId {get;set;}
    public string? StockAdjustmentCode{get;set;}
    public string? StockAdjustmentsReasons{get;set;}
    public DateTime DateOfIssue {get;set;}
    public virtual List<StockAdjustmentProduct>? StockAdjustmentProduct{get;set;}
    
    public int? UserId {get;set;}
    public User? User{get;set;} 
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    
    public StockAdjustment()
    {
        
        this.StockAdjustmentId = default;
        this.StockAdjustmentCode = null;
        this.StockAdjustmentsReasons = null;
        this.UserId = null;
        this.User = null;
        this.DateOfIssue = DateTime.Now;
    }
}
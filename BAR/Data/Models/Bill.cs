using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;


public class Bill{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BillId {get;set;}
    public string? BillCode {set;get;}
    public DateTime BillDateCreated {set;get;}
    
    
#nullable enable
    // One To Many Single user at a time can update this Bill
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    public virtual List<ProductBill>? ProductBill{get;set;}
    
    // ctor
    public Bill()
    {
        this.BillId = default;
        this.BillCode = null;
        this.UserId = null;
        this.User = null;
        this.LogId = null;
        this.Log = null;
        this.BillDateCreated = DateTime.Now;
    }
}
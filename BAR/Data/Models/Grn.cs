using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Grn{
    
    // Grn Info
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrnId {get;set;}
    public string? GrnCode { get; set; }
    public DateTime GrnDateCreated { get; set; } 
    
    //Receipt info
    public string? GrnReceiptCode { get; set; }
    public DateTime GrnReceiptDateCreated { get; set; } 
    
#nullable enable

    public int? SupplierId {get;set;}
    public virtual Supplier? Supplier{get;set;}
    
    public virtual List<ProductGrn>? ProductGrn{get;set;}
    
    // One user can create one or many grn
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    
    // ctor
    public Grn()
    {
        this.GrnId = default;
        this.GrnCode = null;
        this.GrnReceiptCode = null;
        this.GrnReceiptDateCreated = DateTime.Now;
        this.SupplierId = null;
        this.Supplier = null;
        this.UserId = null;
        this.LogId = null;
        this.Log = null;
        this.User = null;
        this.GrnDateCreated = DateTime.Now;
    }
}
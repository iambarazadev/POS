using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;


public class Hold{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HoldId {get;set;}
    public string? HoldCode {set;get;}
    public DateTime HoldDateCreated {set;get;}
    
    
#nullable enable
    // One To Many Single user at a time can update this Hold
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    public virtual List<ProductHold>? ProductHold{get;set;}
    
    // ctor
    public Hold()
    {
        this.HoldId = default;
        this.HoldCode = null;
        this.UserId = null;
        this.User = null;
        this.LogId = null;
        this.Log = null;
        this.HoldDateCreated = DateTime.Now;
    }
}
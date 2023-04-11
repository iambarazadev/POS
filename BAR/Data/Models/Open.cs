using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Open{
    
    // Open Info
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OpenId {get;set;}
    public string? OpenCode { get; set; }
    public DateTime OpenDateCreated { get; set; } 
    
    
#nullable enable
    
    public List<ProductOpen>? ProductOpen{get;set;}
    
    // One user can create one or many Open
    public int? UserId {get;set;}
    public virtual User? User{get;set;}
    public int? LogId {get;set;}
    public virtual Log? Log{get;set;}
    
    // ctor
    public Open()
    {
        this.OpenId = default;
        this.OpenCode = null;
        this.UserId = null;
        this.User = null;
        this.LogId = null;
        this.Log = null;
        this.OpenDateCreated = DateTime.Now;
    }
    
}
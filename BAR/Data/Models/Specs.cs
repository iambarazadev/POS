using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Specs{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SpecsId {get;set;}
    public string? SpecsCode {set;get;}
    public int? Ram{get;set;}
    public string? Processor{get;set;}
    public int? StorageSize{get;set;}
    public string? StorageType {set;get;}
    public int? SimCardSlots{get;set;} 
    public string? DisplayTypeSize{get;set;} 
    public bool Bluetooth{get;set;}
    public bool WiFi{get;set;}
    public bool MemoryCard{get;set;}
    public string? CableType{get;set;}
    public string? CableLength{get;set;}
    public string? Os{get;set;}
    public string? SpecsDescription{get;set;}
    
    
#nullable enable

    // One to one with product
    [ForeignKey("Product")]
    public int ProductId{get;set;}
    public virtual Product? Product {get;set;}
    
    public Specs()
    {
        this.SpecsCode = null;
        this.Ram = null;
        this.Processor = null;
        this.StorageSize = null;
        this.StorageType = null;
        this.SimCardSlots = null;
        this.DisplayTypeSize = null;
        this.Bluetooth = false;
        this.WiFi = false;
        this.MemoryCard = false;
        this.CableLength = null;
        this.CableType = null;
        this.Os = null;
        this.SpecsDescription = null;
    }
}
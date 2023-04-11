using System;
using System.ComponentModel.DataAnnotations;
namespace BAR.Fx.OpenFx;

public class CreateOpenFx{
    public DateTime OpenReceiptDateCreated { get; set; } 
    public double? ProductItemCost{get;set;} = null;
    public int? ProductItemQty{get;set;} = null;
    public double? OldPrice{get;set;} = null;
    public double? LatestPrice{get;set;} = null;
    public int? ProductId {get;set;} = null;
    public string ProductCode {get;set;}
    public string ProductCaption {get;set;}="";
    
}
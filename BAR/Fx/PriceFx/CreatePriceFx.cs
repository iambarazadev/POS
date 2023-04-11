using System;
using System.ComponentModel.DataAnnotations;
namespace BAR.Fx.PriceFx;

public class CreatePriceFx{

    public int PriceId {get;set;}
    public string? PriceCode{get;set;}
    public string? PriceReasons{get;set;} = "";
    public int? ProductId {get;set;} = null;
    public string ProductCode {get;set;}
    public string ProductCaption {get;set;} ="";
    public double? OldPrice{get;set;} = null;
    public double? LatestPrice{get;set;} = null;
    public double? AtThisCost{get;set;} = null;
    public int AtStock{get;set;}
    
}
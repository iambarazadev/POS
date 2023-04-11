using System;
using System.ComponentModel.DataAnnotations;
namespace BAR.Fx.AdjustmentFx;

public class CreateAdjustmentFx{

    public int StockAdjustmentId {get;set;}
    public string? StockAdjustmentCode{get;set;}
    public string? StockAdjumentsReasons{get;set;} = "";
    public int? ProductId {get;set;}
    public string ProductCode {get;set;}
    public string ProductCaption {get;set;}="";
    public int QtyAdjusted{get;set;}
    public int? NewStock{get;set;}
    public int? OldStock{get;set;}
    public double ProductItemCost{get;set;}
    public double ProductItemRetail{get;set;}
    
}
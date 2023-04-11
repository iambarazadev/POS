using System;
using System.ComponentModel.DataAnnotations;
namespace BAR.Fx.BillsFx;

public class BillFx{
    public int ProductItemQty{get;set;} = 0;
    public double BillPrice{get;set;}
    public double BillCost {get;set;}
    public int ProductId {get;set;}
    public string ProductCode {get;set;}
    public string ProductCaption {get;set;}="";
}
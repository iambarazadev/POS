using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;


public class StockAdjustmentProduct{
    
    public int? StockAdjustmentId {get;set;}
    public StockAdjustment? StockAdjustment{get;set;}
    
    public int? ProductId{get;set;}
    public Product? Product{get;set;}
    
    public int StockAtAdjustmentTime {get;set;}
    public int QtyAdjusted{get;set;}
    public double CostAtAdjustmentTime {get;set;}
    public double RetailAtAdjustmentTime {get;set;}

    public StockAdjustmentProduct()
    {
        this.StockAdjustmentId = null;
        this.StockAdjustment = null;
        this.ProductId = null;
        this.Product = null;
        this.StockAtAdjustmentTime = 0;
        this.QtyAdjusted = 0;
        this.CostAtAdjustmentTime = 0.0;
        this.RetailAtAdjustmentTime = 0.0;
    }
}
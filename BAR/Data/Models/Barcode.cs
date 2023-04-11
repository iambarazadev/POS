using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAR.Data.Models;

public class Barcode{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BarcodeId {get;set;}
    
    public virtual List<ProductBarcode>? ProductBarcode {get;set;}
    
    //Ctor
    public Barcode()
    {
        this.BarcodeId = default;
        this.ProductBarcode = new();
    }
}
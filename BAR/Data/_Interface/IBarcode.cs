using BAR.Data.Models;

namespace BAR.Data._Interface;

public interface IBarcode : IBaseRepository<Barcode>{
    Task<Barcode> GetDetailedBarcodeAsync(int sn);
    Task<List<Barcode>> GetAllBarcodesDetailedAsync(int CurrentPage, int PageSize);
}
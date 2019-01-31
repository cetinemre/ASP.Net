using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Admin.Models.Abstract;
using Admin.Models.Enum;

namespace Admin.Models.ViewModels
{
    public class ProductViewModel : BaseEntitiy<Guid>
    {
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Kategori Adı 3 ile 100 karakter arasında  olabilir.")]
        [DisplayName("Ürün Adı")]
        [Required]
        public string ProductName { get; set; }//-asldkasşdqweqwq
        [DisplayName("Ürün Tipi")]
        public ProductTypes ProductType { get; set; }
        [DisplayName("Satış Fiyatı")]
        public decimal SalesPrice { get; set; }//asdasdasdasdasd
        [DisplayName("Alış Fiyatı")]
        public decimal BuyPrice { get; set; }//aşsdmşasdmşasd
        [DisplayName("Stok Miktarı")]
        [Range(0, 9999)]
        public decimal UnitsInStock { get; set; }//dşasdşmasd
        public string SupProductId { get; set; }
        [StringLength(20)]
        [Required]
        public string Barcode { get; set; }//Donas
        [DisplayName("Birim")]
        public int Quantity { get; set; }//dones
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Kategori")]
        public int CategoryId { get; set; }//dursun yaparsın
    }
}
using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Subtotal is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Subtotal must be greater than 0.")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "Discount percent is required.")]
        [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100.")]
        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount => Subtotal * (DiscountPercent / 100);

        public decimal Total => Subtotal - DiscountAmount;
    }
}

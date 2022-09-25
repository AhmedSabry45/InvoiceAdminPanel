using System.ComponentModel.DataAnnotations;

namespace ArmyTechTaskApp.ViewModel
{
    public class InvoiceDetailVM
    {
        
        [Display(Name ="InvoiceHeader")]
        public long InvoiceHeaderId { get; set; }
        public string ItemName { get; set; } = null!;
        public double ItemCount { get; set; }
        public double ItemPrice { get; set; }
    }
}

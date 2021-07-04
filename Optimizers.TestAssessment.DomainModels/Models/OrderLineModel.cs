using System;
using System.ComponentModel.DataAnnotations;

namespace Optimizers.TestAssessment.DomainModels.Models
{
    public class OrderLineModel
    {
        public Guid Id { get; set; }
        [Required]
        public Guid OrderId { get; set; }
        public int? LineNUmber { get; set; }
        [Required]
        public string ItemCode { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
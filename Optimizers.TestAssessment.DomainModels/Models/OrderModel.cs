using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Optimizers.TestAssessment.DomainModels.DTO;

namespace Optimizers.TestAssessment.DomainModels.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public int OrderNumber { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public string Reference { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public Guid UserId { get; set; }
        
        public List<OrderLineModel> OrderLines { get; set; }
    }
}
using System;
using Optimizers.TestAssessment.DomainModels.Models;

namespace Optimizers.TestAssessment.DomainModels.DTO
{
    public class OrderLineDTO
    {
        public OrderLineDTO(OrderLineModel orderLineModel)
        {
            Id = orderLineModel.Id;
            OrderId = orderLineModel.OrderId;
            LineNUmber = orderLineModel.LineNUmber;
            ItemCode = orderLineModel.ItemCode;
            Quantity = orderLineModel.Quantity;
            Price = orderLineModel.Price;
        }
        
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public int? LineNUmber { get; set; }
        public string ItemCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Optimizers.TestAssessment.DomainModels.Models;

namespace Optimizers.TestAssessment.DomainModels.DTO
{
    public class OrderDTO
    {

        public OrderDTO(OrderModel orderModel)
        {
            Id = orderModel.Id;
            OrderNumber = orderModel.OrderNumber;
            OrderDate = orderModel.OrderDate;
            Reference = orderModel.Reference;
            CustomerName = orderModel.CustomerName;
            UserId = orderModel.UserId;
            OrderLines = orderModel.OrderLines.Select(o => new OrderLineDTO(o)).ToList();
        }
        
        public Guid Id { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string Reference { get; set; }
        public string CustomerName { get; set; }
        public Guid UserId { get; set; }
        
        public List<OrderLineDTO> OrderLines { get; set; }
    }
}
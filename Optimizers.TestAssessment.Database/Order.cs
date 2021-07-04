﻿using System;

namespace Optimizers.TestAssessment.Database
{
    public class Order
    {
        public Guid Id { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string Reference { get; set; }
        public string CustomerName { get; set; }
        public Guid UserId { get; set; }
    }
}
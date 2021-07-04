using System.Threading.Tasks;
using Optimizers.TestAssessment.DomainModels.DTO;
using Optimizers.TestAssessment.DomainServices.Interfaces;

namespace Optimizers.TestAssessment.DomainServices
{
    public class OrderService : IOrderService
    {
        public Task<OrderDTO> Create(OrderDTO orderDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
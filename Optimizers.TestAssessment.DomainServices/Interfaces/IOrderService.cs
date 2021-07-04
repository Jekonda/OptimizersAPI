using System.Threading.Tasks;
using Optimizers.TestAssessment.DomainModels.DTO;

namespace Optimizers.TestAssessment.DomainServices.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDTO> Create(OrderDTO orderDto);
    }
}
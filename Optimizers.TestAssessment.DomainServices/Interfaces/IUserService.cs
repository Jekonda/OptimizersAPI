using System.Threading.Tasks;
using Optimizers.TestAssessment.DomainModels.DTO;

namespace Optimizers.TestAssessment.DomainServices.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> CreateUser(UserDTO user);
    }
}
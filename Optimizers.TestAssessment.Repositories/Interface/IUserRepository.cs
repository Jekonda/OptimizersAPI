using System.Threading.Tasks;
using Optimizers.TestAssessment.Database;

namespace Optimizers.TestAssessment.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
    }
}
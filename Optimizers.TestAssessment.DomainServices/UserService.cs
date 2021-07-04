using System.Threading.Tasks;
using Optimizers.TestAssessment.Database;
using Optimizers.TestAssessment.DomainModels.DTO;
using Optimizers.TestAssessment.DomainServices.Interfaces;
using Optimizers.TestAssessment.Repositories.Interface;

namespace Optimizers.TestAssessment.DomainServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Create new instance of <see cref="UserService"/>.
        /// </summary>
        /// <param name="userRepository">Injected userRepository.</param>
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userDto">Record to add.</param>
        /// <returns><see cref="UserDTO"/> record.</returns>
        public async Task<UserDTO> CreateUser(UserDTO userDto)
        {
            var user = new User
            {
                Password = userDto.Password,
                FullName = userDto.FullName,
                UserName = userDto.UserName
            };

            var result = await _userRepository.CreateUser(user);

            if (result != null)
            {
                userDto.Id = result.Id;
                return userDto;
            }

            return null;
        }
    }
}
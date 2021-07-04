using System;
using Optimizers.TestAssessment.DomainModels.Models;

namespace Optimizers.TestAssessment.DomainModels.DTO
{
    public class UserDTO
    {
        public UserDTO()
        {
        }

        public UserDTO(UserModel userModel)
        {
            Id = userModel.Id;
            UserName = userModel.UserName;
            Password = userModel.Password;
            FullName = userModel.FullName;
        }
        
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
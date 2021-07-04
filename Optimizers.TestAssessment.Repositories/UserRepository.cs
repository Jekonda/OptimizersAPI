using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Optimizers.TestAssessment.Database;
using Optimizers.TestAssessment.Repositories.Interface;

namespace Optimizers.TestAssessment.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Create new instance of <see cref="IConfiguration"/>.
        /// </summary>
        /// <param name="configuration">Injected service.</param>
        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        /// <summary>
        /// Creates new User record.
        /// </summary>
        /// <param name="user">User record to add.</param>
        /// <returns><see cref="User"/> record.</returns>
        public async Task<User> CreateUser(User user)
        {
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

            var insertQuery =
                @"INSERT INTO [dbo].[Users]([UserName], [Password], [FullName]) OUTPUT inserted.Id VALUES (@UserName, @Password, @FullName)";

            try
            {
                var result = await db.ExecuteScalarAsync<Guid>(insertQuery, new
                {
                    user.UserName,
                    user.Password,
                    user.FullName
                });
                
                user.Id = result;

                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
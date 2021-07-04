using System;
using System.ComponentModel.DataAnnotations;

namespace Optimizers.TestAssessment.DomainModels.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
        
        [Required]
        [MaxLength(500)]
        public string FullName { get; set; }
    }
}
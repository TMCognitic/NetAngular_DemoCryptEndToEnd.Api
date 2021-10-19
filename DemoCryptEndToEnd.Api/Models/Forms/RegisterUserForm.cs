using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCryptEndToEnd.Api.Models.Forms
{
    public class RegisterUserForm
    {
        [Required]
        [MaxLength(75)]
        public string Nom { get; set; }
        [Required]
        [MaxLength(75)]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(384)]
        public string Email { get; set; }
        [Required]
        public string Passwd { get; set; }
    }
}

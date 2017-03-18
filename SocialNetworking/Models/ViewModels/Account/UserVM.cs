using SocialNetworking.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialNetworking.Models.ViewModels.Account
{
    public class UserVM
    {

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LasttName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }


        public UserVM()
        {

        }

        public UserVM(UserDTO user)
        {
            this.Id = user.Id;
            this.FirstName = user.FirstName;
            this.LasttName = user.LasttName;
            this.EmailAddress = user.EmailAddress;
            this.Username = user.Username;
            this.Password = user.Password;
        }
    }
}
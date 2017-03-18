using SocialNetworking.Models.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SocialNetworking.Models.Data
{
    public class Db : DbContext
    {
        public DbSet<UserDTO> Users { get; set; }
    }
}
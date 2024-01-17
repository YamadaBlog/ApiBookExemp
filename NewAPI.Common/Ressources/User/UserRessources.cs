using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewAPI.Common.Models;
using NewAPI.Common.Ressources.Entity;
using NewAPI.Common.Ressources.Role;

namespace NewAPI.Common.Ressources.User
{
    public class UserRessources :EntityRessources
    {

        public string Name { get; set; } 

        public string FirstName { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }

        public List<RoleRessources> Roles ; 

        public UserRessources()
        {
            Roles = new List<RoleRessources>();
        }
    }
}

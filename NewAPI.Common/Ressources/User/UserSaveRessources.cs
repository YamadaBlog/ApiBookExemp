using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewAPI.Common.Ressources.Role;

namespace NewAPI.Common.Ressources.User
{
    public class UserSaveRessources
    {
        public string Name { get; set; } 

        public string FirstName { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }

        public List<RoleRessources> Roles ; 

        public UserSaveRessources()
        {
            Roles = new List<RoleRessources>(); 
        }
    }
}

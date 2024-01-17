using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace NewAPI.Common.Models 
{
    public class User : Entity
    {

        public string Name { get; set; } 

        public string FirstName { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }

        public List<UserRole> UserRole ; 

        // création d'un constructeur user avec "ctrl ;"
public User()
{
    UserRole = new List<UserRole>();
}
       
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAPI.Common.Models 
{
    public class Role : Entity
    {
       public string Name { get ; set ;}
       public List<UserRole> UserRole ; 
       public Role()
       {
        UserRole = new List<UserRole>();
       }
       }
}

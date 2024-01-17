using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace NewAPI.Common.Models {
    public class UserRole : Entity
    {
        public int UserId;
        public int RoleId; 
    }
}

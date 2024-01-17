using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAPI.Common.Ressources.Entity 
{
    public class EntityRessources
    {
          public int Id { get; set; }
            public int UpdateBy { get; set; }
            public int CreateBy { get; set; }
            public DateTime UpdateAt { get; set; }
            public DateTime CreateAt { get; set; }
    }
}

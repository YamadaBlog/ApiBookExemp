using System ; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPI.Common.Models ;
    
        public class Entity 
        {
            public int Id { get; set; }
            public int UpdateBy { get; set; }
            public int CreateBy { get; set; }
            public DateTime UpdateAt { get; set; }
            public DateTime CreateAt { get; set; }


            #region getter and setter
            // Set value if setter ID is private
            // call : Entity.SetId(1)
            // public void SetId(int id) {Id = id ; }

            // get value if getter ID is private
            // call : Entity.GetId(1)
            // public void GetId(int id) {return = id ; }    
            #endregion        

            public Entity () {}
        
    }

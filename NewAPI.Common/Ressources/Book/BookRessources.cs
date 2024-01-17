using System ; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewAPI.Common.Ressources.Entity;

namespace NewAPI.Common.Ressources.Book
{
    public class BookRessources : EntityRessources
    {
        public string Title { get; set; } 
        public string Author { get; set; }

    }
}
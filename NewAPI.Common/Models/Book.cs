using System ; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPI.Common.Models 
{
    public class Book : Entity  // Book hérite de la classe Entité + les siennes
                                // Le modèle entité contient toutes les propriétés communes à tous les objets, ici book
    {
        // On définit ici les propriétés de la classe Book ; 
        // Les get ete set permettent d'indiquer que ces propriétés peuvent être lues et modifiées depus l'extérieur de la classe
        public string Title { get; set; } 
        public string Type { get; set;} 
        public string Author { get; set; }

    }

}

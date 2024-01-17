using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using NewAPI.Common.Models;
using NewAPI.Common.Ressources;
using NewAPI.Common.Ressources.Book;

namespace NewAPI.Services
{   
    //Création d'une classe BookServices  : contient toutes les méthodes relatives aux livres
    public class BookServices
    {
        // Création d'une liste  : List<Book> => correspond au type et "Books" c'est le nom de la proporiété
        public List<Book> Books {get; set; }

        // Création du constructeur
        // Le constructeur est vide, ce qui signifie qu'il n'effectue aucune opération spécifique lorsqu'une 
        // instance de la classe BookServices est créée.
        public BookServices() {}
        
        // Fonstion qui permet de vérifier que le livre existe ou non 

        public bool ExistBook(BookRessources bookRessources) 
        {
            var existBook = Books.Find(x => x.Id == bookRessources.Id) ; 
            if(existBook == null) {
                return true ; 
            } return false;
        }
        public string Add(BookRessources bookRessources)
        { 
            if(ExistBook(bookRessources))
            {
                var book = new Book ()
                {
                    Id = bookRessources.Id,
                    Title = bookRessources.Title, 
                };
                Books.Add (book);
                return book.Title ; 
            }
            return "already exist";
        }

        public void Update(BookRessources bookRessources) 
        {
            var existBook = Books.Find(x => x.Id == bookRessources.Id) ; 
            if(existBook != null)
            {
                existBook.Title = bookRessources.Title ;
            }
        }

        // public void Delete(BookRessources bookRessources)
        // {
        //     var existBook = Books.Find(x => x.Id == bookRessources.Id) ; 
        //     if(existBook == null) 
        //     {
        //         existBook
        //     }
        // }
// Rque : "Ctrl :" pour commenter toutes les lignes
    
    }
}

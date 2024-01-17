using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewAPI.Common.Ressources;
using NewAPI.Services;

namespace NewAPI.Controllers
{
    [ApiController] // On définit que c'est un controleur
    [Route("Newapi.controller")] // A l'intérieur des guillemets on met ce qu'on veut : ça oriente vers l'url qu'on donnera à l'externe pour connexion à l'API
    
    public class BookController : Controller // controller : c'est le point d'entrée d'une application, 
                                             //on doit d'abord passer par ici avant d'accéder aux autres services
    {
        // Création du constructeur BookController 
        public BookController() {}

        [HttpPost] // Pour ajouter un livre

         // Le IAction correspond à un envoi sur le web via l'HTTP ou HTTPS 
        public IActionResult AddBook (BookRessources bookRessources)
        {
            var service = new BookServices(); // Création d'une instance de la classe BookServices 
            var result = service.Add(bookRessources); // On donne le paramètre "bookressources" à la fonction Add 
                                                    // et on stocke le résultat dans la variable "result"
            return Ok (result);
        }

        [HttpPost ("update")] // Pour mettre à jour
        public IActionResult UpdateBook ()
        {
            return Ok ();
        }
        [HttpPut] // Pour mettre à jour une partie de l'objet  -- mais pas de restriction dans le code qui bloque en cas de modif de tout l'objet comme le post

        public IActionResult PutBook ()
        {
            return Ok ();
        }       
        [HttpGet]

        public IActionResult GetBook () // 
        {
            return Ok ();
        }    

        [HttpGet ("{id}")]   
        public IActionResult GetBookbyId ()
        {
            return Ok ();
        }   

        [HttpDelete]

        public IActionResult DeleteBook ()
        {
            return Ok ();
        }       
    }
}
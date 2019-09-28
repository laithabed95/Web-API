using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.Models;

namespace webapi.Controllers
{
    public class BooksController : ApiController
    {
        //Get primitive Parametrs (int , string ....)
        //public string GetBook (string tittle, int numberOfPages)
        //{
        //    return string.Format("Tittle={0},Number Of Pages{1}", tittle, numberOfPages);

        //}

        //post primitive Parametrs (int , string ....)
        public string PostBook(string tittle, int numberOfPages)
        {
            return string.Format("Tittle={0},Number Of Pages{1}", tittle, numberOfPages);

        }

        //Get complix Parametrs 
        public HttpResponseMessage GetBook(book bookss)
        {
            if(ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
           

        }
        //post complix Parametrs 
        public string PostBook(book bookss)
        {
            return string.Format("Tittle={0},Number Of Pages{1}", bookss.tittle, bookss.numberOfPages);

        }

        //Get complix and premitivs Parametrs 
        public string GetBook(book bookss,string author)
        {
            return string.Format("Tittle={0},Number Of Pages{1}",
                bookss.tittle, bookss.numberOfPages, author);
        }

        //post complix and premitivs Parametrs 
        public string postBook(book bookss, string author)
        {
            return string.Format("Tittle={0},Number Of Pages{1}",
                bookss.tittle, bookss.numberOfPages, author);

        }
        //[FromBody][FromUri]
        public string GetBook([FromBody]string tittle, int numberOfPages)
        {
            return string.Format("Tittle={0},Number Of Pages{1}", tittle, numberOfPages);

        }



    }
}
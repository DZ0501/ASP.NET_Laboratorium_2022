using Microsoft.AspNetCore.Mvc;
using SecondMVCApp.Models;

namespace SecondMVCApp.Controllers
{
    public class BookController : Controller
    {
        

        public static Dictionary<int, Book> books = new Dictionary<int, Book>
        {
            { 1, new Book(){Id = 1, Author = "AAAA", Title = "BBBB", IsAvailable = true, CreatedDate = DateTime.Now} },
            { 2, new Book(){Id = 2, Author = "BBBB", Title = "BBBB", IsAvailable = true, CreatedDate = DateTime.Now} },
            { 3, new Book(){Id = 3, Author = "DDDD", Title = "EEEE", IsAvailable = true, CreatedDate = DateTime.Now} },
            { 4, new Book(){Id = 4, Author = "FFFF", Title = "GGGG", IsAvailable = true, CreatedDate = DateTime.Now} }
        };

        public static int counter = 4;

        public IActionResult Index()
        {
            return View(books);
        }
        //TODO zaprojektuuj formularz do edycji z polami Title i Autohor
        //TODO w formularzu kleiruj dane do akcji Edit (metoda post)
        //TODO w akcji Edit zamień tylko Tytuł i autora
        public IActionResult EditForm([FromRoute] int id)
        {
            return View();
        }

        public IActionResult Delete([FromRoute]int id)
        {
            books.Remove(id);
            return View("Index", books);
        }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult CreateForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]Book bookFromForm)
        {
            if(ModelState.IsValid)
            {
                books[++counter] = bookFromForm;
                return View("Index", books);
            }
            return View("CreateForm");
            //TODO odebranei danych z formularza, zapisanie obiektu do
           
        }
    }
}

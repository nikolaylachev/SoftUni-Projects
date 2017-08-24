using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new IMDBDbContext())
            {
                //We get all movies from the databse.
                var films = db.Films.ToList();

                //And we render the view with the films.
                return View(films);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            //We only render the view
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            //With ModelState we check if our form is valid.
            if (ModelState.IsValid)
            {
                //WE create connection wiht the databse
                using (var db = new IMDBDbContext())
                {
                    //We add the film in the databse
                    db.Films.Add(film);
                    //and we save the changes.
                    db.SaveChanges();
                } 
            }
            //finally we redirect to Home Page.
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            //We check if the id is null because int? id means that this variable can be null.
            if (id == null)
            {
                return HttpNotFound();
            }

            //WE create connection wiht the databse
            using (var database = new IMDBDbContext())
            {
                //We find the film in the databse by id
                Film film = database.Films.First(f => f.Id == id);

                //we check if it is null
                if (film == null)
                {
                    return RedirectToAction("Index");
                }
                //and if it is not we render the edit view with the film.
                return View(film);
            }
            
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Film filmModel)
        {
            //We check if the id is null because int? id means that this variable can be null.
            if (id == null)
            {
                return HttpNotFound();
            }

            //With ModelState we check if our form is valid.
            if (ModelState.IsValid)
            {
                //We create connec tion with the databse.
                using (var database = new IMDBDbContext())
                {
                    //We find the movie thath we want to edit from the database by id.
                    Film filmFromDb = database.Films.Find(id);

                    //We check if it is not null
                    if (filmFromDb == null)
                    {
                        return RedirectToAction("Index");
                    }

                    //And it is not null we coontinue.

                    //This is the actual editing:
                    //We change the name of the film in the database with the the name
                    //of the film from the form
                    filmFromDb.Name = filmModel.Name;
                    //We do this with the genre
                    filmFromDb.Genre = filmModel.Genre;
                    //With the director
                    filmFromDb.Director = filmModel.Director;
                    //and with the year too.
                    filmFromDb.Year = filmModel.Year;

                    database.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            //We check if the id is null because int? id means that this variable can be null.
            if (id == null)
            {
                return HttpNotFound();
            }

            //We create connection with the databse.
            using (var database = new IMDBDbContext())
            {
                //WE get the film from the databse by id
                Film film = database.Films.First(f => f.Id == id);

                //We check if it is null
                if (film == null)
                {
                    return RedirectToAction("Index");
                }

                //and if it is not we render the view with the film in it.
                return View(film);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Film filmModel)
        {
            if (id == null)
            {
                HttpNotFound();
            }

            //We create connection with the databse
            using (var db = new IMDBDbContext())
            {
                //we find the film we want to delete by id.
                var filmToBeDeleted = db.Films.Find(id);

                //we check if it is null
                if (filmToBeDeleted == null)
                {
                    return RedirectToAction("Index");
                }

                //And if it is not we delete it from the database.
                db.Films.Remove(filmToBeDeleted);
                //We save the changes.
                db.SaveChanges();

                // return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
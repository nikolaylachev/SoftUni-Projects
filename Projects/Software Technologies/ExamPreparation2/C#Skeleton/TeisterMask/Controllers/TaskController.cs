using System;
using System.Linq;
using System.Web.Mvc;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    [ValidateInput(false)]
    public class TaskController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            //We create connection with the database.
            using (var db = new TeisterMaskDbContext())
            {
                var tasks = db.Tasks.ToList();
                //We render the index view WITH THE TASKS IN IT!!!
                return View(tasks);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Task task)
        {
            //We check if the task is valid
            if (ModelState.IsValid)
            {
                //And if it is we create connection with the database using db variable.
                using (var db = new TeisterMaskDbContext())
                {
                    //We add the task to the database.
                    db.Tasks.Add(task);
                    //We save the changes in the databse.
                    db.SaveChanges();
                    //and redirect to Home Page so that we can see if we succeeded.
                    return Redirect("/");
                }
            }
            return View();
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var task = db.Tasks.Find(id);
                if (task != null)
                {
                    return View(task);
                }
            }
            return Redirect("/");
        }
        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Task taskModel)
        {
            //We chekc if the task is valid.
            if (!ModelState.IsValid)
            {
                return View(taskModel);
            }

            // And if it is we create connection with the database using db variable.
            using (var db = new TeisterMaskDbContext())
            {
                //We find the task that we want to edit and store it in taskFromDb.
                var taskFromDb = db.Tasks.Find(taskModel.Id);
                //We check if this task is not null
                if (taskFromDb != null)
                {
                    //And if that condition is true we replace the title
                    taskFromDb.Title = taskModel.Title;
                    //We also replace the status as well.
                    taskFromDb.Status = taskModel.Status;
                    //Then we save the changes
                    db.SaveChanges();
                }
            }
            //Finally we redirect to Home Page so that we can see the tasks.
            return Redirect("/");
        }
    }
}
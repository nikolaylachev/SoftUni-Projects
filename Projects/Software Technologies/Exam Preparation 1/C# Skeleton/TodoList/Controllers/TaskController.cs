using System;
using System.Linq;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
	public class TaskController : Controller
	{
	    [HttpGet]
        [Route("")]
        ////This method will render the home view
        public ActionResult Index()
	    {
            using (var db = new TodoListDbContext())
            {
                //this will take all tasks from the databse and put them in a List<Task>.
                var tasks = db.Tasks.ToList();

                //Then we will give them to the Home View (Index.cshtml)
                return View(tasks);
            }
	       
        }

        [HttpGet]
        [Route("create")]
        //This method will only return the view for creating a task.
        public ActionResult Create()
		{
		    return View();//this will return the view in Views/Task/Create.cshtml.
		}

		[HttpPost]
		[Route("create")]
        [ValidateAntiForgeryToken]
        //This method will be used for submitting the info from the form to the database.
		public ActionResult Create(Task task)
		{
            //We check if the task is null and if this condition is true we redirect to Home Page.
            if (task == null)
            {
                return RedirectToAction("Index");
            }

            //We check if the task is with a missing title or comments
            //and if that conditon is true we redirect to Home Page.
            if (string.IsNullOrWhiteSpace(task.Title) 
                || string.IsNullOrWhiteSpace(task.Comments))
            {
                return RedirectToAction("Index");
            }

            //If none of the ifs before returns true we create connection with the database
            // using variable called db.
            using (var db = new TodoListDbContext())
            {
                //With db we can do things with the database like find, add, remove, etc...

                //So we add the task which we took from the create form to the database
                db.Tasks.Add(task);
                //And we save the changes.
                db.SaveChanges();

                //Finally we render to view to Home Page.
                return RedirectToAction("Index");
            }
		    
        }

		[HttpGet]
		[Route("delete/{id}")]
        public ActionResult Delete(int id)
		{
            //With db we create connection with the database.
            //Also with db we can do things with the database like find, add, remove, etc...
            using (var db = new TodoListDbContext())
            {
                //We find the task we want to delete by id.
                //and we save this task in an task variable of type Task.
                var task = db.Tasks.Find(id);

                //We check if the task is null and if this condition is true we redirect to Home Page.
                if (task == null)
                {
                    return RedirectToAction("Index");
                }
                //finally we render the Delete.cshtml view
                //And we put the task in it.
                return View(task);
            }
		    
        }

		[HttpPost]
		[Route("delete/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult DeleteConfirm(int id)
		{
            //With db we can do things with the database like find, add, remove, etc...
            using (var db = new TodoListDbContext())
            {
                //We find the task we want to delete in the databse by id.
                //and we save this task in an task variable of type Task.
                var task = db.Tasks.Find(id);

                //We check if the task is null and if this condition is true we redirect to Home Page.
                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                //Else if the task is not null we remove it from the databse.
                //We use Remove() and we give this function the task, which we want to remove
                //In our example that is the task stored in the task variable.
                db.Tasks.Remove(task);
                //We save the changes in the databse.
                db.SaveChanges();

                //Finally we redirect to Home Page.
                return RedirectToAction("Index");
            }
            
        }
	}
}
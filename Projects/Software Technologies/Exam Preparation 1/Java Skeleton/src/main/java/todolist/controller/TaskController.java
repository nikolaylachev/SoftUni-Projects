package todolist.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import todolist.bindingModel.TaskBindingModel;
import todolist.entity.Task;
import todolist.repository.TaskRepository;

import java.util.List;

@Controller
public class TaskController {
    private final TaskRepository taskRepository;

    @Autowired
    public TaskController(TaskRepository taskRepository) {
        this.taskRepository = taskRepository;
    }

    @GetMapping("/")
    public String index(Model model) {
        //We find all tasks using taskRepository's method findAll()
        //And we put them in a list of tasks.
        List<Task> tasks = taskRepository.findAll();

        //Then we render the home page with the tasks using model.addAttribute().
        model.addAttribute("tasks", tasks);
        model.addAttribute("view", "task/index");

        return "base-layout";
    }

    //This method will be called when the user wants to create new task (render the form).
    @GetMapping("/create")
    public String create(Model model) {
        //This code will add to our model a key-value pair.
        // The key will be the view we want to render and the value is the path to our view.
        model.addAttribute("view","task/create");
        return "base-layout";

    }

    //This method will be called when he submits the data.
    @PostMapping("/create")
    public String createProcess(Model model, TaskBindingModel taskBindingModel) {
        //***THE WHOLE IDEA OF BINDING MODELS IS TO VALIDATE THE USER INPUT***
        if (taskBindingModel == null) {
            return "redirect:/";
        }

        if (taskBindingModel.getTitle().equals("") ||
                taskBindingModel.getComments().equals("")  ) {
            return "redirect:/";
        }
        //We create new task object using Task entity with title and comments which are taken from
        //the taskBindingModel.
        Task task = new Task(taskBindingModel.getTitle(),taskBindingModel.getComments());

        //We upload it to our database, using our task repository.
        taskRepository.saveAndFlush(task);

        return "redirect:/";
    }

    @GetMapping("/delete/{id}")
    public String delete(Model model, @PathVariable int id) {
        //We check if a task with this id exist in the database.
        //And if this if returns false
        if (!this.taskRepository.exists(id)) {
            //We return to index.html.
            return "redirect:/";
        }
        //Else if such task exists
        //We save it the task variable
        Task task = this.taskRepository.findOne(id);

        //Then we render the delete.html view with the task in it.
        model.addAttribute("view","task/delete");
        model.addAttribute("task",task);
        return "base-layout";
    }

    @PostMapping("/delete/{id}")
    public String deleteProcess(Model model, @PathVariable int id) {
        //We get the task from the database using our repository
        //And save it in a task object.
        Task task = taskRepository.findOne(id);

        //Check if such task exists.
        if (task == null) {
            return "redirect:/";
        }

        //Then we delete it from the database.
        taskRepository.delete(task);
        taskRepository.flush();

        return "redirect:/";
    }
}

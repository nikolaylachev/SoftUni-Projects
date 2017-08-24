package teistermask.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import teistermask.bindingModel.TaskBindingModel;
import teistermask.entity.Task;
import teistermask.repository.TaskRepository;

import java.util.List;
import java.util.stream.Collectors;

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

        //We find all open tasks using the two lines below
        List<Task> openTasks = tasks.stream()
                .filter(t -> t.getStatus().equals("Open"))
                .collect(Collectors.toList());

        //We find all in progress tasks using the two lines below
        List<Task> inProgressTasks = tasks.stream()
                .filter(t -> t.getStatus().equals("In Progress"))
                .collect(Collectors.toList());

        //We find all finished tasks using the two lines below
        List<Task> finishedTasks = tasks.stream()
                .filter(t -> t.getStatus().equals("Finished"))
                .collect(Collectors.toList());

        //Then we render the home page with the open, in progress and finished tasks using model.addAttribute().
        model.addAttribute("openTasks", openTasks);
        model.addAttribute("inProgressTasks", inProgressTasks);
        model.addAttribute("finishedTasks", finishedTasks);
        model.addAttribute("view", "task/index");

        return "base-layout";

    }

	@GetMapping("/create")
	public String create(Model model) {
	    //model.addAttribute("task", new Task());
        model.addAttribute("view", "task/create");

        return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, TaskBindingModel taskBindingModel) {
        //***THE WHOLE IDEA OF BINDING MODELS IS TO VALIDATE THE USER INPUT AND GET THE INFO FROM THE FORM.***
        if (taskBindingModel == null) {
            return "redirect:/";
        }

        if (taskBindingModel.getTitle().equals("") ||
                taskBindingModel.getStatus().equals("")  ) {
            model.addAttribute("taskBindingModel", taskBindingModel);
            model.addAttribute("view", "task/create");
            return "base-layout/";
        }

        //We create new task object using Task entity with title and status
        //which are taken from the taskBindingModel.
        Task task = new Task();
        task.setTitle(taskBindingModel.getTitle());
        task.setStatus(taskBindingModel.getStatus());

        //We upload it to our database, using our task repository.
        taskRepository.saveAndFlush(task);

        return "redirect:/";
    }


	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
		Task task = taskRepository.findOne(id);

		if (task != null) {
		    model.addAttribute("task", task);
		    model.addAttribute("view", "task/edit");
		    return "base-layout";
        }
        return  "redirect:/";
	}

	@PostMapping("/edit/{id}")
	public String editProcess(Model model, @PathVariable int id, Task taskBindingModel) {
	    //taskBindingModel is used to save the data from the form.
		if (taskBindingModel.getTitle().equals("")
                || taskBindingModel.getStatus().equals("")) {
		    taskBindingModel.setId(id);
		    model.addAttribute("task", taskBindingModel);
            model.addAttribute("view", "task/edit");
            return "base-layout";
        }

        //We use taskFromDB to get and edit the info about this current task.
        Task taskFromDB = taskRepository.findOne(id);

		//We check if it is not null
		if (taskFromDB != null) {
		    //And if it is not we change the title
		    taskFromDB.setTitle(taskBindingModel.getTitle());
		    //And the status too.
		    taskFromDB.setStatus(taskBindingModel.getStatus());
		    //Then we save the changes.
		    taskRepository.saveAndFlush(taskFromDB);
        }
        //And finally we redirect to Home Page.
        return "redirect:/";
	}
}

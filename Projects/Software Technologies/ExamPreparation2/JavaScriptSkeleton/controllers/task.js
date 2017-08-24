const Task = require('../models/Task');

module.exports = {
	index: (req, res) => {
	    //We find all tasks. They are of the 3 types: Open, In progress, Finished.
        Task.find().then(tasks => {
            //And them we render the view with the 3 types of tasks.
            res.render('task/index', {
                //We want to take all open tasks from task using task.filter()
            	'openTasks': tasks.filter(t => t.status === "Open"),
                //We want to take all in progress tasks from task using task.filter()
				'inProgressTasks': tasks.filter(t => t.status === "In Progress"),
                //We want to take all finished tasks from task using task.filter()
				'finishedTasks': tasks.filter(t => t.status === "Finished")
            });
        });

    },
	createGet: (req, res) => {
        //In the GET Method we only render the task/create.hbs view.
        res.render('task/create');
    },
	createPost: (req, res) => {
        //We take the task title and comments in the POST query by using req.body and store them in taskArgs variable.
        let taskArgs = req.body;
        //We take the info from the taskArgs variable and create the task in the database
        Task.create(taskArgs).then(task => {
            //Then we redirect to home page (index.hbs)
            res.redirect('/');
        })
        //If there were any problems we catch them and render the create view with the error message.
        //The form which the user filled is saved and displayed.
            .catch(err => {
            taskArgs.error = 'Cannot create task.';
            res.render('task/create', taskArgs);
        });

    },
	editGet: (req, res) => {
		let taskId = req.params.id;
		Task.findById(taskId).then(task => {
		    if(task) {
		        return res.render('task/edit', task);
            }
            else {
                return res.redirect('/');
            }
        }).catch(err => res.redirect('/'));
	},
	editPost: (req, res) => {
		let taskId = req.params.id;//We get the id of the task.
		let task = req.body;//We save the new data about the task in the task variable.

        //We find and update the task that we want to update.
        //runValidators makes sure that we can't save a task with a title etc. in the database.
		Task.findByIdAndUpdate(taskId, task, {runValidators : true})
            .then( tasks => {
                res.redirect('/');
            })
            //If there are some errors we go to the catch block.
            .catch(err => {
                task.id = taskId;//We get the id of the task again because we lose it.
                task.error = "Cannot edit task.";
                return res.render("task/edit", task);
        });
	}
};
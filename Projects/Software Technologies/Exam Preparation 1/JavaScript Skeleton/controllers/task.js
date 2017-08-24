const Task = require('../models/Task');

module.exports = {
    index: (req, res) => {
    	//We created a new Task object of the Task Model.
		//We use find() to get all tasks.
        Task.find().then(tasks => {
        	//When we have done that we render the index.hbs view with the tasks.
			//They are of type object {}.
            res.render('task/index', {'tasks': tasks});
		});

    },
	createGet: (req, res) => {
    	//In the GET Method we only render the task/create.hbs view.
        res.render('task/create');
	},
	createPost: (req, res) => {

    	//We take the task title and comments in the POST query by using req.body and store them in taskArgs variable.
        let taskArgs = req.body;

        //We check if they are undefined(title is missing or comments, etc...)
        if(!taskArgs.title || !taskArgs.comments) { //if(taskArgs.title === undefined || taskArgs.comments === undefined) {

            //And if the above if is true we redirect to home page (index.hbs)
        	res.redirect('/');
        	return;
		}

		//Else if everything is ok, we save the task in the databse using create().
		//And we take the task title and comments from taskArgs.
        Task.create(taskArgs).then(task => {
            //Then we redirect to home page (index.hbs)
        	res.redirect('/');
		});

	},
	deleteGet: (req, res) => {
    	//We get the id of the task we want to delete using rеq.params.id.
        let id = req.params.id;

        //Then we find the task by id using findById() function
        Task.findById(id).then(task => {
        	//Then we check if the task exists
        	if(!task){
        		//If the task does not exists we redirect ot index.hbs.
        		res.redirect('/');
        		return;
			}
			//Else we render the delete.hbs view with the task title and comments.
			res.render('task/delete', task)
		});
	},
	deletePost: (req, res) => {
        //We get the id of the task we want to delete using rq.params.id.
        let id = req.params.id;

        //Then we find and remeve the task from the database.
        Task.findByIdAndRemove(id).then(task => {
        	//After that we ridirect to index.hbs.
			res.redirect('/');
		});
	}
};
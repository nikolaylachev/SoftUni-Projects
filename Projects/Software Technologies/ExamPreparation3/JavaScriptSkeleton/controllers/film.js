const Film = require('../models/Film');

module.exports = {
	index: (req, res) => {
        Film.find({}).then(films => {
        	res.render("film/index", {films: films});
		})
	},
	createGet: (req, res) => {
        res.render("film/create");
	},
	createPost: (req, res) => {
        let filmArguments = req.body;

        Film.create(filmArguments).then(film => {
            res.redirect('/');
        });
	},
	editGet: (req, res) => {
		//we get the id of the film from the URL.
        let filmId = req.params.id;

        //We find it in the database and we render the edit view with the film's data in it.
        Film.findById(filmId).then(film => {
        	res.render('film/edit', film)
		})
	},
	editPost: (req, res) => {
        //We get the id of the film from the URL.
       let filmId = req.params.id;

       //We get the new info about the film from the form using req.body
       let filmArguments = req.body;

       //And we update the film with this id with the new data from filmArguments
       Film.findByIdAndUpdate(filmId,filmArguments).then(film => {
       	//Then we redirect to Home Page.
       	res.redirect('/');
	   });
	},
	deleteGet: (req, res) => {
        //we get the id of the film from the URL.
        let filmId = req.params.id;
	//We find it in the database and we render the delete view with the film's data in it.
        Film.findById(filmId).then(film => {
            res.render('film/delete', film)
        })
	},
	deletePost: (req, res) => {
        //we get the id of the film from the URL.
        let filmId = req.params.id;

        //We find the movie by id in the database and remove it.
        Film.findByIdAndRemove(filmId).then(film => {
        	//Then we redirect to Home Page.
        	res.redirect('/');
		});
	}
};
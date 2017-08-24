const Article = require('mongoose').model('Article');

module.exports = {
    //This function visualize the form for the user and returns an hmtl documnet.
  createGet: (req, res) => {
      res.render('article/create');
  },
    //This function saves the data which the user sends into the database.
  createPost: (req, res) => {
    let articleParts = req.body;

    let errorMsg = '';

    if (!req.isAuthenticated()) {
        errorMsg = 'Sorry, you must be logged in!';
    } else if(!articleParts.title) {
        errorMsg = 'Title is required!';
    } else if(!articleParts.content) {
        errorMsg = 'Content is required!';
    }

    if (errorMsg) {
        res.render('article/create', {
            error: errorMsg
        });
        return;
    }
    let userId = req.user.id;//Gets the user id.
    articleParts.author = userId;//Sets the user as an author of the article.

      //Add the article in the articles collection.
      Article.create(articleParts).then( article => {
          req.user.articles.push(article.id);//Add the article in the articles array property in the user model;
          req.user.save(err => {
            if(err) {
                res.render('artcile/create', {
                    error: err.message
                });
            } else {
                res.redirect('/');//Redirect to home page where the home controller will be called and the articles
                // will be desplayed.
            }
          });
      });

  },
    detailsGet: (req,res) => {
      //Get the id from the URL!!!
      let id = req.params.id;

      Article.findById(id).populate('author').then(article => {
         res.render('article/details', article);
      });
    },
    //ALL LINES BELOW ARE ADDED BY ME!
    deleteGet: (req, res) => {
      let id = req.params.id;

      Article.findById(id).then(article => {
         res.render('article/delete', article)
      });

    },

    deletePost: (req,res) => {
        let id = req.params.id;

        Article.findByIdAndRemove(id).then(article => {
            let index = req.user.articles.indexOf(article.id);
            req.user.articles.splice(index,1);
            req.user.save(err => {
                if(err) {
                    res.render('/', {error: err.message});
                } else {
                    res.redirect('/');
                }
            });
        });
    }
};

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
                res.redirect('/');
            }
          });
      });

  },
    detailsGet: (req,res) => {
      let id = req.params.id;

      Article.findById(id).populate('author').then(article => {
         res.render('article/details', article);
      });


    }
};

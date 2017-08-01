const mongoose = require('mongoose');
const ObjectId = mongoose.Schema.Types.ObjectId;

let articleSchema = ({
    title: {type: String, required: true},
    content: {type: String, required: true},
    author: {type: ObjectId, required: true, ref: 'User'},
    date: {type: Date, default: Date.now()}
});

//Make the Article model using articleSchema.
const Article = mongoose.model('Article', articleSchema);

module.exports = Article;

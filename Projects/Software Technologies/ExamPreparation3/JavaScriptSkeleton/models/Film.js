const mongoose = require('mongoose');

let filmSchema = mongoose.Schema({
    name: {type: 'string', required: 'true'},
    genre: {type: 'string', required: 'true'},
    director: {type: 'string', required: 'true'},
    year: {type: Number, required: 'true'},
});
//We want to create our model using our filmSchema.
// Movies is THE NAME OF THE TABLE IN THE DATABASE. IT IS NOT REQUIRED
let Film = mongoose.model('Film', filmSchema, 'Movies');

module.exports = Film;
const mongoose = require('mongoose');
//We create a table using mongoose.Schema()

let taskSchema = mongoose.Schema({
    title : {type: 'string', required: 'true'},
    comments: {type: 'string', required: 'true'}
});
//Then we want to make a model called Task using taskSchema.
let Task = mongoose.model('Task',taskSchema);

//We make Task public
module.exports = Task;
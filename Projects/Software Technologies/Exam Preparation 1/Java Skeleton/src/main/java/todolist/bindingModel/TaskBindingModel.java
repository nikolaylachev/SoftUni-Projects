package todolist.bindingModel;

//***THE WHOLE IDEA OF BINDING MODELS IS TO VALIDATE/GET THE USER INPUT AND SEND THEM TO VIEWS***
public class TaskBindingModel {
   // private int id;
    private String title;
    private  String comments;

    public TaskBindingModel() {

    }

    public TaskBindingModel(String title, String comments) {
        this.title = title;
        this.comments = comments;
    }

   /* public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }*/

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getComments() {
        return comments;
    }

    public void setComments(String comments) {
        this.comments = comments;
    }
}

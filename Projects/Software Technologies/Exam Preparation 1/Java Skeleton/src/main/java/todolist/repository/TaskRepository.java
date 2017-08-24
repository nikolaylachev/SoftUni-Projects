package todolist.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import todolist.entity.Task;

//Each repository gives us basic functions for working with given entity in the database!!!
//functions like findAll(), findById(), saveAndFlush(), etc...
public interface TaskRepository extends JpaRepository<Task, Integer> {
}

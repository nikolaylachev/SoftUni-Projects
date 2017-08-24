<?php

namespace AppBundle\Controller;

use AppBundle\Entity\Task;
use AppBundle\Form\TaskType;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class TaskController extends Controller
{
    /**
     * @param Request $request
     * @Route("/", name="index")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function index(Request $request)
    {
        //We use the repository for working with the database and managing our data.
        $taskRepository = $this->getDoctrine()->getRepository(Task::class);

        //Here we want to find all tasks from the databse.
        $tasks = $taskRepository->findAll();

        //And then we give them to the index.html.twig view.
        return $this->render(':task:index.html.twig', ['tasks' => $tasks]);
    }

    /**
     * @param Request $request
     * @Route("/create", name="create")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function create(Request $request)
    {
        $task = new Task();

        //$form variable, will create a special token for the user
        // and also take the values from the form the user sent us,
        // AND STICK THEM IN THE $task VARIABLE SO WE CAN WORK WITH THEM!!!
        $form = $this->createForm(TaskType::class, $task);

        //With handleRequest() method we process the request
        //before we check what the user sent us was valid.
        $form->handleRequest($request);

        //Now we need to check two things:
        //1. Did the user sent us a form at all (isSubmitted()).
        //2. Did the user sent us a valid form (isValid()).
        if ($form->isSubmitted() && $form->isValid() ) {
            //We check if the title and comments are null
            if ($task->getTitle() == null || $task->getComments() == null) {
                //If they are we redirect the user to Home Page.
                return $this->redirectToRoute('index');
            }
            //Then we get the entity manager from doctrine
            $em = $this->getDoctrine()->getManager();

            ////and using the “persist” function we add our new task in the database.
            $em->persist($task);
            //Finally, we call the “flush” function, which sends the task to our database.
            $em->flush();

            //
            return $this->redirectToRoute('index');
        }

        //After the task is sent to the database, we redirect the view to the index page of our app.
        return $this->render('task/create.html.twig', ['form' => $form->createView()]);
    }

    /**
     * @Route("/delete/{id}", name="delete")
     *
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function delete($id, Request $request)
    {
        //We use the repository for working with the database and managing our data.
        $taskRepository = $this->getDoctrine()->getRepository(Task::class);

        //we want to find the id of the task we want to delete.
        $task = $taskRepository->find($id);

        //We check if the $task variable is null
        if ($task == null) {
            //And if this condition is true we redirect the user to Home Page.
            return $this->redirectToRoute('index');
        }

        // We take the values from the form the user sent us,
        // AND STICK THEM IN THE $task VARIABLE SO WE CAN WORK WITH THEM!!!
        $form = $this->createForm(TaskType::class, $task);

        //With handleRequest() method we process the request
        //before we check what the user sent us was valid.
        $form->handleRequest($request);

        //Now we need to check two things:
        //1. Did the user sent us a form at all (isSubmitted()).
        //2. Did the user sent us a valid form (isValid()).
        if ($form->isSubmitted() && $form->isValid() ) {
            //Then we get the entity manager from doctrine
            $em = $this->getDoctrine()->getManager();

            //We delete the task.
            $em->remove($task);
            //Finally, we call the “flush” function, which sends the task to our database.
            $em->flush();

            //After the task is sent to the database, we redirect the view to the index page of our app.
            return $this->redirectToRoute('index');
        }
         return $this->render('task/delete.html.twig',
             ['task' => $task, 'form' => $form->createView()]);
    }
}

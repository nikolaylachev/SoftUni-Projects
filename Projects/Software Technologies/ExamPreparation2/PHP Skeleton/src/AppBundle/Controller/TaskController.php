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

        //Here we want to find all tasks from the databse: open, in progress, finished.
        $tasksOpen = $taskRepository->findBy(["status" => "Open"]);
        $tasksInProgress = $taskRepository->findBy(["status" => "In Progress"]);
        $tasksFinished = $taskRepository->findBy(["status" => "Finished"]);

        //And then we give them to the index.html.twig view.
        return $this->render(":task:index.html.twig", ["openTasks" => $tasksOpen,
            "inProgressTasks" => $tasksInProgress,
            "finishedTasks" => $tasksFinished]
        );

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
        if ($form->isSubmitted() && $form->isValid()) {

            //Then we get the entity manager from doctrine
            $em = $this->getDoctrine()->getManager();

            //and using the “persist” function we add our new task in the database.
            $em->persist($task);
            //Finally, we call the “flush” function, which sends the task to our database.
            $em->flush();
            return $this->redirectToRoute("index");

        }
        return $this->render(":task:create.html.twig",
            ["task" => $task, "form" => $form->createView()]
            );
    }

    /**
     * @Route("/edit/{id}", name="edit")
     *
     * @param $id
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function edit($id, Request $request)
    {
        $taskRepository = $this->getDoctrine()->getRepository(Task::class);

        //Here we want to find all tasks from the databse: open, in progress, finished.
        $task = $taskRepository->find($id);

        if ($task == null) {
            return $this->redirect("/");
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
        if ($form->isSubmitted() && $form->isValid()) {
            //Then we get the entity manager from doctrine
            $em = $this->getDoctrine()->getManager();
            //We edit the task using merge
            $em->merge($task);
            $em->flush();
            //Then we redirect to Home Page.
            return $this->redirect("/");
        }
        //If the above if returns false we render the edit view.
        return $this->render(":task:edit.html.twig",
            ["task" => $task, "form" => $form->createView()]
        );

    }
}

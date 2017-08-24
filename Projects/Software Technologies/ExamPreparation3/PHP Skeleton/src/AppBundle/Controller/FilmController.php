<?php

namespace AppBundle\Controller;

use AppBundle\Entity\Film;
use AppBundle\Form\FilmType;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class FilmController extends Controller
{
    /**
     * @param Request $request
     * @Route("/", name="index")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function index(Request $request)
    {
        //We get all moview form the database using filmRepository
       $films = $this->getDoctrine()->getRepository(Film::class)->findAll();

       //Then we render the hope Page with the films.
       return $this->render('film/index.html.twig', ['films' => $films]);
    }

    /**
     * @param Request $request
     * @Route("/create", name="create")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function create(Request $request)
    {
        $film = New Film();

        // We take the values from the form the user sent us,
        // AND STICK THEM IN THE $film VARIABLE SO WE CAN WORK WITH THEM!!!
        $form = $this->createForm(FilmType::class, $film);

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
            $em->persist($film);
            //Finally, we call the “flush” function, which sends the task to our database.
            $em->flush();

            //After the task is sent to the database, we redirect the view to the index page of our app.
            return $this->redirectToRoute('index');
        }

        return $this->render('film/create.html.twig', array('form' => $form->createView()));
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
        //We get the film by id using filmRepository to work with the database.
        $film = $this->getDoctrine()->getRepository(Film::class)->find($id);

        //We create the form and we put the film's data in the $film variable
        $form = $this->createForm(FilmType::class, $film);

        //With handleRequest() method we process the request
        //before we check what the user sent us was valid.
        $form->handleRequest($request);

        //Now we need to check two things:
        //1. Did the user sent us a form at all (isSubmitted()).
        //2. Did the user sent us a valid form (isValid()).
        if ($form->isSubmitted() && $form->isValid()) {
            //Then we get the entity manager from doctrine
            $em = $this->getDoctrine()->getManager();
            //Then we merge the film in the database with the film from the form(post request).
            $em->merge($film);
            //Finally, we call the “flush” function, which sends the task to our database.
            $em->flush();

            //After the task is sent to the database, we redirect the view to the index page of our app.
            return $this->redirectToRoute('index');
        }
        return $this->render('film/edit.html.twig', array('film' => $film,
            'form' => $form->createView()));
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
        //We get the film by id using filmRepository to work with the database.
        $film = $this->getDoctrine()->getRepository(Film::class)->find($id);

        //We create the form and we put the film's data in the $film variable
        $form = $this->createForm(FilmType::class, $film);

        //With handleRequest() method we process the request
        //before we check what the user sent us was valid.
        $form->handleRequest($request);

        //Now we need to check two things:
        //1. Did the user sent us a form at all (isSubmitted()).
        //2. Did the user sent us a valid form (isValid()).
        if ($form->isSubmitted() && $form->isValid()) {
            //Then we get the entity manager from doctrine
            $em = $this->getDoctrine()->getManager();
            //Then we remove the film from the database.
            $em->remove($film);
            //Finally, we call the “flush” function, which sends the task to our database.
            $em->flush();

            //After the task is sent to the database, we redirect the view to the index page of our app.
            return $this->redirectToRoute('index');
        }
        return $this->render('film/delete.html.twig', array('film' => $film,
            'form' => $form->createView()));
    }
}

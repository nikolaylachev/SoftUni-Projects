<?php

namespace AppBundle\Form;

use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\OptionsResolver\OptionsResolver;

//This class is used to tell what columns the form is going to have
//and of what type they are gong to be. It is like the bundle in other languages.
//***This class creates a form template, that we are going to fill, each time when we’re creating or deleting a task!!!***
class TaskType extends AbstractType
{
    /**
     * {@inheritdoc}
     */
    public function buildForm(FormBuilderInterface $builder, array $options)//buildForm() will create our form.
    {
        $builder
            ->add('title', TextType::class)
            ->add('comments', TextType::class);
    }
    
    /**
     * {@inheritdoc}
     */
    public function configureOptions(OptionsResolver $resolver)//This function will tell our form that it is for the Task entity.
    {
        //The default value for our resolver tells controller that is going to use the form,
        // in what type of object it should save the date from our form.
        $resolver->setDefaults(array(
            'data_class' => 'AppBundle\Entity\Task'
        ));
    }

}

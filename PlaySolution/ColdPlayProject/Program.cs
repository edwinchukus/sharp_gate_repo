using System;
using ColdPlayProject.inheritance;
using ColdPlayProject.list_in_csharp;
using ColdPlayProject.one_dim_arrays;
using ColdPlayProject.polymorphism.overloadding;
using ColdPlayProject.polymorphism.overriding;
using ColdPlayProject.two_dim_arrays;
using Father = ColdPlayProject.polymorphism.overriding.Father;
using Son = ColdPlayProject.inheritance.Son;


namespace ColdPlayProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

          Daughter daughter = new Daughter("Simon");

            string name = daughter.FatherName;


        }
    }
}


// = Object Oriented Programming = 
        //Encapsulation
        //Inheritance
        //Polymorphism
        //Abstract
        //Interface
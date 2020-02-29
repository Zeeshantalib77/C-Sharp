using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{



    interface IFillable
    {

        void fill(ConsoleColor color);

    }

    class Person {

        public string[] subjects = new string[6];



        public string this[int index]
        {
            get
            {
                return subjects[index];
            }
            set
            {

                subjects[index] = value;
            }


        }











        public void speak()
        {
            Console.WriteLine("Person speaking");
        }


        public virtual void name()
        {
            Console.WriteLine("Person name");
        }
    }

    class Student : Person, IFillable
    {

        public new void speak()
        {
            Console.WriteLine("Student speaking");
        }

        public override void name()
        {
            Console.WriteLine("Student name");
        }


        public void fill(ConsoleColor color)
        {
            Console.WriteLine("fill applied to Student");
        }
    
    
    
    }




    interface IColorable
    {
        void applyColor(ConsoleColor color);

    }






    class Organics
    {

        public void speak()
        {

            Console.WriteLine("Organic Speaking");

        }


        public virtual void walk()
        {
            Console.WriteLine("Organic walking");
        }

    }


    class Animal : Organics, IColorable
    {

        public new void speak()
        {

            Console.WriteLine("Animal Speaking");

        }

        public override void walk()
        {
            Console.WriteLine("Animal walking");
        }

        public void applyColor(ConsoleColor color)
        {
            Console.WriteLine("Color to Animal");
        }
    }


    class Wall : IColorable
    {

        public void applyColor(ConsoleColor color)
        {
            Console.WriteLine("Color to Wall");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {


            IColorable[] colorables = { new Animal(), new Wall() };


            foreach (IColorable item in colorables)
            {
                item.applyColor(ConsoleColor.Red);
            }        



            Animal cat = new Animal();
            cat.speak();
            cat.walk();


            IColorable colorable = cat;
            
            IColorable colorable2 = new Animal();
 

            Organics org = cat;
            org.speak();
            org.walk();





            return;

            Student std = new Student();
            
            std[0] = "math";
            std.subjects[0] = "science";


            Console.WriteLine(std.subjects[0]);  


            Person per2 = new Person();



            IFillable fillable = new Student();
            fillable.fill(ConsoleColor.Red);

            IFillable[] fillables = { std, fillable};

            Person[] perons = {std, per2 };

            foreach (Person item in perons)
            {
                item.name();
            }



            Person per = std;

            per.speak();
            per.name();

            std.speak();
            std.name();


        }






    }


    



}

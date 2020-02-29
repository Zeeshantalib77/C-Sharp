using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Lec 15 Class work
namespace Lec_15_Class
{
    interface Icolorable
    {
       void color();
    }
    interface IsolidColor
    {
        void stroke();
        void color();
    }
    class Person: Icolorable,IsolidColor
    {
        protected int x;
        protected int y;
        public Person()
        {
            // what is constructor
            // it is function of a class
        
            // a constructor has a return type or not?
             //  return this;
            // this means ?  ___ apne aap ko
        }
        public Person(int x , int y)
        {
         // we are using "this" to avoid imbiguity
            this.x = x; // first "this.x" is x of class , and x on left side is local(int x,int y) 
            this.y = y;
        }
        public Person(int new_x)
        {
            // just for understanding check this constructor.
            this.x = new_x; // first "this.x" is x of class , and x on left side is local(int x,int y) 
        }
        public void speak()
        {
            x = 12;
            Console.WriteLine("person speaking...");
        }
        //public void color()
        //{
        //    // diomond problem
        //}
        void color()
        {
            // diomond problem
        }
        void Icolorable.color()//The modifier 'public' is not valid for this item
        {
            // why?
            // in case we remove "pubic" , how we'll access it????????
        }
         void IsolidColor.color()
        {
            // solution of domoad
        }

    }
    class student: Person
    {
        public student()
        {
            // challenge?????????????????????????????
            // code here
            // base constructor
            // code here
            x = 12;
        }
        public student(int x , int y , string name ): base(x,y)
        {
            // name will be set according to student class object
            // x and y will be set out according to base class constructor
            // this is resuseability of OOP
        }
        public student(int x, int y, string name="A",string laptop = "Acer"): this(x , y , name)//solution of follwoing
        //public student(int x, int y, string grade="A",string laptop = "Acer"): this(x , y , name)
        {
             // you can also call constructor of same class from another constructor of that same class
             // above is the implentation of above line in C#   
        }
        public student(int y, string name = "Ammar")    // optional parameters. 
        {
            // if you did't pass name from calling function. then Ammar will be set out.
        }
    }
    class Program
    {
        // always use natural way to use and declaring vairblaes
        // i.e, String and string both are same
        //.......
        static void Main(string[] args)
        {
            //  Lec 15 Class work
            Person per = new Person();
            student std = new student();   
            per.speak();
            new Person().speak();
            // if we are to call the base class constructor?
            //
            // what will happen if we make a child class object
            IsolidColor colorable = std;
            colorable.stroke(); // working
            colorable.color();
            // above case(Diomond Problem) is very important for paper MSDN 
            Icolorable simple = std;
            simple.color();

            Console.ReadKey();
        }
    }
}

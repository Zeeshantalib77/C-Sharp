using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace class_7program1
{
    class Program
    {
        static void Main(string[] args)
        {
                        //Programm 1 start//
           
             //text color change
            
            // ye command jitna b text  ho ga os py coloor apply kar dy gi
           // Console.BackgroundColor = ConsoleColor.Yellow;
           /* Console.Clear();

            Console.WriteLine("I am junaid Mehar");         //Go to next line automatically Console.WriteLine
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("It's a time of programming\n"); */

                    //  program 1 end  //

                    
                   // program 2 start  // 

            /*       // text with color change
            ConsoleColor[] darkcolor = { ConsoleColor.DarkRed,
                                          
                                         ConsoleColor.DarkGreen,

                                         ConsoleColor.DarkYellow,
                                         
                                         ConsoleColor.DarkGray,

                                         ConsoleColor.DarkCyan
                                        };


            int indexrandom = 0;

            Random random = new Random();

            

            while(true)
            {
                indexrandom = random.Next(0, darkcolor.Length);

                Console.BackgroundColor = darkcolor[indexrandom];
                Console.WriteLine("Junaid is Going to Programmer");
                Thread.Sleep(1000);

            }*/
                        //program 2 end//


                       // prgram 3 start //


            string name = " Do you like prgramming ";
             
           Console.Title = "";                          //firstly title is empty then assigning value one by one
            for (int i = 0; i < name.Length; i++)
            {
                Console.Title +=Convert.ToString( name[i] );
                Thread.Sleep(250);
            }

                    //  program 3 end//


        }
    }
}

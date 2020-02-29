using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Class_7_part2
{
    class Program
    {
        static void Main(string[] args)
        {

                    //program 4 start//

            /* int randomindex;
             int frequency = 32;
             int duration = 1000;
            
            Console.Beep(frequency, duration);*/

/*
            ConsoleColor[] darkcolors ={ConsoleColor.Black,
                                           ConsoleColor.DarkBlue,
                                           ConsoleColor.DarkCyan,
                                           ConsoleColor.DarkGray,
                                           ConsoleColor.DarkMagenta,
                                           ConsoleColor.DarkRed
                                       };

            int randomindex;
            Random random = new Random();
            while(true)
            {
                Console.Clear();
                //randomly change window size
                Console.SetWindowSize(
                    random.Next(20,Console.LargestWindowWidth),
                    random.Next(20,Console.LargestWindowHeight)
                    
                    );
                //give randomly color
                randomindex = random.Next(0, darkcolors.Length);
                Console.BackgroundColor =darkcolors[randomindex];
                Console.Beep(random.Next(50,100) , 1000);
                Thread.Sleep(100);
                Console.ReadKey();   //additional thing
            }
 
  
                */
            //  4 program end //

            //5 program Starting from here
           /*
            string name = "Aliz desk";
            
            Console.Title = "";

            for (int i = 0; i < name.Length; i++)
            {
                Console.Title +=Convert.ToString( name[i] );
                Thread.Sleep(250);
            }
            
            */
            //5th program end


            //6 program starting form here
            /*
            int duration=1000;
            int randomindex = 0;
            Random random = new Random();
            ConsoleColor[] colors ={
                                       ConsoleColor.Cyan,
                                       ConsoleColor.DarkCyan,
                                       ConsoleColor.DarkGray,
                                       ConsoleColor.DarkGreen,
                                       ConsoleColor.DarkMagenta

                                      };

            while (true)
            {
                


               Console.SetWindowPosition(0, 0);
                randomindex = random.Next(0, colors.Length);
                Console.BackgroundColor = colors[randomindex];
                Console.Clear();
                Console.SetWindowSize(random.Next(0,Console.LargestWindowWidth),
                    random.Next(0,Console.LargestWindowHeight)
                                      );

                Console.Beep(random.Next(37, 3200),duration);
                Thread.Sleep(duration);

            }

            */
            //End of 6 program
            
            
            //7 program start form here//
            //But this code not working properly if any one find solution then tell me
             /* 
            int totalrows = 0;
            int totalcol = 0;
            int currentrow;
            int currentcol;
            int upperlimit = 0;
            int lowerlimit = 0;
            //int score=0;
            Console.Write("Enter the lower  limit of the random values");
            lowerlimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the upper  limit of the random values");
            upperlimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the number of rows");
            totalrows = Convert.ToInt32(Console.ReadLine());

            int[][] jagged = new int[totalrows][];
            Random randomvalues = new Random();
            int[] numberofcolumn = new int[totalrows];
            int yindex = 0;
            int xindex = 0;
            // int count = 0;
            Random randomindex = new Random();
            yindex = randomindex.Next(0, totalrows);
            xindex = randomindex.Next(0, totalrows);
            int realans = 0;
            realans = randomindex.Next(0, totalrows);


            for (currentrow = 0; currentrow < totalrows; currentrow++)
            {
                Console.Write("\nEnter the number of Columns at index:" + (currentrow + 1) + " \n");
                totalcol = Convert.ToInt32(Console.ReadLine());
                jagged[currentrow] = new int[totalcol];

                for (currentcol = 0; currentcol < jagged[currentrow].Length; currentcol++)
                {
                    Console.Write(" ");
                    Console.Write("#");
                    Console.Write(" ");

                }
                Console.Write("\n");
            }//outer for loop close

            Console.Clear();
            Console.Write("your number of columns at each row are these\n");

            for (currentrow = 0; currentrow < totalrows; currentrow++)
            {

                for (currentcol = 0; currentcol < jagged[currentrow].Length; currentcol++)
                {

                    if (xindex == currentrow && yindex == currentcol)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                        Console.Write("?");
                        Console.Write(" ");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.Write("#");
                        Console.Write(" ");

                    }

                }//inner for close

                Console.Write("\n");

            }//outer for close

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(a)" + xindex + "(b)" + xindex + "(c)" + realans);
            Console.Write("\n\n\n");

            ///
            int ans = 0;
            Console.Write("Guess the value at ? mark index");
            ans = Convert.ToInt32(Console.ReadLine());




            for (currentrow = 0; currentrow < numberofcolumn.Length; currentrow++)
            {


                for (currentcol = 0; currentcol < jagged[currentrow].Length; currentcol++)
                {

                    jagged[currentrow][currentcol] = randomvalues.Next(lowerlimit, upperlimit);

                    if (xindex == currentrow && yindex == currentcol)
                    {
                        if (jagged[xindex][yindex] == ans)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (jagged[xindex][yindex] != ans)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(" ");
                        Console.Write(ans);
                        Console.Write(" ");

                    }

                    else if (jagged[currentrow][currentcol] == realans)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" ");
                        Console.Write(realans);
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.Write("#");
                        Console.Write(" ");

                    }

                }//inner for loop close
                Console.Write("\n");

            }//outer for loop close


            //End of program 7//

             
            */










        }
    }
}

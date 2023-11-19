using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_set_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOOPS

        }
        static void Q_set3_1()
        {
            //print all numbers from 1 upto N...
            Console.WriteLine("Print all numbers 1 upto 10:");

            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);

            }
        }
        static void Q_set3_2()
        {
            //Given M,N Print all numbers from M upto N, where M<N...
             Console.WriteLine("print all numbers from M upto N:");

            Console.WriteLine("Enter the M value:" );
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the N value:");
            int N = int.Parse(Console.ReadLine());

            for (; M < N; M++)
            {

                Console.WriteLine(M);//m=1 , n=101

            }
        
        }
        static void Q_set3_3()
        {
            //Given N, Print all even numbers from 1 upto N.
             Console.WriteLine("Print all even numbers 1 upto N:");
            Console.WriteLine("Enter the N value:");
            int N = int.Parse(Console.ReadLine());
            int i;
            for ( i=0;i<=N; i=i+2)
            {
                
                Console.WriteLine(i);

            }
        
        }

        static void Q_set3_4()
        {
            //Given N,Print all odd numbers from 1 upto N.
             Console.WriteLine("print all Even numbers 1 upto N:");

            Console.WriteLine("Enter the N valur:");
            int N = int.Parse(Console.ReadLine());
            int i =1;
           for (;i<=N;i =i+2)
            {
                Console.WriteLine(i);
                
            }
        }

        static void Q_set3_5()
        {
            //Given M,N Print all even numbers from Mupto N,where M<N.
            Console.WriteLine("Print all even numbers M upto N:");


            Console.WriteLine("Enter the M value :");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the N value:");
            int N = int.Parse(Console.ReadLine());

            for (; M <= N; M++)
            {
                if (M % 2 == 0)//4%2==0 or 5%2=1 !=0
                {
                    Console.WriteLine(M);

                }

            }
        }
        static void Q_set3_6()
        {
            //Given M,N Print all odd numbers from Mupto N, where M<N.
            Console.WriteLine("print all odd numbers from M upto N :");
            Console.WriteLine("Enter the value M:");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value N:");
            int N = int.Parse(Console.ReadLine());
            for (; M <= N; M++)
            {
                if (M % 2 == 1)
                {
                    Console.WriteLine(M);

                }
            }

        }
        static void Q_set3_7()
        {
            //Print all Numbers between 1 upto 100 that are divisible by a Given Number N.
            Console.WriteLine("Print all Numbers between  1 upto 100 divisible by N:");
            //Console.WriteLine("Enter the M value:");
            //int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the N value:");
            int N = int.Parse(Console.ReadLine());
            int i;

            for (i = 1; i <= 100; i++)
            {
                if (i % N == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Q_set3_8()
        {
            //Display the multiplication Table upto 20 for a given value N.
                         Console.WriteLine("Multiplication Table upto 20 for a given value N:");
             Console.WriteLine("Enter the value N:");
             int N = int.Parse(Console.ReadLine());
             int i;
               int p ;
               for (i = 1; i <= 20; i++)
               {
                   p = (i * N);
                   {
                       Console.WriteLine("" + " " +i + "*" +N+ "=" +p);
                      // Console.ReadKey();
                   }
               }

        }


        static void Q_set3_9()
        {
            //Display Multiplication tables for 1,2,3,4,5 upto 20 rows in each.
            Console.WriteLine("Multiplication Tables  1,2,3,4,5 upto 20 rows:");
            Console.WriteLine("Enter the value a is 1st Table:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value b is 2nd Table:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value c is 3rd Table:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value d is 4th Table:");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value e is 5th Table:");
            int e = int.Parse(Console.ReadLine());

             int i,p,j,q,k,l,m,r,s,t;

             Console.WriteLine("\n First table");

               for (i = 1; i <= 20;i++)
               {
                   p = i * a;
                   {
                       Console.WriteLine("" + " " +i + "*" +a+ "=" +p);
                       
                   }
               }

               Console.WriteLine("\n Second table");

            for (j = 1; j <= 20;j++)
            {
                q = j * b;
                {
                    Console.WriteLine("" + " " + j + "*" + b + "=" + q);
                    // Console.ReadKey();
                }
            }

            Console.WriteLine("\n third table");
            Console.WriteLine("/n");
            for (k = 1; k <= 20; k++)
            {
                r = k * c;
                {
                    Console.WriteLine("" + " " + k + "*" + c + "=" + r);

                }
            }

            Console.WriteLine("\n fourth table");
            Console.WriteLine("/n");
            for (l = 1; l <= 20; l++)
            {
                s = l * d;
                {
                    Console.WriteLine("" + " " + l + "*" + d + "=" + s);

                }
            }

            Console.WriteLine("\n fifth table");
            Console.WriteLine("/n");
            for (m = 1; m <= 20; m++)
            {
                t = m * e;
                {
                    Console.WriteLine("" + " " + m + "*" + e + "=" + t);

                }
            }

        }
        static void Q_set3_10()
        {

            //Given N, Print the sum of all numbers between 1 and N. 
              Console.WriteLine("Print the sum of all numbers between 1 and N:");
            Console.WriteLine("/n");

            Console.WriteLine("Enter the value of N:");
            int N = int.Parse(Console.ReadLine());

          int  sum =0 ;

          for (int i = 1; i <= N;i++)//
          {
              sum = sum + i;        //0+1=1; 2+1=3; 3+3=6; 4+6=10;5+10=15;

             
          }
          Console.WriteLine(" sum of numbers:" + sum);
        
        }


        static void Q_set3_11()
        {

            //Given N, Print the sum of all even numbers b/w 1 and N.

             Console.WriteLine("Print the sum of all even numbers:");

            Console.WriteLine("Given the value of N:");
            int N = int.Parse(Console.ReadLine());

            int i;
           int sum = 0;
            for (i = 1; i <= N; i++) 
            {
                if (i % 2 == 0) // 1%2!=0;2%2=0 , sum =0 +2=2  // 4%2==0 sum =2+4=6; // 6%2==0 sum =6+6=12 // sum =8+12=20;

                {
                    sum = sum + i;

                    Console.WriteLine(sum);
                }
            }
               

        }
        


        static void Q_set3_12()
        {

            //Given N, Print the sum of all odd numbers b/w 1 and N.
            Console.WriteLine("Print the sum of all odd numbers b/w 1 and N:");
            Console.WriteLine("Given the value of N:");
            int N = int.Parse(Console.ReadLine());

            int i;
            int sum = 0;
            for (i = 1; i <= N; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;

                    Console.WriteLine(sum);
                }
            }

        }
        static void Q_set3_13()
        {
            //Given K and N, Print the sum of all multiples of k between 1 and N.
            Console.WriteLine("print the sum of all multiple of K between 1 and N:");

            Console.WriteLine(" ");
            Console.WriteLine("Given the value of N:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Given the value of k:");
            int k = int.Parse(Console.ReadLine());

            int i, p, sum = 0;
            for (i = 1; i <= N; i++)
            {
                p = (i * k); //1*2=2, 2*2=4 ,3*2=6,4*2=8 , 5*2=10, 12,14 , 16.18,20...
                sum = sum + p; //0+2=2, 2+4=6,6+6=12, 12+8=20,20+10=30,42, 56, 72,90,110..

            }
            Console.WriteLine(sum);
        }
        static void Q_set3_14()
        {
            /*Given N, Write a program that prints  Fizz if the no. is a multiple of 3 and 5, otherwise number is a multiple of 5,Fizzbuzz if the 
            is a multiple of 3 and 5, print the no.upto N. */

                        Console.WriteLine("fizz buzz ");
            Console.WriteLine(" ");
            Console.WriteLine("Given the value of N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");


            for (int i = 1; i <= N; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3==0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            
        }
        static void Q_set3_15()
        {
           //factorial of a given number...
            Console.WriteLine("Enter the factorial of a given number:");

            Console.WriteLine("");

            int N = int.Parse(Console.ReadLine());
            int i = 1;
            int fact = 1;
            for (; i <= N; i++)
            {
                fact = fact * i;   //1*1=1;1*2=2;2*3=3..


            }
            Console.WriteLine("The factorial is:" + fact);

        }
        static void Q_set3_16()
        {
            //To Find the total and Average marks...
             Console.WriteLine("Find the total and Average all subjects in the current semester:");
            Console.WriteLine("");

            Console.WriteLine("Given the how many subjects in the current semester:");
            int N = int.Parse(Console.ReadLine());


            int i = 1, total = 0, Avg;

            for (; i <= N; i++)
            {
                Console.WriteLine("Enter the Subject marks");
                int sub = int.Parse(Console.ReadLine());
                total = (total + sub);
                Console.WriteLine("Ur total is:" + total);
                Avg = (total / N);

                Console.WriteLine("Ur Average is:" + Avg);

            }

                //Console.WriteLine("Enter the each subject of marks:");
                // int sub = sub + i;
                //Console.WriteLine(i);
            
        
           
        }
        static void Q_set3_17()
        {
            //Print the running score after each round and find the total at the end.
             Console.WriteLine("Enter the match rounds:");
            int N = int.Parse(Console.ReadLine());

            int i = 1,total=0;
            for (; i <= N; i++)
            {
                Console.WriteLine("Enter the each match scores:");
                int score = int.Parse(Console.ReadLine());
                //break;
                //Console.WriteLine(score);
                total = (total + score);
            }
                Console.WriteLine("Final score:" +total);
        }
        static void Q_set3_18()
        {
            //Improve the menu driven calculator...
            string value;
            do
            {
            Console.WriteLine("Menu driven calculator:");
            Console.WriteLine(" ");

            Console.WriteLine("MENU ,1. Addition,2. subtraction,3. multiplicatio,4. division ,5. modulo division ");

            Console.WriteLine("Enter the menu number ");
            int num1 = int.Parse(Console.ReadLine());
             
           

            switch (num1)
            {
                case 1:
                    Console.WriteLine("Enter the  add no. 1");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the add no. 2");
                    double n2 = double.Parse(Console.ReadLine());
                    double sum = n1 + n2;
                    Console.WriteLine("addition value is" + sum);
                    break;

                case 2:
                    Console.WriteLine("Enter the  sub no.1");
                    double m = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the sub no. 2");
                    double n = double.Parse(Console.ReadLine());
                    double sub = m - n;
                    Console.WriteLine("subtraction value is" + sub);
                    break;

                case 3:
                    Console.WriteLine("Enter the  mul no.1");
                    double p = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the mul no. 2");
                    double q = double.Parse(Console.ReadLine());
                    double mul = p * q;
                    Console.WriteLine("multiplication value is" + mul);
                    break;

                case 4:
                    Console.WriteLine("Enter the  div no.1");
                    double a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the div no. 2");
                    double b = double.Parse(Console.ReadLine());
                    double div = a / b;
                    Console.WriteLine("division value is" + div);
                    break;

                case 5:
                    Console.WriteLine("Enter the  modulo division no.1");
                    double c = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the modulo division 2");
                    double d = double.Parse(Console.ReadLine());
                    double mdiv = c % d;
                    Console.WriteLine("modulo division value is" + mdiv);
                    break;
            }
                //Console.ReadKey();
            Console.WriteLine("Do you want to continue click Yes:");
            value = Console.ReadLine();
            Console.WriteLine(value);
            } while (value == "yes" || value == "Yes");

        }
        static void Q_set3_19()
        {
            //RPS game.

             {
                Console.WriteLine("Enter the each match  round in odd numbers:");
                int X = int.Parse(Console.ReadLine());
                for (int i = 1; i <= X; i++)
                {
                    Console.WriteLine("Improve the RPS game:");
                    Console.WriteLine(" ");

                    Console.WriteLine("play the Rock, Paper ,Scissors");


                    int computerNum;
                    //int p = 0, q = 0;

                    Console.WriteLine("Choose the 1.Rock , 2.Paper , 3. Scissor");
                    int userNum = int.Parse(Console.ReadLine());

                    Random random = new Random();
                    computerNum = random.Next(1, 4);

                    Console.WriteLine("computer number" + computerNum);
                    // if (userNum == computerNum)
                    // {
                    //      Console.WriteLine("draw");
                    //}
                    if ((userNum == 1 && computerNum == 3) || (userNum == 2 && computerNum == 1) || (userNum == 3 && computerNum == 2))
                    {
                        Console.WriteLine("You win:" + userNum);
                         
                        Console.WriteLine( userNum);
                    }
                    else
                    {

                        Console.WriteLine("computer win" + computerNum);
                     
                        Console.WriteLine(computerNum);

                    }
                }  
            }
            
        }
        static void Q_set3_20()
        {
            //Number guessing game.

             {
            Console.WriteLine("Guessing game:");
            Console.WriteLine();

            Random random = new Random();
            int user1 = random.Next(1, 21);

           int  user2=0;
            int attempt =0;


            while (user2 != user1)
            {

                Console.WriteLine("Enter the guessing Number 1 to 21:");
                user2 = int.Parse(Console.ReadLine());

                attempt++;

                if (user2 > user1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You are guessing number is high:");
                }
                else if (user2 < user1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You are guessing number is low:");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Congratulations!"+"You are win:" );

                }
                Console.WriteLine("");
                Console.WriteLine("You are attempt is: " +attempt);
            }
                }
            
        }
        
         /* Console.WriteLine("Random number");
            Random rnd = new Random();
            int randomnumber = rnd.Next(0, 2);
            Console.WriteLine("Random number" + randomnumber);*/
        }
        }
       

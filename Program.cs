using System;

namespace Net.Training
{
    class Program
    {
        static int x;
        static bool myBool = false;
        static char c = 'a';
        static string str = "name";
        static double dbl = 10;
        static decimal myDecimal = 20.22m;
        static float flt = 10.2f;
        static long sht = 1234567891111111110; //64 bit, 32bit, 16bit

        static int[] arr = new int[7] { 40, 50, 20, 50, 20, 20, 30 };
        static void Main(string[] args)
        {


            int x = 110;
            int y = 20;

            //int z = x % y;

            //x++; //x=x+1;
            //x--;

            //int z = x++;  //post increment operator
            int z = ++x; //pre inc opr

            Console.WriteLine(z + " " + x);


            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int i = 0;

            //while (i < arr.Length)
            //{
            //    Console.WriteLine(arr[i]);
            //    i++;
            //}


            //int i = 0;

            //do
            //{
            //    Console.WriteLine(arr[i]);
            //    i++;
            //}
            //while (i < arr.Length);


            //Console.WriteLine("Enter your age");

            //int age = Convert.ToInt32(Console.ReadLine())

            //Console.WriteLine("Enter your name");

            //string name = Console.ReadLine();

            //switch (name)
            //{
            //    case "john":
            //        Console.WriteLine("Hello Mr. " + name);
            //        break;
            //    case "susan":
            //        Console.WriteLine("Hello Mrs. " + name);
            //        break;
            //}


            //CTRL + K U
            // CTRL + K C
            //if (age <= 20)
            //{
            //    Console.WriteLine("You are young");
            //}
            //else if (age <= 30)
            //{
            //    Console.WriteLine("You are young at heart");
            //}
            //else if (age <= 40)
            //{
            //    Console.WriteLine("You are still young");
            //}
            //else
            //{
            //    Console.WriteLine("You are awesome");
            //}

            //switch (age)
            //{
            //    case 20:
            //        Console.WriteLine("You are young");
            //        break;
            //    case 30:
            //        Console.WriteLine("You are young");
            //        break;
            //    case 40:
            //        Console.WriteLine("You are young");
            //        //
            //        //
            //        //
            //        break;
            //    default:
            //        Console.WriteLine("You are awesome");
            //        break;
            //}

            //myBool = true;

            //arr[1] = 100;

            //arr[5] = 300;

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);



        }

        static void Method1()
        {
            int y = 10;
            Console.WriteLine(y);
        }
    }
}
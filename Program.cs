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

            string str = "";

            int age = 20;

            //if (age == 20)
            //{
            //    str = "you are young";
            //}
            //else
            //{
            //    str = "you are awesome";
            //}

            str = age == 20 ? "You are young" : "you are awesome";

            Console.WriteLine(str);

            //string name = "Joseph";

            //Method2(name);

            //Console.WriteLine(name);

            //int x = 10;
            //int y = 20;

            //int result = Add(ref x, ref y);

            //Console.WriteLine(result);

            //Console.WriteLine("x is " + x);
            //Console.WriteLine("y is " + y);



            //Console.WriteLine(Add(10, 20));
            //result += 10;

            //Add(20, 20);
            //Add(30, 20);


            //int x = 10;
            //int y = 20;

            //x = x + 10;

            //x += 10;
            //x -= 10;
            // x *= 10; //x=x*10;

            // x /= 10; //x=x/10;

            //x %= 10; //x=x%10;  0
            //Console.WriteLine(x);

            //Console.WriteLine(x >= y);

            //bool myVar = false;
            //bool myVar2 = false;

            ////if(myVar==false)
            //if (myVar || myVar2)
            //{
            //    Console.WriteLine("If is executed");
            //}

            /*
             
             P  q   p^q

             0  0    0
             0  1    0
             1  0    0
             1  1    1

             P  q   p|q

             0  0    0
             0  1    1
             1  0    1
             1  1    1
             
             */


            //for (int i = 0; i < arr.Length/2; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //foreach(int elem in arr)
            //{
            //    Console.WriteLine(elem);
            //}



            //var enumerator = arr.GetEnumerator();

            //while (enumerator.MoveNext() == true)
            //{
            //    Console.WriteLine(enumerator.Current);
            //}


            //int x = 110;
            //int y = 20;

            //int z = x % y;

            //x++; //x=x+1;
            //x--;

            //int z = x++;  //post increment operator
            //int z = ++x; //pre inc opr

            //Console.WriteLine(z + " " + x);




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

        static void Method()
        {
            Console.WriteLine("Method is called");
        }

        //Single responsibility Principle SRP
        static int Add(ref int a, ref int b)
        {
            a++;
            b++;
            return a + b;
        }

        static void Method2(string name)
        {
            name += "Mr.";
        }
    }

}
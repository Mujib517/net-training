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

            //instance 
            MyClass mc = new MyClass(50, 70);
            mc.Display();

            MyClass mc2 = new MyClass(100, 70);
            mc2.Display();



            //4bytes +4 bytes
            //MyClass mc = new MyClass(); //building
            //mc.Display();
            //int result = mc.Add(20, 30);
            //Console.WriteLine(result);
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

        static void DisplayEvenNumbers()
        {
            int[] vals = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < vals.Length; i++)
            //{
            //    if (vals[i] % 2 == 0)
            //    {
            //        Console.WriteLine(vals[i]);
            //    }
            //}


            foreach (int elem in vals)
            {
                if (elem % 2 == 0) Console.WriteLine(elem);
            }

        }

        static void DisplayOddNumbers()
        {
            int[] vals = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < vals.Length; i++)
            //{
            //    if (vals[i] % 2 != 0)
            //    {
            //        Console.WriteLine(vals[i]);
            //    }
            //}

            //foreach (int elem in vals)
            //{
            //    if (elem % 2 != 0) Console.WriteLine(elem);
            //}

            int i = 0;
            while (i < vals.Length)
            {
                if (vals[i] % 2 != 0)
                {
                    Console.Write(vals[i] + " ");
                }
                i++;
            }
            Console.WriteLine();
        }
    }
}
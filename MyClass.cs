using System;

namespace Net.Training
{
    //encapsulation
    class MyClass
    {
        private int _x;  //4bytes,long:8bytes
        private int _y;

        //initialization 
        //public MyClass()
        //{
        //    _x = 10;
        //    _y = 20;
        //    //db calls
        //    //complex operations
        //    Console.WriteLine("Constructor invoked");
        //}

        public MyClass(int x, int y)
        {
            _x = x;
            _y = y;
            //this.x = x;
            //this.y = y;
        }

        //Method overloading
        //inside a single class
        //2 or more methods with same name
        //with different number of parameters
        //different type of parameters
        public void Display()
        {
            Console.WriteLine(_x);
        }

        public void Display(int z)
        {
            Console.WriteLine(z);
        }

        public void Display(string z)
        {
            Console.WriteLine(z);
        }

        public void Display(int z, int w)
        {
            Console.WriteLine(z + " " + w);
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

    }
}
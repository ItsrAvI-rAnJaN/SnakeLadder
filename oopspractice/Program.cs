using System;

namespace oopspractice
{
    class program
    {
        public program()
        {
            Console.WriteLine("This is Constructor Number 1");

        }
        public program(int a, int b)
        {
            Console.WriteLine("This is Consttructor Number 2", a + b);

        }
        public program(int a, int b, int c)
        {
            Console.WriteLine("This is COnstructor Number 3",a+b+c);

        }
        public program(string a, string b, string c)
        {
            Console.WriteLine("This is Constructor Number 4", "a","b","c");
        }
        static void Main(string[] args)
        {
            program p =new program();
            p.
            program q = new program(4, 5);
            program r = new program(6, 7, 8);
            program s = new program( "Ravi", "Anmol", "Chunmun");
        }


        
    }
}
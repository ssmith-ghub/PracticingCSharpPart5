using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting = Converting a value to a different data type
            //                Useful when we accept user input (string)
            //                Different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a); //converting a double to int will get rid of the decimal places : Convert.ToInt32(variable)

            int c = 123;
            double d = Convert.ToDouble(c); //converting an int to a doulb will allow decimal places if available : Convert.ToDouble(variable)

            int e = 321;
            string f = Convert.ToString(e); //if you convert int to string it can no longer be used for math : Convert.ToString(variable) 

            string g = "$";
            char h = Convert.ToChar(g); //strings are multiple characters while char is a single character : Convert.ToChar(variable)

            string i = "true";
            bool j = Convert.ToBoolean(i); //even though the string and bool say true its the "" that changes if it is a bool : Convert.ToBoolean(variable)

            Console.WriteLine(a.GetType()); //this is the GetType method which will dispaly data types : variable.GetType()
            Console.WriteLine(a);
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadKey();

            Console.WriteLine(c.GetType());
            Console.WriteLine(c);
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);
            Console.ReadKey();

            Console.WriteLine(e.GetType());
            Console.WriteLine(e);
            Console.WriteLine(f.GetType());
            Console.WriteLine(f);
            Console.ReadKey();

            Console.WriteLine(g.GetType());
            Console.WriteLine(g);
            Console.WriteLine(h.GetType());
            Console.WriteLine(h);
            Console.ReadKey();

            Console.WriteLine(i.GetType());
            Console.WriteLine(i);
            Console.WriteLine(j.GetType());
            Console.WriteLine(j);
            Console.ReadKey();
            Console.Beep();
        }
    }
}

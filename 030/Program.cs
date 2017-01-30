using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int number = 1;
        while (number != 0)
        {
            loop:
            Console.WriteLine("Enter a number:  (Enter 0 to exit)");
            string x = Console.ReadLine();
            bool result = Int32.TryParse(x, out number);
            if (result)
            {

                for (int i = 1; i < 13; i++)
                {
                    Console.Write("{0} x {1} = {2}\t", i, number, number * i);
                    Console.Write("{0} + {1} = {2}\t", i, number, number + i);
                    Console.Write("{0} - {1} = {2}\t", i, number, number - i);
                    Console.Write("{0} \u00F7 {1} = {2}\n", i, number, number / i);
                }
            }
            else
            {
                //            if (value == null) value = ""; 
                Console.WriteLine("Attempted conversion of '{0}' failed.", x == null ? "<null>" : x);
                goto loop;
            }
        }
    }
}
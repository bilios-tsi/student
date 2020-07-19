using System;
using System.Diagnostics.Tracing;

namespace mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string getage;
            Student S = new Student();
            c += 1;
            S.Id = "CD" + c.ToString();
            Console.WriteLine("Hello Student!");
            Console.WriteLine("Give your Age");
            S.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give your last name");
            S.LN = Console.ReadLine();
            Console.WriteLine("give your first name");
            S.FN = Console.ReadLine();
            Console.WriteLine(S.FN +" "+ S.LN + " is " + S.Age + " years old and your ID is "+S.Id);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190214b
{
    class Program
    {
        static void Main(string[] args)
        {
            new WorkBench().Run();
        }
    }

    class WorkBench
    {
        Random rand = new Random();
        int randomChoice = 0;

        public void Run()
        {
            // commit
            randomChoice = rand.Next(0, 25);

            for (Console.WriteLine("YIPPIE") ; MethodA() ; Console.WriteLine(MethodB()) )
            {   
                Console.WriteLine("Happy Valentine's Day!!");
                Console.ReadLine();
            }
        }

        public bool MethodA()
        {
            return true;
        }

        public string MethodB()
        {
            string[] letters = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            string output;
            
            output = letters[randomChoice];
            return output;
        }

    }
}

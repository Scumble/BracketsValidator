using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Bracket
    {
        public static bool checkBrackets(string str)
        {
            int counter = 0;
            foreach (char v in str)
            {
                if (v == '(')
                {
                    counter++;
                }
                else if (v == ')')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    return false;
                }
            }
            return counter == 0;
        }

        static void Main(string[] args)
        {

            String example = "())((";
            Console.WriteLine(example);
            if (checkBrackets(example))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.ReadLine();
        }
    }
}

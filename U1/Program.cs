using System;

namespace U1
{
    class Program
    {
        private static object employee;

        static void Main(string[] args)
        {
            String[] employee = new String[];
            String[] salary = new String[];

            while (Console.ReadLine() != null)
            {
                int m;
                Console.WriteLine("Ange namn på anställd: ");
                employee[m] = Console.ReadLine();
                Console.WriteLine("Ange lön för anställd: ");
                salary[m] = Console.ReadLine();
                m++;


            }


        }

        private static getreg(x)
        {

            int i=x;
                        while (i<=Program.employee[].length)
            {
                Console.WriteLine(Program.employee[i]);
                i++;
            }

        }
    }
}

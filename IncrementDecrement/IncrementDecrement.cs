using System;


namespace IncrementDecrement
{
    class IncrementDecrement
    {
        static void Main(string[] args)
        {
            int a = 0;
            int x = 0;
            int b = 0;
            int y = 0;

            //a
            Console.WriteLine("Enter an integer for a");
            string str_a = Console.ReadLine();
            a = Convert.ToInt32(str_a);

            //x
            Console.WriteLine("Enter an integer for x");
            string str_x = Console.ReadLine();
            x = Convert.ToInt32(str_x);

            //b
            Console.WriteLine("Enter an integer for b");
            string str_b = Console.ReadLine();
            b = Convert.ToInt32(str_b);

            //y
            Console.WriteLine("Enter an integer for y");
            string str_y = Console.ReadLine();
            y = Convert.ToInt32(str_y);

            MakeTheNumbersMatch(a, x, b, y);

            Console.ReadLine();
        }

        public static void MakeTheNumbersMatch(int a, int x, int b, int y)
        {
            int startA = a;
            int startX = x;
            int startB = b;
            int startY = y;

            while (a != x && b != y)
            {
                if (a < x)
                {
                    a++;
                }
                else if (a > x)
                {
                    a--;
                }

                if (b < y)
                {
                    b++;
                }
                else if (b > y)
                {
                    b--;
                }
            }

            Console.WriteLine("Initial values of a = {0} and x = {1} are equal when 'a' either increments or decrements to equal a={2}", startA, startX, a);

            Console.WriteLine();

            Console.WriteLine("Initial values of b = {0} and y = {1} are equal when 'b' either increments or decrements to equal b={2}", startB, startY, b);
        }
    }
}

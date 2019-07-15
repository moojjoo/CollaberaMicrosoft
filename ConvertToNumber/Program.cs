using System;

namespace CollaberaMicrosoft
{
    class Program
    {
        static void Main(string[] args)
        {

            //Returns 0 if it cannot convert
            int n = ConvertToNumber("1234sss5");
            Console.Write(n + Environment.NewLine);
        }

        public static int ConvertToNumber(string str)
        {
            int result = 0;

            bool IsConversionSuccessfull = int.TryParse(str, out result);

            if (IsConversionSuccessfull)
                Console.Write(result);

            else
                Console.Write("Sting cannot be converted to number" + " " + "");

            return result;

        }

    }
}

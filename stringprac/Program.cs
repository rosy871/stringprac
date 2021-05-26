using System;

namespace stringprac
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "this is test";
            string str2 = "this is text";

            if (String.Compare(str1,str2)==0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.ReadKey();

            if (str1.Contains("test"))
            {
                Console.WriteLine("'test' word was found in str1.\n\n");
            }
            Console.ReadKey();

            string[] sarray = new string[]
            {
                "my husband name is sudeep",
                "my name is rosy",
                "I have two children",
                "my first child is boy",
                "and his name is suroz",
                "and my second child is girl",
                "and her name is surina"
            };
            string str = String.Join("\n", sarray);
            Console.WriteLine(str);

        }
    }
}

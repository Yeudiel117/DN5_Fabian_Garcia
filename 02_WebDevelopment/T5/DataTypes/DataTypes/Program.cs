using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "This is string";
            int age = 35;
            DateTime now = DateTime.Now;

            double amount = 0;

            string string2 = text + " a secon string";

            string string3 = string.Format("The age is {0}, the time is {1}, and the amount is {2}", age, now, amount);

            string string4 = $"The age is {age}, the time is {now}, and the amount is {amount}";

            char sampleChar = 'A';
            char[] arrayChar = string4.ToCharArray();

            age = 10 / 3;

            string test = "15";

            string booleanValue = "True";

            bool isTrue = bool.Parse(booleanValue);

            age = int.Parse(test);


            Console.ReadKey();

        }
    }
}

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myName = "Sasha";
            //decimal myAge = 20 + 3;

            //Console.WriteLine("Hello, my name is {0,-10}! I am {1} years old.", myName, myAge);
            //Console.WriteLine("Hello! My name is " + myName + ". I am " + myAge + " years old.");
            //Console.WriteLine($"Hello! My name is {myName}. I am {myAge} years old.");

            double myNumber = 10 * 2;
            Console.WriteLine(myNumber);
            double secondNumber = 46.0 / 3;
            Console.WriteLine(secondNumber);
            double thirdNumber = 45 - 5;
            Console.WriteLine(thirdNumber);
            double fourthNumber = 25 * 2;
            Console.WriteLine(fourthNumber);

            double remain = 20 % 3;
            Console.WriteLine(remain);

            double result = (2 + 8) * 2;
            Console.WriteLine("The result is {0}.", result);

            double combine = myNumber + secondNumber + thirdNumber + fourthNumber + remain + result;
            Console.WriteLine(combine);

            double x = 9;
            x += 1;
            Console.WriteLine("The value of x is {0}.", x);

            double y = 7;
            y++;
            Console.WriteLine("The value of y is {0}.", y);

            double a = 23;
            double b = a++;
            Console.WriteLine("I am {0} years old and I'll be {1} years old in July.", b, a);
        }
    }
}
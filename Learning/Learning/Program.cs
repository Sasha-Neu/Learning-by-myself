namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Sasha";
            decimal myAge = 23;
            
            Console.WriteLine("Hello, my name is {0,-10}! I am {1} years old.", myName, myAge);
            Console.WriteLine("Hello! My name is " + myName + ". I am " + myAge + " years old.");
            Console.WriteLine($"Hello! My name is {myName}. I am {myAge} years old.");
        }
    }
}
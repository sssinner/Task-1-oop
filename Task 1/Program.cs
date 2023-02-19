namespace Task_1
{
    internal class Program
    {
        delegate float Operation(float x, float y);
        static void Main(string[] args)
        {

            Operation add = (a, b) => a + b;
            Operation subtract = (a, b) => a - b;
            Operation multiply = (a, b) => a * b;
            Operation divide = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return 0;
                }
                return a / b;
            };

            Console.WriteLine("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter two numbers: ");
            float elem1 = float.Parse(Console.ReadLine());
            float elem2 = float.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine(add(elem1, elem2));
                    break;
                case "-":
                    Console.WriteLine(subtract(elem1, elem2));
                    break;
                case "*":
                    Console.WriteLine(multiply(elem1, elem2));
                    break;
                case "/":
                    Console.WriteLine(divide(elem1, elem2));
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number:");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine number:");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe (+, -, *, /):");
            string input = Console.ReadLine();

            switch (input)

            {
                case "+":
                    Console.WriteLine($"tulemus: {firstNumber + secondNumber}");
                    break;
                //case "-":
                //    result = firstNumber - secondNumber;
                //    break;
                //case "*":
                //    result = firstNumber * secondNumber;
                //    break;
                //case "/":
                //    result = firstNumber / secondNumber;
                //    break;
                    case "-":
                        Console.WriteLine($"tulemus: {firstNumber - secondNumber}");
                        break;
                case "*":
                    Console.WriteLine($"tulemus: {firstNumber * secondNumber}");
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("poesh govna");
                    }
                    else
                    {
                        Console.WriteLine($"tulemus: {firstNumber / secondNumber}");
                        
                    }
                    break;
                default:
                    Console.WriteLine("eflbjfeeflbj-");
                    break;


            }
        }
    }
}

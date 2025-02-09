namespace Calculator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play = true;

            Console.WriteLine("--------------------------");
            Console.WriteLine("------- calculator -------");
            Console.WriteLine("--------------------------");

            while (play)
            {
                bool ple = true;
                bool pl = true;
                bool p = true;
                bool o = true;

                float Result = 0;
                float? num1 = null;
                float? num2 = null;

                char? num3 = null;

                while (ple)
                {
                    Console.WriteLine("");

                    try
                    {
                        Console.Write("Enter first number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                    }
                    catch (FormatException)
                    {
                        num1 = null;

                        Console.WriteLine("An error has occurred!");
                    }
                    if (num1 == null) { ple = true; }
                    else { ple = false; }
                }

                while (pl)
                {
                    try
                    {

                        Console.Write("Enter second number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                    }
                    catch (FormatException)
                    {
                        num2 = null;

                        Console.WriteLine("An error has occurred!");
                    }
                    if (num2 == null) { pl = true; }
                    else { pl = false; }
                }
                while (p)
                {
                    try
                    {
                        Console.WriteLine("");

                        Console.WriteLine("     +|");
                        Console.WriteLine("     -|");
                        Console.WriteLine("     *|");
                        Console.WriteLine("     /|");

                        Console.WriteLine("");

                        num3 = Convert.ToChar(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        num3 = null;

                        Console.WriteLine();
                        Console.WriteLine("An error has occurred!");
                        Console.WriteLine();
                    }
                    if (num3 == null) { p = true; }
                    else { p = false; }
                }

                while (o)
                {
                    if (num3 == '+' || num3 == '-' || num3 == '*' || num3 == '/')
                    {
                        num3 = num3;
                        o = false;
                    }
                    else
                    {
                        Console.WriteLine("");

                        Console.WriteLine("     +|");
                        Console.WriteLine("     -|");
                        Console.WriteLine("     *|");
                        Console.WriteLine("     /|");

                        Console.WriteLine("");

                        num3 = Convert.ToChar(Console.ReadLine());

                        o = true;
                    }
                }

                switch (num3)
                {
                    case '+':
                        Result = (float)(num1 + num2);
                        Console.WriteLine(Result);
                        break;
                    case '-':
                        Result = (float)(num1 - num2);
                        Console.WriteLine(Result);
                        break;
                    case '*':
                        Result = (float)(num1 * num2);
                        Console.WriteLine(Result);
                        break;
                    case '/':
                        Result = (float)(num1 / num2);
                        Console.WriteLine(Result);
                        break;
                    default: break;
                }

                Console.WriteLine("Would you like to use a calculator? (Y/N): ");
                string k = Console.ReadLine(); k = k.ToUpper();


                if (k == "Y")
                {
                    play = true;
                }
                else { play = false; }
            }
        }
    }
}

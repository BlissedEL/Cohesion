using Cohesion.Abstractions.Cohesion;

namespace Cohesion.Abstractions
{
    internal class Method
    {
        public static async Task MonitorKeyPressAsync()
        {
            System.Console.Clear();
            await Task.Yield(); // Yield to prevent running the following code synchronously on the caller's context

            MainConsoleMenu.Reveal();
            System.Console.WriteLine("Press any key to evaluate (press enter to quit):");

            while (true)
            {
                ConsoleKeyInfo keyInfo = System.Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    System.Console.WriteLine("Quitting...");
                    break;
                }

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        System.Console.Clear();
                        Sol _ = new Sol();
                        break;
                    case ConsoleKey.D2:
                        System.Console.WriteLine($"'{keyInfo.Key}' maps to '2' as the alternative.");
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D8:
                        break;
                    case ConsoleKey.D0:
                        break;
                    // ... Add more cases as needed
                    default:
                        System.Console.WriteLine($"'{keyInfo.Key}' is without mapping.");
                        break;
                }
            }
        }
    }
}

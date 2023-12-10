using System;

class Program 
{
    static void Main()
    {
        string[] salespersonNames = {"Danielle", "Edward", "Francis"};
        char[] allowedInitials = {'D', 'E', 'F'};
        double[] salesValues = {0, 0, 0};
        double grandTotal = 0;
        int highestSalespersonIndex = 0;

        char input;
        double saleAmount;

        do
        {
            Console.Write("Enter salesperson initial (D, E, or F) or Z to exit: ");
            input = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (input == 'E' || input == 'D' || input== 'F')
            {
                Console.Write("Enter sale amount: ");
                if (Double.TryParse(Console.ReadLine(), out saleAmount))
                {
                    int index = Array.IndexOf(allowedInitials, input);
                    if (index != -1)
                    {
                        salesValues[index] += saleAmount;
                        grandTotal += saleAmount;
                    }
                    else
                    {
                        Console.WriteLine("Invalid initial. Please enter D, E, or F.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid sale amount. Please enter a valid number.");
                }
            }
        } while (input != 'Z');

        Console.WriteLine("Salesperson totals:");
        for (int i = 0; i < salespersonNames.Length; i++)
        {
            Console.WriteLine($"{salespersonNames[i]}: {salesValues[i]:C}");
            if (salesValues[i] > salesValues[highestSalespersonIndex])
            {
                highestSalespersonIndex = i;
            }
        }

        Console.WriteLine($"Grand total: {grandTotal:C}");
        Console.WriteLine($"Salesperson with the highest total: {salespersonNames[highestSalespersonIndex]}");
    }
}

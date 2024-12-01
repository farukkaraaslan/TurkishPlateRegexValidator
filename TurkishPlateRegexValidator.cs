using System;
using System.Text.RegularExpressions;

while (true) // Sonsuz döngü
{
    Console.WriteLine("Please enter a plate number (type 'exit' to quit):");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        Console.WriteLine("Terminating the application...");
        break;
    }
    else if (ValidatePlate(input))
    {
        Console.WriteLine("Plate is valid.\n");
    }
    else
    {
        Console.WriteLine("Plate is invalid.\n");
    }
}

static bool ValidatePlate(string plate)
{
    string pattern = @"^(0[1-9]|[1-7][0-9]|8[01])\s((?:[A-Z]\s\d{4,5})|(?:[A-Z]{2}\s\d{3,4})|(?:[A-Z]{3}\s\d{2,3}))$";
    return Regex.IsMatch(plate, pattern);
}

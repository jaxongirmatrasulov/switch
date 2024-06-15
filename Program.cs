using System;

string userInput;
do
{
    Console.WriteLine("Karra jadval");
    int number;
    string mun = Console.ReadLine();
    number = Convert.ToInt32(mun);
    while ( number > 1 && number < 10)
    {
        int multiplayer = 1;
        while (multiplayer <= 9)
        {
            Console.Write($"{number} x {multiplayer} = {multiplayer * number}; ");
            multiplayer++;
        }

        Console.WriteLine("number: " + number);
        number++;

    }
    Console.WriteLine("Do you want continue? (y -> n)");
    userInput = Console.ReadLine();
}
while (userInput == "y");


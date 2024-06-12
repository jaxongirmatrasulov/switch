using System;

string userName ; 
Console.Write("Amalni tanlang:");
userName = Console.ReadLine();

switch(userName)
{
    case "Arifmetik":
    {
        int firstNum = 15 ;
        int secondNum = 20 ;
        int qoshish = firstNum + secondNum ;

        Console.WriteLine("Natija: " + qoshish);
        break;
    }

    case "Geometrik":
    {
        decimal pi = 3.14m ;
        int radius = 2 ;
        decimal yuza = pi * radius*radius ;

        Console.WriteLine("Natija: " + yuza);
        break;
    }

}    
    
    

using System;

// string userName ; 
// Console.Write("Amalni tanlang:");
// userName = Console.ReadLine();

// switch(userName)
// {
//     case "Arifmetik":
//     {
//         int firstNum = 15 ;
//         int secondNum = 20 ;
//         int qoshish = firstNum + secondNum ;

//         Console.WriteLine("Natija: " + qoshish);
//         break;
//     }

//     case "Geometrik":
//     {
//         decimal pi = 3.14m ;
//         int radius = 2 ;
//         decimal yuza = pi * radius*radius ;

//         Console.WriteLine("Natija: " + yuza);
//         break;
//     }

// }    


// ternary operator

// Console.WriteLine("Malumot kiriting.");
// Console.Write("Age: ");
// string inputAge = Console.ReadLine();
// int Age = Convert.ToInt32(inputAge);
// bool idAge = Age >= 16;

// string message = idAge 
//     ? "Siz Id karta olishingiz mumkin."
//     : "Siz hali yoshsiz.";
// Console.WriteLine(message);


// pattern matching.

string userName = Console.ReadLine();
string messages = userName switch 
{
    "Elbek" => "You are teacher.",
    "Jahongir" => "You are student.",
    _ => "default holati"
};
Console.WriteLine(messages);
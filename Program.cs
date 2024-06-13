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

// string userName = Console.ReadLine();
// string messages = userName switch 
// {
//     "Elbek" => "You are teacher.",
//     "Jahongir" => "You are student.",
//     _ => "default holati"
// };
// Console.WriteLine(messages);

//HAFTA KUNLARI.

// string days ;
// Console.Write("Kiriting: ");
// days = Console.ReadLine();


// switch(days)
// {
//     case "1":
//     {
//         Console.WriteLine("Dushanba");
//         break;
//     }
//     case "2":
//     {
//         Console.WriteLine("Seshanba");
//         break;
//     }
//     case "3":
//     {
//         Console.WriteLine("Chorshanba");
//         break;
//     }
//     case "4":
//     {
//         Console.WriteLine("Payshanba");
//         break;
//     }
//     case "5":
//     {
//         Console.WriteLine("Juma");
//         break;
//     }
//     case "6":
//     {
//         Console.WriteLine("Shanba");
//         break;
//     }
//     case "7":
//     {
//         Console.WriteLine("Yakshanba");
//         break;
//     }
//     default:
//         Console.WriteLine("xato");
//         break;
    
// }

for (int i=0; i<5; i++){
    Console.WriteLine("ha");
}

string[] cars = {"bmw", "gm", "toyota", "mers", "honda"};
cars[1] = "ferrari";
Console.WriteLine(cars[1]);
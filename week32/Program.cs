﻿//Odd or even 

int a = 11;

int result = a % 2;

//if (result == 0)
//{
//    Console.WriteLine($"{a} is an even number");
//}
//else
//{
//    Console.WriteLine($"{a} is an odd number");
//}

switch (result)
{
    case 0:
        {
            Console.WriteLine($"{a} is an even number");
            break;
        }
    case 1:
        {
            Console.WriteLine($"{a} is an odd number");
            break;
        }
    default:
        {
            Console.WriteLine("ERROR");
            break;
        }
}

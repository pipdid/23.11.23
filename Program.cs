////2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        string userInput = Console.ReadLine();


//        if (int.TryParse(userInput, out int number))
//        {

//            if (number % 3 == 0)
//            {
//                Console.WriteLine("Число делится на 3.");
//            }
//            else
//            {
//                Console.WriteLine("Число не делится на 3.");
//            }
//        }


//        Console.ReadLine();
//    }
//}

//// 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        string userInput = Console.ReadLine();


//        if (int.TryParse(userInput, out int number))
//        {

//            if (number % 5 == 2 || number % 7 == 1)
//            {
//                Console.WriteLine("Число удовлетворяет критериям.");
//            }
//            else
//            {
//                Console.WriteLine("Число не удовлетворяет критериям.");
//            }
//        }


//        Console.ReadLine();
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        string userInput = Console.ReadLine();


//        if (int.TryParse(userInput, out int number))
//        {

//            if (number % 4 == 0 && number >= 10)
//            {
//                Console.WriteLine("Число удовлетворяет критериям.");
//            }
//            else
//            {
//                Console.WriteLine("Число не удовлетворяет критериям.");
//            }
//        }




//        Console.ReadLine();
//    }
//}

//5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        string userInput = Console.ReadLine();


//        if (int.TryParse(userInput, out int number))
//        {

//            if (number >= 5 && number <= 10)
//            {
//                Console.WriteLine("Число  попадает в диапозон от 5 до 10.");
//            }
//            else
//            {
//                Console.WriteLine("Число не попадает в диапозон от 5 до 10.");
//            }
//        }



//        Console.ReadLine();
//    }
//}


////////////////number6
//using System.Globalization;
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        string userInput = Console.ReadLine();


//        if (int.TryParse(userInput, out int number))
//        {

//            if (Math.Abs(number) >= 1000)
//            {

//                int fourthDigit = (Math.Abs(number) / 1000) % 10;

//                Console.WriteLine($"В четвертой цифре справа {fourthDigit} тысяч.");
//            }
//            else
//            {
//                Console.WriteLine("Число  не состоит из четырех или более цифр.");
//            }
//        }


//        Console.ReadLine();
//    }
//}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string userInput = Console.ReadLine();


        if (int.TryParse(userInput, out int number))
        {

            string octalRepresentation = Convert.ToString(number, 8);


            if (octalRepresentation.Length >= 2)
            {
                char secondDigit = octalRepresentation[octalRepresentation.Length - 2];

                Console.WriteLine($"Вторая справа цифра в восьмеричном представлении: {secondDigit}");
            }
            else
            {
                Console.WriteLine($"Число  не имеет двух цифр в восьмеричном представлении.");
            }
        }



        Console.ReadLine();
    }
}


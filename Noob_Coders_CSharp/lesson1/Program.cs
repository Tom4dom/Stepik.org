// int - хранит целое число, все целочисленные литералы по умолчанию представляют значения типа int
// double - хранит число с плавающей точкой и занимает 8 байт
// short - хранит целое число от -32768 до 32767 и занимает 2 байта
// long - хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
// float - хранит число с плавающей точкой и занимает 4 байта
// byte - хранит целое число от 0 до 255 и занимает 1 байт
// bool - хранит значение true или false (логические литералы)
// string - хранит набор символов Unicode, этому типу соответствуют строковые литералы
// char - хранит одиночный символ в кодировке Unicode и занимает 2 байта
// decimal - хранит десятичное дробное число
// и другие


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//        bool isTwo = 100 / 50 == 2;

//        Console.WriteLine($"Actual variable value: {isTwo}");
//        Console.Read()
//     }
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//        int a = 5;
//        int b = 2;
//        int c = a++ / b;                   //++ as prefix has a priority ++ as postfix has no priority.

//        Console.WriteLine($"{a} / {b} = {c}");
//     }
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int number = -2147483648;
//         number = number +2147483647;

//         Console.WriteLine(number);
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         long number = -2_147_483_647;
//         number = number -100_000_000_001;

//         Console.WriteLine(number);
//     }
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         double decimalValue = (double) 5/2;

//         Console.WriteLine(decimalValue);
//     }
// }




// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string hello = "Hello,";
//         string world = " World!";
//         string result = hello + world;

//         Console.WriteLine(result);
//     }
// }





// class Program
// {
//     static void Main(string[] args)
//     {
//         string item = "Flashlight";
//         string item1 = "Candle";


//         Console.WriteLine("You found {0}. Do you wanna take it? {1}", item, item1);
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//        char letter = 'a';
//        letter++;
//        letter++;

//         Console.WriteLine(letter);
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//        var stringName = "Tom";
//        var intCounter = 1;
//        var doubleName = 1.5;

//         Console.WriteLine(letter);
//     }
// }




// class Program
// {
//     static void Main(string[] args)
//     {
//         int a = 5;
//         int b = 2;
//         Console.WriteLine(a + b);
//         Console.WriteLine(a - b);
//         Console.WriteLine(a*b);
//         Console.WriteLine(a/b);
//         Console.WriteLine(a % b);

//     }
// }




// class Program
// {
//     static void Main(string[] args)
//     {
//         double a = 5;
//         double b = 2;
//         Console.WriteLine(a + b);
//         Console.WriteLine(a - b);
//         Console.WriteLine(a * b);
//         Console.WriteLine(a / b);
//         Console.WriteLine(a % b);

//     }
// }





class Program
{
    static void Main(string[] args)
    {
        int a = 0;

        a += 5;
        Console.WriteLine(a);
        a--;
        Console.WriteLine(a);
        a *= 2;
        Console.WriteLine(a);
        a /= 2;
        Console.WriteLine(a);
        a %= 2;
        Console.WriteLine(a);

    }
}
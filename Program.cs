// Задача 19. Напишите программу,которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите пятизначное число:");
//         int number = Convert.ToInt32(Console.ReadLine());

//         // Разбиваем число на цифры и сохраняем их в массив
//         int[] digits = new int[5];
//         int temp = number;

//         for (int i = digits.Length - 1; i >= 0; i--)
//         {
//             digits[i] = temp % 10;
//             temp /= 10;
//         }

//         // Проверяем, является ли число палиндромом
//         bool isPalindrome = (digits[0] == digits[4]) && (digits[1] == digits[3]);

//         if (isPalindrome)
//         {
//             Console.WriteLine("Да, это палиндром.");
//         }
//         else
//         {
//             Console.WriteLine("Нет, это не палиндром.");
//         }



// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


//  Console.WriteLine("Введите координаты точки A (x, y, z):");
//         double x1 = Convert.ToDouble(Console.ReadLine());
//         double y1 = Convert.ToDouble(Console.ReadLine());
//         double z1 = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Введите координаты точки B (x, y, z):");
//         double x2 = Convert.ToDouble(Console.ReadLine());
//         double y2 = Convert.ToDouble(Console.ReadLine());
//         double z2 = Convert.ToDouble(Console.ReadLine());

//         // Вычисление расстояния между двумя точками
//         double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

//         Console.WriteLine("Расстояние между точками A и B: " + distance.ToString("F2"));


// Задача 23. Напишите программу , которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//   Console.WriteLine("Введите число N:");
//         int N = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");

//         for (int i = 1; i <= N; i++)
//         {
//             int cube = i * i * i;
//             Console.Write(cube + " ");
//         }
    
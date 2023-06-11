// Задача 19
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите пятизначное число: ");
//         int number = int.Parse(Console.ReadLine());

//         int digit1 = number / 10000; // первая цифра
//         int digit2 = (number / 1000) % 10; // вторая цифра
//         int digit3 = (number / 100) % 10; // третья цифра
//         int digit4 = (number / 10) % 10; // четвертая цифра
//         int digit5 = number % 10; // пятая цифра

//         if (digit1 == digit5 && digit2 == digit4)
//         {
//             Console.WriteLine("Это палиндром!");
//         }
//         else
//         {
//             Console.WriteLine("Это не палиндром :(");
//         }
//     }
// }

// Задача 21 

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Ввод координат точек
//         Console.WriteLine("Введите координаты точки A через пробел (x y z):");
//         string[] aCoords = Console.ReadLine().Split(' ');
//         Console.WriteLine("Введите координаты точки B через пробел (x y z):");
//         string[] bCoords = Console.ReadLine().Split(' ');

//         // Конвертация значений в числа
//         double aX = double.Parse(aCoords[0]);
//         double aY = double.Parse(aCoords[1]);
//         double aZ = double.Parse(aCoords[2]);
//         double bX = double.Parse(bCoords[0]);
//         double bY = double.Parse(bCoords[1]);
//         double bZ = double.Parse(bCoords[2]);

//         // Вычисление расстояния между точками
//         double distance = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2));

//         // Вывод расстояния на экран с округлением
//         Console.WriteLine($"Расстояние между точками A({aX},{aY},{aZ}) и B({bX},{bY},{bZ}): {distance:F2}");
//     }
// }

// Убил на задачу около 7 часов, но я это сделал!:_-)

// Задача 23...

// using System;
// class Program {
//     static void Main(string[] args) {
//         Console.Write("Введите число: ");
//         int n = int.Parse(Console.ReadLine());

//         for (int i = 1; i <= n; i++) {
//             Console.WriteLine("{0} -> {1}", i, i * i * i);
//         }
//     }
// }

// Господь всемогущий сколько же вы тратите на эти задачи времени?! Вы просто боги если решаете это быстрее 30 минут xD
// P.s надеюсь такие около весёлые коменты приподнимут Вам настроение).
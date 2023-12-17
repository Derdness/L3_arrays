/*
Задача 2: Задайте массив на 10 целых чисел.
Напишите программу, которая определяет количество чётных чисел в массиве.

*/
using System.Dynamic;

int[] array = new int[10];  //Инициализируем массив из 10 целых чисел.
Random rng = new Random();
for(int i=0;i<10;i++)       //Заполняем массив случайными целыми числами
{                           //в диапазоне [1, 100]
    array[i] = rng.Next(1,101);
    if(i != 0) Console.Write(", "); //Запятая перед каждым элементом кроме первого
    if(array[i] % 2 == 0)
        Console.ForegroundColor = ConsoleColor.Green;//Подсвечиваем чётные элементы
    Console.Write(array[i]);//Выводим сгенерированный массив
    Console.ResetColor();
}
Console.WriteLine();
int count = 0;              //Количество чётных чисел
for(int i=0;i<array.Length;i++)
{
    if(array[i] % 2 == 0)
        count++;
}
Console.WriteLine(count);   //Выводим ответ
/*
Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
*/
using System.Dynamic;

int[] array = new int[10];  //Инициализируем массив из 10 целых чисел.
Random rng = new Random();
for(int i=0;i<10;i++)       //Заполняем массив случайными целыми числами
{                           //в диапазоне [1, 100]
    array[i] = rng.Next(1,101);
    if(i != 0) Console.Write(", "); //Запятая перед каждым элементом кроме первого
    if(array[i] >= 20 && array[i] <= 90)
        Console.ForegroundColor = ConsoleColor.Green;//Подсвечиваем элементы удовлетворяющие условию
    Console.Write(array[i]);//Выводим сгенерированный массив
    Console.ResetColor();
}
Console.WriteLine();
int count = 0;              //Количество чисел в заданном диапазоне
for(int i=0;i<array.Length;i++)
{
    if(array[i] >= 20 && array[i] <= 90)
        count++;
}
Console.WriteLine(count);   //Выводим ответ
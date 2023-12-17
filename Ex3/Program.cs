/*
Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
Найдите разницу между максимальным и минимальным элементов массива.
*/

using System.Reflection;

double[] array = new double[10];  //Инициализируем массив из 10 вещественных чисел.
double notZero = 0;
double max = 0;
double min = 0;
Random rng = new Random();
bool newline = true;                //Флаг для форматирования вывода
for(int i=0;i<array.Length;i++)       //Заполняем массив случайными целыми числами
{                                     //в диапазоне [-100, 100]
    while(notZero == 0) notZero = rng.NextDouble();//Если сгенерировался 0, то повторить
    array[i] = rng.Next(-100,101) + notZero;//Число из целой и дробной части
    notZero = 0;             //Сброс
    if(min > array[i]) min = array[i];//Ищем значение максимального элемента
    if(max < array[i]) max = array[i];//Ищем значение минимального элемента
}
for(int i=0;i<array.Length;i++)//Выводим сгенерированный массив
{
    if(!newline) 
    {   
        Console.Write(", "); //Запятая перед каждым элементом кроме первого
    }
    if(array[i] == max)
        Console.ForegroundColor = ConsoleColor.Green;//Подсвечиваем максимальный элемент
    if(array[i] == min)
        Console.ForegroundColor = ConsoleColor.Blue;//Подсвечиваем минимальный элемент
    Console.Write(array[i]);
    newline = false;
    Console.ResetColor();
    if(i % 5 == 5-1 && i != 0) {
        Console.WriteLine();//Переносим строку каждые 5 значений
        newline = true;
    }
}
Console.WriteLine();
Console.WriteLine(max - min);   //Выводим ответ
﻿/*
Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
Создайте массив, состоящий из цифр этого числа.
Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
Размер массива должен быть равен количеству цифр.
*/

Random rng = new Random();
int natNumber = rng.Next(1,100001); //Cлучайное натуральное число согласно условия
Console.WriteLine(natNumber);
int len = 1;
int temp = natNumber;
while(temp / 10 != 0) //Определяем длину числа
{
    len++;
    temp = temp / 10;
}
int[] array = new int[len];  //Инициализируем массив из 10 вещественных чисел
temp = natNumber;
for(int i=array.Length-1;i>=0;i--) //Заполняем массив цифрами числа
{
    array[i] = temp % 10;
    temp = temp / 10;
}

for(int i=0;i<array.Length;i++)//Выводим полученный массив
{
    if(i != 0) Console.Write(", "); //Запятая перед первым элементом не нужна
    Console.Write(array[i]);
}
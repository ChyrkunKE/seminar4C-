﻿
// Принимает число 
// выдает количество цифр в числе


int DigitCount(int num)
{
    int count = 0;
    if (num==0) return 1; 
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = DigitCount (number);
Console.Write($"Число {number} состоит из {result} знаков");

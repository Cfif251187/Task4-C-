/*// Задача 25. Программа принимает два числа (А,В) и возводит число А в натуральную степень В.
int degree(int numberA, int numberB)
{
    int degree = 1;
    for (int i = 0; i < numberB; i++)
    {
       degree *= numberA;
    }
    return degree;
}
Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{degree(numberA,numberB)}");*/



/*// Задача № 27. Программа принимает число и выдает сумму цифр в числе.

int Sum(int number);
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в числе {number} = {Sum(number)}");*/


// Задача 29. Программа задает массив из m  элементов, генерируемый пользователем.
 int[] CreatArray(int size)
{
    int[] array = new int[size];
    int i=0;
    while(i < array.Length)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        array[i] = m;
        i++;
    }
    return array;

}
void ShowArray(int[] array)
{
    for(int i= 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatArray(a);
ShowArray(myArray);

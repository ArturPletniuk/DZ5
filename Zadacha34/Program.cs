// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] CreateArrayRndInt(int size,int min,int max)
{
    int[] array = new int[size];
    Random RandomNumber = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = RandomNumber.Next(min, max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int AnEvenNumber(int[] array)
{
    int numberOfEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int remains = array[i] % 2;
        if (remains == 0) numberOfEvenNumbers += 1;
    }
    return numberOfEvenNumbers;
}
Console.Write("Введите количество элементов в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
int[] createArray = CreateArrayRndInt(number,100,1000);
PrintArray(createArray);
int evenNumber = AnEvenNumber(createArray);
Console.Write($"Количество чётных чисел в массиве = {evenNumber}");
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
int SumElements(int[] list)
{
    int index = 0;
    int sum = 0;
    while (index != list.Length)
    {
        int c = index % 2;
        if (c == 1)  sum += list[index];
        index += 1;
    }
    return sum;
}
Console.Write("Введите длину массива:");
int number = Convert.ToInt32(Console.ReadLine());
int[] createArray = CreateArrayRndInt(number,-45,100); // так как диапазон не назван по условию я выбрал от -45 до 99
PrintArray(createArray);
int evenNumber = SumElements(createArray);
Console.Write($"Сумма элементов, стоящих на нечётных позициях = {evenNumber}");
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] array = new double[size];
    Random RandomNumber = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = RandomNumber.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
double SumArrayMaxMin(double[] list)
{
    double indmax = list[0];
    double indmin = list[0];
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] > indmax) indmax = list[i];
        if (list[i] < indmin) indmin = list[i];
    }
    double differenceMaxMin = indmax - indmin;
    return differenceMaxMin;
}
Console.Write("Введите количество элементов в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
double[] createArray = CreateArrayRndDouble(number, 10, 99); 
PrintArray(createArray);
double donbleArray = SumArrayMaxMin(createArray);
Console.WriteLine(Math.Round(donbleArray, 1));
Console.Write("Exit.");
Console.ReadLine();

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void InputArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10001);
        for (int i = 0; i < array.Length; i++)
                array[i] = Convert.ToDouble(array[i]/100);
}

double Maximum(double [] array)
{
    double max = 0;
    for (int j = 0; j < array.Length; j++)
        if (array[j] > max)
            max = array[j];
    return max;
}


double Minimum(double [] array)
{
    double min = array[0];
    for (int g = 0; g < array.Length; g++)
        if (array[g] < min)
            min = array[g];
    return min;
}

double ReleaseArray(double[] array)
{
    double r = Maximum(array) - Minimum(array);
    return r;
}


Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"max = {Maximum(array)}");
Console.WriteLine($"min = {Minimum(array)}");
Console.WriteLine($"Разница между max и min: {ReleaseArray(array)}");
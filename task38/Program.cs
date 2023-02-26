//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным 
// элементов массива.
//[3 7 22 2 78] -> 76

int[] array = GetRandomArray(5, -2, 12);
Console.WriteLine(String.Join(", ", array));

int max = array[0];
int min = array[0];
for(int i = 0 ; i<array.Length ; i++)
{
if(array[i] > max)
   max = array[i];
else
  if(array[i] < min) min = array[i];
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int difference = max - min;

Console.WriteLine($"Разница между {max} и {min} = {difference}");
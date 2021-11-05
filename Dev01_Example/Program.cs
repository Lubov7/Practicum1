// Задача
// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
// Создать на его основе масив B, отбрасывая те, которые

// 1. нарушают порядок возрастания
// 2. больше среднего арифметического элементов A
// 3. чётные



// Задать массив 
int[] array = new int[10];

int index = 0;

// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100);
    index++;
}

index = 0;
// Печатаем массив
while (index <=9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
Console.WriteLine("\nЧисла в массиве, соблюдающие порядок возрастания:");
index = 1;
// Исключение элементов которые нарушают порядок возрастания
int currentElement = array[0];
Console.WriteLine(currentElement);
while(index <= 9)
{
    if(array[index] > currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement=array[index];
    }
    index++;
}

// Выводит числа, которые меньше среднего арифмитического элементов массива
Console.WriteLine("\nСумма элементов массива:"); // Пустая строка
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
     sum += array[i]; // Сумма элементов в массиве
}
Console.WriteLine(sum);
int average = sum/array.Length; // Среднее арифметическое элементов массива
Console.WriteLine("Среднее арифметическое элементов массива\n" + average);
Console.WriteLine("Числа, которые меньше среднего арифмитического элементов массива:");
index = 0;
while (index < array.Length)
{
     if (array[index] < average)
     {
          Console.WriteLine(array[index]);
     }
     index++;
}

// Вывести нечетные элементы массива
Console.WriteLine("\nНечётные элементы массива:"); // Пустая строка
index = 0;
while (index < array.Length)
{
     if (array[index] % 2 != 0 )
     {
         Console.WriteLine(array[index]);
     }
     index++;
}
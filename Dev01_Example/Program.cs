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
Console.WriteLine("Числа в массиве, соблюдающие порядок возрастания:");
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
Console.WriteLine("Сумма элементов массива:");
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
     sum += array[i]; // Сумма элементов в массиве
}
Console.WriteLine(sum);
int average = sum/array.Length; // Среднее арифметическое элементов массива
Console.WriteLine("Среднее арифметическое элементов массива");
Console.WriteLine(average);
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
Console.WriteLine("Нечётные элементы массива:"); // Пустая строка
index = 0;
while (index < array.Length)
{
     if (array[index] % 2 != 0 )
     {
         Console.WriteLine(array[index]);
     }
     index++;
}
//   Посчитать сумму всех элементов массива. Для этого до цикла вводится переменная для суммы (например, sum). 
// Далее в цикле перебираются элементы массива и значение каждого добавляется к этой переменной. 
// Подсчет суммы можно выполнить в том же цикле, что и заполнение массива.
// Когда сумма элементов посчитана, находится среднее арифметическое, которое равно сумме разделенной на количество элементов массива.
// Массив перебирается в цикле, каждый элемент сравнивается с найденным средним значением. 
// Если элемент меньше, то он выводится на экран (или сохраняется в другом массиве).
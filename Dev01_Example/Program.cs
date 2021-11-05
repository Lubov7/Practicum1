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


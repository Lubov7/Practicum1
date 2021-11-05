// Задача
// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок:

// 1. возрастания
// 2. элементы, больше 8
// 3. знакочередования


// Задать массив
int minValue = 1;
int maxValue = 12;

int[] array = new int [10];

int index =0;
// Заполняем массив 
while(index < 10)
{
    array[index] = new Random().Next(minValue,maxValue);
    index++;
}

index = 0;
//Печатаем массив
while(index <=9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}
Console.WriteLine("Числа в массиве по возрастанию:");



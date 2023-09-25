// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Write("Введите размер массива: ");
int count=int.Parse(Console.ReadLine());
string[] array1 = new string[count];
for(int i=0; i<count; i++)
{
    array1[i] = Console.ReadLine();
}
Console.WriteLine("[" + String.Join(", ", array1) + "]");
int size=0;
for(int i=0; i<count; i++)
{
    if(array1[i].Length<=3)
    {
        size++;
    }
}
string[] array2 = new string[size];
int index=0;
for(int i=0; i<count; i++)
{
    if(array1[i].Length<=3)
    {
        array2[index]=array1[i];
        index++;
    }
}
Console.WriteLine("[" + String.Join(", ", array2) + "]");
int[] mas = new int[10];
Console.WriteLine("Введите десять чисел: ");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = int.Parse(Console.ReadLine());
}

// сортировка
int temp;
for (int i = 0; i < mas.Length - 1; i++)
{
    for (int j = i + 1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
        {
            temp = mas[i];
            mas[i] = mas[j];
            mas[j] = temp;
        }
    }
}
Console.WriteLine("Отсортированный массив: ");
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]+" ");
}
Console.WriteLine("Введите элемент: ");
int element = int.Parse(Console.ReadLine());

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] == element) 
        Console.WriteLine("Индекс элемента: "+(i + 1));
}
Console.WriteLine("Ошибка");
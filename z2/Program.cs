void FillArray(int[,] coord)
{
    int length = coord.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите координату x[{i}]: ");
        coord[i, 0] = int.Parse(Console.ReadLine() ?? "0");
        Console.Write($"Введите координату y[{i}]: ");
        coord[i, 1] = int.Parse(Console.ReadLine() ?? "0");
    }
}
void PrintArray(int[,] printCoord, int k)
{
    int size = printCoord.GetLength(0);
    for (int j = 0; j < size; j++)
    {
        Console.Write($"({printCoord[j, 0] * k};{printCoord[j, 1] * k}) ");
    }
}

Console.Write("Укажите количество вершин в фигуре: ");
int apic = int.Parse(Console.ReadLine() ?? "0");
int[,] coordXY = new int[apic, 2];
FillArray(coordXY);
Console.Write("Координаты вершин: ");

int k = 1;
PrintArray(coordXY, k);
Console.WriteLine();
Console.Write("Введите коэффициент увеличени фигуры: ");
k = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Координаты вершин после увеличения: ");
PrintArray(coordXY, k);


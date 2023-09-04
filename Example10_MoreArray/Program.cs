int [] array = {16,22,33,42,15,68,97,81};
int n = array.Length;
Console.Write("Введите число для поиска: ");
int find = int.Parse(Console.ReadLine()!);
int index=0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
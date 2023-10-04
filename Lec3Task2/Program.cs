// Сортировка массива

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int [] array)
{
    int count = array.Length;

    for(int i =0 ; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelestionSort(int[] array)
{
     for(int i =0 ; i<array.Length; i++)
     {
        int minPosition = i;
         for(int i =0 ; i<array.Length; i++)
         {
            //Лекция 3 , 35:24
         }
        int temporary = array [i];
        array [i] = array [minPosition];
        array [minPosition] = temporary;
     }
}

PrintArray(arr);
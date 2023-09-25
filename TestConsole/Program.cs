using TestConsole;

static void SummIdSort(int[,] array)
{
    SummId[] summId = new SummId[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summId[i] = new SummId();
        summId[i].id = i;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summId[i].summ += array[i, j];
        }
    }

    foreach (var item in summId)
    {
        Console.WriteLine($"{item.id} {item.summ}");
    }

    for (int i = 0; i < summId.Length; i++)
    {
        for (int j = 0; j < summId.Length - 1 - i; j++)
        {
            int buf1 = 0;
            int buf2 = 0;
            if(summId[j].summ > summId[j + 1].summ)
            {
                buf1 = summId[j+1].summ;
                buf2 = summId[j+1].id;
                summId[j + 1].id = summId[j].id;
                summId[j + 1].summ = summId[j].summ;
                summId[j].id = buf2;
                summId[j].summ = buf1;
            }

        }
    }
    Console.WriteLine();
    foreach (var item in summId)
    {
        Console.WriteLine($"{item.id} {item.summ}");
    }

}

int[,] arr = new int[10, 10];
for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(10, 100);
    }

SummIdSort(arr);



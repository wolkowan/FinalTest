

string[] GetArray()
{
    Console.WriteLine("Введите массив строк через пробел");
            
    string[] original = Console.ReadLine().Split(' ');
    string[] result = new string[original.Length];
    
    int i = 0;
    foreach (string value in original)
        {
            if (value.Length <= 3)
            {
                result[i] = value;
                i++;
            }
        }
    return result;
}

void PrintArray(string[] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {
                System.Console.Write($"{array[i]} ");
            }  
    }

PrintArray(GetArray());
          


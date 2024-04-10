// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Print(int [] arr, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(arr[n] + " "); 
      	Print(arr, n - 1); 
      } 
      else 
        Console.WriteLine(arr[0]); 
    }
    
      int [] num = {1, 2, 5, 0, 10, 34}; 
      Print(num, 5);

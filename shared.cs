
public class shared
{

//Ввод данных
public static int Input( string text)
{Console.WriteLine(text + " ");
 return Convert.ToInt32(Console.ReadLine());
 
}


//Создание массива
public static string [] CreateArray(int sizex)
{return new string[sizex];
}


//заполнение данных
public static void FillBy(string?[] array)
{
    int lengthx = array.GetLength(0);
  for (int i = 0; i< lengthx; i++)
      { array[i] = Console.ReadLine() ;
      }
        
}

//печать
public static void PrintArray(string[] array)
  {
    int lengthx = array.GetLength(0);
    Console.Write("[ ");
     for (int i = 0; i< lengthx; i++)
                { Console.Write(array[i] + " ");
                 }
    Console.Write("]");                 
    System.Console.WriteLine();

   
  }

//формирование нового массива
public static void MyFuncItog(string[] array)
  {
    int lengthx = array.GetLength(0);
    int n = 0;
    string[] stringfinish = CreateArray(lengthx);

     for (int i = 0; i< lengthx; i++)
          { if (array[i].Length <= 3 )
              {stringfinish[n] = array[i];
              n = n+1;
              }
         }
    Console.WriteLine("Результат : ");         
    PrintArray(stringfinish);
 
  }



  
}
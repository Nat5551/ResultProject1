using static shared;
Console.Clear();

int index = Input("Введите размерность первоначального массива: ");

string[] stringstart = CreateArray(index);

Console.WriteLine($"Введите элементы массива: ") ;
FillBy(stringstart);

Console.WriteLine();

Console.WriteLine("Первоначальный массив : ");
PrintArray(stringstart);
MyFuncItog(stringstart);

//Нужно указать желаемое количесвто элементов (N) и заполнить стартовый массив элементами в цикле введенное количесвто раз.
//Программа проходит по массиву в цикле и проверяет, подходит ли элемент условию "длина символов <= 3". 
//Если элемент подходит под данное условие, то мы добавляем его в новый массив,  используя при этом дополнительный счетчик, 
//чтобы элементы в новом массиве заполнялись последовательно (без пропусков).
Console.Write("Сколько будет жлементов? : ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
Console.WriteLine($"{i+1}-й элемент: ");
string element = Convert.ToString(Console.ReadLine());
arrayStrings[i] = element;
}
string[] arrayFinal = new string[size];
int len = 3;
int pos = 0;
for (int j = 0; j < size; j++)
{
if (arrayStrings[j].Length <= len)
{
arrayFinal[pos] = arrayStrings[j];
pos++;
}
}
Console.WriteLine();
PrintArray(arrayFinal);
void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
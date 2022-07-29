/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длинна которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры либо задать 
на старте выполнения алгоритма. */

string alpha = "symbols_and_words";
string[] array = new string[30];
string[] arrayres = new string[30];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    int wordLength = new Random().Next(1, 10);
    string word = alpha.Substring(0, wordLength);
    array[i] = word;
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arrayres[j] = array[i];
        j++;
    }
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(arrayres[i] + " ");
}



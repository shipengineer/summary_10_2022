//----------------------------------Exercise------------------------------
/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/
//----------------------------------SOLUTION-----------------------------------

string[] in_mas = { "DayOfWeek", "devor", "del", "mar", "sam", "prokm", "end" };

string[] SearchForThrdCharString(string[] in_mas)
{
    string[] out_mas = new string[1];
    int j = 0;
    for (int i = 0; i < in_mas.Length; i++)
    {
        if (in_mas[i].Length <= 3)
        {
            Array.Resize(ref out_mas, 1 + j);
            out_mas[j] = in_mas[i];
            j++;
        }
    }
    return out_mas;
}
System.Console.WriteLine(String.Join("|", SearchForThrdCharString(in_mas)));

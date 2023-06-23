// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
void Main()
{
    // string[] testStrArray = { "Hello", "2", "world", ":-)" };
    // string[] testStrArray = { "aaa", "bbbb", "cc", "ddddd", "123" };
    // string[] testStrArray = { "Russa", "Denmark", "Kazan", "Saint-Pereburg" };
    string[] testStrArray = { "aaa", "bbbb", "cc", "ddddd", "1234", "nothing", "Hye" };

    int icount = CountSatifactors(testStrArray);
    if (icount == 0)
    {
        System.Console.WriteLine("В исходном массиве НЕ НАЙДЕНО элементов, удовлетворяющих заданнному критерию");
        PrintStrArrayInColumn(testStrArray); // контрольная печать исходного массива
    }
    else
    {
        System.Console.WriteLine("Результат отбора элементов, удовлетворяющих заданнному критерию");
        string[] shortStr = SelectShortStrOutOfStrArray(testStrArray);
        PrintStrArrayInColumn(shortStr); // печать результата (массива с выбранными элементами)
    }
}
string[] SelectShortStrOutOfStrArray(string[] givenStrArray)
// создает новый массив строк с числом элементов, равным числу элементов исходного, удовлетворяющих условию,
// и заполняет новый массив отбранными значениями
{
    string[] resultStrArray = new string[CountSatifactors(givenStrArray)];
    int k = 0;
    for (int i = 0; i < givenStrArray.Length; i++)
        if (Criterion(givenStrArray[i])) { resultStrArray[k] = givenStrArray[i]; k++; };
    return resultStrArray;
}
int CountSatifactors(string[] StrArray)
// подсчитывает, сколько элементов массива удовлетворяют заданному критерию: 
{
    int kcount = 0;
    for (int i = 0; i < StrArray.Length; i++)
    {
        if (Criterion(StrArray[i])) { kcount++; }
    };
    return kcount;
}

Boolean Criterion(string txt) // возвращает результат проверки: удовлетворяет ли строка заданному условию
{                                 // текуее условие: длина строки меньше, либо равна 3 символам
    if (txt.Length <= 3) { return true; }
    else return false;
}
void PrintStrArrayInColumn(string[] strArray)
{
    for (int i = 0; i < strArray.Length; i++)
    {
        System.Console.WriteLine($"{i}: {strArray[i]}");
    }
    return;
}

Main();


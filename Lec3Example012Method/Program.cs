﻿//Вид 1, ничего не принимают и ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();

//Вид 2, что-то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Текст",count:4); //при использовании именнованых аргументов не обязательно писать их по порядку
//Вид 3, ничего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//Вид 4, что-то принимают и что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i<count)
//     {
//         result=result+text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = string.Empty;
    for(int i = 0; i<count; i++)
    {
        result=result+text;
    }
    return result;
}
string res = Method4(10,"asdf");
//Console.WriteLine(res);

for(int i = 2; i < 10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
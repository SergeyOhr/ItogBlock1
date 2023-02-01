using System;
using static System.Console;

Clear();

string[] inArray = InputArray();
string[] outArray = FindElement(inArray, 3);
WriteLine($"[{string.Join(", ", inArray)}] -> [{string.Join(", ", outArray)}]");

string[] FindElement(string[] inarray, int n)
{
    string[] outarray = new string[CountElement(inarray, n)];

    for (int i = 0, j = 0; i < inarray.Length; i++)
    {
        if (inarray[i].Length <= n)
        {
            outarray[j] = inarray[i];
            j = j + 1;
        }
    }

    return outarray;
}

int CountElement(string[] inarray, int n)
{
    int count = 0;

    for (int i = 0; i < inarray.Length; i++)
    {
        if (inarray[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

string[] InputArray()
{
    Write("Введите значения разделяя их пробелом: ");
    return ReadLine().Split(" ");
}


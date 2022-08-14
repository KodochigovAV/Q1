string Text(string message)
{
    System.Console.Write(message);
    return (System.Console.ReadLine());
}

int Count(string message)
{
    System.Console.Write(message);
    int n = int.Parse(System.Console.ReadLine());
    return n;
}

void Fill(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = Text($"Enter string # {i + 1} ->");
    }
}

void Print(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        System.Console.WriteLine(mass[i]);
    }
}

int ThreeSymCount(string[] mass)
{
    int i = 0;
    int j = 0;
    while (i < mass.Length)
    {
        if (mass[i].Length <= 3)
        {
            j = j + 1;
        }
        i = i + 1;
    }
    return j;
}

string[] ThreeOnly(string[] mass1, string[] mass2)
{
    int i = 0;
    int j = 0;
    while (i < mass1.Length)
    {
        if (mass1[i].Length <= 3)
        {
            mass2[j] = mass1[i];
            j = j + 1;
        }
        i = i + 1;
    }
    return mass2;
}

string[] arrayIn = new string[Count("Strings number -> ")];
Fill(arrayIn);
string[] arrayOut = new string[ThreeSymCount(arrayIn)];
System.Console.WriteLine("Control:");
Print(arrayIn);
ThreeOnly(arrayIn, arrayOut);
System.Console.WriteLine("Contains three or less symbols:");
Print(arrayOut);
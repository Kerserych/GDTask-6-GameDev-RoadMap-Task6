Console.WriteLine("Введите неприятное приложение");
Console.WriteLine(antitroll(Console.ReadLine()));

string antitroll(string troll)
{
    string nono = "аяуюоеёэиы";
    return rectroll(troll, nono);
}


string rectroll(string str, string nonono)
{
    for (int i = 0; i < str.Length; i++)
    {
        if ((nonono.Contains(str[i]) == true) | (nonono.ToUpper().Contains(str[i]) == true))
        {
            str = str.Replace($"{str[i]}", "");
            rectroll(str, nonono);
        }
    }
    return str;
}

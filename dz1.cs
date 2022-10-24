
using System.Text.RegularExpressions;
string str1;
str1 = Console.ReadLine();
Console.WriteLine("first word-" + str1.ToLower());


string str2;
str2 = Console.ReadLine();
Console.WriteLine("second word-" + str2.ToLower());
if (str1.Length != str2.Length)
{
    Console.WriteLine("error");
}

string res = "";
for (int i = 0; i < str1.Length; i++)
{
    for (int j = 0; j < str2.Length; j++)
    {
        if (str1[i] == str2[j])
        {
            res += str2[j];
            str2 = str2.Remove(j, 1);
        }
    }
}
if (res.Length == str1.Length)
    Console.WriteLine("Yes");
else Console.WriteLine("No");


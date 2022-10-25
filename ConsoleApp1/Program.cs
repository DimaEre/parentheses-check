using System;
using System.Collections.Specialized;

class Program
{
    static void Main()
    { 
        string text;
        Console.WriteLine("Enter text:  ");
        text = Console.ReadLine();
        int t = -1;
        int b = 0;
        bool h = false;
        int s1 = 0, s2 = 0;


        foreach (var item in text)
        {
            if (item == '(') s1++;
            else if (item == ')') s2++;
        }
        if (s1 != s2)
        {
            Console.WriteLine("Wrong");
            return;
        }



        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ')')
            {
                h = true;   
                b = t;
                for (int j = t; j < i; j++)
                {
                    if (j == t)
                    {

                    }
                    else if (text[j] == '(')
                    {
                        t = j;
                        break;
                    }
                }
                if (b == t)
                {
                    Console.WriteLine("Wrong");
                    return;
                }
            }
        }
        
        if(h == true)
            Console.WriteLine("Succesfull");
        else
            Console.WriteLine("Wrong");
    }
}

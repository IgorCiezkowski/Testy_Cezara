using System;

class Program
{
    public static string Szyfrowanie(string word, int klucz)
    {
        string output = "";
        string alfabet = "abcdefghijklmnopqrstuvwxyz";
        if (klucz > 26)
        {
            klucz = klucz % 26;
        }
        else if(klucz < 0)
        {
            klucz = (klucz % 26) + 26;
        }
        else if(klucz == 0)
        {
            return word;
        }

        for (int i = 0; i < word.Length; i++)
        {
            char litera = word[i];
            int index = alfabet.IndexOf(litera);
            if (index != -1)
            {
                int nowyIndex = (index + klucz) % 26;
                output += alfabet[nowyIndex];
            }
        }


        return output;
    }
    
    static void Main()
    {
        Console.WriteLine("Podaj słowo do zaszyfrowania: ");
        string input = Console.ReadLine();
        Console.WriteLine("Podaj klucz szyfrowania: ");
        int klucz = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Szyfrowanie(input, klucz));

    }
}
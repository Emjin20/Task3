using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите строку: ");
            s = Console.ReadLine();
            string s1 = s.ToLower();
            String[] words = s.Split(new char[] { ' ','.','!','?',':',',' }, StringSplitOptions.RemoveEmptyEntries);
            String[] wordsReserv = s1.Split(new char[] { ' ', '.', '!', '?', ':',',' }, StringSplitOptions.RemoveEmptyEntries);
            int checkend = Check(ref wordsReserv, ref words, s1, s);

        }
        static int Check(ref string[] wordsReserv, ref string[] words, string s1,string s)
        {
            int n = 0;
            int checkend = 0;
            for (int i = 0; i< wordsReserv.Length; i++ )
            {
                for (int j = wordsReserv.Length-1; j >= 0; j--)
                {
                    if ((wordsReserv[i] == wordsReserv[j])^(i == j))
                    {
                        n = 1;
                    }

                }
                if (n == 0)
                {
                    Console.WriteLine(words[i]);

                }
                n = 0;
            }
            return checkend;
        } 
    }
}

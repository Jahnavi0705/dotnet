using System;

namespace count_of_vowels_consonants
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vowel = 0, consonant = 0;
            string str;


            Console.WriteLine("Enter input: ");
            str = Console.ReadLine();
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] =='u')
                {
                    Vowel++;
                    

                }
                else if(str[i]>='a' && str[i]<='z')
                {
                    consonant++;
                    
                }
            }
            Console.WriteLine("Vowels count are: " + Vowel);
            Console.WriteLine("Consonants count are: " + consonant);



        }
    }
}

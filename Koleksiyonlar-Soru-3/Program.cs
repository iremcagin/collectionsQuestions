using System;

namespace collections3{
    class Program{
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>();
            Console.Write("Enter a sentence: ");
            string str = Console.ReadLine();

            for(int i=0; i<str.Length; ++i){
                if(str[i]=='a' | str[i]=='A' | str[i]=='e' | str[i]=='E' | str[i]=='i' | str[i]=='I' | str[i]=='o' | str[i]=='O' | str[i]=='U' | str[i]=='u')
                    if(vowels.Contains(str[i]) == false) vowels.Add(str[i]);
            }

            Console.Write("Vowels: ");
            for(int i=0; i<vowels.Count; ++i){
                Console.Write(vowels[i]+" ");
            }
        }
    }
}
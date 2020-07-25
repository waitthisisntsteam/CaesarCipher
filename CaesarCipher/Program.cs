using System;
using linkedLists;

namespace CaesarCipher
{
    class Program
    {
        static public string CaesarCypherEncrypt(int key, string phrase)
        {
            string[] EncyptedPhrase = new string[phrase.Length];
            for (int i = 0; i < phrase.Length; i++)
            {
                for (char currentLetter = 'a'; currentLetter <= 'z'; currentLetter++)
                {
                    if (phrase[i] == currentLetter)
                    {
                        //for (char finalLetter = currentLetter; finalLetter <= )
                        //EncyptedPhrase = currentLetter + key;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList<char>();

            for (char currentLetter = 'a'; currentLetter <= 'z'; currentLetter++)
            {
                list.AddNodeToLast(currentLetter);
            }

            Console.WriteLine("Enter a key for the Caesar Cypher.");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a phrase for the Caesar Cypher.");
            string phrase = Console.ReadLine();
        }
    }
}

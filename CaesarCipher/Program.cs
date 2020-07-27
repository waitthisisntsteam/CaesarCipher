using System;
using System.Text.RegularExpressions;
using linkedLists;

namespace CaesarCipher
{
    class Program
    {
        static public string CaesarCypherEncrypt(int key, string phrase)
        {
            char Encryptor = new DoublyLinkedList<char>();
            string EncryptedPhrase = "";
            char finalLetter = ' ';
            for (int i = 0; i < phrase.Length; i++)
            {
                for (char currentLetter = 'a'; currentLetter <= 'z'; currentLetter++)
                {
                    if (phrase[i] == ' ')
                    {
                        Encryptor.AddNodeToLast(' ');
                        break;
                    }
                    else if (phrase[i] == currentLetter)
                    {
                        finalLetter = currentLetter;
                        for (int j = 0; j < key; j++)
                        {
                            finalLetter++;
                        }
                        Encryptor.AddNodeToLast(finalLetter);
                    }
                }
            }
            var runner = Encryptor.Head;
            for (int i = 0; i < Encryptor.Count; i++)
            {
                EncryptedPhrase += runner;
                runner = runner.Next;
            }
            return EncryptedPhrase;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a key for the Caesar Cypher.");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a phrase for the Caesar Cypher.");
            string phrase = Console.ReadLine();
            Console.WriteLine(CaesarCypherEncrypt(key, phrase));
        }
    }
}

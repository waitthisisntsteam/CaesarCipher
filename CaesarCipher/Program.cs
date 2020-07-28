using System;
using System.Text.RegularExpressions;
using linkedLists;

namespace CaesarCipher
{
    class Program
    {
        static public string CaesarCypherEncrypt(int key, string phrase, string way)
        {
            var Encryptor = new DoublyLinkedList<char>();
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
                        if (way == "encrypt")
                        {
                            finalLetter = currentLetter;
                            for (int j = 0; j < key; j++)
                            {
                                finalLetter++;
                            }
                            Encryptor.AddNodeToLast(finalLetter);
                        }
                        else if (way == "decrypt")
                        {
                            finalLetter = currentLetter;
                            for (int j = 0; j < key; j++)
                            {
                                finalLetter--;
                            }
                            Encryptor.AddNodeToLast(finalLetter);
                        }
                    }
                }
            }
            var runner = Encryptor.Head;
            for (int i = 0; i < Encryptor.Count; i++)
            {
                EncryptedPhrase += runner.data;
                runner = runner.next;
            }
            return EncryptedPhrase;
        }
        static void Main(string[] args)
        {
            string answer = "";
            string phrase = "";
            int key = 0;
            while (true)
            {
                Console.WriteLine("Do you want to encrypt or decrypt?");
                answer = Console.ReadLine().ToLower();
                if (answer == "encrypt" || answer == "decrypt")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Check your spelling errors.");
                }
            }
            Console.WriteLine("Enter a phrase for the Caesar Cypher.");
            phrase = Console.ReadLine();  
            Console.WriteLine("Enter a key for the Caesar Cypher.");
            key = int.Parse(Console.ReadLine());                      
            Console.WriteLine(CaesarCypherEncrypt(key, phrase, answer));
        }
    }
}

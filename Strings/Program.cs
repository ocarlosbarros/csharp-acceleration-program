﻿namespace Strings;
public class Program
{
    public static void Main(string[] args)
    {
        /*
            Methods used with the String class 
            */

        //Concat()
        string textOne = "Você está aprendendo sobre ";
        string textTwo = "Strings em C# ";
        string textThree = "e agora sabe concatenar textos utilizando o método Concat";

        string concatResult = string.Concat(textOne, textTwo, textThree);

        Console.WriteLine(concatResult);

        //Split()
        string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com";
        string[] emailList = emails.Split(";");
        
        foreach(var email in emailList)
        {
            Console.WriteLine(email);
        }

        //IndexOf
        string marvel = "Marvel";
        int index = marvel.IndexOf("v");
        Console.WriteLine(index);//3

        int indexNotFound = marvel.IndexOf("s");
        Console.WriteLine(indexNotFound);//-1

        string avengersMovie = "Hulk smashing Loki";
        int startOfIndex = avengersMovie.IndexOf("k", 13);//search start in Loki
        Console.WriteLine(startOfIndex);//16

        //Contains
        List<string> languages = new List<string>
        {
            "C#",
            "java",
            "javascript",
            "python"
        };
        Console.WriteLine("Escreva o tipo de linguagem que deseja buscar:");
        string? languageSearch = Console.ReadLine();
        
        var languageChoose = languageSearch ?? throw new ArgumentNullException("Linguagem obrigatória para pesquisa", languageSearch);

        bool languageExists = languageChoose.Contains(languageChoose);
        Console.WriteLine(languageExists);

        //Join
        IEnumerable<int> listNumbers = Enumerable.Range(1, 10);
        string numbersText = string.Join(',', listNumbers);//The Join return is a string.
        Console.WriteLine(numbersText);

        //String interpolation
        string textString = "string";
        string text = $"Isso é uma {textString}";
        Console.WriteLine(text);

        Console.WriteLine("Digite seu nome: ");
        string? username = Console.ReadLine();
        string subject = $"Olá, {username}! Boas vindas ao sistema parceiro da Trybe!";
        Console.WriteLine(subject);
    }
}
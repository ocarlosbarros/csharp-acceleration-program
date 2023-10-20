namespace Strings;
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
        
    }
}
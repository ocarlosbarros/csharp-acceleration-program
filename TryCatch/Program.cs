public class Program
{
    public static void Main(string[] args)
    {

        //Tries execute a possible problematic code
        try
        {
            int division = DivideNumbers(10, 0);    
            Console.WriteLine(division);
        }
        //Catch with exception more specific
        catch(DivideByZeroException ex){
            Console.WriteLine($"Ocorreu uma exceção específica: {ex.Message}");//action taken

        }
        //Catch the general exception
        catch(Exception ex){
            Console.WriteLine($"Ocorreu uma exceção: {ex.Message}");//action taken
        }


        string[] chemicalProduct = new string[3];

    try
    {
    chemicalProduct[0] = "Cálcio";
    chemicalProduct[1] = "Zinco";
    chemicalProduct[2] = "Hidrazina";
    chemicalProduct[3] = "Anilina"; //problem is here: IndexOutOfRangeException 
    }
    catch (IndexOutOfRangeException ex) 
    {
    Console.WriteLine("Erro Específico, sabemos exatamente o motivo do erro." + ex);
    }
    catch (Exception ex)
    {
    Console.WriteLine("Temos a mensagem, porém é um pouco incerto o que ocorreu." + ex);
    }
        
    }

    public static int DivideNumbers(int numberOne, int numberTwo)
    {
        return numberOne / numberTwo;
    }
}
public class Program
{
    public static void Main()
    {
        //Creating an array
        int[] numberArray;
        
        //Creating instance of an array
        numberArray = new int[5];

        //Simple inicialization
        int[] agesArray = new int[5];

        //creating array with pre-defined values
        int[] numberList = new int[5] {1, 2, 3, 4, 5};
        int[] ageList = {1, 2, 3, 4, 5};

        string[] namesArrays = new string[5] {"Bruce", "Peter", "Diana", "Natasha", "Carol"};

        Console.WriteLine(numberList[0]);
        Console.WriteLine(namesArrays[1]);


        //Multidimensional Arrays
        int[,] multidimensionalArray = new int[2,3];

        string[,] herosAndVillains = new string[2,3] { {"Batman", "Spiderman", "BlackPanther"}, {"Joker", "Venom", "Killmonger"} };

        /*
            Jagged Array
            It's multidimensional arrays with internal arrays has different length
        */
        int[][] jaggedArray = new int[4][];

        jaggedArray[0] = new int[4] {6, 6, 6, 6};
        jaggedArray[1] = new int[3] {3, 3, 3};
        jaggedArray[2] = new int[1] {12};
        jaggedArray[3] = new int[2] {24, 36};
    }
}

namespace AdvancedTypes
{
    public class Program
    {
        public static void Main()
        {
            //Generic Classes and Methods

            //Generic List example
            GenericList<int> intList = new GenericList<int>();
            GenericList<string> stringList = new GenericList<string>();
            GenericList<SomeClass> someClassList = new GenericList<SomeClass>();

            //Generic Method
            intList.Add(1);
            intList.Add(10);
            intList.Add(1000);
            intList.Add(100);

            intList.Print();

            stringList.Add("Bruce Wayne");
            stringList.Add("Diana Prince");
            stringList.Add("Natasha Romanoff");
            stringList.Add("Peter Parker");

            stringList.Print();
            
        }
    }
}
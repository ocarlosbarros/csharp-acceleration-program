/*  Implicit Casting
    When a smaller data type is converted into a larger data type.
    */

int someIntNumber = 51;
long longNumberCast = someIntNumber;

Console.WriteLine(longNumberCast);

int intResult = 5/2;

/*
    Here the compiler ignore decimal value because intResult is an int variable.
    In this case there was a loss of information
    */
Console.WriteLine(intResult);// 2 

/*  Explicit Casting
    When we inform which data type we want to convert
    */
long someLongNumber = 516144066604654;
int intNumber = (int ) someLongNumber;//(int) converts to int even if  data is lost
Console.WriteLine(intNumber);// 666775150

/*
    Convert + method ToInt32()
    Throw an error if convertion is not possible:  Value was either too large or too small for an Int32
    */
long someLongNumberValue = 42;
int intNumberValue = Convert.ToInt32(someLongNumberValue);
Console.WriteLine($"Using the Convert {intNumberValue}");// 

string someString = "42";
int convertInt = Convert.ToInt32(someString);
Console.WriteLine(convertInt);

/*
    TryParse 
    Return a bool if the convert is possible or not, and if possible return the value
    */
string? userEntry = Console.ReadLine();
bool canConvert = Int32.TryParse(userEntry, out var valueConverted);
Console.WriteLine($"A conversão deu certo ? {canConvert} e seu valor é : {valueConverted}");
  
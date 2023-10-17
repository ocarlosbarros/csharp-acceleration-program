//Addition
int augend = 50, addend = 30;
int sum = augend + addend;
Console.WriteLine($"first value {augend} + second value {addend} = {sum}");

//Subtraction
int minuend = 77, subtrahend = 21;
int difference = minuend - subtrahend;
Console.WriteLine($"first value {minuend} - second value {subtrahend} = {difference}");

//Multiplication
int multiplicand = 5, multiplier = 5;
int product = multiplicand * multiplier;
Console.WriteLine($"first value {multiplicand} * second value {multiplier} = {product}");

//Division
int dividend = 90, divisor = 9;
int quotient = dividend / divisor;
Console.WriteLine($"first value {dividend} / second value {divisor} = {quotient}");

//remainder
int firstIntValue = 36, secondIntValue = 7;
int intResult = firstIntValue % secondIntValue;
Console.WriteLine($"first value {firstIntValue} % second value {secondIntValue} = {intResult}");

//incremet
int intValue = 1;
intValue++;
int incrementedValue = intValue;
Console.WriteLine($"value = {incrementedValue}");

//decrement
int originalValue = 10;
originalValue--;
int decrementedValue = originalValue;
Console.WriteLine($"value = {decrementedValue}");

//Assignment operators
int age = 18;
age += 1; // age = age + 1
Console.WriteLine($"Age = {age}");

int value = 11;
value *= 2; // value = value * 2
Console.WriteLine($"Double value {value}");

decimal decimalValue = 11;
decimalValue /= 3; // decimalValue = decimalValue / 3
Console.WriteLine($"Decimal value = {decimalValue.ToString("N2")}");

float floatValue = 9.9f;
floatValue %= 3; // floatValue = floatValue % 3
Console.WriteLine($"Float value = {floatValue.ToString("N2")}");
// See https://aka.ms/new-console-template for more information

/*
try
{
    // Console.WriteLine("Hello, World!");
    // float a = 7;
    // float b = 10;
    // float result = a / b;
    // Console.WriteLine("result : " + result);

    var admission = new Admission();

    int samAge = 11;
    Console.WriteLine($"Student age is {samAge}");
    admission.CheckAge(samAge);

    Console.WriteLine("admission successful");
}
catch (System.Exception ex)
{
    Console.WriteLine("Error occured: " + ex.Message);
    Console.WriteLine("admission denied");
}
// finally
// {
//     Console.WriteLine("Cleanup up the memory");
//}

*/
/*
try
{
    int a = 5;
    int b = 0;
    int result = a/b;
    Console.WriteLine("result :" + result);
}
catch(DivideByZeroException )
{
    Console.WriteLine("number can't be divided by zero");
}
*/
public class NumberChecker
{
    public void checkEven(int number)
    {
        if (number % 2 != 0)
        {
            throw new
            ArgumentException("number is not even");
            
        }
    }
}
class program 
{
    static void Main(string[]args)
    {
        NumberChecker checker = new NumberChecker();
        try
        {
            checker.checkEven(10);
            checker.checkEven(11);
        }
        catch (ArgumentException ex
        ){
            Console.WriteLine(ex.Message);
        }
    }
}
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
    int result = a / b;
    Console.WriteLine("result :" + result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("number can't be divided by zero");
}
catch (OverflowException)
{
    Console.WriteLine("number is too large")
}
*/
/*
public class NumberChecker
{
    public void checkEven(int number)
    {
        if (number % 2 != 0)
        {
            throw new
            ArgumentException("number is not even");
            
        }
        else{
            Console.WriteLine("valid even number");
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
}*/

public class ArrayHelper
{
    public void GetElementAt(int[] numbers, int index)
    {
        try
        {
            int element = numbers[index];
            Console.WriteLine($"Element at index {index}: {element}");
 
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("invalid index");
        }



    }
}
class program
{
    static void Main(string[] args)
    {
        ArrayHelper helper = new ArrayHelper();
        int[] number = { 10, 20, 40, 60, };
        helper.GetElementAt(number, 2);
        helper.GetElementAt(number, 10);
    }
}
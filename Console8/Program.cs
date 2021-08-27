using System;
using System.Linq;

namespace Console8
{
    class Program
    {
        static void Main(string[] args)
        {

        // Arrays of different types 
        int[] arrayInt = new int[5] {1, 2, 3, 4, 5};
        string[] arrayString = new string[5] {"a", "b", "c", "d", "e"}; 
        double[] arrayDouble = new double[5] {1.1, 2.5, 3.1, 4.3, 5.2}; 
        decimal[] arrayDecimal = new decimal[5] {10.0m, 20.0m, 30.0m, 40.0m, 50.0m}; 
        float[] arrayFloat = new float[5] {100.0f, 200.0f, 300.0f, 400.0f, 500.0f}; 

        // Pop method

        System.Console.WriteLine("Pop method:");
        System.Console.WriteLine();

        System.Console.WriteLine("Last Element of Integer Array: " + ArrayHelper.Pop(ref arrayInt));
        System.Console.WriteLine("Last Element of String Array: " + ArrayHelper.Pop(ref arrayString));
        System.Console.WriteLine("Last Element of Double Array: " + ArrayHelper.Pop(ref arrayDouble));
        System.Console.WriteLine("Last Element of Decimal Array: " + ArrayHelper.Pop(ref arrayDecimal));
        System.Console.WriteLine("Last Element of Float Array: " + ArrayHelper.Pop(ref arrayFloat));

        // Push method

        System.Console.WriteLine();
        System.Console.WriteLine("Push method: ");
        System.Console.WriteLine();

        System.Console.WriteLine("Add An Element to Integer Array");
        int IntElement = int.Parse(System.Console.ReadLine());
        ArrayHelper.Push(ref arrayInt, IntElement);
        System.Console.WriteLine("New Integer Array Length: " + arrayInt.Length);

        System.Console.WriteLine("Add An Element to String Array");
        string StringElement = System.Console.ReadLine();
        ArrayHelper.Push(ref arrayString, StringElement);
        System.Console.WriteLine("New String Array Length: " + arrayString.Length);

        System.Console.WriteLine("Add An Element to Double Array");
        double DoubleElement = double.Parse(System.Console.ReadLine());
        ArrayHelper.Push(ref arrayDouble, DoubleElement);
        System.Console.WriteLine("New Double Array Length: " + arrayDouble.Length);

        System.Console.WriteLine("Add An Element to Decimal Array");
        decimal DecimalElement = decimal.Parse(System.Console.ReadLine());
        ArrayHelper.Push(ref arrayDecimal, DecimalElement);
        System.Console.WriteLine("New Decimal Array Length: " + arrayDecimal.Length);

        System.Console.WriteLine("Add An Element to Float Array");
        float FloatElement = float.Parse(System.Console.ReadLine());
        ArrayHelper.Push(ref arrayFloat, FloatElement);
        System.Console.WriteLine("New Integer Array Length: " + arrayFloat.Length);


        // Shift method

        System.Console.WriteLine();
        System.Console.WriteLine("Shift method: ");
        System.Console.WriteLine();

        System.Console.WriteLine("First Element of Integer Array: " + ArrayHelper.Shift(ref arrayInt));
        System.Console.WriteLine("First Element of String Array: " + ArrayHelper.Shift(ref arrayString));
        System.Console.WriteLine("First Element of Double Array: " + ArrayHelper.Shift(ref arrayDouble));
        System.Console.WriteLine("First Element of Decimal Array: " + ArrayHelper.Shift(ref arrayDecimal));
        System.Console.WriteLine("First Element of Float Array: " + ArrayHelper.Shift(ref arrayFloat));

        // UnShift method

        System.Console.WriteLine();
        System.Console.WriteLine("UnShift method: ");
        System.Console.WriteLine();

        System.Console.WriteLine("Add An Element to Beginning of Integer Array");
        int IntElement2 = int.Parse(System.Console.ReadLine());
        ArrayHelper.UnShift(ref arrayInt, IntElement2);
        System.Console.WriteLine("New Integer Array Length: " + arrayInt.Length);

        System.Console.WriteLine("Add An Element to Beginning of String Array");
        string StringElement2 = System.Console.ReadLine();
        ArrayHelper.UnShift(ref arrayString, StringElement2);
        System.Console.WriteLine("New String Array Length: " + arrayString.Length);

        System.Console.WriteLine("Add An Element to Beginning of Double Array");
        double DoubleElement2 = double.Parse(System.Console.ReadLine());
        ArrayHelper.UnShift(ref arrayDouble, DoubleElement2);
        System.Console.WriteLine("New Double Array Length: " + arrayDouble.Length);

        System.Console.WriteLine("Add An Element to Beginning of Decimal Array");
        decimal DecimalElement2 = decimal.Parse(System.Console.ReadLine());
        ArrayHelper.UnShift(ref arrayDecimal, DecimalElement2);
        System.Console.WriteLine("New Decimal Array Length: " + arrayDecimal.Length);

        System.Console.WriteLine("Add An Element to Beginning of Float Array");
        float FloatElement2 = float.Parse(System.Console.ReadLine());
        ArrayHelper.UnShift(ref arrayFloat, FloatElement2);
        System.Console.WriteLine("New Integer Array Length: " + arrayFloat.Length);

        }


        }
    
    class ArrayHelper

    {

    // Pop

    public static int Pop(ref int[] ArrayOfIntegers)
    {
        int lastElement = ArrayOfIntegers[ArrayOfIntegers.Length - 1];
        var tempArray = ArrayOfIntegers.ToList();
        tempArray.RemoveAt(ArrayOfIntegers.Length - 1);
        ArrayOfIntegers = tempArray.ToArray();
        return lastElement;
    }

     public static string Pop(ref string[] ArrayOfStrings)
    {
        string lastElement = ArrayOfStrings[ArrayOfStrings.Length - 1];
        var tempArray = ArrayOfStrings.ToList();
        tempArray.RemoveAt(ArrayOfStrings.Length - 1);
        ArrayOfStrings = tempArray.ToArray();
        return lastElement;
    }
    

     public static double Pop(ref double[] ArrayOfDoubles)
    {
        double lastElement = ArrayOfDoubles[ArrayOfDoubles.Length - 1];
        var tempArray = ArrayOfDoubles.ToList();
        tempArray.RemoveAt(ArrayOfDoubles.Length - 1);
        ArrayOfDoubles = tempArray.ToArray();
        return lastElement;
    }

     public static decimal Pop(ref decimal[] ArrayOfDecimals)
    {
        decimal lastElement = ArrayOfDecimals[ArrayOfDecimals.Length - 1];
        var tempArray = ArrayOfDecimals.ToList();
        tempArray.RemoveAt(ArrayOfDecimals.Length - 1);
        ArrayOfDecimals = tempArray.ToArray();
        return lastElement;
    }

     public static float Pop(ref float[] ArrayOfFloats)
    {
        float lastElement = ArrayOfFloats[ArrayOfFloats.Length - 1];
        var tempArray = ArrayOfFloats.ToList();
        tempArray.RemoveAt(ArrayOfFloats.Length - 1);
        ArrayOfFloats = tempArray.ToArray();
        return lastElement;
    }

    // Push

    public static int Push(ref int[] ArrayOfIntegers, int IntElement)
    {
    var tempArray = ArrayOfIntegers.ToList();
    tempArray.Add(IntElement);
    ArrayOfIntegers = tempArray.ToArray();
    return ArrayOfIntegers.Length;  
    }

    public static int Push(ref string[] ArrayOfStrings, string StringElement)
    {
    var tempArray = ArrayOfStrings.ToList();
    tempArray.Add(StringElement);
    ArrayOfStrings = tempArray.ToArray();
    return ArrayOfStrings.Length;  
    }

    public static int Push(ref double[] ArrayOfDoubles, double DoubleElement)
    {
    var tempArray = ArrayOfDoubles.ToList();
    tempArray.Add(DoubleElement);
    ArrayOfDoubles = tempArray.ToArray();
    return ArrayOfDoubles.Length;  
    }

    public static int Push(ref decimal[] ArrayOfDecimals, decimal DecimalElement)
    {
    var tempArray = ArrayOfDecimals.ToList();
    tempArray.Add(DecimalElement);
    ArrayOfDecimals = tempArray.ToArray();
    return ArrayOfDecimals.Length;  
    }

    public static int Push(ref float[] ArrayOfFloats, float FloatElement)
    {
    var tempArray = ArrayOfFloats.ToList();
    tempArray.Add(FloatElement);
    ArrayOfFloats = tempArray.ToArray();
    return ArrayOfFloats.Length;  
    }

    // Shift

    public static int Shift(ref int[] ArrayOfIntegers)
    {
    int lastElement = ArrayOfIntegers[0];
    var tempArray = ArrayOfIntegers.ToList();
    tempArray.RemoveAt(0);
    ArrayOfIntegers = tempArray.ToArray();
    return lastElement;
    }

     public static string Shift(ref string[] ArrayOfStrings)
    {
    string lastElement = ArrayOfStrings[0];
    var tempArray = ArrayOfStrings.ToList();
    tempArray.RemoveAt(0);
    ArrayOfStrings = tempArray.ToArray();
    return lastElement;
    }

     public static double Shift(ref double[] ArrayOfDoubles)
    {
    double lastElement = ArrayOfDoubles[0];
    var tempArray = ArrayOfDoubles.ToList();
    tempArray.RemoveAt(0);
    ArrayOfDoubles = tempArray.ToArray();
    return lastElement;
    }

     public static decimal Shift(ref decimal[] ArrayOfDecimals)
    {
    decimal lastElement = ArrayOfDecimals[0];
    var tempArray = ArrayOfDecimals.ToList();
    tempArray.RemoveAt(0);
    ArrayOfDecimals = tempArray.ToArray();
    return lastElement;
    }

     public static float Shift(ref float[] ArrayOfFloats)
    {
    float lastElement = ArrayOfFloats[0];
    var tempArray = ArrayOfFloats.ToList();
    tempArray.RemoveAt(0);
    ArrayOfFloats = tempArray.ToArray();
    return lastElement;
    }

    // UnShift

    public static int UnShift(ref int[] ArrayOfintegers, int IntElement)
    {
    var tempArray = ArrayOfintegers.ToList();
    tempArray.Reverse();
    tempArray.Add(IntElement);
    tempArray.Reverse();
    ArrayOfintegers = tempArray.ToArray();
    return ArrayOfintegers.Length;  
    }

    public static int UnShift(ref string[] ArrayOfStrings, string StringElement)
    {
    var tempArray = ArrayOfStrings.ToList();
    tempArray.Reverse();
    tempArray.Add(StringElement);
    tempArray.Reverse();
    ArrayOfStrings = tempArray.ToArray();
    return ArrayOfStrings.Length;  
    }

    public static int UnShift(ref double[] ArrayOfDoubles, double DoubleElement)
    {
    var tempArray = ArrayOfDoubles.ToList();
    tempArray.Reverse();
    tempArray.Add(DoubleElement);
    tempArray.Reverse();
    ArrayOfDoubles = tempArray.ToArray();
    return ArrayOfDoubles.Length;  
    }

    public static int UnShift(ref decimal[] ArrayOfDecimals, decimal DecimalElement)
    {
    var tempArray = ArrayOfDecimals.ToList();
    tempArray.Reverse();
    tempArray.Add(DecimalElement);
    tempArray.Reverse();
    ArrayOfDecimals = tempArray.ToArray();
    return ArrayOfDecimals.Length;  
    }

    public static int UnShift(ref float[] ArrayOfFloats, float FloatElement)
    {
    var tempArray = ArrayOfFloats.ToList();
    tempArray.Reverse();
    tempArray.Add(FloatElement);
    tempArray.Reverse();
    ArrayOfFloats = tempArray.ToArray();
    return ArrayOfFloats.Length;  
    }


    }

 
}


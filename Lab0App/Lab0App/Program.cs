/*
 * CPRG 211 Lab 0 Activity
 * Author: Monica
 * When: Winter 2025
 */

//get low and high int number
//low must be positive
//high must be greater than low

using Lab0;

int low,high;
int diff;

low = Utilities.GetPositiveInt("low number");

high = Utilities.GetIntInRange("high number", low + 1, Int32.MaxValue); //the largest int possible

//calculate and print difference
diff = high - low;
//Console.WriteLine($"The low number: {low}");
//Console.WriteLine($"The high number: {high}");
Console.WriteLine($"The difference between {low} and {high} is {diff}");

//create an array to hold numbers between low and high
int[] numbers = new int[diff+1];//size of array
for (int i = 0; i <= diff; i++) // i is the index
{
    numbers[i] = low + i;
}

Console.WriteLine("Numbers in the array");
for (int i = 0; i <= diff; i++) 
{
    Console.WriteLine(numbers[i]);
}

//create file named "numbers.txt" and write to it the numbers from the array in reverse order
StreamWriter streamWriter = File.CreateText("numbers.txt");
string fullPath = Path.GetFullPath("numbers.txt");
for (int i = numbers.Length-1; i >= 0; i--) 
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close();
Console.WriteLine("File written");



List<double> resultList = Utilities.GetInputFromFile(fullPath);
Console.WriteLine("Numbers in the List");
for (int i = 1; i < resultList.Count; i++)
{
    
    if (Utilities.CheckPrimeNum(resultList[i])) 
    {
        Console.WriteLine(resultList[i]);
    }
}
    

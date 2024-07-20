//Reverse a string
Console.Write("Enter string to reverse:");
string str = Console.ReadLine();
char[] strArr = str.ToCharArray();
Array.Reverse(strArr);
Console.WriteLine("Reversed string is: {0}", new string(strArr));

//Palindrome checker
if (string.Equals(new string(strArr), str, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}

//Reverse order of words in a Sentence
Console.WriteLine("Enter sentence to reverse order of words");
string sentence1 = Console.ReadLine();
string[] words = sentence1.Split(" ");
Array.Reverse(words);
Console.WriteLine("Reversed sentence is: {0}", string.Join(" ", words));

//Reverse each word in a Sentence
Console.WriteLine("Enter sentence to reverse each words");
string sentence2 = Console.ReadLine();
string[] sentArray = sentence2.Split(" ");
for (int i = 0; i < sentArray.Length; i++)
{
    char[] charArr = sentArray[i].ToCharArray();
    Array.Reverse(charArr);

    sentArray[i] = string.Join("", charArr);
}
Console.WriteLine("Expected output is: {0}", string.Join(" ", sentArray));

//Count the occurrence of each character in a string
Console.Write("Enter string:");
string str2 = Console.ReadLine();
Dictionary<char, int> characterCount = new Dictionary<char, int>();
foreach (var c in str2)
{
    if (c != ' ')
    {
        if (!characterCount.ContainsKey(c))
        {
            characterCount.Add(c, 1);
        }
        else
        {
            characterCount[c]++;
        }
    }
}
foreach (var ch in characterCount)
{
    Console.WriteLine("{0} - {1}", ch.Key, ch.Value);
}

//Remove duplicate charaters in string
string result = "";
foreach (var s in str2)
{
    if (!result.Contains(s))
    {
        result += s;
    }
}
Console.WriteLine("String without duplicates: {0}", result);

//find all possible substring of a given string
Console.Write("Enter string to find substrings:");
string str3 = Console.ReadLine();
string substring = "";
for (int i = 0; i < str3.Length; i++)
{
    for (int j = i; j < str3.Length; j++)
    {
        substring += str3[j];
        Console.Write(substring + " ");
    }
    substring = "";
}

//Rotation of array
Console.Write("Enter array size:");
int arrSize = Convert.ToInt32(Console.ReadLine());
object[] arr = new object[arrSize];
Console.Write("Enter array elements:");
for (int i = 0; i < arrSize; i++)
{
    arr[i] = Console.ReadLine();
}
Console.Write("Entered array is: ");
for (int i = 0; i < arrSize; i++)
{
    Console.Write(arr[i] + " ");
}
Console.Write("\nEnter no. of rotations:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter direction of rotation (Left/Right): ");
string d = Console.ReadLine();
for (int i = 0; i < n; i++)
{
    rotateArray(arr);
}

void rotateArray(object[] array)
{
    if (d == "Left")
    {
        var temp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = temp;
    }
    else
    {
        var temp = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;
    }
}
Console.Write("Rotated array is: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

//find if a positive integer is a prime number or not
Console.Write("Enter positive integer: ");
int num = Convert.ToInt32(Console.ReadLine());
bool isPrime = true;
for (int i = 2; i < num; i++)
{
    if (num % i == 0) isPrime = false;
}
if (isPrime == true)
{
    Console.WriteLine("Number is prime");
}
else
{
    Console.WriteLine("Number is not prime");
}

//find the sum of digits of a positive integer
Console.Write("Enter a positive integer: ");
string num2 = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(num2));
int sum = 0;
for (int i = 0; i < num2.Length; i++)
{
    sum += Convert.ToInt32(num2[i].ToString());
}
Console.WriteLine("Sum of digits: {0}", sum);

//Find first, second and third largest integer in array using only one loop
int[] ints = { 14, 198, 21, 18, 20, 5 };
int max1 = 0;
int max2 = 0;
int max3 = 0;
foreach (int i in ints)
{
    if (i > max1)
    {
        max3 = max2;
        max2 = max1;
        max1 = i;
    }
    else if (i > max2)
    {
        max3 = max2;
        max2 = i;
    }
    else if (i > max3)
    {
        max3 = i;
    }
}
Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);

//Convert 2-D array to 1-D array
int[,] twoDarray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int width = twoDarray.GetLength(0);
int height = twoDarray.GetLength(1);
int[] singleDarr = new int[width * height];
int index1 = 0;
int index2 = 0;
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        singleDarr[index1] = twoDarray[j, i];
        Console.Write(singleDarr[index1] + " ");
        index1++;
    }
}
Console.WriteLine("\n");
for (int i = 0; i < width; i++)
{
    for (int j = 0; j < height; j++)
    {
        singleDarr[index2] = twoDarray[i, j];
        Console.Write(singleDarr[index2] + " ");
        index2++;
    }
}

//Convert 1D array to 2D array
int[] oneDarray = {1,2,3,4,5,6 };
int[,] newTwoDarray = new int[3,2];
int index = 0;
for (int i=0;i<3;i++) {
    for (int j = 0; j < 2; j++)
    {
        newTwoDarray[i, j] = oneDarray[index];
        Console.Write(newTwoDarray[i, j]+" ");
        index++;
    }
    Console.WriteLine();
}
 





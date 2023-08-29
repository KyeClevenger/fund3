// 1.
static void PrintList(List<string> MyList)
{
    foreach (string Names in MyList)
    {
        Console.WriteLine(Names);
    }
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);


// 2.
static void SumOfNumbers(List<int> IntList)
{
    var result = 0;
    for (var i = 0; i <= IntList.Count - 1; i++)
    {
        result += IntList[i];
    }
    Console.WriteLine(result);
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);


// 3.
{
    static int FindMax(List<int> IntList)
    {
        int maxVal = int.MinValue;
        foreach (int i in IntList)
        {
            if (i > maxVal)
            {
                maxVal = i;
            }
        }
        return maxVal;
    }
    List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
    int maxValue = FindMax(TestIntList2);
    Console.WriteLine("Maximum element: " + maxValue);
}


// 4.
static List<int> SquareValues(List<int> IntList)
{
    List<int> Squared = new List<int>();
    for (var idx = 0; idx < IntList.Count; idx++)
    {
        Squared.Add(IntList[idx] * IntList[idx]);
    }
    return Squared;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

foreach (var Number in SquareValues(TestIntList3))
{
    Console.WriteLine(Number);
}


// // 5.
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if(IntArray[i]<0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
int[] modifiedArray = NonNegatives(TestIntArray);
// Print the modified array to verify the result
foreach (var value in modifiedArray)
{
    Console.WriteLine(value);
}


// // 6.
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (KeyValuePair<string,string> data in MyDictionary)
    {
        Console.WriteLine($"{data.Key}: {data.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);


// // 7.
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    foreach (KeyValuePair<string,string> search in MyDictionary)
    {
        if(search.Key == SearchTerm){
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));


// // 8.
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary <string, int> GenerateDictionary(List <string> Name, List <int> Ages)
{
    Dictionary <string, int> OtherDictionary =  new Dictionary <string, int> ();
    for (var i = 0; i < Name.Count; i++)
    {
        OtherDictionary.Add($"{Name[i]}", Ages[i]);
    }
    foreach (KeyValuePair<string, int> merge in OtherDictionary)
    {
        Console.WriteLine($"{merge.Key} is {merge.Value}");
    }
    return OtherDictionary;
}
List <string> TheNames = new List <string> () {"Julie", "Harold", "James", "Monica"};
List <int> CurrentAge = new List <int> () {6,12,7,10};

GenerateDictionary(TheNames, CurrentAge);

// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here



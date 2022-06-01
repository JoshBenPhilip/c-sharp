// See https://aka.ms/new-console-template for more information
string stranger = "Another One";
int one = 1;


Console.WriteLine($"Hello, {stranger} {one}");
Console.WriteLine(stranger.IndexOf("n"));

int a = 10, b = 20, c = 40;

int sum = a + b + c;

double d = 5.0, e = 2.0;

double div = d / e;

int max = int.MaxValue;
int maxIsh = max +3;


Console.WriteLine($"The sum is {sum}");
Console.WriteLine($"What is 70/3 {div}");

Console.WriteLine($"What is the max of double {double.MaxValue}");
Console.WriteLine($"What is the max of int {int.MaxValue}");

Console.WriteLine($"What is the maxish {maxIsh}");

Console.WriteLine($"--------------------------------- List ---------");

// int[] arr2 = new int [] {1,2,3,4};
var firstArr = new int [5] {-69, 46, 10, 1, 100};


firstArr[1] = 20;

for (var i = 0; i < firstArr.Count(); i++) {
    Console.WriteLine($"The value at {i} is {firstArr[i]}");
    };

    foreach(var el in firstArr)
    {
        Console.WriteLine($"The value is {el}");
    }

    Console.WriteLine("---------------- Array -----");
    
    List<int> list = new List<int>();
var list1 = new List<int>();

    list.AddRange(firstArr);
    list.Add(1000);
    list.Add(10001);
    list.Add(10002);
    
    foreach(var el in list)
    {
        Console.WriteLine($"The value is {el}");
    }

// See https://aka.ms/new-console-template for more information
using Data_Structure_And_Algorithms;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Hello, World!");

static string TitleCase(string title, string minorWords = "")
{
    
    if (string.IsNullOrEmpty(title)) return "";
    if (string.IsNullOrEmpty(minorWords))
    {
        var arr = title.Split(" ");
        for (int i = 0; i < arr.Length; i++)
        {
            var newStr = Char.ToUpper(arr[i][0]) + arr[i].Substring(1);
            arr[i] = newStr;
        }
        return string.Join(" ", arr);
    }
    var newMinorWords = minorWords.Split(" ");
    var arr2 = title.Split(" ");
    for (int i = 0; i < arr2.Length; i++)
    {
        var newStr = Char.ToUpper(arr2[i][0]) + arr2[i].Substring(1).ToLower();
        if(i < 1)
        {
            arr2[i] = newStr;
        }
        else
        {
            
           if(newMinorWords.Contains(newStr.ToLower()))
            {
                arr2[i] = newStr.ToLower();
            }
           else
            {
                arr2[i] = newStr;
            }
        }
        
    }
    return string.Join(" ", arr2);
}
 static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
{
    var years = 0;
    while (principal !< desiredPrincipal)
    {
        years++;
        var vint = principal * interest;
        var increasePerYear = vint - (vint * tax);
        principal += increasePerYear;
    }
    return years;
}
//"a clash of KINGS", "a an the of"
static string FindNeedle(object[] haystack)
{
    //Code goes here!
    var Nedd = "needle";
    return $"found the needle at position {Array.IndexOf(haystack, Nedd) + 1}";
  }
//static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
//{
//    // Your code goes here. Have fun!
//    while (fighter1.Health > 0 && fighter2.Health > 0)
//    {
//        if (firstAttacker == fighter1.Name)
//        {
//            fighter2.Health -= fighter1.DamagePerAttack;
//            if (fighter2.Health > 0)
//            {
//                fighter1.Health -= fighter2.DamagePerAttack;
//            }
//            else
//            {
//                return fighter1.Name;
//            }
//        }
//        else
//        {
//            fighter1.Health -= fighter2.DamagePerAttack;
//            if (fighter1.Health > 0)
//            {
//                fighter2.Health -= fighter1.DamagePerAttack;
//            }
//            else
//            {
//                return firstAttacker;
//            }
//        }

//    }
//    return fighter1.Health == 0 ? fighter2.Name : fighter1.Name;
//}
static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
{
    Fighter currentAttacker = firstAttacker == fighter1.Name ? fighter1 : fighter2;
    Fighter opponent = currentAttacker == fighter1 ? fighter2 : fighter1;

    while (currentAttacker.Health > 0 && opponent.Health > 0)
    {
        opponent.Health -= currentAttacker.DamagePerAttack;

        // Swap current attacker and opponent
        var temp = currentAttacker;
        currentAttacker = opponent;
        opponent = temp;
    }

    return currentAttacker.Health > 0 ? currentAttacker.Name : opponent.Name;
}
var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
    //Console.WriteLine(declareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"));
static string High(string s)
{
    char[] alphabet = new char[26];

    for (int i = 0; i < 26; i++)
    {
        alphabet[i] = (char)('a' + i); // You can also use 'a' + i for lowercase letters.
    }
    var arr = new int[s.Length];
    var splitedS = s.Split(" ");
    for (int i = 0; i < splitedS.Length; i++)
    {
        var temp = splitedS[i].ToCharArray();
        var item = 0;
        for (int j = 0; j < temp.Length; j++)
        {
            item += Array.IndexOf(alphabet, temp[j]) + 1;
        }
        arr[i] = item;

    }
    return splitedS[Array.IndexOf(arr, arr.Max())];
}
static string RemoveUrlAnchor(string url)
{
    // TODO: complete
    var arr = Array.IndexOf(url.ToCharArray(), '#');
    return arr > 0 ? url.Substring(0, arr): url;
}
//Console.WriteLine(RemoveUrlAnchor("www.codewars.com"));
static List<int> PipeFix(List<int> numbers)
{
    //Good luck!
    var num = numbers.ToArray();
    var list = new List<int>();
    for (int i = 0; i < num.Length; i++)
    {
        if(i != num.Length - 1)
        {
            if (num[i + 1] - num[i] != 1)
            {
                list.Add(num[i]);
                for (int j = 0; j < (num[i + 1] - num[i]-1); j++)
                {
                    var temp = num[i] + j + 1;
                    list.Add(temp);
                }
            }
            else
            {
                list.Add(num[i]);
            }
        }
        else
        {
            list.Add(num[i]);
        }
    }
    return list;
}
static string HowMuchILoveYou(int nb_petals)
{
    // your code
    var arr = new string[]{
      "I love you",
"a little",
"a lot",
"passionately",
"madly",
"not at all"
    };
    if(nb_petals == 0) return arr[0];
    if (nb_petals <= 6)
    {
        return arr[nb_petals - 1];
    }
    var store = 7;
    while (store >= 6)
    {
        store = nb_petals - 6;
        nb_petals = store;
    }
    return arr[nb_petals - 1];
}
static int DescendingOrder(int num)
{
    // Bust a move right here
    var arr = $"{num}".ToCharArray();
    var arr1 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        var temp = int.Parse($"{arr[i]}");
        arr1[i] = temp;
    }
    Array.Sort(arr1);
    Array.Reverse(arr1);
    var str = string.Join("", arr1);
    return Convert.ToInt32(str);
}
static int[] DeleteNth(int[] arr, int x)
{
    // ...
    var list = new int[arr.Length];
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (dict.ContainsKey(arr[i]))
        {
            if(dict[arr[i]] < 2)
            {
                dict[arr[i]]++;
            }
            
        }
        else
        {
            dict.Add(arr[i], 1);
        }
    }
   

    foreach (var kvp in dict)
    {
        int key = kvp.Key;
        int value = kvp.Value;

        // Add the key 'value' number of times to the result list
        for (int i = 0; i < value; i++)
        {
            var index = Array.IndexOf(arr, key);
            arr[index] = -1;
            list[index] = key;
        }
    }
    var result = list.Where(x => x != 0).ToArray();
    return result.ToArray();
}
static int Sum(int[] numbers)
{
    if (numbers == null || numbers.Length == 1) return 0;
    var max = numbers.Max();
    var min = numbers.Min();
    var num = numbers.ToList();
    num.Remove(max);
    num.Remove(min);
    return num.Sum();
}
static int HexToDec(string hexString)
{
    if (hexString.StartsWith("-"))
    {
        hexString = hexString.Substring(1);
        var resul = Convert.ToInt32(hexString, 16);
        return -resul;
    }
    var result = Convert.ToInt32(hexString, 16);
    return result;
}
static long QueueTime(int[] customers, int n)
{
    if (n == 1)
    {
        return customers.Sum();
    }

    // Initialize the list of checkout tills
    List<int> checkoutTills = new List<int>(n);

    for (int i = 0; i < n; i++)
    {
        checkoutTills.Add(0);
    }

    // Simulate the checkout process for each customer
    foreach (int customerTime in customers)
    {
        int minCheckoutTime = checkoutTills.Min();
        int minCheckoutIndex = checkoutTills.IndexOf(minCheckoutTime);
        checkoutTills[minCheckoutIndex] += customerTime;
    }

    // Find the maximum total time among checkout tills
    int maxTotalTime = checkoutTills.Max();

    return maxTotalTime;
}
static bool IsAnagram(string test, string original)
{
    // your code goes here
    if (test.Length != original.Length) return false;
    for (int i = 0; i < original.Length; i++)
    {
        if (!test.Contains(original[i], StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }
        bool removedOnce = false;
        test = string.Join("", test.Where(x =>
        {
            if (!removedOnce && x == original[i])
            {
                removedOnce = true;
                return false;
            }
            return true;
        }));
    }
    return true;
}
static int[] Take(int[] arr, int n)
{
    //Array.Resize(ref arr, n);
    //return arr;
    if (n == 0 || arr.Length == 0) return new int[0];
    if(n > arr.Length) n = arr.Length;  
    var result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = arr[i];
    }
    return result;
}
static int Stray(int[] numbers)
{
    var result = numbers.GroupBy(x => x).SingleOrDefault(x => x.Count() == 1);
    return result.Key;
}
static List<string> wave(string str)
{
    var list = new List<string>();
    var str1 = str.ToArray();
    for (int i = 0; i < str.Length; i++)
    {

        if (!string.IsNullOrEmpty($"{str1[i]}") && str1[i] != ' ' )
        {
            str1[i] = Char.ToUpper(str1[i]);
            var newText = string.Join("", str1);
            list.Add(newText);
            str1[i] = Char.ToLower(str1[i]);
        }
    }
    return list;
}
static long QueuesTime(int[] customers, int n)
{
    if (n == 0) return customers.Sum();
    var queue = Enumerable.Repeat(0, n).ToArray();
    foreach (var customerTime in customers)
    {
        var minvalue = queue.Min();
        var idx = Array.IndexOf(queue, minvalue);
        queue[idx] += customerTime;
    }
    return queue.Max();
}

static string[] dirReduc(string[] arr)
{
    Stack<string> stack = new Stack<string>();

    foreach (var direction in arr)
    {
        if (stack.Count > 0 && AreOppositeDirections(stack.Peek(), direction))
        {
            // If the current direction is opposite to the one at the top of the stack, pop it.
            stack.Pop();
        }
        else
        {
            // Otherwise, push the current direction onto the stack.
            stack.Push(direction);
        }
    }

    // Convert the stack to an array in reverse order to get the correct order of directions.
    string[] result = stack.ToArray();
    Array.Reverse(result);

    return result;
}

static bool AreOppositeDirections(string dir1, string dir2)
{
    return (dir1 == "NORTH" && dir2 == "SOUTH") ||
           (dir1 == "SOUTH" && dir2 == "NORTH") ||
           (dir1 == "EAST" && dir2 == "WEST") ||
           (dir1 == "WEST" && dir2 == "EAST");
}

static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
{

    var list = new List<int>(); 
    foreach (var item in listOfItems)
    {
        if(item is int)
        {
            list.Add(int.Parse($"{item}"));
        }
    }

    return list;
}
string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
static long RowSumOddNumbers(long n)
{
    // TODO
    return n * n * n;
}
static int СenturyFromYear(int year)
{
    var num = $"{year}".ToCharArray();
    if (num.Length > 4)
    {
        var nums = int.Parse(string.Join("", num[0], num[1], num[2], num[3])) + 1;
        return nums;
    }
    var dom = int.Parse($"{num[num.Length - 2]}{num[num.Length - 1]}");
    var ans = dom < 1 ? int.Parse($"{num[0]}{num[1]}") : int.Parse($"{num[0]}{num[1]}") + 1;
    return ans;
}
var tree = new BinaryTree<int>();

foreach (var value in new[] { 8, 5, 6, 4, 1, 2 })
    tree.Add(value);
//Console.WriteLine(СenturyFromYear(4137987));
static int BinarySearch(int[] num, int value, int min, int max)
{
    
    if (min > max) return 0;
    var mid = (min + max) / 2;
    if(value == num[mid]) return ++mid;
    if(value < num[mid])
    {
        mid--;
        return BinarySearch(num, value,min, mid-1 );
    }
    else
    {
        mid++;
        return BinarySearch(num, value, mid+1,max);
    }
}
static int[] Race(int v1, int v2, int g)
{
    // your code
    //if (v1 >= v2) return new int[] { -1, -1, -1 };
    //var RelativeSpeed = v2 - v1;
    //var time = (decimal)g / (decimal)RelativeSpeed;
    //int h = (int)(time / 1);
    //decimal remainingSeconds = time % 1;
    //var m = (remainingSeconds * 60);
    //int rM = (int)m;
    //int s = (int)(time % 1 * 60 % 1 * 60);
    //return new int[] { h, rM, s };
    if (v1 >= v2) return null;
    var ts = System.TimeSpan.FromSeconds(((g * 3600) / (v2 - v1)));
    return new int[] { ts.Hours, ts.Minutes, ts.Seconds };
}
static string GetMiddle(string s)
{
    //Code goes here!
    if(s.Length % 2 == 0)
    {
        return $"{s[(s.Length / 2)-1]}{s[s.Length / 2]}";
    }
    var mid = s.Length / 2;
    var fir = s.Substring(0, mid);
    var sec = s.Substring(mid+1);
    if (fir.Length == sec.Length)
    {
        return $"{s[mid]}";
    }
    return s;
}
static int CheckExam(string[] arr1, string[] arr2)
{
    var result = arr1.Zip(arr2, (a, b) =>
    a == b ? 4 : (b == "" ? 0 : -1)
).Sum();
    return result < 0 ? 0 : result;
}
static String factors(int lst)
{
    var res = PrimeFactors(lst);
    var result = "";
    foreach (var n in res)
    {
        result += n.Value > 1 ? $"({n.Key}**{n.Value})": $"({n.Key})";
    }
    return result;
}
static Dictionary<int, int> PrimeFactors(int number)
{
    var factors = Enumerable.Range(2, (int)Math.Sqrt(number))
        .Where(divisor => number % divisor == 0)
        .Select(divisor =>
        {
            int count = 0;
            while (number % divisor == 0)
            {
                count++;
                number /= divisor;
            }
            return new { Divisor = divisor, Count = count };
        })
        .ToDictionary(item => item.Divisor, item => item.Count);

    if (number > 1)
    {
        if (factors.ContainsKey(number))
        {
            factors[number]++;
        }
        else
        {
            factors[number] = 1;
        }
    }

    return factors;
}
//Console.WriteLine(factors(86240));
static Dictionary<int, int> PrimeFactorAndNumberOfApperamce(int number)
{
    var factor = Enumerable.Range(2, (int)Math.Sqrt((double)number))
        .Where(divisor => number % divisor == 0)
        .Select(divisor =>
        {
            int count = 0;
            while (number % divisor == 0)
            {
                count++;
                number /= divisor;
            }
            return new { Divisor = divisor, Count = count };
        }).ToDictionary(item => item.Divisor,item => item.Count);
    return factor;
}
var arr = new int[] { 1,4,5,7,8,9,10,11,13 };
var result = SearchAlgorithm.IsPalindrome("racecar");
//Console.WriteLine(result);
static string ReverseWord(string str)
{
    var arr = str.Split(" ");
    var list = new List<string>();
    foreach (var item in arr)
    {
        var temp = item.ToCharArray();
        Array.Reverse(temp);
        list.Add(string.Join("", temp));
    }
    return string.Join(" ", list);
}
//rearrange the alphabets in the string base on the position of the number
static string AlphabetPosition1(string text)
{
    return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 96));
}
//return  the alphabet in a string in aphabetic order e.g "The big brown fox" => "big brown fox The"
static string AlphabetPosition(string text)
{
    var arr = text.Split(" ");
    Array.Sort(arr);
    return string.Join(" ", arr);
}
var result1 = AlphabetPosition("The big brown fox");
Console.WriteLine(result1);

// return a string form from the alphabet and the number next to it e'g "a3,b2,c1" => "aaabbc" use Linq
static string AlphabetPosition2(string text)
{
    var arr = text.Split(",");
    var list = new List<string>();
    foreach (var item in arr)
    {
        var temp = item.ToCharArray();
        var num = int.Parse($"{temp[1]}");
        for (int i = 0; i < num; i++)
        {
            list.Add($"{temp[0]}");
        }
    }
    return string.Join("", list);
}
var result2 = AlphabetPosition2("a3,b2,c1");
Console.WriteLine(result2);

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
/*
// README.md를 읽고 코드를 작성하세요.
//1.
Stack objectStack = new Stack();
objectStack.Push(100);
objectStack.Push(200);

int value1 = (int)objectStack.Pop();
int value2 = (int)objectStack.Pop();

Console.WriteLine($"값1: {value1}, 값2: {value2}");

//2.
Stack<int> intStack = new Stack<int>();
intStack.Push(100);
intStack.Push(200);

int value1 = intStack.Pop();
int value2 = intStack.Pop();

Console.WriteLine($"값1: {value1}, 값2: {value2}");


//3.
Cup<string> textCup= new Cup<string>();
textCup.Content = "커피";

Cup<int> numberCup = new Cup<int>();
numberCup.Content = 500;

Console.WriteLine($"음료: {textCup.Content}");
Console.WriteLine($"용량: {numberCup.Content}");

public class Cup<T>
{
    public T Content { get; set; }
}

//4.
var player = new Pair<string, int>("용사", 100);
Console.WriteLine($"이름: {player.First}, HP: {player.Second}");

var score = new Pair<int, double>(1, 95.5);
Console.WriteLine($"순위: {score.First}등, 점수: {score.Second}점");

public class Pair<TFrist, TSecond>
{
    public TFrist First { get; set; }
    public TSecond Second { get; set; }

    public Pair(TFrist first, TSecond second)
    {
        First = first;
        Second = second;
    }
}


//5.
void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b; 
    b = temp;
}

int x = 10;
int y = 20;
Console.WriteLine(  $"교환 전: x={x}, y={y}");

Swap(ref x, ref y);
Console.WriteLine($"교환 후: x={x}, y={y}");

string first = "사과";
string second = "바나나";
Console.WriteLine($"교환 전: first={first}, second={second}");

Swap(ref first,ref  second);
Console.WriteLine($"교환 후: first={first}, second={second}");


//6.
var intContainer = new NumberSontainer<int>();
intContainer.Value = 100;
Console.WriteLine($"정수값: {intContainer.Value}");

var floatContainer = new NumberSontainer<float>();
floatContainer.Value = 3.14f;
Console.WriteLine($"실수값: {floatContainer.Value}");

//var stringContainer = new NumberSontainer<string>();

public class NumberSontainer<T> where T : struct
{
    public T Value { get; set; }
}


//7.
T CreateInstance<T>() where T : new()
{
    return new T();
}

Monster monster = CreateInstance<Monster>();
Console.WriteLine($"생성된 몬스터: {monster.Name}, HP: {monster.HP}");
public class Monster
{
    public string Name { get; set; } = "슬라임";
    public int HP { get; set; } = 50;
}


//8.
T GetMax<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) > 0 ? a : b;
}

int maxInt = GetMax(10, 20);
Console.WriteLine($"더 큰 정수: {maxInt}");

string maxString = GetMax("apple", "banana");
Console.WriteLine($"사전순 뒤: {maxString}");


//9.
T GetDefaultValue<T>()
{
    return default;
}

int intDefault = GetDefaultValue<int>();
bool boolDefault = GetDefaultValue<bool>();
string stringDefault = GetDefaultValue<string>();

Console.WriteLine($"int 기본값: {intDefault}");
Console.WriteLine($"bool 기본값: {boolDefault}");
Console.WriteLine($"string 기본값: {stringDefault ?? "(null)"}");


//10.
List<string> names = new List<string>();
names.Add("철수");
names.Add("영희");
names.Add("민수");

Console.WriteLine("이름 목록:");
foreach (var name in names)
{
    Console.WriteLine($"   - {name}");
}

Dictionary<string, int> scores = new Dictionary<string, int>();
scores["철수"] = 95;
scores["영희"] = 88;
scores["민수"] = 92;

Console.WriteLine("\n점수:");
foreach (var pair in scores)
{
    Console.WriteLine($"   {pair.Key}: {pair.Value}점");
}


//11.
var special = new SpecialContainer<string>();
special.Item = "특별한 아이템";
special.Description = "레어 등급";
Console.WriteLine($"{special.Item} ({special.Description})");

var intBox = new IntContainer();
intBox.Item = 50;
Console.WriteLine($"값: {intBox.Item}, 두 배: {intBox.Double()}");

public class Container<T>
{
    public T Item { get; set; }
}

public class SpecialContainer<T> : Container<T>
{
    public string Description { get; set; }
}

public class IntContainer : Container<int>
{
    public int Double() => Item * 2;
}
*/

//12.
Conter<int>.Count++;
Conter<int>.Count++;
Conter<string>.Count++;

Console.WriteLine($"Conter<int>.Count: {Conter<int>.Count}");
Console.WriteLine($"Conter<string>.Count: {Conter<string>.Count}");
public class Conter<T>
{
    public static int Count = 0;
}
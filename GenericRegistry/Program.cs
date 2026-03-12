using Microsoft.Win32;
using System;

// README.md를 읽고 아래에 코드를 작성하세요.


public class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    public TKey[] keys;
    public TValue[] values;
    public int _count;

    public Registry(int capacity)
    {
        keys = new TKey[capacity];
        values = new TValue[capacity];
    }

    public Register(TKey key, TValue value)
    {

    }
}
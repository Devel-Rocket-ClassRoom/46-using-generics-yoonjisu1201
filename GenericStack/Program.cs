using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

class MyStack<T>
{
    T[] stack;
    public MyStack(int capacity)
    {
        stack = new T[capacity];
    }
}
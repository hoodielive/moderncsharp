using System;
using System.Collections;
using System.Collections.Generic;

class Stack<T>
{
    private T[] array;
    private int currentIndex; 

    public Stack(int size)
    {
        array = new T[size];
        currentIndex = 0;
    }

    public void Push(T item)
    {
        array[currentIndex] = item; 
        currentIndex++;
    }
    
    public T Pop() 
    {
        currentIndex--;
        return array[currentIndex];
    }
}
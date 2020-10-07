using System;
using System.Collections;
using System.Collections.Generic;
public class GenericMethodExploration
{
    string string1 = "a";
    string string2 = "b";

    int integer1 = 1;
    int integer2 = 2;
    public void RevealSwap()
    {

       this.Swap<string>(ref string1, ref string2);
       this.Swap<int>(ref integer1, ref integer2);

    }
    private void Swap<T>(ref T item1, ref T item2)
    {
        T tempItem = item1;
        item1 = item2;
        item2 = tempItem;
    }

}
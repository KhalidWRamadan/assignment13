using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContainer<T>
{
    private T item;
    public T Item
    {
        set;
        get;
    }
}

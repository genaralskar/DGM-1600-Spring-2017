//Lists are similar to arrays but are dynamic and don't need an assigned size

using UnityEngine;
using System.Collections;
//Using lists requires using System.Collections.Generic
using System.Collections.Generic;

public class SomeClass : MonoBehaviour
{
    void Start ()
    {
        //Create new list badguys containing class BadGuy
        List<BadGuy> badguys = new List<BadGuy>();

        //Add bad guys to the list badguys
        badguys.Add(new BadGuy("Harvey", 50));
        badguys.Add(new BadGuy("Magneto", 100));
        badguys.Add(new BadGuy("Pip", 5));

        //Lists can be called like arrays
        badguys[0];
        //Count works the same as length for arrays
        badguys.Count;
        //RemoveAt removes an element from the list and moves all other elements down one
        //here Harvey would get removed and Magneto and Pip would move down one space
        badguys.RemoveAt(0)
        //Insert inserts a new element at a given space and moves all elements after that space up one to make room
        //here Harv would get added at space two and Pip would move up one space
        badguys.Insert(2, new BadGuy("Harv", 20));

        badguys.Sort;

        foreach(BadGuy guy in badguys)
        {
            print (guy.name + " " + guy.power);
        }


        //Clear a list and remove all elements
        badguys.clear;
    }
}

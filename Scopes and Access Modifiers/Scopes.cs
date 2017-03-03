using UnityEngine;
using System.Collections;

//curley brackets are used to determine scopes of things.
//for example, i can be accessed everywhere because it's global and outside of a fuction
//but we cannot access j outside of its function, so we can't return j at the end because it's in a function
//i is global, j is not because it is in a function
//scope 1 open
{
    public int i = 5;

    //this variable can't be accessed outside of this script
    private int y = 3;

    if(i=5)
    //scope 2 open
    {
        private int j = 10;
        return i-j;
    //scope 2 close
    }


    //this does not work because we can access j because it's in a function
    return j;
//scope 1 close
}

//public or private are access modifiers which determines if an object is able to be changed outside of the script
//if you want to be able to change a variable in Unity, like a move speed, it must be public

//this can be acccessed in unity or from another script;
public int p = 10;

//this cannot be accessed from outside of this script
private int t = 5;
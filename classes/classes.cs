// Class Examples
// classes are used to store and organize variables.
// these variables can be called and changed at a later time

public class classes: MonoBehavior
{
    int score;

//  Multiply two integers
    public class multi
    {
        int result = 0;

        multi(int a, int b)
        {
            result = a*b;
        }
    }

    multi Test = new multi(5, 4);

// Inventory
    public class stuff
    {
        int foodstuff = 5;
        int firestarter = 1;
        int wood = 3;
        int selfRespect = 0;
    }
}
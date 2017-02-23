using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class switchStatments : MonoBehaviour {

    public int intelligence = 5;
    public InputField mainInputField;
    public string dialogChoice = "default";
    public int number = 6;

	// Use this for initialization
	void Start () {
        void Greet()
        {
            switch (intelligence)
            {
                //check intelligence value and print specific text for each value
                case 5:
                    print ("Good morrow my fine sir, may I interest you in some tea and crumpets?");
                    break;
                case 4:
                    print ("Hello, how are you doing today?");
                    break;
                case 3:
                    print ("Hey man what's up?");
                    break;
                case 2:
                    print ("Yo.");
                    break;
                case 1:
                    print ("ugh?");
                    break;
                default:
                    print ("Incorrect intelligence value");
                    break;
            }
        }

        void dialogChoice
        {
            //ask if you would like to buy some wares, text field comes up (I think), choose dialog depending on input text
            print ("Would you like to by some of my wares");
            dialogChoice = mainInputField.text;
            switch (dialogChoice)
            {
                case "Yes":
                    print ("Yes. What do you have for sale?");
                    break;
                case "No":
                    print ("No I don't want your smelly old wares!");
                    break;
                case "Maybe":
                    print ("I'm not sure. What kinds of things do you sell?");
                    break;
                default:
                    print ("Invalid dialogChoice string");
                    break;
            }
        }

        void numberComparison
            switch(true)
            {
                case (number > 1):
                    print (number + " is greater than 1");
                    break;
                case (number < 1):
                    print (number + " is less than 1");
                    break;
                case (number == 1):
                    print (number + " is equal to 1");
                    break;
                default:
                    print ("Unknown error. " + number + " might not be an integer.");
                    break;
            }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

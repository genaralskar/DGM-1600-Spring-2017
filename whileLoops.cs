using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class whileLoops : MonoBehaviour {

    int ammo = 0;
    int unmilkedCows = 5;

	// Use this for initialization
	void Start () {

            //if ammo is less than 12, add one to ammo and print how much ammo there is
            while(ammo < 12)
            {
                ammo++
                print ("Loading round " + ammo);
            }

            //if ammo is great than twelve, subtract one ammo and print how much ammo is left
            //ammo-- might need to change to --ammo, not sure
            for(ammo; ammo > 0; ammo--)
            {
                print ("You fire your gun. You now have " + ammo + " rounds left");
            }

            //print something for every unmilked cow
            for(int i = 0; i < unmilkedCows; i++)
            {
                print ("You milked an unmilked cow! Congratulations!");
            }

        }
	
	// Update is called once per frame
	void Update () {
		
	}
}

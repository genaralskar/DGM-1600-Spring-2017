using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour {

	//arrays allow you store information and access it or change it later.
	//kinda like an excell spreadsheet

	//int is type of info in array, it will contain ints
	//int[5] is how many spaces in array
	//if you define 5 you can only have 5 values, cant add more
	int[] myIntArray = new int[5];

	//faster way to do it all in one line
	int[] fastArray = {12, 5, 42, 10, 10001};

	//arrays can be public
	public GameObject[] players;

	public string[] words = {"this", "is", "a", "sentence"};

	// Use this for initialization
	void Start () {
		//space 1 will be int 12. arrays start at 0, so this array is 0-4
		//this take more work
		myIntArray[0] = 12;
		myIntArray[1] = 5;
		myIntArray[2] = 42;
		myIntArray[3] = 10;
		myIntArray[4] = 10001;


		//fastArray can still be changed as the previous array
		//here we change the first value from 12 to 6
		fastArray[0] = 6;



		//assign gameobjects with tag Player into array
		players = GameObject.FindGameObjectsWithTag("Player");

		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("Player Number "+ i +" is named "+ players[i].name);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class NewArray : MonoBehaviour {

	public string[] words = {"this", "is", "a", "sentence"};

	// Use this for initialization
	void Start () {

		for(int i = 0; i < words.Length; i++)
		{
			print("Word "+i+" is "+words[i]);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

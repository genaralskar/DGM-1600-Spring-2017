using UnityEngine;
using System.Collections;

public class Operators : MonoBehaviour {

	public int one = 5;
	public int two = 3;

	// Use this for initialization
	void Start () {
		// Add one to two
		Debug.Log(one + two);
		// Subtract one from two
		Debug.Log(one - two);
		// Multiply one times two
		Debug.Log(one * two);
		// Divide one by two
		Debug.Log(one / two);
		// Modulus
		Debug.Log(one % two);
		// Increment one
		Debug.Log(++one);
		// Decrement one
		Debug.Log(--one);
		//Square one
		Debug.Log(one * one);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

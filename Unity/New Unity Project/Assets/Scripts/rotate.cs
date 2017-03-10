using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	
	public int number = 10;
	public int rotSpeed = 50;

	// Use this for initialization
	void Start () {
		Debug.Log(number);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate(0,0,3);
		transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
	}
}

using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public int moveSpeed = 5;
	public int rotateSpeed =180;

	// Use this for initialization
	void Start () {
		
		Debug.Log(moveSpeed);
		Debug.Log(rotateSpeed);

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.DownArrow))
			transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);
	}
}

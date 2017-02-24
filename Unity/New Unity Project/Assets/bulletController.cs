using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour {

	public int moveSpeed = 15;
	public int objectLife = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

		Object.Destroy(gameObject, objectLife);
	
	}
}

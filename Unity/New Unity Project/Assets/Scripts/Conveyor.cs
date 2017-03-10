using UnityEngine;
using System.Collections;

public class Conveyor : MonoBehaviour {


	public float speed = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//on object collision, move collided object forward
	void OnCollisionStay(Collision obj) {
		float Velocity = speed * Time.deltaTime;
		obj.gameObject.GetComponent<Rigidbody>().velocity = Velocity * transform.forward;
	}
}

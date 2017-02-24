using UnityEngine;
using System.Collections;

public class gunController : MonoBehaviour {

	public GameObject bullet;
	public int fireRate = 10;
	int fireRateTimer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(fireRateTimer>0){
			fireRateTimer--;
		}

		if(Input.GetButton("Fire1"))
		{
			if(fireRateTimer<=0)
			{
				fireRateTimer = fireRate;
				Instantiate(bullet, transform.position, transform.rotation);
			}
		}

	}
}

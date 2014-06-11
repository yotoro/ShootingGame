using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject bullet;

	void Update () {
		if(Input.GetKey(KeyCode.K))
		{
			Instantiate( bullet, transform.position, transform.rotation );
		}
	}
}

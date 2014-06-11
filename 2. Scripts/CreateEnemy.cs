using UnityEngine;
using System.Collections;

public class CreateEnemy : MonoBehaviour {
	public GameObject Enemy;
	float regenTime;

	void Update () {
		if (Time.time > regenTime)
		{		
			regenTime = Time.time + 1;

			Vector3 v =  transform.position;
			v.x += Random.Range(-5,5);

			Instantiate( Enemy, v, transform.rotation );
		}
	}
}

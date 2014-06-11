using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float power = 1000.0f;

	void Update () {
		gameObject.rigidbody.AddForce(transform.TransformDirection(new Vector3(0,0,1) * power));
		Destroy(gameObject, 3);
	}
}

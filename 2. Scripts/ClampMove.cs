using UnityEngine;
using System.Collections;

public class ClampMove : MonoBehaviour {
	public GameObject moveZone;

	public float minX;
	public float maxX;
	public float minZ;
	public float maxZ;

	public float speed = 5.0f;
	
	void Start () {
		minX = moveZone.transform.position.x - moveZone.renderer.bounds.size.x / 2;
		minZ = moveZone.transform.position.z - moveZone.renderer.bounds.size.z / 2;

		maxX = moveZone.transform.position.x + moveZone.renderer.bounds.size.x / 2;
		maxZ = moveZone.transform.position.z + moveZone.renderer.bounds.size.z / 2;
	}

	void Update () {
		int h = 0, v = 0;

		if (Input.GetKey (KeyCode.A)) h = -1;
		if (Input.GetKey (KeyCode.D)) h = 1;
		if (Input.GetKey (KeyCode.W)) v = 1;
		if (Input.GetKey (KeyCode.S)) v = -1;

		Vector3 pos = transform.position;
		pos.x += speed * h * Time.deltaTime;
		pos.z += speed * v * Time.deltaTime;

		pos.x = Mathf.Clamp ( pos.x, minX, maxX );
		pos.z = Mathf.Clamp ( pos.z, minZ, maxZ );

		transform.position = pos;
	}
}
